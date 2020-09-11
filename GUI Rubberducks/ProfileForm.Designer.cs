namespace GUI_Registration_p1
{
    partial class ProfileForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
			this.lblJobTitle = new System.Windows.Forms.Label();
			this.lblDepartment = new System.Windows.Forms.Label();
			this.lblUserType = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblUserID = new System.Windows.Forms.Label();
			this.lblUserTypeChosen = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblPhone = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.lblConfirm = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtJobTitle = new System.Windows.Forms.TextBox();
			this.txtDepartment = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUserType = new System.Windows.Forms.TextBox();
			this.txtUserID = new System.Windows.Forms.TextBox();
			this.btnEdit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblJobTitle
			// 
			this.lblJobTitle.AutoSize = true;
			this.lblJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblJobTitle.Location = new System.Drawing.Point(876, 282);
			this.lblJobTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblJobTitle.Name = "lblJobTitle";
			this.lblJobTitle.Size = new System.Drawing.Size(147, 37);
			this.lblJobTitle.TabIndex = 51;
			this.lblJobTitle.Text = "Job Title:";
			// 
			// lblDepartment
			// 
			this.lblDepartment.AutoSize = true;
			this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDepartment.Location = new System.Drawing.Point(830, 341);
			this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDepartment.Name = "lblDepartment";
			this.lblDepartment.Size = new System.Drawing.Size(193, 37);
			this.lblDepartment.TabIndex = 50;
			this.lblDepartment.Text = "Department:";
			// 
			// lblUserType
			// 
			this.lblUserType.AutoSize = true;
			this.lblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUserType.Location = new System.Drawing.Point(25, 118);
			this.lblUserType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUserType.Name = "lblUserType";
			this.lblUserType.Size = new System.Drawing.Size(172, 37);
			this.lblUserType.TabIndex = 48;
			this.lblUserType.Text = "User Type:";
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Location = new System.Drawing.Point(570, 608);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(170, 99);
			this.btnClose.TabIndex = 47;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.Location = new System.Drawing.Point(856, 528);
			this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(167, 37);
			this.lblPassword.TabIndex = 45;
			this.lblPassword.Text = "Password:";
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.Location = new System.Drawing.Point(850, 464);
			this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(173, 37);
			this.lblUsername.TabIndex = 44;
			this.lblUsername.Text = "Username:";
			// 
			// lblUserID
			// 
			this.lblUserID.AutoSize = true;
			this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUserID.Location = new System.Drawing.Point(890, 118);
			this.lblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUserID.Name = "lblUserID";
			this.lblUserID.Size = new System.Drawing.Size(133, 37);
			this.lblUserID.TabIndex = 40;
			this.lblUserID.Text = "User ID:";
			// 
			// lblUserTypeChosen
			// 
			this.lblUserTypeChosen.AutoSize = true;
			this.lblUserTypeChosen.Location = new System.Drawing.Point(256, 262);
			this.lblUserTypeChosen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUserTypeChosen.Name = "lblUserTypeChosen";
			this.lblUserTypeChosen.Size = new System.Drawing.Size(0, 25);
			this.lblUserTypeChosen.TabIndex = 33;
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAddress.Location = new System.Drawing.Point(132, 528);
			this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(144, 37);
			this.lblAddress.TabIndex = 32;
			this.lblAddress.Text = "Address:";
			// 
			// lblPhone
			// 
			this.lblPhone.AutoSize = true;
			this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPhone.Location = new System.Drawing.Point(156, 464);
			this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(118, 37);
			this.lblPhone.TabIndex = 31;
			this.lblPhone.Text = "Phone:";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.Location = new System.Drawing.Point(168, 403);
			this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(106, 37);
			this.lblEmail.TabIndex = 30;
			this.lblEmail.Text = "Email:";
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLastName.Location = new System.Drawing.Point(92, 341);
			this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(182, 37);
			this.lblLastName.TabIndex = 29;
			this.lblLastName.Text = "Last Name:";
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFirstName.Location = new System.Drawing.Point(92, 282);
			this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(184, 37);
			this.lblFirstName.TabIndex = 28;
			this.lblFirstName.Text = "First Name:";
			// 
			// lblConfirm
			// 
			this.lblConfirm.AutoSize = true;
			this.lblConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConfirm.Location = new System.Drawing.Point(744, 30);
			this.lblConfirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblConfirm.Name = "lblConfirm";
			this.lblConfirm.Size = new System.Drawing.Size(152, 51);
			this.lblConfirm.TabIndex = 27;
			this.lblConfirm.Text = "Profile";
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(281, 328);
			this.txtLastName.Multiline = true;
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.ReadOnly = true;
			this.txtLastName.Size = new System.Drawing.Size(498, 50);
			this.txtLastName.TabIndex = 54;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(281, 390);
			this.txtEmail.Multiline = true;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.ReadOnly = true;
			this.txtEmail.Size = new System.Drawing.Size(498, 50);
			this.txtEmail.TabIndex = 55;
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(281, 269);
			this.txtFirstName.Multiline = true;
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.ReadOnly = true;
			this.txtFirstName.Size = new System.Drawing.Size(498, 50);
			this.txtFirstName.TabIndex = 56;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(281, 451);
			this.txtPhone.Multiline = true;
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.ReadOnly = true;
			this.txtPhone.Size = new System.Drawing.Size(498, 50);
			this.txtPhone.TabIndex = 57;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(281, 515);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.ReadOnly = true;
			this.txtAddress.Size = new System.Drawing.Size(498, 50);
			this.txtAddress.TabIndex = 58;
			// 
			// txtJobTitle
			// 
			this.txtJobTitle.Location = new System.Drawing.Point(1030, 269);
			this.txtJobTitle.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
			this.txtJobTitle.Multiline = true;
			this.txtJobTitle.Name = "txtJobTitle";
			this.txtJobTitle.ReadOnly = true;
			this.txtJobTitle.Size = new System.Drawing.Size(498, 50);
			this.txtJobTitle.TabIndex = 59;
			// 
			// txtDepartment
			// 
			this.txtDepartment.Location = new System.Drawing.Point(1030, 328);
			this.txtDepartment.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
			this.txtDepartment.Multiline = true;
			this.txtDepartment.Name = "txtDepartment";
			this.txtDepartment.ReadOnly = true;
			this.txtDepartment.Size = new System.Drawing.Size(498, 50);
			this.txtDepartment.TabIndex = 60;
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(1030, 451);
			this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
			this.txtUsername.Multiline = true;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.ReadOnly = true;
			this.txtUsername.Size = new System.Drawing.Size(498, 50);
			this.txtUsername.TabIndex = 61;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(1030, 515);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
			this.txtPassword.Multiline = true;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.ReadOnly = true;
			this.txtPassword.Size = new System.Drawing.Size(498, 50);
			this.txtPassword.TabIndex = 62;
			// 
			// txtUserType
			// 
			this.txtUserType.Location = new System.Drawing.Point(204, 105);
			this.txtUserType.MaxLength = 500;
			this.txtUserType.Multiline = true;
			this.txtUserType.Name = "txtUserType";
			this.txtUserType.ReadOnly = true;
			this.txtUserType.Size = new System.Drawing.Size(498, 50);
			this.txtUserType.TabIndex = 63;
			// 
			// txtUserID
			// 
			this.txtUserID.Location = new System.Drawing.Point(1030, 105);
			this.txtUserID.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
			this.txtUserID.Multiline = true;
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.ReadOnly = true;
			this.txtUserID.Size = new System.Drawing.Size(498, 50);
			this.txtUserID.TabIndex = 64;
			// 
			// btnEdit
			// 
			this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.Location = new System.Drawing.Point(949, 608);
			this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(172, 99);
			this.btnEdit.TabIndex = 65;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// ProfileForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Pink;
			this.ClientSize = new System.Drawing.Size(1574, 759);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.txtUserID);
			this.Controls.Add(this.txtUserType);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.txtDepartment);
			this.Controls.Add(this.txtJobTitle);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.lblJobTitle);
			this.Controls.Add(this.lblDepartment);
			this.Controls.Add(this.lblUserType);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.lblUserID);
			this.Controls.Add(this.lblUserTypeChosen);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.lblPhone);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.lblFirstName);
			this.Controls.Add(this.lblConfirm);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ProfileForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Profile";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUserTypeChosen;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserType;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Button btnEdit;
	}
}