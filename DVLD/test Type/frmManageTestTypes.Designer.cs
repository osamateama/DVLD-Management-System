namespace DVLD
{
    partial class frmManageTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageTestTypes));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTestTypes = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeTestTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbrecordnum1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(336, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Test Types";
            // 
            // dgvTestTypes
            // 
            this.dgvTestTypes.AllowUserToAddRows = false;
            this.dgvTestTypes.AllowUserToDeleteRows = false;
            this.dgvTestTypes.AllowUserToOrderColumns = true;
            this.dgvTestTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestTypes.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTestTypes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvTestTypes.Location = new System.Drawing.Point(5, 329);
            this.dgvTestTypes.Name = "dgvTestTypes";
            this.dgvTestTypes.ReadOnly = true;
            this.dgvTestTypes.RowHeadersWidth = 51;
            this.dgvTestTypes.RowTemplate.Height = 26;
            this.dgvTestTypes.Size = new System.Drawing.Size(1178, 277);
            this.dgvTestTypes.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeTestTypeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(276, 60);
            // 
            // editeTestTypeToolStripMenuItem
            // 
            this.editeTestTypeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editeTestTypeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editeTestTypeToolStripMenuItem.Image")));
            this.editeTestTypeToolStripMenuItem.Name = "editeTestTypeToolStripMenuItem";
            this.editeTestTypeToolStripMenuItem.Size = new System.Drawing.Size(275, 56);
            this.editeTestTypeToolStripMenuItem.Text = "Edite Test Type";
            this.editeTestTypeToolStripMenuItem.Click += new System.EventHandler(this.editeTestTypeToolStripMenuItem_Click);
            // 
            // lbrecordnum1
            // 
            this.lbrecordnum1.AutoSize = true;
            this.lbrecordnum1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbrecordnum1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbrecordnum1.Location = new System.Drawing.Point(107, 628);
            this.lbrecordnum1.Name = "lbrecordnum1";
            this.lbrecordnum1.Size = new System.Drawing.Size(38, 24);
            this.lbrecordnum1.TabIndex = 15;
            this.lbrecordnum1.Text = "----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 628);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "#Records: ";
            // 
            // btnClose1
            // 
            this.btnClose1.BackColor = System.Drawing.Color.White;
            this.btnClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose1.Image = ((System.Drawing.Image)(resources.GetObject("btnClose1.Image")));
            this.btnClose1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose1.Location = new System.Drawing.Point(1070, 612);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(113, 40);
            this.btnClose1.TabIndex = 14;
            this.btnClose1.Text = "Close";
            this.btnClose1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose1.UseVisualStyleBackColor = false;
            this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(412, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 217);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1195, 655);
            this.Controls.Add(this.btnClose1);
            this.Controls.Add(this.lbrecordnum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTestTypes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageTestTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Test Types";
            this.Load += new System.EventHandler(this.frmManageTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvTestTypes;
        private System.Windows.Forms.Button btnClose1;
        private System.Windows.Forms.Label lbrecordnum1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editeTestTypeToolStripMenuItem;
    }
}