namespace DVLD
{
    partial class frmUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserInfo));
            this.ctrlUser1 = new DVLD.ctrlUser();
            this.btncloseUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlUser1
            // 
            this.ctrlUser1.BackColor = System.Drawing.Color.White;
            this.ctrlUser1.Location = new System.Drawing.Point(1, 12);
            this.ctrlUser1.Name = "ctrlUser1";
            this.ctrlUser1.Size = new System.Drawing.Size(910, 452);
            this.ctrlUser1.TabIndex = 0;
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
            this.btncloseUser.Location = new System.Drawing.Point(806, 452);
            this.btncloseUser.Name = "btncloseUser";
            this.btncloseUser.Size = new System.Drawing.Size(105, 39);
            this.btncloseUser.TabIndex = 8;
            this.btncloseUser.Text = "Close";
            this.btncloseUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncloseUser.UseVisualStyleBackColor = false;
            this.btncloseUser.Click += new System.EventHandler(this.btncloseUser_Click);
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 503);
            this.Controls.Add(this.btncloseUser);
            this.Controls.Add(this.ctrlUser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Info";
            this.Load += new System.EventHandler(this.frmUserInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlUser ctrlUser1;
        private System.Windows.Forms.Button btncloseUser;
    }
}