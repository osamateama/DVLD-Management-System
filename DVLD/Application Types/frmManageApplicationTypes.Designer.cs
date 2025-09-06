namespace DVLD
{
    partial class frmManageApplicationTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageApplicationTypes));
            this.dgvManageAppTypes = new System.Windows.Forms.DataGridView();
            this.cms1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeApplicationTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbrecordnum1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmanageAppType = new System.Windows.Forms.Label();
            this.btnClose1 = new System.Windows.Forms.Button();
            this.pbManageAppTypes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageAppTypes)).BeginInit();
            this.cms1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageAppTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManageAppTypes
            // 
            this.dgvManageAppTypes.AllowUserToDeleteRows = false;
            this.dgvManageAppTypes.AllowUserToOrderColumns = true;
            this.dgvManageAppTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvManageAppTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageAppTypes.ContextMenuStrip = this.cms1;
            this.dgvManageAppTypes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvManageAppTypes.GridColor = System.Drawing.Color.Black;
            this.dgvManageAppTypes.Location = new System.Drawing.Point(8, 332);
            this.dgvManageAppTypes.Name = "dgvManageAppTypes";
            this.dgvManageAppTypes.ReadOnly = true;
            this.dgvManageAppTypes.RowHeadersWidth = 51;
            this.dgvManageAppTypes.RowTemplate.Height = 26;
            this.dgvManageAppTypes.Size = new System.Drawing.Size(832, 301);
            this.dgvManageAppTypes.TabIndex = 1;
            // 
            // cms1
            // 
            this.cms1.BackColor = System.Drawing.Color.White;
            this.cms1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.cms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeApplicationTypeToolStripMenuItem});
            this.cms1.Name = "contextMenuStrip1";
            this.cms1.Size = new System.Drawing.Size(359, 60);
            // 
            // editeApplicationTypeToolStripMenuItem
            // 
            this.editeApplicationTypeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.editeApplicationTypeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editeApplicationTypeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editeApplicationTypeToolStripMenuItem.Image")));
            this.editeApplicationTypeToolStripMenuItem.Name = "editeApplicationTypeToolStripMenuItem";
            this.editeApplicationTypeToolStripMenuItem.Size = new System.Drawing.Size(358, 56);
            this.editeApplicationTypeToolStripMenuItem.Text = "Edite Application Type";
            this.editeApplicationTypeToolStripMenuItem.Click += new System.EventHandler(this.editeApplicationTypeToolStripMenuItem_Click);
            // 
            // lbrecordnum1
            // 
            this.lbrecordnum1.AutoSize = true;
            this.lbrecordnum1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbrecordnum1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbrecordnum1.Location = new System.Drawing.Point(110, 648);
            this.lbrecordnum1.Name = "lbrecordnum1";
            this.lbrecordnum1.Size = new System.Drawing.Size(38, 24);
            this.lbrecordnum1.TabIndex = 12;
            this.lbrecordnum1.Text = "----";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 648);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "#Records: ";
            // 
            // lblmanageAppType
            // 
            this.lblmanageAppType.AutoSize = true;
            this.lblmanageAppType.BackColor = System.Drawing.Color.White;
            this.lblmanageAppType.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanageAppType.ForeColor = System.Drawing.Color.Crimson;
            this.lblmanageAppType.Location = new System.Drawing.Point(141, 255);
            this.lblmanageAppType.Name = "lblmanageAppType";
            this.lblmanageAppType.Size = new System.Drawing.Size(589, 52);
            this.lblmanageAppType.TabIndex = 13;
            this.lblmanageAppType.Text = "Manage Application Types";
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
            this.btnClose1.Location = new System.Drawing.Point(727, 640);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(113, 40);
            this.btnClose1.TabIndex = 11;
            this.btnClose1.Text = "Close";
            this.btnClose1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose1.UseVisualStyleBackColor = false;
            this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // pbManageAppTypes
            // 
            this.pbManageAppTypes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbManageAppTypes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbManageAppTypes.BackgroundImage")));
            this.pbManageAppTypes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbManageAppTypes.Location = new System.Drawing.Point(302, 12);
            this.pbManageAppTypes.Name = "pbManageAppTypes";
            this.pbManageAppTypes.Size = new System.Drawing.Size(237, 230);
            this.pbManageAppTypes.TabIndex = 0;
            this.pbManageAppTypes.TabStop = false;
            // 
            // frmManageApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose1;
            this.ClientSize = new System.Drawing.Size(849, 693);
            this.Controls.Add(this.lblmanageAppType);
            this.Controls.Add(this.btnClose1);
            this.Controls.Add(this.lbrecordnum1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvManageAppTypes);
            this.Controls.Add(this.pbManageAppTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageApplicationTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Application Types";
            this.Load += new System.EventHandler(this.frmManageApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageAppTypes)).EndInit();
            this.cms1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbManageAppTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbManageAppTypes;
        private System.Windows.Forms.DataGridView dgvManageAppTypes;
        private System.Windows.Forms.Button btnClose1;
        private System.Windows.Forms.Label lbrecordnum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmanageAppType;
        private System.Windows.Forms.ContextMenuStrip cms1;
        private System.Windows.Forms.ToolStripMenuItem editeApplicationTypeToolStripMenuItem;
    }
}