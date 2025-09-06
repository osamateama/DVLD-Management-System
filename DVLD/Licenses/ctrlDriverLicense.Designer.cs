namespace DVLD
{
    partial class ctrlDriverLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlDriverLicense));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpLocal = new System.Windows.Forms.TabPage();
            this.lblLocalLicenses = new System.Windows.Forms.Label();
            this.lblRecordlocal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLocalLicensesHistory = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblInternationalHistory = new System.Windows.Forms.Label();
            this.lblinternationalrecords = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvInternationalLicensesHistory = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.showInternatinalLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesHistory)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicensesHistory)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1178, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpLocal);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1162, 313);
            this.tabControl1.TabIndex = 1;
            // 
            // tpLocal
            // 
            this.tpLocal.Controls.Add(this.lblLocalLicenses);
            this.tpLocal.Controls.Add(this.lblRecordlocal);
            this.tpLocal.Controls.Add(this.label1);
            this.tpLocal.Controls.Add(this.dgvLocalLicensesHistory);
            this.tpLocal.Location = new System.Drawing.Point(4, 31);
            this.tpLocal.Name = "tpLocal";
            this.tpLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocal.Size = new System.Drawing.Size(1154, 278);
            this.tpLocal.TabIndex = 0;
            this.tpLocal.Text = "Local";
            this.tpLocal.UseVisualStyleBackColor = true;
            // 
            // lblLocalLicenses
            // 
            this.lblLocalLicenses.AutoSize = true;
            this.lblLocalLicenses.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicenses.Location = new System.Drawing.Point(6, 16);
            this.lblLocalLicenses.Name = "lblLocalLicenses";
            this.lblLocalLicenses.Size = new System.Drawing.Size(238, 24);
            this.lblLocalLicenses.TabIndex = 1;
            this.lblLocalLicenses.Text = "Local Licenses History:";
            // 
            // lblRecordlocal
            // 
            this.lblRecordlocal.AutoSize = true;
            this.lblRecordlocal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordlocal.Location = new System.Drawing.Point(116, 251);
            this.lblRecordlocal.Name = "lblRecordlocal";
            this.lblRecordlocal.Size = new System.Drawing.Size(42, 22);
            this.lblRecordlocal.TabIndex = 1;
            this.lblRecordlocal.Text = "----";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "#Records:";
            // 
            // dgvLocalLicensesHistory
            // 
            this.dgvLocalLicensesHistory.AllowUserToAddRows = false;
            this.dgvLocalLicensesHistory.AllowUserToDeleteRows = false;
            this.dgvLocalLicensesHistory.AllowUserToOrderColumns = true;
            this.dgvLocalLicensesHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalLicensesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicensesHistory.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLocalLicensesHistory.Location = new System.Drawing.Point(6, 45);
            this.dgvLocalLicensesHistory.Name = "dgvLocalLicensesHistory";
            this.dgvLocalLicensesHistory.ReadOnly = true;
            this.dgvLocalLicensesHistory.RowHeadersWidth = 51;
            this.dgvLocalLicensesHistory.RowTemplate.Height = 26;
            this.dgvLocalLicensesHistory.Size = new System.Drawing.Size(1140, 200);
            this.dgvLocalLicensesHistory.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(311, 60);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLicenseInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseInfoToolStripMenuItem.Image")));
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(310, 56);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblInternationalHistory);
            this.tabPage2.Controls.Add(this.lblinternationalrecords);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dgvInternationalLicensesHistory);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1154, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "International";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblInternationalHistory
            // 
            this.lblInternationalHistory.AutoSize = true;
            this.lblInternationalHistory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalHistory.Location = new System.Drawing.Point(6, 14);
            this.lblInternationalHistory.Name = "lblInternationalHistory";
            this.lblInternationalHistory.Size = new System.Drawing.Size(320, 24);
            this.lblInternationalHistory.TabIndex = 3;
            this.lblInternationalHistory.Text = "International Licenses History:";
            // 
            // lblinternationalrecords
            // 
            this.lblinternationalrecords.AutoSize = true;
            this.lblinternationalrecords.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinternationalrecords.Location = new System.Drawing.Point(116, 249);
            this.lblinternationalrecords.Name = "lblinternationalrecords";
            this.lblinternationalrecords.Size = new System.Drawing.Size(42, 22);
            this.lblinternationalrecords.TabIndex = 4;
            this.lblinternationalrecords.Text = "----";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "#Records:";
            // 
            // dgvInternationalLicensesHistory
            // 
            this.dgvInternationalLicensesHistory.AllowUserToAddRows = false;
            this.dgvInternationalLicensesHistory.AllowUserToDeleteRows = false;
            this.dgvInternationalLicensesHistory.AllowUserToOrderColumns = true;
            this.dgvInternationalLicensesHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInternationalLicensesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicensesHistory.ContextMenuStrip = this.contextMenuStrip2;
            this.dgvInternationalLicensesHistory.Location = new System.Drawing.Point(6, 43);
            this.dgvInternationalLicensesHistory.Name = "dgvInternationalLicensesHistory";
            this.dgvInternationalLicensesHistory.ReadOnly = true;
            this.dgvInternationalLicensesHistory.RowHeadersWidth = 51;
            this.dgvInternationalLicensesHistory.RowTemplate.Height = 26;
            this.dgvInternationalLicensesHistory.Size = new System.Drawing.Size(1142, 201);
            this.dgvInternationalLicensesHistory.TabIndex = 2;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInternatinalLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(449, 60);
            // 
            // showInternatinalLicenseHistoryToolStripMenuItem
            // 
            this.showInternatinalLicenseHistoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showInternatinalLicenseHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showInternatinalLicenseHistoryToolStripMenuItem.Image")));
            this.showInternatinalLicenseHistoryToolStripMenuItem.Name = "showInternatinalLicenseHistoryToolStripMenuItem";
            this.showInternatinalLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(448, 56);
            this.showInternatinalLicenseHistoryToolStripMenuItem.Text = " Show Internatinal License Info";
            this.showInternatinalLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showInternatinalLicenseHistoryToolStripMenuItem_Click);
            // 
            // ctrlDriverLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlDriverLicense";
            this.Size = new System.Drawing.Size(1190, 361);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpLocal.ResumeLayout(false);
            this.tpLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesHistory)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicensesHistory)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLocalLicensesHistory;
        private System.Windows.Forms.Label lblLocalLicenses;
        private System.Windows.Forms.Label lblRecordlocal;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblInternationalHistory;
        private System.Windows.Forms.Label lblinternationalrecords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvInternationalLicensesHistory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem showInternatinalLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
