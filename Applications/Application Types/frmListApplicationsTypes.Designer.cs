namespace DVLD_Project
{
    partial class frmListApplicationsTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListApplicationsTypes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvAppsTypes = new System.Windows.Forms.DataGridView();
            this.lblRecordsApppsNums = new System.Windows.Forms.Label();
            this.lblrecordsApps = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblManageAppsTypes = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppsTypes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.Application_Types_512;
            this.pictureBox1.Location = new System.Drawing.Point(194, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvAppsTypes
            // 
            this.dgvAppsTypes.AllowUserToAddRows = false;
            this.dgvAppsTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAppsTypes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAppsTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppsTypes.Location = new System.Drawing.Point(1, 236);
            this.dgvAppsTypes.Name = "dgvAppsTypes";
            this.dgvAppsTypes.Size = new System.Drawing.Size(554, 218);
            this.dgvAppsTypes.TabIndex = 5;
            // 
            // lblRecordsApppsNums
            // 
            this.lblRecordsApppsNums.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordsApppsNums.AutoSize = true;
            this.lblRecordsApppsNums.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsApppsNums.Location = new System.Drawing.Point(70, 465);
            this.lblRecordsApppsNums.Name = "lblRecordsApppsNums";
            this.lblRecordsApppsNums.Size = new System.Drawing.Size(19, 16);
            this.lblRecordsApppsNums.TabIndex = 7;
            this.lblRecordsApppsNums.Text = "--";
            // 
            // lblrecordsApps
            // 
            this.lblrecordsApps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblrecordsApps.AutoSize = true;
            this.lblrecordsApps.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecordsApps.Location = new System.Drawing.Point(3, 465);
            this.lblrecordsApps.Name = "lblrecordsApps";
            this.lblrecordsApps.Size = new System.Drawing.Size(73, 16);
            this.lblrecordsApps.TabIndex = 6;
            this.lblrecordsApps.Text = "Records : ";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(473, 484);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 33);
            this.btnClose.TabIndex = 14;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblManageAppsTypes
            // 
            this.lblManageAppsTypes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblManageAppsTypes.AutoSize = true;
            this.lblManageAppsTypes.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageAppsTypes.ForeColor = System.Drawing.Color.Red;
            this.lblManageAppsTypes.Location = new System.Drawing.Point(136, 190);
            this.lblManageAppsTypes.Name = "lblManageAppsTypes";
            this.lblManageAppsTypes.Size = new System.Drawing.Size(281, 25);
            this.lblManageAppsTypes.TabIndex = 15;
            this.lblManageAppsTypes.Text = "Manage Application types";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(202, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(201, 38);
            this.editToolStripMenuItem.Text = "&Edit Application Type";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(198, 6);
            // 
            // frmListApplicationsTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 529);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblManageAppsTypes);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsApppsNums);
            this.Controls.Add(this.lblrecordsApps);
            this.Controls.Add(this.dgvAppsTypes);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmListApplicationsTypes";
            this.Text = "frmListApplicationsTypes";
            this.Load += new System.EventHandler(this.frmListApplicationsTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppsTypes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvAppsTypes;
        private System.Windows.Forms.Label lblRecordsApppsNums;
        private System.Windows.Forms.Label lblrecordsApps;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblManageAppsTypes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}