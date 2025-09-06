namespace DVLD
{
    partial class frmManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUsers));
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbrecordnum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPeople = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsearch1 = new System.Windows.Forms.TextBox();
            this.cbsearch1 = new System.Windows.Forms.ComboBox();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbManageUsers = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUsers.Location = new System.Drawing.Point(12, 240);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 26;
            this.dgvUsers.Size = new System.Drawing.Size(1150, 285);
            this.dgvUsers.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.updateUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.moreInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(284, 284);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addUserToolStripMenuItem.Image")));
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(283, 56);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateUserToolStripMenuItem.Image")));
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(283, 56);
            this.updateUserToolStripMenuItem.Text = "Update User";
            this.updateUserToolStripMenuItem.Click += new System.EventHandler(this.updateUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteUserToolStripMenuItem.Image")));
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(283, 56);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // moreInfoToolStripMenuItem
            // 
            this.moreInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("moreInfoToolStripMenuItem.Image")));
            this.moreInfoToolStripMenuItem.Name = "moreInfoToolStripMenuItem";
            this.moreInfoToolStripMenuItem.Size = new System.Drawing.Size(283, 56);
            this.moreInfoToolStripMenuItem.Text = "More Info";
            this.moreInfoToolStripMenuItem.Click += new System.EventHandler(this.moreInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordToolStripMenuItem.Image")));
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(283, 56);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // lbrecordnum
            // 
            this.lbrecordnum.AutoSize = true;
            this.lbrecordnum.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbrecordnum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbrecordnum.Location = new System.Drawing.Point(111, 563);
            this.lbrecordnum.Name = "lbrecordnum";
            this.lbrecordnum.Size = new System.Drawing.Size(38, 24);
            this.lbrecordnum.TabIndex = 9;
            this.lbrecordnum.Text = "----";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 563);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "#Records: ";
            // 
            // lbPeople
            // 
            this.lbPeople.AutoSize = true;
            this.lbPeople.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.lbPeople.ForeColor = System.Drawing.Color.Firebrick;
            this.lbPeople.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPeople.Location = new System.Drawing.Point(461, 127);
            this.lbPeople.Name = "lbPeople";
            this.lbPeople.Size = new System.Drawing.Size(226, 36);
            this.lbPeople.TabIndex = 10;
            this.lbPeople.Text = "Manage Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Filter By: ";
            // 
            // txtsearch1
            // 
            this.txtsearch1.Location = new System.Drawing.Point(277, 188);
            this.txtsearch1.Name = "txtsearch1";
            this.txtsearch1.Size = new System.Drawing.Size(197, 24);
            this.txtsearch1.TabIndex = 13;
            this.txtsearch1.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // cbsearch1
            // 
            this.cbsearch1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbsearch1.FormattingEnabled = true;
            this.cbsearch1.Items.AddRange(new object[] {
            "None",
            "User ID",
            "Person ID",
            "Full Name",
            "User Name",
            "Is Active"});
            this.cbsearch1.Location = new System.Drawing.Point(130, 187);
            this.cbsearch1.Name = "cbsearch1";
            this.cbsearch1.Size = new System.Drawing.Size(141, 25);
            this.cbsearch1.TabIndex = 12;
            this.cbsearch1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbsearch1_DrawItem);
            this.cbsearch1.SelectedIndexChanged += new System.EventHandler(this.cbsearch1_SelectedIndexChanged);
            // 
            // cbIsActive
            // 
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.ItemHeight = 16;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(277, 188);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(101, 24);
            this.cbIsActive.TabIndex = 16;
            this.cbIsActive.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbIsActive_DrawItem_1);
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged_1);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.White;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddNew.Location = new System.Drawing.Point(1002, 150);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(158, 61);
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.Text = "Add User";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(1049, 551);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 40);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(95, 187);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 24);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pbManageUsers
            // 
            this.pbManageUsers.BackgroundImage = global::DVLD.Properties.Resources.skills;
            this.pbManageUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbManageUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbManageUsers.Location = new System.Drawing.Point(0, 0);
            this.pbManageUsers.Name = "pbManageUsers";
            this.pbManageUsers.Size = new System.Drawing.Size(1172, 124);
            this.pbManageUsers.TabIndex = 0;
            this.pbManageUsers.TabStop = false;
            // 
            // frmManageUsers
            // 
            this.AcceptButton = this.btnAddNew;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1172, 611);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsearch1);
            this.Controls.Add(this.cbsearch1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lbPeople);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbrecordnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.pbManageUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbManageUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbrecordnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPeople;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsearch1;
        private System.Windows.Forms.ComboBox cbsearch1;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}