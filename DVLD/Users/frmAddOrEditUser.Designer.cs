namespace DVLD
{
    partial class frmAddOrEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOrEditUser));
            this.lblUser = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new DVLD.ctrlPersonCardWithFilter();
            this.tagPageLoginInfo = new System.Windows.Forms.TabPage();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmUserPassword = new System.Windows.Forms.TextBox();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.lblConfirmUserPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.btnsaveUser = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btncloseUser = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPagePersonalInfo.SuspendLayout();
            this.tagPageLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.White;
            this.lblUser.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Crimson;
            this.lblUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUser.Location = new System.Drawing.Point(295, 32);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(327, 52);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Add New User";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePersonalInfo);
            this.tabControl1.Controls.Add(this.tagPageLoginInfo);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(922, 529);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPagePersonalInfo
            // 
            this.tabPagePersonalInfo.Controls.Add(this.btnNext);
            this.tabPagePersonalInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tabPagePersonalInfo.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePersonalInfo.Location = new System.Drawing.Point(4, 27);
            this.tabPagePersonalInfo.Name = "tabPagePersonalInfo";
            this.tabPagePersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonalInfo.Size = new System.Drawing.Size(914, 498);
            this.tabPagePersonalInfo.TabIndex = 0;
            this.tabPagePersonalInfo.Text = "Personal Info";
            this.tabPagePersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::DVLD.Properties.Resources.next;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(777, 443);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(119, 38);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(6, 6);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(905, 415);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            // 
            // tagPageLoginInfo
            // 
            this.tagPageLoginInfo.Controls.Add(this.txtUserName);
            this.tagPageLoginInfo.Controls.Add(this.txtUserPassword);
            this.tagPageLoginInfo.Controls.Add(this.txtConfirmUserPassword);
            this.tagPageLoginInfo.Controls.Add(this.cbIsActive);
            this.tagPageLoginInfo.Controls.Add(this.lblConfirmUserPassword);
            this.tagPageLoginInfo.Controls.Add(this.lblUserName);
            this.tagPageLoginInfo.Controls.Add(this.lblUserPassword);
            this.tagPageLoginInfo.Controls.Add(this.txtUserID);
            this.tagPageLoginInfo.Controls.Add(this.lblUserID);
            this.tagPageLoginInfo.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagPageLoginInfo.Location = new System.Drawing.Point(4, 27);
            this.tagPageLoginInfo.Name = "tagPageLoginInfo";
            this.tagPageLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tagPageLoginInfo.Size = new System.Drawing.Size(914, 498);
            this.tagPageLoginInfo.TabIndex = 1;
            this.tagPageLoginInfo.Text = "Login Info";
            this.tagPageLoginInfo.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(219, 142);
            this.txtUserName.MaxLength = 30;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(186, 23);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(219, 199);
            this.txtUserPassword.MaxLength = 16;
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(186, 23);
            this.txtUserPassword.TabIndex = 3;
            this.txtUserPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserPassword_Validating);
            // 
            // txtConfirmUserPassword
            // 
            this.txtConfirmUserPassword.Location = new System.Drawing.Point(219, 256);
            this.txtConfirmUserPassword.MaxLength = 16;
            this.txtConfirmUserPassword.Name = "txtConfirmUserPassword";
            this.txtConfirmUserPassword.PasswordChar = '*';
            this.txtConfirmUserPassword.Size = new System.Drawing.Size(186, 23);
            this.txtConfirmUserPassword.TabIndex = 4;
            this.txtConfirmUserPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmUserPassword_Validating);
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsActive.Location = new System.Drawing.Point(219, 312);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(107, 25);
            this.cbIsActive.TabIndex = 5;
            this.cbIsActive.Text = "Is Active";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // lblConfirmUserPassword
            // 
            this.lblConfirmUserPassword.AutoSize = true;
            this.lblConfirmUserPassword.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmUserPassword.Location = new System.Drawing.Point(21, 257);
            this.lblConfirmUserPassword.Name = "lblConfirmUserPassword";
            this.lblConfirmUserPassword.Size = new System.Drawing.Size(181, 22);
            this.lblConfirmUserPassword.TabIndex = 6;
            this.lblConfirmUserPassword.Text = "Confirm Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(94, 140);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(116, 22);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "User Name:";
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPassword.Location = new System.Drawing.Point(107, 197);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(104, 22);
            this.lblUserPassword.TabIndex = 4;
            this.lblUserPassword.Text = "Password:";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(219, 91);
            this.txtUserID.MaxLength = 20;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(186, 23);
            this.txtUserID.TabIndex = 1;
            this.txtUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserID_KeyPress);
            this.txtUserID.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserID_Validating);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(127, 92);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(86, 22);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "User ID:";
            // 
            // btnsaveUser
            // 
            this.btnsaveUser.BackColor = System.Drawing.Color.White;
            this.btnsaveUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaveUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveUser.Image = ((System.Drawing.Image)(resources.GetObject("btnsaveUser.Image")));
            this.btnsaveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsaveUser.Location = new System.Drawing.Point(793, 635);
            this.btnsaveUser.Name = "btnsaveUser";
            this.btnsaveUser.Size = new System.Drawing.Size(108, 42);
            this.btnsaveUser.TabIndex = 6;
            this.btnsaveUser.Text = "Save";
            this.btnsaveUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsaveUser.UseVisualStyleBackColor = false;
            this.btnsaveUser.Click += new System.EventHandler(this.btnsaveUser_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btncloseUser
            // 
            this.btncloseUser.BackColor = System.Drawing.Color.White;
            this.btncloseUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncloseUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncloseUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncloseUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncloseUser.Image = ((System.Drawing.Image)(resources.GetObject("btncloseUser.Image")));
            this.btncloseUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncloseUser.Location = new System.Drawing.Point(628, 635);
            this.btncloseUser.Name = "btncloseUser";
            this.btncloseUser.Size = new System.Drawing.Size(105, 42);
            this.btncloseUser.TabIndex = 7;
            this.btncloseUser.Text = "Close";
            this.btncloseUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncloseUser.UseVisualStyleBackColor = false;
            this.btncloseUser.Click += new System.EventHandler(this.btncloseUser_Click);
            // 
            // frmAddOrEditUser
            // 
            this.AcceptButton = this.btnsaveUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btncloseUser;
            this.ClientSize = new System.Drawing.Size(943, 689);
            this.Controls.Add(this.btncloseUser);
            this.Controls.Add(this.btnsaveUser);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddOrEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.frmAddOrEditUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePersonalInfo.ResumeLayout(false);
            this.tagPageLoginInfo.ResumeLayout(false);
            this.tagPageLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePersonalInfo;
        private System.Windows.Forms.TabPage tagPageLoginInfo;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Button btnsaveUser;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txtConfirmUserPassword;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.Label lblConfirmUserPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btncloseUser;
    }
}