namespace DVLD_Project
{
    partial class frmReplaceLostOrDamagedLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplaceLostOrDamagedLicense));
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD_Project.ctrlDriverLicenseInfoWithFilter();
            this.grbboxReason = new System.Windows.Forms.GroupBox();
            this.rdbtnLost = new System.Windows.Forms.RadioButton();
            this.rdbtnDamaged = new System.Windows.Forms.RadioButton();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblLinkShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lbllinkShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblOldLicenseIdResult = new System.Windows.Forms.Label();
            this.lblOldLicenseId = new System.Windows.Forms.Label();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.lblReplacedLicenseIDResult = new System.Windows.Forms.Label();
            this.lblRenewedLicenseID = new System.Windows.Forms.Label();
            this.lblRLAPPResult = new System.Windows.Forms.Label();
            this.lblRLID = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lblAPPFeesResult = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.lblAppDAteResult = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCreatedByResult = new System.Windows.Forms.Label();
            this.lblFormStatus = new System.Windows.Forms.Label();
            this.grbboxReason.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(-6, 41);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(669, 353);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // grbboxReason
            // 
            this.grbboxReason.Controls.Add(this.rdbtnLost);
            this.grbboxReason.Controls.Add(this.rdbtnDamaged);
            this.grbboxReason.Location = new System.Drawing.Point(324, 48);
            this.grbboxReason.Name = "grbboxReason";
            this.grbboxReason.Size = new System.Drawing.Size(328, 51);
            this.grbboxReason.TabIndex = 1;
            this.grbboxReason.TabStop = false;
            this.grbboxReason.Text = "Reason";
            // 
            // rdbtnLost
            // 
            this.rdbtnLost.AutoSize = true;
            this.rdbtnLost.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnLost.Location = new System.Drawing.Point(186, 19);
            this.rdbtnLost.Name = "rdbtnLost";
            this.rdbtnLost.Size = new System.Drawing.Size(92, 18);
            this.rdbtnLost.TabIndex = 1;
            this.rdbtnLost.TabStop = true;
            this.rdbtnLost.Text = "Lost License";
            this.rdbtnLost.UseVisualStyleBackColor = true;
            this.rdbtnLost.CheckedChanged += new System.EventHandler(this.rdbtnLost_CheckedChanged);
            // 
            // rdbtnDamaged
            // 
            this.rdbtnDamaged.AutoSize = true;
            this.rdbtnDamaged.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnDamaged.Location = new System.Drawing.Point(18, 19);
            this.rdbtnDamaged.Name = "rdbtnDamaged";
            this.rdbtnDamaged.Size = new System.Drawing.Size(120, 18);
            this.rdbtnDamaged.TabIndex = 0;
            this.rdbtnDamaged.TabStop = true;
            this.rdbtnDamaged.Text = "Damaged License";
            this.rdbtnDamaged.UseVisualStyleBackColor = true;
            this.rdbtnDamaged.CheckedChanged += new System.EventHandler(this.rdbtnDamaged_CheckedChanged);
            // 
            // btnIssue
            // 
            this.btnIssue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Image = global::DVLD_Project.Properties.Resources.Renew_Driving_License_32;
            this.btnIssue.Location = new System.Drawing.Point(552, 498);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(95, 39);
            this.btnIssue.TabIndex = 98;
            this.btnIssue.Text = "Issue";
            this.btnIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnCancel.Location = new System.Drawing.Point(429, 499);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 39);
            this.btnCancel.TabIndex = 97;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLinkShowLicenseHistory
            // 
            this.lblLinkShowLicenseHistory.AutoSize = true;
            this.lblLinkShowLicenseHistory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkShowLicenseHistory.Location = new System.Drawing.Point(8, 509);
            this.lblLinkShowLicenseHistory.Name = "lblLinkShowLicenseHistory";
            this.lblLinkShowLicenseHistory.Size = new System.Drawing.Size(145, 16);
            this.lblLinkShowLicenseHistory.TabIndex = 96;
            this.lblLinkShowLicenseHistory.TabStop = true;
            this.lblLinkShowLicenseHistory.Text = "Show License History";
            this.lblLinkShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkShowLicenseHistory_LinkClicked);
            // 
            // lbllinkShowNewLicenseInfo
            // 
            this.lbllinkShowNewLicenseInfo.AutoSize = true;
            this.lbllinkShowNewLicenseInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllinkShowNewLicenseInfo.Location = new System.Drawing.Point(151, 509);
            this.lbllinkShowNewLicenseInfo.Name = "lbllinkShowNewLicenseInfo";
            this.lbllinkShowNewLicenseInfo.Size = new System.Drawing.Size(155, 16);
            this.lbllinkShowNewLicenseInfo.TabIndex = 95;
            this.lbllinkShowNewLicenseInfo.TabStop = true;
            this.lbllinkShowNewLicenseInfo.Text = "Show New License Info";
            this.lbllinkShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllinkShowNewLicenseInfo_LinkClicked);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(530, 44);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(27, 22);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox8.TabIndex = 134;
            this.pictureBox8.TabStop = false;
            // 
            // lblOldLicenseIdResult
            // 
            this.lblOldLicenseIdResult.AutoSize = true;
            this.lblOldLicenseIdResult.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseIdResult.Location = new System.Drawing.Point(565, 45);
            this.lblOldLicenseIdResult.Name = "lblOldLicenseIdResult";
            this.lblOldLicenseIdResult.Size = new System.Drawing.Size(51, 16);
            this.lblOldLicenseIdResult.TabIndex = 133;
            this.lblOldLicenseIdResult.Text = "[........]";
            // 
            // lblOldLicenseId
            // 
            this.lblOldLicenseId.AutoSize = true;
            this.lblOldLicenseId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseId.Location = new System.Drawing.Point(418, 47);
            this.lblOldLicenseId.Name = "lblOldLicenseId";
            this.lblOldLicenseId.Size = new System.Drawing.Size(105, 16);
            this.lblOldLicenseId.TabIndex = 132;
            this.lblOldLicenseId.Text = "Old License Id :";
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(530, 18);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(27, 22);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox14.TabIndex = 131;
            this.pictureBox14.TabStop = false;
            // 
            // lblReplacedLicenseIDResult
            // 
            this.lblReplacedLicenseIDResult.AutoSize = true;
            this.lblReplacedLicenseIDResult.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplacedLicenseIDResult.Location = new System.Drawing.Point(565, 19);
            this.lblReplacedLicenseIDResult.Name = "lblReplacedLicenseIDResult";
            this.lblReplacedLicenseIDResult.Size = new System.Drawing.Size(51, 16);
            this.lblReplacedLicenseIDResult.TabIndex = 130;
            this.lblReplacedLicenseIDResult.Text = "[........]";
            // 
            // lblRenewedLicenseID
            // 
            this.lblRenewedLicenseID.AutoSize = true;
            this.lblRenewedLicenseID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenewedLicenseID.Location = new System.Drawing.Point(379, 21);
            this.lblRenewedLicenseID.Name = "lblRenewedLicenseID";
            this.lblRenewedLicenseID.Size = new System.Drawing.Size(144, 16);
            this.lblRenewedLicenseID.TabIndex = 129;
            this.lblRenewedLicenseID.Text = "Replaced License Id :";
            // 
            // lblRLAPPResult
            // 
            this.lblRLAPPResult.AutoSize = true;
            this.lblRLAPPResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRLAPPResult.Location = new System.Drawing.Point(185, 22);
            this.lblRLAPPResult.Name = "lblRLAPPResult";
            this.lblRLAPPResult.Size = new System.Drawing.Size(45, 14);
            this.lblRLAPPResult.TabIndex = 128;
            this.lblRLAPPResult.Text = "[.......]";
            // 
            // lblRLID
            // 
            this.lblRLID.AutoSize = true;
            this.lblRLID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRLID.Location = new System.Drawing.Point(12, 21);
            this.lblRLID.Name = "lblRLID";
            this.lblRLID.Size = new System.Drawing.Size(130, 16);
            this.lblRLID.TabIndex = 126;
            this.lblRLID.Text = "R.L Application ID :";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(148, 18);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(27, 22);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox10.TabIndex = 127;
            this.pictureBox10.TabStop = false;
            // 
            // lblAPPFeesResult
            // 
            this.lblAPPFeesResult.AutoSize = true;
            this.lblAPPFeesResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPPFeesResult.Location = new System.Drawing.Point(186, 75);
            this.lblAPPFeesResult.Name = "lblAPPFeesResult";
            this.lblAPPFeesResult.Size = new System.Drawing.Size(49, 14);
            this.lblAPPFeesResult.TabIndex = 122;
            this.lblAPPFeesResult.Text = "[$$$$]";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(148, 72);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 121;
            this.pictureBox3.TabStop = false;
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFees.Location = new System.Drawing.Point(21, 75);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(121, 16);
            this.lblAppFees.TabIndex = 120;
            this.lblAppFees.Text = "Application Fees :";
            // 
            // lblAppDAteResult
            // 
            this.lblAppDAteResult.AutoSize = true;
            this.lblAppDAteResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDAteResult.Location = new System.Drawing.Point(185, 47);
            this.lblAppDAteResult.Name = "lblAppDAteResult";
            this.lblAppDAteResult.Size = new System.Drawing.Size(63, 14);
            this.lblAppDAteResult.TabIndex = 119;
            this.lblAppDAteResult.Text = "[../../....]";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(148, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 118;
            this.pictureBox2.TabStop = false;
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDate.Location = new System.Drawing.Point(19, 47);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(123, 16);
            this.lblAppDate.TabIndex = 117;
            this.lblAppDate.Text = "Application Date :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(530, 72);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 136;
            this.pictureBox4.TabStop = false;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(436, 75);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(88, 16);
            this.lblCreatedBy.TabIndex = 135;
            this.lblCreatedBy.Text = "Created By :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCreatedByResult);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.lblCreatedBy);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.lblOldLicenseIdResult);
            this.groupBox1.Controls.Add(this.lblOldLicenseId);
            this.groupBox1.Controls.Add(this.pictureBox14);
            this.groupBox1.Controls.Add(this.lblReplacedLicenseIDResult);
            this.groupBox1.Controls.Add(this.lblRenewedLicenseID);
            this.groupBox1.Controls.Add(this.lblRLAPPResult);
            this.groupBox1.Controls.Add(this.lblRLID);
            this.groupBox1.Controls.Add(this.pictureBox10);
            this.groupBox1.Controls.Add(this.lblAPPFeesResult);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.lblAppFees);
            this.groupBox1.Controls.Add(this.lblAppDAteResult);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.lblAppDate);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 105);
            this.groupBox1.TabIndex = 138;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "App Info for Replaced";
            // 
            // lblCreatedByResult
            // 
            this.lblCreatedByResult.AutoSize = true;
            this.lblCreatedByResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByResult.Location = new System.Drawing.Point(566, 74);
            this.lblCreatedByResult.Name = "lblCreatedByResult";
            this.lblCreatedByResult.Size = new System.Drawing.Size(49, 14);
            this.lblCreatedByResult.TabIndex = 137;
            this.lblCreatedByResult.Text = "[........]";
            // 
            // lblFormStatus
            // 
            this.lblFormStatus.AutoSize = true;
            this.lblFormStatus.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormStatus.ForeColor = System.Drawing.Color.Red;
            this.lblFormStatus.Location = new System.Drawing.Point(109, 12);
            this.lblFormStatus.Name = "lblFormStatus";
            this.lblFormStatus.Size = new System.Drawing.Size(431, 32);
            this.lblFormStatus.TabIndex = 139;
            this.lblFormStatus.Text = "Replacement Licence Application";
            // 
            // frmReplaceLostOrDamagedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 545);
            this.Controls.Add(this.lblFormStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblLinkShowLicenseHistory);
            this.Controls.Add(this.lbllinkShowNewLicenseInfo);
            this.Controls.Add(this.grbboxReason);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Name = "frmReplaceLostOrDamagedLicense";
            this.Text = "Replace Lost Or Damaged License";
            this.Activated += new System.EventHandler(this.frmReplaceLostOrDamagedLicense_Activated);
            this.Load += new System.EventHandler(this.frmReplaceLostOrDamagedLicense_Load);
            this.grbboxReason.ResumeLayout(false);
            this.grbboxReason.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.GroupBox grbboxReason;
        private System.Windows.Forms.RadioButton rdbtnLost;
        private System.Windows.Forms.RadioButton rdbtnDamaged;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel lblLinkShowLicenseHistory;
        private System.Windows.Forms.LinkLabel lbllinkShowNewLicenseInfo;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblOldLicenseIdResult;
        private System.Windows.Forms.Label lblOldLicenseId;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Label lblReplacedLicenseIDResult;
        private System.Windows.Forms.Label lblRenewedLicenseID;
        private System.Windows.Forms.Label lblRLAPPResult;
        private System.Windows.Forms.Label lblRLID;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label lblAPPFeesResult;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label lblAppDAteResult;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCreatedByResult;
        private System.Windows.Forms.Label lblFormStatus;
    }
}