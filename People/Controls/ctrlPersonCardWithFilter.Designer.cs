namespace DVLD_Project
{
    partial class ctrlPersonCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPersonCardWithFilter));
            this.lblFindBy = new System.Windows.Forms.Label();
            this.cmboFindBy = new System.Windows.Forms.ComboBox();
            this.GrpFilter = new System.Windows.Forms.GroupBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnSearchperson = new System.Windows.Forms.Button();
            this.txtFilterdValue = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonCard1 = new DVLD_Project.ctrlPersonCard();
            this.GrpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFindBy
            // 
            this.lblFindBy.AutoSize = true;
            this.lblFindBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindBy.Location = new System.Drawing.Point(8, 21);
            this.lblFindBy.Name = "lblFindBy";
            this.lblFindBy.Size = new System.Drawing.Size(57, 16);
            this.lblFindBy.TabIndex = 1;
            this.lblFindBy.Text = "Find By:";
            // 
            // cmboFindBy
            // 
            this.cmboFindBy.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmboFindBy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboFindBy.FormattingEnabled = true;
            this.cmboFindBy.Items.AddRange(new object[] {
            "Person ID",
            "National Number"});
            this.cmboFindBy.Location = new System.Drawing.Point(71, 20);
            this.cmboFindBy.Name = "cmboFindBy";
            this.cmboFindBy.Size = new System.Drawing.Size(140, 21);
            this.cmboFindBy.TabIndex = 2;
            this.cmboFindBy.SelectedIndexChanged += new System.EventHandler(this.cmboFindBy_SelectedIndexChanged);
            // 
            // GrpFilter
            // 
            this.GrpFilter.Controls.Add(this.btnAddPerson);
            this.GrpFilter.Controls.Add(this.btnSearchperson);
            this.GrpFilter.Controls.Add(this.txtFilterdValue);
            this.GrpFilter.Controls.Add(this.cmboFindBy);
            this.GrpFilter.Controls.Add(this.lblFindBy);
            this.GrpFilter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpFilter.Location = new System.Drawing.Point(14, 18);
            this.GrpFilter.Name = "GrpFilter";
            this.GrpFilter.Size = new System.Drawing.Size(612, 52);
            this.GrpFilter.TabIndex = 3;
            this.GrpFilter.TabStop = false;
            this.GrpFilter.Text = "Filter";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPerson.Image")));
            this.btnAddPerson.Location = new System.Drawing.Point(435, 14);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(34, 33);
            this.btnAddPerson.TabIndex = 7;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnSearchperson
            // 
            this.btnSearchperson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchperson.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchperson.Image")));
            this.btnSearchperson.Location = new System.Drawing.Point(386, 14);
            this.btnSearchperson.Name = "btnSearchperson";
            this.btnSearchperson.Size = new System.Drawing.Size(34, 33);
            this.btnSearchperson.TabIndex = 6;
            this.btnSearchperson.UseVisualStyleBackColor = true;
            this.btnSearchperson.Click += new System.EventHandler(this.btnSearchperson_Click);
            // 
            // txtFilterdValue
            // 
            this.txtFilterdValue.Location = new System.Drawing.Point(230, 21);
            this.txtFilterdValue.Name = "txtFilterdValue";
            this.txtFilterdValue.Size = new System.Drawing.Size(140, 22);
            this.txtFilterdValue.TabIndex = 3;
            this.txtFilterdValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterdValue_KeyPress);
            this.txtFilterdValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterdValue_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(3, 64);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(623, 225);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // ctrlPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrpFilter);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Name = "ctrlPersonCardWithFilter";
            this.Size = new System.Drawing.Size(640, 323);
            this.Load += new System.EventHandler(this.ctrlPersonCardWithFilter_Load);
            this.GrpFilter.ResumeLayout(false);
            this.GrpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Label lblFindBy;
        private System.Windows.Forms.ComboBox cmboFindBy;
        private System.Windows.Forms.GroupBox GrpFilter;
        private System.Windows.Forms.TextBox txtFilterdValue;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnSearchperson;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
