using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RocksDbSharp;
using System.IO;
using Org.BouncyCastle.Math;
using System.Threading;

namespace RecoveryCoin
{
    public partial class frmMain : Form
    {

        public Address loadedAddress;
        public BigInteger totalOps = BigInteger.Zero;
        public BigInteger totalHits = BigInteger.Zero;

        private void frmMain_Load(object sender, EventArgs e)
        {
            Targets.Load();
            Addresses.Load(lstAddresses);
            Hits.Load(lstHits);
            BigInteger targetCount = Targets.Count();
            lblTotalTargets.Text = targetCount.ToString();
            BigInteger oddsHit = new BigInteger("256").Pow(ECDSA.HIT_LENGTH).Divide(targetCount);
            lblOddsHit.Text = "1 : " + oddsHit.ToString();
            BigInteger oddsRecovery = new BigInteger("256").Pow(ECDSA.PRIVATE_KEY_LENGTH).Divide(targetCount);
            lblOddsRecovery.Text = "1 : " + oddsRecovery.ToString();
        }

        private void cmdHash_Click(object sender, EventArgs e)
        {
            if (txtHashInput.Text == "") { txtHashOutput.Text = ""; return; }
            byte[] input;
            if (chkHex.Checked) {
                input = ByteOps.HexToByte(txtHashInput.Text);
                if (input==null) { 
                    MessageBox.Show("Input not in HEX format");return;
                }
            } else {
                input = Encoding.UTF8.GetBytes(txtHashInput.Text);
                if (input == null) return;
            }
            bool isHit = false;
            byte[] output = ECDSA.Hash(input, ref isHit);
            txtHashOutput.Text = ByteOps.ByteToHex(output);
            if (isHit)
            {
                totalHits = totalHits.Add(BigInteger.One);
                lblTotalHits.Text = totalHits.ToString();
            }
            totalOps = totalOps.Add(BigInteger.One);
            lblTotalOps.Text = totalOps.ToString();
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdGenerateNewAddress_Click(object sender, EventArgs e)
        {
            progGenerateAddress.Value = 0;
            cmdGenerateNewAddress.Visible = false;
            cmdCancel.Visible = true;
            loadedAddress = new Address();
            loadedAddress.Finished += new Address.FinishedHandler(address_generated);
            loadedAddress.Progress += new Address.ProgressHandler(address_progress);
            loadedAddress.Hit += new Address.ProgressHandler(address_hit);
            Thread thread = new Thread(new ThreadStart(loadedAddress.GenerateNew));
            thread.Start();
        }

        private void address_generated(Address address, EventArgs e)
        {
            if (InvokeRequired)
            {
                Address.FinishedHandler cb = new Address.FinishedHandler(address_generated);
                Invoke(cb, new object[] { address, e }); return;
            }
            txtPrivateKey.Text = ByteOps.ByteToHex(address.privKey);
            txtAddress.Text = ByteOps.ByteToAddress(address.address);
            lstAddresses.Items.Add(txtAddress.Text);
            Addresses.Database.Put(address.address, address.privKey);
            cmdGenerateNewAddress.Visible = true;
            cmdCancel.Visible = false;
            lblProgress.Text = "";
            progGenerateAddress.Value = 0;
        }
        private void address_progress(Address address, EventArgs e)
        {
            if (InvokeRequired)
            {
                Address.ProgressHandler cb = new Address.ProgressHandler(address_progress);
                Invoke(cb, new object[] { address, e }); return;
            }
            progGenerateAddress.Value = Convert.ToInt32(address.estimatedProgress);
            lblProgress.Text = address.estimatedProgress>=99? "Finalizing..." : "%" +(float)address.estimatedProgress;
            totalOps = totalOps.Add(new BigInteger("1000"));
            lblTotalOps.Text = totalOps.ToString();
        }
        private void address_hit(Address address, EventArgs e)
        {
            if (InvokeRequired)
            {
                Address.HitHandler cb = new Address.HitHandler(address_hit);
                Invoke(cb, new object[] { address, e }); return;
            }
            totalHits = totalHits.Add(BigInteger.One);
            lblTotalHits.Text = totalHits.ToString();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            loadedAddress.cancelFlag = true;
            progGenerateAddress.Value = 0;
            cmdGenerateNewAddress.Visible = true;
            cmdCancel.Visible = false;
            lblProgress.Text = "";
        }

        private void txtLoadPrivateKey_Click(object sender, EventArgs e)
        {
            loadedAddress = new Address(ByteOps.HexToByte(txtPrivateKey.Text), AddressPerspective.PrivateKey);
            if (!loadedAddress.meetsTarget)
            {
                MessageBox.Show("Address does not belong to this network");
                txtAddress.Text = "";
                loadedAddress = null;
                return;
            }
            txtAddress.Text = ByteOps.ByteToAddress(loadedAddress.address);
        }

        private void lstAddresses_SelectedIndexChanged(object sender, EventArgs e)
        {
            string addr = (string)lstAddresses.Items[lstAddresses.SelectedIndex];
            byte[] address = ByteOps.AddressToBytes(addr);
            byte[] privkey = Addresses.Database.Get(address);
            txtPrivateKey.Text = ByteOps.ByteToHex(privkey);
            txtAddress.Text = addr;
        }

        private void lstHits_SelectedIndexChanged(object sender, EventArgs e)
        {
            string priv = (string)lstHits.Items[lstHits.SelectedIndex];
            byte[] privKey = ByteOps.HexToByte(priv);
            byte[] pubKey = Hits.Database.Get(privKey);
            lblHitPubKey.Text = ByteOps.ByteToHex(pubKey);
        }
    }
}
