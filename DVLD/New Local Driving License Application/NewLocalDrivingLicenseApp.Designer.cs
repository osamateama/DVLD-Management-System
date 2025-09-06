namespace DVLD
{
    partial class NewLocalDrivingLicenseApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewLocalDrivingLicenseApp));
            this.lblAddOrUpdate = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new DVLD.ctrlPersonCardWithFilter();
            this.tagPageApplicationInfo = new System.Windows.Forms.TabPage();
            this.cbFillLicenseClass = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConfirmUserPassword = new System.Windows.Forms.Label();
            this.lApplicationDate0 = new System.Windows.Forms.Label();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.lblAppID = new System.Windows.Forms.Label();
            this.lblDLApplicationID0 = new System.Windows.Forms.Label();
            this.btncloseUser = new System.Windows.Forms.Button();
            this.btnsaveUser = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPagePersonalInfo.SuspendLayout();
            this.tagPageApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddOrUpdate
            // 
            this.lblAddOrUpdate.AutoSize = true;
            this.lblAddOrUpdate.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddOrUpdate.ForeColor = System.Drawing.Color.Crimson;
            this.lblAddOrUpdate.Location = new System.Drawing.Point(100, 21);
            this.lblAddOrUpdate.Name = "lblAddOrUpdate";
            this.lblAddOrUpdate.Size = new System.Drawing.Size(786, 48);
            this.lblAddOrUpdate.TabIndex = 17;
            this.lblAddOrUpdate.Text = "New Local Driving License Application";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePersonalInfo);
            this.tabControl1.Controls.Add(this.tagPageApplicationInfo);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(8, 109);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(958, 545);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPagePersonalInfo
            // 
            this.tabPagePersonalInfo.Controls.Add(this.btnNext);
            this.tabPagePersonalInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tabPagePersonalInfo.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePersonalInfo.Location = new System.Drawing.Point(4, 27);
            this.tabPagePersonalInfo.Name = "tabPagePersonalInfo";
            this.tabPagePersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonalInfo.Size = new System.Drawing.Size(950, 514);
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
            this.btnNext.Location = new System.Drawing.Point(806, 470);
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
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(27, 35);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(917, 432);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            this.ctrlPersonCardWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrlPersonCardWithFilter1_OnPersonSelected);
            // 
            // tagPageApplicationInfo
            // 
            this.tagPageApplicationInfo.Controls.Add(this.cbFillLicenseClass);
            this.tagPageApplicationInfo.Controls.Add(this.pictureBox2);
            this.tagPageApplicationInfo.Controls.Add(this.pictureBox5);
            this.tagPageApplicationInfo.Controls.Add(this.pictureBox4);
            this.tagPageApplicationInfo.Controls.Add(this.pictureBox3);
            this.tagPageApplicationInfo.Controls.Add(this.pictureBox1);
            this.tagPageApplicationInfo.Controls.Add(this.label2);
            this.tagPageApplicationInfo.Controls.Add(this.lblConfirmUserPassword);
            this.tagPageApplicationInfo.Controls.Add(this.lApplicationDate0);
            this.tagPageApplicationInfo.Controls.Add(this.lblUserPassword);
            this.tagPageApplicationInfo.Controls.Add(this.lblAppFees);
            this.tagPageApplicationInfo.Controls.Add(this.lblUserName);
            this.tagPageApplicationInfo.Controls.Add(this.lblAppDate);
            this.tagPageApplicationInfo.Controls.Add(this.lblAppID);
            this.tagPageApplicationInfo.Controls.Add(this.lblDLApplicationID0);
            this.tagPageApplicationInfo.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagPageApplicationInfo.Location = new System.Drawing.Point(4, 27);
            this.tagPageApplicationInfo.Name = "tagPageApplicationInfo";
            this.tagPageApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tagPageApplicationInfo.Size = new System.Drawing.Size(950, 514);
            this.tagPageApplicationInfo.TabIndex = 1;
            this.tagPageApplicationInfo.Text = "Application Info";
            this.tagPageApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // cbFillLicenseClass
            // 
            this.cbFillLicenseClass.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbFillLicenseClass.FormattingEnabled = true;
            this.cbFillLicenseClass.Location = new System.Drawing.Point(264, 202);
            this.cbFillLicenseClass.Name = "cbFillLicenseClass";
            this.cbFillLicenseClass.Size = new System.Drawing.Size(202, 24);
            this.cbFillLicenseClass.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(214, 304);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 31);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(214, 98);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 31);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(217, 147);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 31);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(217, 201);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 31);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(214, 258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 31);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Created BY:";
            // 
            // lblConfirmUserPassword
            // 
            this.lblConfirmUserPassword.AutoSize = true;
            this.lblConfirmUserPassword.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmUserPassword.Location = new System.Drawing.Point(46, 258);
            this.lblConfirmUserPassword.Name = "lblConfirmUserPassword";
            this.lblConfirmUserPassword.Size = new System.Drawing.Size(163, 22);
            this.lblConfirmUserPassword.TabIndex = 6;
            this.lblConfirmUserPassword.Text = "Application Fees:";
            // 
            // lApplicationDate0
            // 
            this.lApplicationDate0.AutoSize = true;
            this.lApplicationDate0.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lApplicationDate0.Location = new System.Drawing.Point(46, 147);
            this.lApplicationDate0.Name = "lApplicationDate0";
            this.lApplicationDate0.Size = new System.Drawing.Size(165, 22);
            this.lApplicationDate0.TabIndex = 5;
            this.lApplicationDate0.Text = "Application Date:";
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPassword.Location = new System.Drawing.Point(75, 201);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(136, 22);
            this.lblUserPassword.TabIndex = 4;
            this.lblUserPassword.Text = "License Class:";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFees.Location = new System.Drawing.Point(260, 259);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(0, 22);
            this.lblAppFees.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(260, 309);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(56, 22);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "[???]";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDate.Location = new System.Drawing.Point(260, 149);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(56, 22);
            this.lblAppDate.TabIndex = 0;
            this.lblAppDate.Text = "[???]";
            // 
            // lblAppID
            // 
            this.lblAppID.AutoSize = true;
            this.lblAppID.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppID.Location = new System.Drawing.Point(260, 99);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Size = new System.Drawing.Size(56, 22);
            this.lblAppID.TabIndex = 0;
            this.lblAppID.Text = "[???]";
            // 
            // lblDLApplicationID0
            // 
            this.lblDLApplicationID0.AutoSize = true;
            this.lblDLApplicationID0.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLApplicationID0.Location = new System.Drawing.Point(31, 98);
            this.lblDLApplicationID0.Name = "lblDLApplicationID0";
            this.lblDLApplicationID0.Size = new System.Drawing.Size(180, 22);
            this.lblDLApplicationID0.TabIndex = 0;
            this.lblDLApplicationID0.Text = "D.L Application ID:";
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
            this.btncloseUser.Location = new System.Drawing.Point(710, 687);
            this.btncloseUser.Name = "btncloseUser";
            this.btncloseUser.Size = new System.Drawing.Size(105, 54);
            this.btncloseUser.TabIndex = 20;
            this.btncloseUser.Text = "Close";
            this.btncloseUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncloseUser.UseVisualStyleBackColor = false;
            this.btncloseUser.Click += new System.EventHandler(this.btncloseUser_Click);
            // 
            // btnsaveUser
            // 
            this.btnsaveUser.BackColor = System.Drawing.Color.White;
            this.btnsaveUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaveUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveUser.Image = ((System.Drawing.Image)(resources.GetObject("btnsaveUser.Image")));
            this.btnsaveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsaveUser.Location = new System.Drawing.Point(844, 687);
            this.btnsaveUser.Name = "btnsaveUser";
            this.btnsaveUser.Size = new System.Drawing.Size(118, 54);
            this.btnsaveUser.TabIndex = 19;
            this.btnsaveUser.Text = "Save";
            this.btnsaveUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsaveUser.UseVisualStyleBackColor = false;
            this.btnsaveUser.Click += new System.EventHandler(this.btnsaveUser_Click);
            // 
            // NewLocalDrivingLicenseApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 771);
            this.Controls.Add(this.btncloseUser);
            this.Controls.Add(this.btnsaveUser);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblAddOrUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewLocalDrivingLicenseApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Local Driving License Application";
            this.Activated += new System.EventHandler(this.NewLocalDrivingLicenseApp_Activated);
            this.Load += new System.EventHandler(this.NewLocalDrivingLicenseApp_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePersonalInfo.ResumeLayout(false);
            this.tagPageApplicationInfo.ResumeLayout(false);
            this.tagPageApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddOrUpdate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePersonalInfo;
        private System.Windows.Forms.Button btnNext;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.TabPage tagPageApplicationInfo;
        private System.Windows.Forms.Label lblConfirmUserPassword;
        private System.Windows.Forms.Label lApplicationDate0;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Label lblDLApplicationID0;
        private System.Windows.Forms.Button btncloseUser;
        private System.Windows.Forms.Button btnsaveUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAppID;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cbFillLicenseClass;
    }
}