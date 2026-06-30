namespace DVLD_Project
{
    partial class frmDetainLicenseApplication
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainLicenseApplication));
            this.lblManagePeopleDetainLicense = new System.Windows.Forms.Label();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD_Project.ctrlDriverLicenseInfoWithFilter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbxFineFees = new System.Windows.Forms.TextBox();
            this.lblCreatedByResult = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblLicenseIdResult = new System.Windows.Forms.Label();
            this.lblLicenseId = new System.Windows.Forms.Label();
            this.lblDetainIDResult = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.lblDetainDAteResult = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblLinkShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.btnDetain = new System.Windows.Forms.Button();
            this.lbllinkShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManagePeopleDetainLicense
            // 
            this.lblManagePeopleDetainLicense.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblManagePeopleDetainLicense.AutoSize = true;
            this.lblManagePeopleDetainLicense.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagePeopleDetainLicense.ForeColor = System.Drawing.Color.Red;
            this.lblManagePeopleDetainLicense.Location = new System.Drawing.Point(251, 10);
            this.lblManagePeopleDetainLicense.Name = "lblManagePeopleDetainLicense";
            this.lblManagePeopleDetainLicense.Size = new System.Drawing.Size(164, 25);
            this.lblManagePeopleDetainLicense.TabIndex = 2;
            this.lblManagePeopleDetainLicense.Text = "Detain License";
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(-2, 35);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(669, 353);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 3;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbxFineFees);
            this.groupBox1.Controls.Add(this.lblCreatedByResult);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.lblCreatedBy);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.lblLicenseIdResult);
            this.groupBox1.Controls.Add(this.lblLicenseId);
            this.groupBox1.Controls.Add(this.lblDetainIDResult);
            this.groupBox1.Controls.Add(this.lblDetainID);
            this.groupBox1.Controls.Add(this.pictureBox10);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.lblFineFees);
            this.groupBox1.Controls.Add(this.lblDetainDAteResult);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.lblDetainDate);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 105);
            this.groupBox1.TabIndex = 143;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detain Information";
            // 
            // txtbxFineFees
            // 
            this.txtbxFineFees.Location = new System.Drawing.Point(152, 72);
            this.txtbxFineFees.Name = "txtbxFineFees";
            this.txtbxFineFees.Size = new System.Drawing.Size(60, 22);
            this.txtbxFineFees.TabIndex = 138;
            this.txtbxFineFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtbxFineFees_Validating);
            // 
            // lblCreatedByResult
            // 
            this.lblCreatedByResult.AutoSize = true;
            this.lblCreatedByResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByResult.Location = new System.Drawing.Point(567, 50);
            this.lblCreatedByResult.Name = "lblCreatedByResult";
            this.lblCreatedByResult.Size = new System.Drawing.Size(49, 14);
            this.lblCreatedByResult.TabIndex = 137;
            this.lblCreatedByResult.Text = "[........]";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(530, 46);
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
            this.lblCreatedBy.Location = new System.Drawing.Point(436, 49);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(88, 16);
            this.lblCreatedBy.TabIndex = 135;
            this.lblCreatedBy.Text = "Created By :";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(530, 18);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(27, 22);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox8.TabIndex = 134;
            this.pictureBox8.TabStop = false;
            // 
            // lblLicenseIdResult
            // 
            this.lblLicenseIdResult.AutoSize = true;
            this.lblLicenseIdResult.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseIdResult.Location = new System.Drawing.Point(565, 20);
            this.lblLicenseIdResult.Name = "lblLicenseIdResult";
            this.lblLicenseIdResult.Size = new System.Drawing.Size(51, 16);
            this.lblLicenseIdResult.TabIndex = 133;
            this.lblLicenseIdResult.Text = "[........]";
            // 
            // lblLicenseId
            // 
            this.lblLicenseId.AutoSize = true;
            this.lblLicenseId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseId.Location = new System.Drawing.Point(443, 22);
            this.lblLicenseId.Name = "lblLicenseId";
            this.lblLicenseId.Size = new System.Drawing.Size(81, 16);
            this.lblLicenseId.TabIndex = 132;
            this.lblLicenseId.Text = "License Id :";
            // 
            // lblDetainIDResult
            // 
            this.lblDetainIDResult.AutoSize = true;
            this.lblDetainIDResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainIDResult.Location = new System.Drawing.Point(149, 22);
            this.lblDetainIDResult.Name = "lblDetainIDResult";
            this.lblDetainIDResult.Size = new System.Drawing.Size(45, 14);
            this.lblDetainIDResult.TabIndex = 128;
            this.lblDetainIDResult.Text = "[.......]";
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainID.Location = new System.Drawing.Point(30, 21);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(76, 16);
            this.lblDetainID.TabIndex = 126;
            this.lblDetainID.Text = "Detain ID :";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(112, 18);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(27, 22);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox10.TabIndex = 127;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(112, 72);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 121;
            this.pictureBox3.TabStop = false;
            // 
            // lblFineFees
            // 
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineFees.Location = new System.Drawing.Point(32, 73);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(74, 16);
            this.lblFineFees.TabIndex = 120;
            this.lblFineFees.Text = "Fine Fees :";
            // 
            // lblDetainDAteResult
            // 
            this.lblDetainDAteResult.AutoSize = true;
            this.lblDetainDAteResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDAteResult.Location = new System.Drawing.Point(149, 47);
            this.lblDetainDAteResult.Name = "lblDetainDAteResult";
            this.lblDetainDAteResult.Size = new System.Drawing.Size(63, 14);
            this.lblDetainDAteResult.TabIndex = 119;
            this.lblDetainDAteResult.Text = "[../../....]";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(112, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 118;
            this.pictureBox2.TabStop = false;
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.Location = new System.Drawing.Point(13, 47);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(93, 16);
            this.lblDetainDate.TabIndex = 117;
            this.lblDetainDate.Text = "Detain Date :";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnCancel.Location = new System.Drawing.Point(434, 496);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 39);
            this.btnCancel.TabIndex = 141;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLinkShowLicenseHistory
            // 
            this.lblLinkShowLicenseHistory.AutoSize = true;
            this.lblLinkShowLicenseHistory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkShowLicenseHistory.Location = new System.Drawing.Point(13, 498);
            this.lblLinkShowLicenseHistory.Name = "lblLinkShowLicenseHistory";
            this.lblLinkShowLicenseHistory.Size = new System.Drawing.Size(145, 16);
            this.lblLinkShowLicenseHistory.TabIndex = 140;
            this.lblLinkShowLicenseHistory.TabStop = true;
            this.lblLinkShowLicenseHistory.Text = "Show License History";
            this.lblLinkShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkShowLicenseHistory_LinkClicked);
            // 
            // btnDetain
            // 
            this.btnDetain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetain.Image = ((System.Drawing.Image)(resources.GetObject("btnDetain.Image")));
            this.btnDetain.Location = new System.Drawing.Point(557, 495);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(95, 39);
            this.btnDetain.TabIndex = 142;
            this.btnDetain.Text = "Detain";
            this.btnDetain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // lbllinkShowNewLicenseInfo
            // 
            this.lbllinkShowNewLicenseInfo.AutoSize = true;
            this.lbllinkShowNewLicenseInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllinkShowNewLicenseInfo.Location = new System.Drawing.Point(156, 498);
            this.lbllinkShowNewLicenseInfo.Name = "lbllinkShowNewLicenseInfo";
            this.lbllinkShowNewLicenseInfo.Size = new System.Drawing.Size(155, 16);
            this.lbllinkShowNewLicenseInfo.TabIndex = 139;
            this.lbllinkShowNewLicenseInfo.TabStop = true;
            this.lbllinkShowNewLicenseInfo.Text = "Show New License Info";
            this.lbllinkShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllinkShowNewLicenseInfo_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDetainLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblLinkShowLicenseHistory);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.lbllinkShowNewLicenseInfo);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.lblManagePeopleDetainLicense);
            this.Name = "frmDetainLicenseApplication";
            this.Text = "Detain License Application";
            this.Activated += new System.EventHandler(this.frmDetainLicenseApplication_Activated);
            this.Load += new System.EventHandler(this.frmDetainLicenseApplication_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManagePeopleDetainLicense;
        private ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCreatedByResult;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblLicenseIdResult;
        private System.Windows.Forms.Label lblLicenseId;
        private System.Windows.Forms.Label lblDetainIDResult;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.Label lblDetainDAteResult;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel lblLinkShowLicenseHistory;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.LinkLabel lbllinkShowNewLicenseInfo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtbxFineFees;
    }
}