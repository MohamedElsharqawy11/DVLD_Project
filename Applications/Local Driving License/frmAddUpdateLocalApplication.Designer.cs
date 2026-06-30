namespace DVLD_Project
{
    partial class frmAddUpdateLocalApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateLocalApplication));
            this.tb1 = new System.Windows.Forms.TabControl();
            this.tbPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new DVLD_Project.ctrlPersonCardWithFilter();
            this.tbAppInfo = new System.Windows.Forms.TabPage();
            this.cmboLicensesClasses = new System.Windows.Forms.ComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblLicenseClasses = new System.Windows.Forms.Label();
            this.lblCreatedByResult = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblAPPFeesResult = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.lblAppDAteResult = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.lblDLAPPResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDLAPP = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tb1.SuspendLayout();
            this.tbPersonalInfo.SuspendLayout();
            this.tbAppInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Controls.Add(this.tbPersonalInfo);
            this.tb1.Controls.Add(this.tbAppInfo);
            this.tb1.Location = new System.Drawing.Point(2, 70);
            this.tb1.Name = "tb1";
            this.tb1.SelectedIndex = 0;
            this.tb1.Size = new System.Drawing.Size(657, 352);
            this.tb1.TabIndex = 0;
            // 
            // tbPersonalInfo
            // 
            this.tbPersonalInfo.Controls.Add(this.btnNext);
            this.tbPersonalInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tbPersonalInfo.Location = new System.Drawing.Point(4, 22);
            this.tbPersonalInfo.Name = "tbPersonalInfo";
            this.tbPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonalInfo.Size = new System.Drawing.Size(649, 326);
            this.tbPersonalInfo.TabIndex = 0;
            this.tbPersonalInfo.Text = "Personal Info";
            this.tbPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(545, 278);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 38);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(-2, 0);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(640, 283);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            // 
            // tbAppInfo
            // 
            this.tbAppInfo.Controls.Add(this.cmboLicensesClasses);
            this.tbAppInfo.Controls.Add(this.pictureBox5);
            this.tbAppInfo.Controls.Add(this.lblLicenseClasses);
            this.tbAppInfo.Controls.Add(this.lblCreatedByResult);
            this.tbAppInfo.Controls.Add(this.pictureBox4);
            this.tbAppInfo.Controls.Add(this.lblCreatedBy);
            this.tbAppInfo.Controls.Add(this.lblAPPFeesResult);
            this.tbAppInfo.Controls.Add(this.pictureBox3);
            this.tbAppInfo.Controls.Add(this.lblAppFees);
            this.tbAppInfo.Controls.Add(this.lblAppDAteResult);
            this.tbAppInfo.Controls.Add(this.pictureBox2);
            this.tbAppInfo.Controls.Add(this.lblAppDate);
            this.tbAppInfo.Controls.Add(this.lblDLAPPResult);
            this.tbAppInfo.Controls.Add(this.pictureBox1);
            this.tbAppInfo.Controls.Add(this.lblDLAPP);
            this.tbAppInfo.Location = new System.Drawing.Point(4, 22);
            this.tbAppInfo.Name = "tbAppInfo";
            this.tbAppInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbAppInfo.Size = new System.Drawing.Size(649, 326);
            this.tbAppInfo.TabIndex = 1;
            this.tbAppInfo.Text = "Application Info";
            this.tbAppInfo.UseVisualStyleBackColor = true;
            // 
            // cmboLicensesClasses
            // 
            this.cmboLicensesClasses.FormattingEnabled = true;
            this.cmboLicensesClasses.Location = new System.Drawing.Point(207, 135);
            this.cmboLicensesClasses.Name = "cmboLicensesClasses";
            this.cmboLicensesClasses.Size = new System.Drawing.Size(171, 21);
            this.cmboLicensesClasses.TabIndex = 76;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(162, 135);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 22);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 75;
            this.pictureBox5.TabStop = false;
            // 
            // lblLicenseClasses
            // 
            this.lblLicenseClasses.AutoSize = true;
            this.lblLicenseClasses.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseClasses.Location = new System.Drawing.Point(41, 138);
            this.lblLicenseClasses.Name = "lblLicenseClasses";
            this.lblLicenseClasses.Size = new System.Drawing.Size(116, 16);
            this.lblLicenseClasses.TabIndex = 74;
            this.lblLicenseClasses.Text = "License Classes :";
            // 
            // lblCreatedByResult
            // 
            this.lblCreatedByResult.AutoSize = true;
            this.lblCreatedByResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByResult.Location = new System.Drawing.Point(205, 213);
            this.lblCreatedByResult.Name = "lblCreatedByResult";
            this.lblCreatedByResult.Size = new System.Drawing.Size(45, 14);
            this.lblCreatedByResult.TabIndex = 73;
            this.lblCreatedByResult.Text = "[.......]";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(162, 209);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 72;
            this.pictureBox4.TabStop = false;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(68, 212);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(88, 16);
            this.lblCreatedBy.TabIndex = 71;
            this.lblCreatedBy.Text = "Created By :";
            // 
            // lblAPPFeesResult
            // 
            this.lblAPPFeesResult.AutoSize = true;
            this.lblAPPFeesResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPPFeesResult.Location = new System.Drawing.Point(205, 174);
            this.lblAPPFeesResult.Name = "lblAPPFeesResult";
            this.lblAPPFeesResult.Size = new System.Drawing.Size(45, 14);
            this.lblAPPFeesResult.TabIndex = 70;
            this.lblAPPFeesResult.Text = "[.......]";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(162, 170);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 69;
            this.pictureBox3.TabStop = false;
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFees.Location = new System.Drawing.Point(36, 172);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(121, 16);
            this.lblAppFees.TabIndex = 68;
            this.lblAppFees.Text = "Application Fees :";
            // 
            // lblAppDAteResult
            // 
            this.lblAppDAteResult.AutoSize = true;
            this.lblAppDAteResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDAteResult.Location = new System.Drawing.Point(205, 100);
            this.lblAppDAteResult.Name = "lblAppDAteResult";
            this.lblAppDAteResult.Size = new System.Drawing.Size(45, 14);
            this.lblAppDAteResult.TabIndex = 67;
            this.lblAppDAteResult.Text = "[.......]";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(162, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDate.Location = new System.Drawing.Point(34, 98);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(123, 16);
            this.lblAppDate.TabIndex = 65;
            this.lblAppDate.Text = "Application Date :";
            // 
            // lblDLAPPResult
            // 
            this.lblDLAPPResult.AutoSize = true;
            this.lblDLAPPResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLAPPResult.Location = new System.Drawing.Point(205, 62);
            this.lblDLAPPResult.Name = "lblDLAPPResult";
            this.lblDLAPPResult.Size = new System.Drawing.Size(45, 14);
            this.lblDLAPPResult.TabIndex = 64;
            this.lblDLAPPResult.Text = "[.......]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // lblDLAPP
            // 
            this.lblDLAPP.AutoSize = true;
            this.lblDLAPP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLAPP.Location = new System.Drawing.Point(45, 61);
            this.lblDLAPP.Name = "lblDLAPP";
            this.lblDLAPP.Size = new System.Drawing.Size(112, 16);
            this.lblDLAPP.TabIndex = 62;
            this.lblDLAPP.Text = "D.L.Application :";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::DVLD_Project.Properties.Resources.Save_32;
            this.btnSave.Location = new System.Drawing.Point(551, 428);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 39);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnCancel.Location = new System.Drawing.Point(428, 429);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 39);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(62, 23);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(549, 32);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "New Local Driving Licenses Application";
            // 
            // frmAddUpdateLocalApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 481);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tb1);
            this.Name = "frmAddUpdateLocalApplication";
            this.Text = " ";
            this.Activated += new System.EventHandler(this.frmAddUpdateLocalApplication_Activated);
            this.Load += new System.EventHandler(this.frmAddUpdateApplication_Load);
            this.tb1.ResumeLayout(false);
            this.tbPersonalInfo.ResumeLayout(false);
            this.tbAppInfo.ResumeLayout(false);
            this.tbAppInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tb1;
        private System.Windows.Forms.TabPage tbPersonalInfo;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.TabPage tbAppInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCreatedByResult;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblAPPFeesResult;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label lblAppDAteResult;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label lblDLAPPResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDLAPP;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblLicenseClasses;
        private System.Windows.Forms.ComboBox cmboLicensesClasses;
    }
}