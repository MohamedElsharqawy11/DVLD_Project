namespace DVLD_Project.Applications.Rlease_Detained_License
{
    partial class frmListDetainedLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListDetainedLicenses));
            this.cmboFilterBy = new System.Windows.Forms.ComboBox();
            this.showPersonHistoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.CMenuApps = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainedLicesneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.txtFilterBy = new System.Windows.Forms.TextBox();
            this.btnDetain = new System.Windows.Forms.Button();
            this.PbManagePeopleForm = new System.Windows.Forms.PictureBox();
            this.lblRecordsNums = new System.Windows.Forms.Label();
            this.lblrecords = new System.Windows.Forms.Label();
            this.lblLocalDrivingLicense = new System.Windows.Forms.Label();
            this.dgvDetainedLicenseApps = new System.Windows.Forms.DataGridView();
            this.btnRelease = new System.Windows.Forms.Button();
            this.cmbIsReleased = new System.Windows.Forms.ComboBox();
            this.CMenuApps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbManagePeopleForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenseApps)).BeginInit();
            this.SuspendLayout();
            // 
            // cmboFilterBy
            // 
            this.cmboFilterBy.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmboFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboFilterBy.FormattingEnabled = true;
            this.cmboFilterBy.Items.AddRange(new object[] {
            "None",
            "Detain ID",
            "Is Released",
            "National Number",
            "Full Name",
            "Released Application ID"});
            this.cmboFilterBy.Location = new System.Drawing.Point(78, 195);
            this.cmboFilterBy.Name = "cmboFilterBy";
            this.cmboFilterBy.Size = new System.Drawing.Size(147, 21);
            this.cmboFilterBy.TabIndex = 32;
            this.cmboFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmboFilterBy_SelectedIndexChanged);
            // 
            // showPersonHistoryToolStripMenuItem1
            // 
            this.showPersonHistoryToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("showPersonHistoryToolStripMenuItem1.Image")));
            this.showPersonHistoryToolStripMenuItem1.Name = "showPersonHistoryToolStripMenuItem1";
            this.showPersonHistoryToolStripMenuItem1.Size = new System.Drawing.Size(241, 38);
            this.showPersonHistoryToolStripMenuItem1.Text = "Show &Person License History";
            this.showPersonHistoryToolStripMenuItem1.Click += new System.EventHandler(this.showPersonHistoryToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(238, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseToolStripMenuItem.Image")));
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.showLicenseToolStripMenuItem.Text = "Show &License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(238, 6);
            // 
            // CMenuApps
            // 
            this.CMenuApps.ImageScalingSize = new System.Drawing.Size(31, 31);
            this.CMenuApps.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.showLicenseToolStripMenuItem,
            this.toolStripMenuItem9,
            this.showPersonHistoryToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.releaseDetainedLicesneToolStripMenuItem});
            this.CMenuApps.Name = "contextMenuStrip1";
            this.CMenuApps.Size = new System.Drawing.Size(242, 174);
            this.CMenuApps.Opening += new System.ComponentModel.CancelEventHandler(this.CMenuApps_Opening);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.PersonDetails_32;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.showDetailsToolStripMenuItem.Text = "&Show Person Info";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(238, 6);
            // 
            // releaseDetainedLicesneToolStripMenuItem
            // 
            this.releaseDetainedLicesneToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Release_Detained_License_32;
            this.releaseDetainedLicesneToolStripMenuItem.Name = "releaseDetainedLicesneToolStripMenuItem";
            this.releaseDetainedLicesneToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.releaseDetainedLicesneToolStripMenuItem.Text = "&Release Detained Licesne";
            this.releaseDetainedLicesneToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicesneToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(792, 410);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 33);
            this.btnClose.TabIndex = 33;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(8, 197);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(64, 16);
            this.lblFilterBy.TabIndex = 31;
            this.lblFilterBy.Text = "FilterBy :";
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterBy.Location = new System.Drawing.Point(305, 194);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(81, 22);
            this.txtFilterBy.TabIndex = 30;
            this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
            this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            // 
            // btnDetain
            // 
            this.btnDetain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetain.AutoSize = true;
            this.btnDetain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetain.Image = ((System.Drawing.Image)(resources.GetObject("btnDetain.Image")));
            this.btnDetain.Location = new System.Drawing.Point(793, 149);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(73, 72);
            this.btnDetain.TabIndex = 29;
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // PbManagePeopleForm
            // 
            this.PbManagePeopleForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PbManagePeopleForm.Image = ((System.Drawing.Image)(resources.GetObject("PbManagePeopleForm.Image")));
            this.PbManagePeopleForm.Location = new System.Drawing.Point(355, 6);
            this.PbManagePeopleForm.Name = "PbManagePeopleForm";
            this.PbManagePeopleForm.Size = new System.Drawing.Size(182, 108);
            this.PbManagePeopleForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbManagePeopleForm.TabIndex = 28;
            this.PbManagePeopleForm.TabStop = false;
            // 
            // lblRecordsNums
            // 
            this.lblRecordsNums.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordsNums.AutoSize = true;
            this.lblRecordsNums.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsNums.Location = new System.Drawing.Point(83, 419);
            this.lblRecordsNums.Name = "lblRecordsNums";
            this.lblRecordsNums.Size = new System.Drawing.Size(19, 16);
            this.lblRecordsNums.TabIndex = 27;
            this.lblRecordsNums.Text = "--";
            // 
            // lblrecords
            // 
            this.lblrecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblrecords.AutoSize = true;
            this.lblrecords.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecords.Location = new System.Drawing.Point(12, 419);
            this.lblrecords.Name = "lblrecords";
            this.lblrecords.Size = new System.Drawing.Size(73, 16);
            this.lblrecords.TabIndex = 26;
            this.lblrecords.Text = "Records : ";
            // 
            // lblLocalDrivingLicense
            // 
            this.lblLocalDrivingLicense.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLocalDrivingLicense.AutoSize = true;
            this.lblLocalDrivingLicense.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalDrivingLicense.ForeColor = System.Drawing.Color.Red;
            this.lblLocalDrivingLicense.Location = new System.Drawing.Point(319, 117);
            this.lblLocalDrivingLicense.Name = "lblLocalDrivingLicense";
            this.lblLocalDrivingLicense.Size = new System.Drawing.Size(244, 25);
            this.lblLocalDrivingLicense.TabIndex = 25;
            this.lblLocalDrivingLicense.Text = "List Detained Licenses";
            // 
            // dgvDetainedLicenseApps
            // 
            this.dgvDetainedLicenseApps.AllowUserToAddRows = false;
            this.dgvDetainedLicenseApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetainedLicenseApps.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDetainedLicenseApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetainedLicenseApps.ContextMenuStrip = this.CMenuApps;
            this.dgvDetainedLicenseApps.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDetainedLicenseApps.Location = new System.Drawing.Point(9, 229);
            this.dgvDetainedLicenseApps.Name = "dgvDetainedLicenseApps";
            this.dgvDetainedLicenseApps.Size = new System.Drawing.Size(857, 172);
            this.dgvDetainedLicenseApps.TabIndex = 24;
            // 
            // btnRelease
            // 
            this.btnRelease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRelease.AutoSize = true;
            this.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelease.Image = ((System.Drawing.Image)(resources.GetObject("btnRelease.Image")));
            this.btnRelease.Location = new System.Drawing.Point(716, 149);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(72, 72);
            this.btnRelease.TabIndex = 34;
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // cmbIsReleased
            // 
            this.cmbIsReleased.FormattingEnabled = true;
            this.cmbIsReleased.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cmbIsReleased.Location = new System.Drawing.Point(231, 195);
            this.cmbIsReleased.Name = "cmbIsReleased";
            this.cmbIsReleased.Size = new System.Drawing.Size(68, 21);
            this.cmbIsReleased.TabIndex = 35;
            // 
            // frmListDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 452);
            this.Controls.Add(this.cmbIsReleased);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.cmboFilterBy);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.PbManagePeopleForm);
            this.Controls.Add(this.lblRecordsNums);
            this.Controls.Add(this.lblrecords);
            this.Controls.Add(this.lblLocalDrivingLicense);
            this.Controls.Add(this.dgvDetainedLicenseApps);
            this.Name = "frmListDetainedLicenses";
            this.Text = "List Detained Licenses";
            this.Load += new System.EventHandler(this.frmListDetainedLicenses_Load);
            this.CMenuApps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbManagePeopleForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenseApps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboFilterBy;
        private System.Windows.Forms.ToolStripMenuItem showPersonHistoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip CMenuApps;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.TextBox txtFilterBy;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.PictureBox PbManagePeopleForm;
        private System.Windows.Forms.Label lblRecordsNums;
        private System.Windows.Forms.Label lblrecords;
        private System.Windows.Forms.Label lblLocalDrivingLicense;
        private System.Windows.Forms.DataGridView dgvDetainedLicenseApps;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicesneToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbIsReleased;
    }
}