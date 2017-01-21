namespace RecoveryCoin
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.progGenerateAddress = new System.Windows.Forms.ProgressBar();
            this.cmdGenerateNewAddress = new System.Windows.Forms.Button();
            this.txtLoadPrivateKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdHash = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHashOutput = new System.Windows.Forms.TextBox();
            this.chkHex = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHashInput = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblOddsRecovery = new System.Windows.Forms.Label();
            this.lblOddsHit = new System.Windows.Forms.Label();
            this.lblTotalHits = new System.Windows.Forms.Label();
            this.lblTotalOps = new System.Windows.Forms.Label();
            this.lblTotalTargets = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProgress);
            this.groupBox1.Controls.Add(this.progGenerateAddress);
            this.groupBox1.Controls.Add(this.cmdGenerateNewAddress);
            this.groupBox1.Controls.Add(this.txtLoadPrivateKey);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtPrivateKey);
            this.groupBox1.Controls.Add(this.cmdCancel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 124);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PoW Address";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(83, 105);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 13);
            this.lblProgress.TabIndex = 16;
            // 
            // progGenerateAddress
            // 
            this.progGenerateAddress.Location = new System.Drawing.Point(86, 79);
            this.progGenerateAddress.Name = "progGenerateAddress";
            this.progGenerateAddress.Size = new System.Drawing.Size(274, 23);
            this.progGenerateAddress.TabIndex = 13;
            // 
            // cmdGenerateNewAddress
            // 
            this.cmdGenerateNewAddress.Location = new System.Drawing.Point(366, 78);
            this.cmdGenerateNewAddress.Name = "cmdGenerateNewAddress";
            this.cmdGenerateNewAddress.Size = new System.Drawing.Size(78, 25);
            this.cmdGenerateNewAddress.TabIndex = 12;
            this.cmdGenerateNewAddress.Text = "Generate";
            this.cmdGenerateNewAddress.UseVisualStyleBackColor = true;
            this.cmdGenerateNewAddress.Click += new System.EventHandler(this.cmdGenerateNewAddress_Click);
            // 
            // txtLoadPrivateKey
            // 
            this.txtLoadPrivateKey.Location = new System.Drawing.Point(524, 25);
            this.txtLoadPrivateKey.Name = "txtLoadPrivateKey";
            this.txtLoadPrivateKey.Size = new System.Drawing.Size(75, 22);
            this.txtLoadPrivateKey.TabIndex = 11;
            this.txtLoadPrivateKey.Text = "Load";
            this.txtLoadPrivateKey.UseVisualStyleBackColor = true;
            this.txtLoadPrivateKey.Click += new System.EventHandler(this.txtLoadPrivateKey_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(32, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Private Key:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(86, 53);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(358, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(86, 27);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(432, 20);
            this.txtPrivateKey.TabIndex = 7;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(366, 77);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(78, 25);
            this.cmdCancel.TabIndex = 17;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Visible = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdHash);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtHashOutput);
            this.groupBox2.Controls.Add(this.chkHex);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtHashInput);
            this.groupBox2.Location = new System.Drawing.Point(12, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 199);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ECDSA Hash";
            // 
            // cmdHash
            // 
            this.cmdHash.Location = new System.Drawing.Point(524, 130);
            this.cmdHash.Name = "cmdHash";
            this.cmdHash.Size = new System.Drawing.Size(75, 22);
            this.cmdHash.TabIndex = 21;
            this.cmdHash.Text = "Hash";
            this.cmdHash.UseVisualStyleBackColor = true;
            this.cmdHash.Click += new System.EventHandler(this.cmdHash_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(16, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Output:";
            // 
            // txtHashOutput
            // 
            this.txtHashOutput.Location = new System.Drawing.Point(19, 158);
            this.txtHashOutput.Name = "txtHashOutput";
            this.txtHashOutput.Size = new System.Drawing.Size(580, 20);
            this.txtHashOutput.TabIndex = 19;
            // 
            // chkHex
            // 
            this.chkHex.AutoSize = true;
            this.chkHex.Location = new System.Drawing.Point(554, 26);
            this.chkHex.Name = "chkHex";
            this.chkHex.Size = new System.Drawing.Size(45, 17);
            this.chkHex.TabIndex = 15;
            this.chkHex.Text = "Hex";
            this.chkHex.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(16, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Input:";
            // 
            // txtHashInput
            // 
            this.txtHashInput.Location = new System.Drawing.Point(19, 43);
            this.txtHashInput.Multiline = true;
            this.txtHashInput.Name = "txtHashInput";
            this.txtHashInput.Size = new System.Drawing.Size(580, 81);
            this.txtHashInput.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblOddsRecovery);
            this.groupBox3.Controls.Add(this.lblOddsHit);
            this.groupBox3.Controls.Add(this.lblTotalHits);
            this.groupBox3.Controls.Add(this.lblTotalOps);
            this.groupBox3.Controls.Add(this.lblTotalTargets);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(614, 165);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Targets";
            // 
            // lblOddsRecovery
            // 
            this.lblOddsRecovery.AutoSize = true;
            this.lblOddsRecovery.Location = new System.Drawing.Point(17, 137);
            this.lblOddsRecovery.Name = "lblOddsRecovery";
            this.lblOddsRecovery.Size = new System.Drawing.Size(13, 13);
            this.lblOddsRecovery.TabIndex = 19;
            this.lblOddsRecovery.Text = "0";
            // 
            // lblOddsHit
            // 
            this.lblOddsHit.AutoSize = true;
            this.lblOddsHit.Location = new System.Drawing.Point(190, 95);
            this.lblOddsHit.Name = "lblOddsHit";
            this.lblOddsHit.Size = new System.Drawing.Size(13, 13);
            this.lblOddsHit.TabIndex = 18;
            this.lblOddsHit.Text = "0";
            // 
            // lblTotalHits
            // 
            this.lblTotalHits.AutoSize = true;
            this.lblTotalHits.Location = new System.Drawing.Point(190, 72);
            this.lblTotalHits.Name = "lblTotalHits";
            this.lblTotalHits.Size = new System.Drawing.Size(13, 13);
            this.lblTotalHits.TabIndex = 17;
            this.lblTotalHits.Text = "0";
            // 
            // lblTotalOps
            // 
            this.lblTotalOps.AutoSize = true;
            this.lblTotalOps.Location = new System.Drawing.Point(190, 49);
            this.lblTotalOps.Name = "lblTotalOps";
            this.lblTotalOps.Size = new System.Drawing.Size(13, 13);
            this.lblTotalOps.TabIndex = 16;
            this.lblTotalOps.Text = "0";
            // 
            // lblTotalTargets
            // 
            this.lblTotalTargets.AutoSize = true;
            this.lblTotalTargets.Location = new System.Drawing.Point(190, 27);
            this.lblTotalTargets.Name = "lblTotalTargets";
            this.lblTotalTargets.Size = new System.Drawing.Size(13, 13);
            this.lblTotalTargets.TabIndex = 15;
            this.lblTotalTargets.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(16, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Total Hits:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(17, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Odds for Recovery:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(17, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Odds for Hit (1 REC reward):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(16, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total ECDSA Operations Made:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(16, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total Targets:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 524);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecoveryCoin Address Generator & ECDSA Hash Demonstration";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progGenerateAddress;
        private System.Windows.Forms.Button cmdGenerateNewAddress;
        private System.Windows.Forms.Button txtLoadPrivateKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHashInput;
        private System.Windows.Forms.CheckBox chkHex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHashOutput;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button cmdHash;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalTargets;
        private System.Windows.Forms.Label lblOddsRecovery;
        private System.Windows.Forms.Label lblOddsHit;
        private System.Windows.Forms.Label lblTotalHits;
        private System.Windows.Forms.Label lblTotalOps;
        private System.Windows.Forms.Button cmdCancel;
    }
}

