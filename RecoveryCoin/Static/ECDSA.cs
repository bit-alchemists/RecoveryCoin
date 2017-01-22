using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Security;

namespace RecoveryCoin
{
    public static class ECDSA
    {
        public static Org.BouncyCastle.Asn1.X9.X9ECParameters EC = Org.BouncyCastle.Asn1.Sec.SecNamedCurves.GetByName("secp256k1");
        public static byte[] NetworkBytes = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        public const int HASH_LENGTH = 32;
        public const int HIT_LENGTH = 4;
        public const int PRIVATE_KEY_LENGTH = 32;
        public const int PUBLIC_KEY_LENGTH = 65;
        public const int ADDRESS_LENGTH = 16;
        public const int ADDRESS_DIFFICULTY = 100;
        public static byte[] Hash(byte[] input, ref bool isHit)
        {
            byte[] appInput = new byte[input.Length + (HASH_LENGTH - input.Length%HASH_LENGTH)];
            Array.Copy(input, 0, appInput, 0, input.Length);

            byte[] key = new byte[HASH_LENGTH];
            for (int x=0;x<appInput.Length;x+=HASH_LENGTH)
            {
                byte[] chunk = new byte[HASH_LENGTH];
                Array.Copy(appInput, x, chunk, 0, HASH_LENGTH);
                key = ByteOps.ModuloAddBytes(key, chunk);
            }

            BigInteger nKey = new BigInteger(1, key).Mod(EC.N);
            if (nKey == BigInteger.Zero) nKey = BigInteger.One;
            ECPoint hp = EC.G.Multiply(nKey);
            byte[] hashx = hp.Normalize().AffineXCoord.ToBigInteger().ToByteArrayUnsigned();
            byte[] hashy = hp.Normalize().AffineYCoord.ToBigInteger().ToByteArrayUnsigned();
            byte[] hash = ByteOps.ModuloAddBytes(hashx, hashy);

            byte[] tryHit = new byte[HIT_LENGTH];
            Array.Copy(hashx, 0, tryHit, 0, HIT_LENGTH);
            if (Targets.Database.Get(tryHit) != null)
            {
                isHit = true;
                Hits.Database.Put(nKey.ToByteArrayUnsigned(), hp.GetEncoded());
            }

            return hash;
        }
    }
}
