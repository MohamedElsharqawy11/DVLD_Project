namespace DVLD_Project
{
    partial class frmListLocalDrivingLicensesApps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListLocalDrivingLicensesApps));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.txtFilterBy = new System.Windows.Forms.TextBox();
            this.btnAddNewApplication = new System.Windows.Forms.Button();
            this.PbManagePeopleForm = new System.Windows.Forms.PictureBox();
            this.lblRecordsNums = new System.Windows.Forms.Label();
            this.lblrecords = new System.Windows.Forms.Label();
            this.lblLocalDrivingLicense = new System.Windows.Forms.Label();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMenuApps = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ScheduleTests = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.issueDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonHistoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmboFilterBy = new System.Windows.Forms.ComboBox();
            this.dgvLocalLicenseApps = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbManagePeopleForm)).BeginInit();
            this.CMenuApps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenseApps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(931, 517);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 33);
            this.btnClose.TabIndex = 22;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(5, 189);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(64, 16);
            this.lblFilterBy.TabIndex = 20;
            this.lblFilterBy.Text = "FilterBy :";
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterBy.Location = new System.Drawing.Point(228, 183);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(155, 22);
            this.txtFilterBy.TabIndex = 19;
            this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
            this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            // 
            // btnAddNewApplication
            // 
            this.btnAddNewApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewApplication.AutoSize = true;
            this.btnAddNewApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewApplication.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewApplication.Image")));
            this.btnAddNewApplication.Location = new System.Drawing.Point(933, 141);
            this.btnAddNewApplication.Name = "btnAddNewApplication";
            this.btnAddNewApplication.Size = new System.Drawing.Size(72, 72);
            this.btnAddNewApplication.TabIndex = 18;
            this.btnAddNewApplication.UseVisualStyleBackColor = true;
            this.btnAddNewApplication.Click += new System.EventHandler(this.btnAddPersonManage_Click);
            // 
            // PbManagePeopleForm
            // 
            this.PbManagePeopleForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PbManagePeopleForm.Image = ((System.Drawing.Image)(resources.GetObject("PbManagePeopleForm.Image")));
            this.PbManagePeopleForm.Location = new System.Drawing.Point(431, 7);
            this.PbManagePeopleForm.Name = "PbManagePeopleForm";
            this.PbManagePeopleForm.Size = new System.Drawing.Size(182, 111);
            this.PbManagePeopleForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbManagePeopleForm.TabIndex = 17;
            this.PbManagePeopleForm.TabStop = false;
            // 
            // lblRecordsNums
            // 
            this.lblRecordsNums.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordsNums.AutoSize = true;
            this.lblRecordsNums.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsNums.Location = new System.Drawing.Point(80, 522);
            this.lblRecordsNums.Name = "lblRecordsNums";
            this.lblRecordsNums.Size = new System.Drawing.Size(19, 16);
            this.lblRecordsNums.TabIndex = 16;
            this.lblRecordsNums.Text = "--";
            // 
            // lblrecords
            // 
            this.lblrecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblrecords.AutoSize = true;
            this.lblrecords.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecords.Location = new System.Drawing.Point(9, 522);
            this.lblrecords.Name = "lblrecords";
            this.lblrecords.Size = new System.Drawing.Size(73, 16);
            this.lblrecords.TabIndex = 15;
            this.lblrecords.Text = "Records : ";
            // 
            // lblLocalDrivingLicense
            // 
            this.lblLocalDrivingLicense.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLocalDrivingLicense.AutoSize = true;
            this.lblLocalDrivingLicense.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalDrivingLicense.ForeColor = System.Drawing.Color.Red;
            this.lblLocalDrivingLicense.Location = new System.Drawing.Point(340, 121);
            this.lblLocalDrivingLicense.Name = "lblLocalDrivingLicense";
            this.lblLocalDrivingLicense.Size = new System.Drawing.Size(365, 25);
            this.lblLocalDrivingLicense.TabIndex = 14;
            this.lblLocalDrivingLicense.Text = "Local Driving License Applications";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(258, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.deleteToolStripMenuItem.Text = "&Delete Application";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.edit_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.editToolStripMenuItem.Text = "&Edit Application";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(258, 6);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.PersonDetails_32;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.showDetailsToolStripMenuItem.Text = "&Show Application Info";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // CMenuApps
            // 
            this.CMenuApps.ImageScalingSize = new System.Drawing.Size(31, 31);
            this.CMenuApps.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.toolStripMenuItem10,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem4,
            this.cancelApplicationToolStripMenuItem,
            this.toolStripMenuItem2,
            this.ScheduleTests,
            this.toolStripMenuItem3,
            this.issueDrivingLicenseToolStripMenuItem,
            this.toolStripMenuItem8,
            this.showLicenseToolStripMenuItem,
            this.toolStripMenuItem9,
            this.showPersonHistoryToolStripMenuItem1});
            this.CMenuApps.Name = "contextMenuStrip1";
            this.CMenuApps.Size = new System.Drawing.Size(262, 372);
            this.CMenuApps.Opening += new System.ComponentModel.CancelEventHandler(this.CMenuApps_Opening);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(258, 6);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cancelApplicationToolStripMenuItem.Image")));
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.cancelApplicationToolStripMenuItem.Text = "&Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(258, 6);
            // 
            // ScheduleTests
            // 
            this.ScheduleTests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ScheduleVisionTest,
            this.ScheduleWrittenTest,
            this.ScheduleStreetTest});
            this.ScheduleTests.Image = ((System.Drawing.Image)(resources.GetObject("ScheduleTests.Image")));
            this.ScheduleTests.Name = "ScheduleTests";
            this.ScheduleTests.Size = new System.Drawing.Size(261, 38);
            this.ScheduleTests.Text = "Schedule &Tests";
            // 
            // ScheduleVisionTest
            // 
            this.ScheduleVisionTest.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleVisionTest.Image = ((System.Drawing.Image)(resources.GetObject("ScheduleVisionTest.Image")));
            this.ScheduleVisionTest.Name = "ScheduleVisionTest";
            this.ScheduleVisionTest.Size = new System.Drawing.Size(186, 22);
            this.ScheduleVisionTest.Text = "Schedule Vision Test";
            this.ScheduleVisionTest.Click += new System.EventHandler(this.ScheduleVisionTest_Click);
            // 
            // ScheduleWrittenTest
            // 
            this.ScheduleWrittenTest.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleWrittenTest.Image = ((System.Drawing.Image)(resources.GetObject("ScheduleWrittenTest.Image")));
            this.ScheduleWrittenTest.Name = "ScheduleWrittenTest";
            this.ScheduleWrittenTest.Size = new System.Drawing.Size(186, 22);
            this.ScheduleWrittenTest.Text = "Schedule Written Test";
            this.ScheduleWrittenTest.Click += new System.EventHandler(this.ScheduleWrittenTest_Click);
            // 
            // ScheduleStreetTest
            // 
            this.ScheduleStreetTest.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleStreetTest.Image = ((System.Drawing.Image)(resources.GetObject("ScheduleStreetTest.Image")));
            this.ScheduleStreetTest.Name = "ScheduleStreetTest";
            this.ScheduleStreetTest.Size = new System.Drawing.Size(186, 22);
            this.ScheduleStreetTest.Text = "Schedule Street Test";
            this.ScheduleStreetTest.Click += new System.EventHandler(this.ScheduleStreetTest_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(258, 6);
            // 
            // issueDrivingLicenseToolStripMenuItem
            // 
            this.issueDrivingLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.account_settings_64;
            this.issueDrivingLicenseToolStripMenuItem.Name = "issueDrivingLicenseToolStripMenuItem";
            this.issueDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.issueDrivingLicenseToolStripMenuItem.Text = "&Issue Driving License (First Time)";
            this.issueDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(258, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseToolStripMenuItem.Image")));
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.showLicenseToolStripMenuItem.Text = "Show &License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(258, 6);
            // 
            // showPersonHistoryToolStripMenuItem1
            // 
            this.showPersonHistoryToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("showPersonHistoryToolStripMenuItem1.Image")));
            this.showPersonHistoryToolStripMenuItem1.Name = "showPersonHistoryToolStripMenuItem1";
            this.showPersonHistoryToolStripMenuItem1.Size = new System.Drawing.Size(261, 38);
            this.showPersonHistoryToolStripMenuItem1.Text = "Show &Person License History";
            this.showPersonHistoryToolStripMenuItem1.Click += new System.EventHandler(this.showPersonHistoryToolStripMenuItem1_Click);
            // 
            // cmboFilterBy
            // 
            this.cmboFilterBy.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmboFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboFilterBy.FormattingEnabled = true;
            this.cmboFilterBy.Items.AddRange(new object[] {
            "None",
            "L.D.L AppID",
            "National Number",
            "Full Name",
            "Status"});
            this.cmboFilterBy.Location = new System.Drawing.Point(75, 184);
            this.cmboFilterBy.Name = "cmboFilterBy";
            this.cmboFilterBy.Size = new System.Drawing.Size(147, 21);
            this.cmboFilterBy.TabIndex = 21;
            this.cmboFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmboFilterBy_SelectedIndexChanged);
            // 
            // dgvLocalLicenseApps
            // 
            this.dgvLocalLicenseApps.AllowUserToAddRows = false;
            this.dgvLocalLicenseApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLocalLicenseApps.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLocalLicenseApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicenseApps.ContextMenuStrip = this.CMenuApps;
            this.dgvLocalLicenseApps.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLocalLicenseApps.Location = new System.Drawing.Point(6, 216);
            this.dgvLocalLicenseApps.Name = "dgvLocalLicenseApps";
            this.dgvLocalLicenseApps.Size = new System.Drawing.Size(999, 295);
            this.dgvLocalLicenseApps.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(584, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // frmListLocalDrivingLicensesApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 555);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.btnAddNewApplication);
            this.Controls.Add(this.PbManagePeopleForm);
            this.Controls.Add(this.lblRecordsNums);
            this.Controls.Add(this.lblrecords);
            this.Controls.Add(this.lblLocalDrivingLicense);
            this.Controls.Add(this.cmboFilterBy);
            this.Controls.Add(this.dgvLocalLicenseApps);
            this.Name = "frmListLocalDrivingLicensesApps";
            this.Text = "List Local Driving Licenses Applications";
            this.Load += new System.EventHandler(this.frmListLocalDrivingLicensesApps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbManagePeopleForm)).EndInit();
            this.CMenuApps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenseApps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.TextBox txtFilterBy;
        private System.Windows.Forms.Button btnAddNewApplication;
        private System.Windows.Forms.PictureBox PbManagePeopleForm;
        private System.Windows.Forms.Label lblRecordsNums;
        private System.Windows.Forms.Label lblrecords;
        private System.Windows.Forms.Label lblLocalDrivingLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CMenuApps;
        private System.Windows.Forms.ComboBox cmboFilterBy;
        private System.Windows.Forms.DataGridView dgvLocalLicenseApps;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ScheduleTests;
        private System.Windows.Forms.ToolStripMenuItem ScheduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem ScheduleWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem ScheduleStreetTest;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem showPersonHistoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
    }
}