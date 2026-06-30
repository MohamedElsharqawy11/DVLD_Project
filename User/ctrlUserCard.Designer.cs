namespace DVLD_Project
{
    partial class ctrlUserCard
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
            this.ctrlPersonCard1 = new DVLD_Project.ctrlPersonCard();
            this.grbLogiInfo = new System.Windows.Forms.GroupBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUsrIDResult = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserNameResult = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblIsActiveResult = new System.Windows.Forms.Label();
            this.grbLogiInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(1, 3);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(649, 258);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // grbLogiInfo
            // 
            this.grbLogiInfo.Controls.Add(this.lblIsActiveResult);
            this.grbLogiInfo.Controls.Add(this.lblIsActive);
            this.grbLogiInfo.Controls.Add(this.lblUserNameResult);
            this.grbLogiInfo.Controls.Add(this.lblUserName);
            this.grbLogiInfo.Controls.Add(this.lblUsrIDResult);
            this.grbLogiInfo.Controls.Add(this.lblUserID);
            this.grbLogiInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLogiInfo.Location = new System.Drawing.Point(12, 265);
            this.grbLogiInfo.Name = "grbLogiInfo";
            this.grbLogiInfo.Size = new System.Drawing.Size(638, 58);
            this.grbLogiInfo.TabIndex = 1;
            this.grbLogiInfo.TabStop = false;
            this.grbLogiInfo.Text = "Login Information";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(111, 30);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(63, 14);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "User ID : ";
            // 
            // lblUsrIDResult
            // 
            this.lblUsrIDResult.AutoSize = true;
            this.lblUsrIDResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrIDResult.Location = new System.Drawing.Point(177, 30);
            this.lblUsrIDResult.Name = "lblUsrIDResult";
            this.lblUsrIDResult.Size = new System.Drawing.Size(49, 14);
            this.lblUsrIDResult.TabIndex = 1;
            this.lblUsrIDResult.Text = "[........]";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(289, 30);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(82, 14);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name : ";
            // 
            // lblUserNameResult
            // 
            this.lblUserNameResult.AutoSize = true;
            this.lblUserNameResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameResult.Location = new System.Drawing.Point(374, 30);
            this.lblUserNameResult.Name = "lblUserNameResult";
            this.lblUserNameResult.Size = new System.Drawing.Size(49, 14);
            this.lblUserNameResult.TabIndex = 3;
            this.lblUserNameResult.Text = "[........]";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.Location = new System.Drawing.Point(484, 30);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(72, 14);
            this.lblIsActive.TabIndex = 4;
            this.lblIsActive.Text = "Is Active : ";
            // 
            // lblIsActiveResult
            // 
            this.lblIsActiveResult.AutoSize = true;
            this.lblIsActiveResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActiveResult.Location = new System.Drawing.Point(559, 30);
            this.lblIsActiveResult.Name = "lblIsActiveResult";
            this.lblIsActiveResult.Size = new System.Drawing.Size(49, 14);
            this.lblIsActiveResult.TabIndex = 5;
            this.lblIsActiveResult.Text = "[........]";
            // 
            // ctrlUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbLogiInfo);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Name = "ctrlUserCard";
            this.Size = new System.Drawing.Size(657, 334);
            this.grbLogiInfo.ResumeLayout(false);
            this.grbLogiInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.GroupBox grbLogiInfo;
        private System.Windows.Forms.Label lblIsActiveResult;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblUserNameResult;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUsrIDResult;
        private System.Windows.Forms.Label lblUserID;
    }
}
