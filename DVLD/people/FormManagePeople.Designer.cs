namespace DVLD
{
    partial class ManagePeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePeople));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lbPeople = new System.Windows.Forms.Label();
            this.dgvpeople = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbrecordnum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbsearch = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcurentPage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltotalpages = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalRecoreds = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpeople)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(643, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(248, 135);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
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
            this.btnAddNew.Location = new System.Drawing.Point(1359, 133);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(158, 55);
            this.btnAddNew.TabIndex = 15;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click_1);
            // 
            // lbPeople
            // 
            this.lbPeople.AutoSize = true;
            this.lbPeople.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.lbPeople.ForeColor = System.Drawing.Color.Firebrick;
            this.lbPeople.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPeople.Location = new System.Drawing.Point(612, 140);
            this.lbPeople.Name = "lbPeople";
            this.lbPeople.Size = new System.Drawing.Size(327, 48);
            this.lbPeople.TabIndex = 16;
            this.lbPeople.Text = "Manage People";
            // 
            // dgvpeople
            // 
            this.dgvpeople.AllowUserToAddRows = false;
            this.dgvpeople.AllowUserToDeleteRows = false;
            this.dgvpeople.AllowUserToOrderColumns = true;
            this.dgvpeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpeople.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvpeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpeople.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvpeople.Location = new System.Drawing.Point(12, 200);
            this.dgvpeople.Name = "dgvpeople";
            this.dgvpeople.ReadOnly = true;
            this.dgvpeople.RowHeadersWidth = 51;
            this.dgvpeople.RowTemplate.Height = 26;
            this.dgvpeople.Size = new System.Drawing.Size(1512, 352);
            this.dgvpeople.TabIndex = 17;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(250, 142);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(249, 46);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(249, 46);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("moreToolStripMenuItem.Image")));
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(249, 46);
            this.moreToolStripMenuItem.Text = "More Details";
            this.moreToolStripMenuItem.Click += new System.EventHandler(this.moreToolStripMenuItem_Click);
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
            this.btnClose.Location = new System.Drawing.Point(1404, 581);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 40);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // lbrecordnum
            // 
            this.lbrecordnum.AutoSize = true;
            this.lbrecordnum.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbrecordnum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbrecordnum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbrecordnum.Location = new System.Drawing.Point(161, 566);
            this.lbrecordnum.Name = "lbrecordnum";
            this.lbrecordnum.Size = new System.Drawing.Size(38, 24);
            this.lbrecordnum.TabIndex = 20;
            this.lbrecordnum.Text = "----";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "#Page Records: ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(110, 169);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 24);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Filter By: ";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(320, 169);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(197, 24);
            this.txtsearch.TabIndex = 22;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(868, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 47);
            this.button1.TabIndex = 25;
            this.button1.Text = "Next ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbsearch
            // 
            this.cbsearch.FormattingEnabled = true;
            this.cbsearch.Location = new System.Drawing.Point(158, 169);
            this.cbsearch.Name = "cbsearch";
            this.cbsearch.Size = new System.Drawing.Size(156, 24);
            this.cbsearch.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(547, 573);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 47);
            this.button2.TabIndex = 25;
            this.button2.Text = "Previous";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(679, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Current Page:";
            // 
            // lblcurentPage
            // 
            this.lblcurentPage.AutoSize = true;
            this.lblcurentPage.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurentPage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblcurentPage.Location = new System.Drawing.Point(823, 586);
            this.lblcurentPage.Name = "lblcurentPage";
            this.lblcurentPage.Size = new System.Drawing.Size(42, 22);
            this.lblcurentPage.TabIndex = 27;
            this.lblcurentPage.Text = "----";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(12, 623);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "#Total Pages: ";
            // 
            // lbltotalpages
            // 
            this.lbltotalpages.AutoSize = true;
            this.lbltotalpages.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbltotalpages.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbltotalpages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbltotalpages.Location = new System.Drawing.Point(144, 624);
            this.lbltotalpages.Name = "lbltotalpages";
            this.lbltotalpages.Size = new System.Drawing.Size(38, 24);
            this.lbltotalpages.TabIndex = 20;
            this.lbltotalpages.Text = "----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(12, 593);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "#Total Recordes: ";
            // 
            // lblTotalRecoreds
            // 
            this.lblTotalRecoreds.AutoSize = true;
            this.lblTotalRecoreds.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblTotalRecoreds.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotalRecoreds.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotalRecoreds.Location = new System.Drawing.Point(171, 594);
            this.lblTotalRecoreds.Name = "lblTotalRecoreds";
            this.lblTotalRecoreds.Size = new System.Drawing.Size(38, 24);
            this.lblTotalRecoreds.TabIndex = 20;
            this.lblTotalRecoreds.Text = "----";
            // 
            // ManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1529, 656);
            this.Controls.Add(this.lblcurentPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbsearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTotalRecoreds);
            this.Controls.Add(this.lbltotalpages);
            this.Controls.Add(this.lbrecordnum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvpeople);
            this.Controls.Add(this.lbPeople);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManagePeople";
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.ManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpeople)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lbPeople;
        private System.Windows.Forms.DataGridView dgvpeople;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbrecordnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbsearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcurentPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltotalpages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalRecoreds;
    }
}