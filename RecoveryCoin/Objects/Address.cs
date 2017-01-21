using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using System.Security.Cryptography;

namespace RecoveryCoin
{
    public enum AddressPerspective { PrivateKey, PublicKey, Address }
    public enum AddressType { Unknown, Normal }

    public class Address
    {
        public byte[] privKey, pubKey, address;
        public bool meetsTarget;

        public event FinishedHandler Finished;
        public delegate void FinishedHandler(Address address, EventArgs e);
        public event ProgressHandler Progress;
        public delegate void ProgressHandler(Address address, EventArgs e);
        public event ProgressHandler Hit;
        public delegate void HitHandler(Address address, EventArgs e);
        public bool cancelFlag = false;
        public double estimatedProgress;
        public ulong attempts, odds;

        private BigInteger nPrivKey;
        public ECPoint ecPubKey;

        public Address()
        { Init(); }

        public Address(byte[] data, AddressPerspective inptype)
        {
            Init();

            switch (inptype)
            {
                case AddressPerspective.PrivateKey:
                    privKey = data;

                    try
                    {
                        nPrivKey = new BigInteger(1, privKey);
                        ecPubKey = ECDSA.EC.G.Multiply(nPrivKey);

                        GetPublicKeyBytes();
                        CalculateAddress();
                        MeetsTarget();
                    }
                    catch (Exception)
                    {
                        Init();
                    }

                    break;
                case AddressPerspective.PublicKey:
                    if (data.Length == ECDSA.PUBLIC_KEY_LENGTH)
                    {
                        pubKey = data;
                        CalculateAddress();
                        MeetsTarget();
                    }
                    break;
                case AddressPerspective.Address:
                    if (data.Length == ECDSA.ADDRESS_LENGTH)
                    {
                        address = data;
                        MeetsTarget();
                    }
                    break;
                default: break;
            }
        }

        public void GenerateNew()
        {
            privKey = new byte[ECDSA.PRIVATE_KEY_LENGTH];
            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
            rngCsp.GetBytes(privKey); rngCsp.Dispose();

            nPrivKey = new BigInteger(1, privKey);
            ecPubKey = ECDSA.EC.G.Multiply(nPrivKey);

            calculateOdds(); attempts = 0; estimatedProgress = 0;
            if (Progress != null) Progress(this, null);

            while (!cancelFlag)
            {
                GetPublicKeyBytes(); CalculateAddress();

                if (MeetsTarget())
                {
                    privKey = nPrivKey.ToByteArrayUnsigned();
                    if (Finished != null) Finished(this, null); break;
                }

                attempts += 1;
                calculateEstimatedProgress();

                nPrivKey = nPrivKey.Add(BigInteger.One);
                ecPubKey = ecPubKey.Add(ECDSA.EC.G);

                byte[] hashx = ecPubKey.Normalize().AffineXCoord.ToBigInteger().ToByteArrayUnsigned();

                byte[] tryHit = new byte[ECDSA.HIT_LENGTH];
                Array.Copy(hashx, 0, tryHit, 0, ECDSA.HIT_LENGTH);
                if (Targets.Database.Get(tryHit) != null) {
                    if (Hit != null) Hit(this, null); 
                }
            }
        }

        private void Init()
        {
            privKey = null; pubKey = null; address = null;
            meetsTarget = false;
            attempts = 0; odds = 0; estimatedProgress = 0;
            nPrivKey = null; ecPubKey = null;
        }

        private void GetPublicKeyBytes()
        {
            pubKey = ecPubKey.GetEncoded();
        }

        private void CalculateAddress()
        {
            byte[] x = new byte[32]; Array.Copy(pubKey, 1, x, 0, 32);
            byte[] y = new byte[32]; Array.Copy(pubKey, 33, y, 0, 32);
            byte[] z = ByteOps.ModuloAddBytes(x, y);
            byte[] z1 = new byte[16]; Array.Copy(z, 0, z1, 0, 16);
            byte[] z2 = new byte[16]; Array.Copy(z, 16, z2, 0, 16);
            address = ByteOps.ModuloAddBytes(z1, z2);
            address = ByteOps.ModuloAddBytes(address, ECDSA.NetworkBytes);
        }

        private bool MeetsTarget()
        {
            byte highestByte = 0;

            for (int x = 0; x < ECDSA.ADDRESS_LENGTH; x++)
            {
                if (address[x] > highestByte) highestByte = address[x];
                if (address[x] >= ECDSA.ADDRESS_DIFFICULTY)
                {
                    meetsTarget = false;
                    return meetsTarget;
                }
            }

            meetsTarget = true;
            return meetsTarget;
        }

        private void calculateOdds()
        {
            BigInteger normalOdds = new BigInteger("256").Pow(ECDSA.ADDRESS_LENGTH);
            BigInteger difficultyOdds = new BigInteger(ECDSA.ADDRESS_DIFFICULTY.ToString()).Pow(ECDSA.ADDRESS_LENGTH);
            odds = (ulong)normalOdds.Divide(difficultyOdds).LongValue*2;
        }

        private void calculateEstimatedProgress()
        {
            if (attempts % 1000 != 0) return;
            double updated = (double)attempts / (double)odds * 100;
            if (updated == estimatedProgress) return;
            estimatedProgress = updated;
            estimatedProgress = estimatedProgress > 99 ? 99 : estimatedProgress;
            if (Progress != null) Progress(this, null);
        }

    }
}
