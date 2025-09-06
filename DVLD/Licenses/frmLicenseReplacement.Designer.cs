namespace DVLD
{
    partial class frmLicenseReplacement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicenseReplacement));
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlDriverLicenseInfoWithFiltter1 = new DVLD.ctrlDriverLicenseInfoWithFiltter();
            this.gbReplacementFor = new System.Windows.Forms.GroupBox();
            this.rbLostLicense = new System.Windows.Forms.RadioButton();
            this.rbDamagedLicense = new System.Windows.Forms.RadioButton();
            this.gbAppNewLicenseInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.lblRLAppId = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.lblRreplacedLicenseID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.llShowNewLicensesInfo = new System.Windows.Forms.LinkLabel();
            this.llShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssueReplacement = new System.Windows.Forms.Button();
            this.gbReplacementFor.SuspendLayout();
            this.gbAppNewLicenseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTitle.Location = new System.Drawing.Point(319, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(316, 36);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "License Replacment";
            // 
            // ctrlDriverLicenseInfoWithFiltter1
            // 
            this.ctrlDriverLicenseInfoWithFiltter1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseInfoWithFiltter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFiltter1.Location = new System.Drawing.Point(3, 45);
            this.ctrlDriverLicenseInfoWithFiltter1.Name = "ctrlDriverLicenseInfoWithFiltter1";
            this.ctrlDriverLicenseInfoWithFiltter1.Size = new System.Drawing.Size(1036, 467);
            this.ctrlDriverLicenseInfoWithFiltter1.TabIndex = 3;
            this.ctrlDriverLicenseInfoWithFiltter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFiltter1_OnLicenseSelected);
            // 
            // gbReplacementFor
            // 
            this.gbReplacementFor.Controls.Add(this.rbLostLicense);
            this.gbReplacementFor.Controls.Add(this.rbDamagedLicense);
            this.gbReplacementFor.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReplacementFor.Location = new System.Drawing.Point(603, 45);
            this.gbReplacementFor.Name = "gbReplacementFor";
            this.gbReplacementFor.Size = new System.Drawing.Size(426, 66);
            this.gbReplacementFor.TabIndex = 4;
            this.gbReplacementFor.TabStop = false;
            this.gbReplacementFor.Text = "Replacement For:";
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.AutoSize = true;
            this.rbLostLicense.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLostLicense.Location = new System.Drawing.Point(258, 23);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(137, 25);
            this.rbLostLicense.TabIndex = 1;
            this.rbLostLicense.TabStop = true;
            this.rbLostLicense.Text = "Lost License";
            this.rbLostLicense.UseVisualStyleBackColor = true;
            this.rbLostLicense.CheckedChanged += new System.EventHandler(this.rbLostLicense_CheckedChanged);
            // 
            // rbDamagedLicense
            // 
            this.rbDamagedLicense.AutoSize = true;
            this.rbDamagedLicense.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDamagedLicense.Location = new System.Drawing.Point(23, 23);
            this.rbDamagedLicense.Name = "rbDamagedLicense";
            this.rbDamagedLicense.Size = new System.Drawing.Size(186, 25);
            this.rbDamagedLicense.TabIndex = 0;
            this.rbDamagedLicense.TabStop = true;
            this.rbDamagedLicense.Text = "Damaged License ";
            this.rbDamagedLicense.UseVisualStyleBackColor = true;
            this.rbDamagedLicense.CheckedChanged += new System.EventHandler(this.rbDamagedLicense_CheckedChanged);
            // 
            // gbAppNewLicenseInfo
            // 
            this.gbAppNewLicenseInfo.Controls.Add(this.pictureBox6);
            this.gbAppNewLicenseInfo.Controls.Add(this.pictureBox5);
            this.gbAppNewLicenseInfo.Controls.Add(this.pictureBox2);
            this.gbAppNewLicenseInfo.Controls.Add(this.pictureBox10);
            this.gbAppNewLicenseInfo.Controls.Add(this.pictureBox9);
            this.gbAppNewLicenseInfo.Controls.Add(this.pictureBox1);
            this.gbAppNewLicenseInfo.Controls.Add(this.label12);
            this.gbAppNewLicenseInfo.Controls.Add(this.label5);
            this.gbAppNewLicenseInfo.Controls.Add(this.label9);
            this.gbAppNewLicenseInfo.Controls.Add(this.label3);
            this.gbAppNewLicenseInfo.Controls.Add(this.label8);
            this.gbAppNewLicenseInfo.Controls.Add(this.lblCreatedBy);
            this.gbAppNewLicenseInfo.Controls.Add(this.lblAppFees);
            this.gbAppNewLicenseInfo.Controls.Add(this.lblRLAppId);
            this.gbAppNewLicenseInfo.Controls.Add(this.lblAppDate);
            this.gbAppNewLicenseInfo.Controls.Add(this.lblOldLicenseID);
            this.gbAppNewLicenseInfo.Controls.Add(this.lblRreplacedLicenseID);
            this.gbAppNewLicenseInfo.Controls.Add(this.label2);
            this.gbAppNewLicenseInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAppNewLicenseInfo.Location = new System.Drawing.Point(3, 518);
            this.gbAppNewLicenseInfo.Name = "gbAppNewLicenseInfo";
            this.gbAppNewLicenseInfo.Size = new System.Drawing.Size(1026, 169);
            this.gbAppNewLicenseInfo.TabIndex = 21;
            this.gbAppNewLicenseInfo.TabStop = false;
            this.gbAppNewLicenseInfo.Text = "Application Info For License Replacement";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(708, 114);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 27);
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(189, 120);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 27);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(190, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 27);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox10.Location = new System.Drawing.Point(708, 74);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(28, 27);
            this.pictureBox10.TabIndex = 2;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Location = new System.Drawing.Point(708, 41);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(28, 27);
            this.pictureBox9.TabIndex = 2;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(190, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(590, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "Created By:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Application Fees:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(559, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Old License ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Application Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(510, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Replaced License ID:";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(753, 120);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(66, 21);
            this.lblCreatedBy.TabIndex = 0;
            this.lblCreatedBy.Text = "[????]";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFees.Location = new System.Drawing.Point(263, 124);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(59, 21);
            this.lblAppFees.TabIndex = 0;
            this.lblAppFees.Text = "[$$$]";
            // 
            // lblRLAppId
            // 
            this.lblRLAppId.AutoSize = true;
            this.lblRLAppId.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRLAppId.Location = new System.Drawing.Point(263, 48);
            this.lblRLAppId.Name = "lblRLAppId";
            this.lblRLAppId.Size = new System.Drawing.Size(56, 21);
            this.lblRLAppId.TabIndex = 0;
            this.lblRLAppId.Text = "[???]";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDate.Location = new System.Drawing.Point(263, 85);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(140, 21);
            this.lblAppDate.TabIndex = 0;
            this.lblAppDate.Text = "[dd/mm/yyyy]";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseID.Location = new System.Drawing.Point(753, 78);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(56, 21);
            this.lblOldLicenseID.TabIndex = 0;
            this.lblOldLicenseID.Text = "[???]";
            // 
            // lblRreplacedLicenseID
            // 
            this.lblRreplacedLicenseID.AutoSize = true;
            this.lblRreplacedLicenseID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRreplacedLicenseID.Location = new System.Drawing.Point(753, 42);
            this.lblRreplacedLicenseID.Name = "lblRreplacedLicenseID";
            this.lblRreplacedLicenseID.Size = new System.Drawing.Size(56, 21);
            this.lblRreplacedLicenseID.TabIndex = 0;
            this.lblRreplacedLicenseID.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "R.L Application ID:";
            // 
            // llShowNewLicensesInfo
            // 
            this.llShowNewLicensesInfo.AutoSize = true;
            this.llShowNewLicensesInfo.Enabled = false;
            this.llShowNewLicensesInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llShowNewLicensesInfo.Location = new System.Drawing.Point(266, 694);
            this.llShowNewLicensesInfo.Name = "llShowNewLicensesInfo";
            this.llShowNewLicensesInfo.Size = new System.Drawing.Size(225, 24);
            this.llShowNewLicensesInfo.TabIndex = 24;
            this.llShowNewLicensesInfo.TabStop = true;
            this.llShowNewLicensesInfo.Text = "Show New Licenses Info";
            this.llShowNewLicensesInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowNewLicensesInfo_LinkClicked);
            // 
            // llShowLicenseHistory
            // 
            this.llShowLicenseHistory.AutoSize = true;
            this.llShowLicenseHistory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llShowLicenseHistory.Location = new System.Drawing.Point(33, 692);
            this.llShowLicenseHistory.Name = "llShowLicenseHistory";
            this.llShowLicenseHistory.Size = new System.Drawing.Size(199, 24);
            this.llShowLicenseHistory.TabIndex = 25;
            this.llShowLicenseHistory.TabStop = true;
            this.llShowLicenseHistory.Text = "Show License History";
            this.llShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseHistory_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(618, 697);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 33);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnIssueReplacement
            // 
            this.btnIssueReplacement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueReplacement.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueReplacement.Image = ((System.Drawing.Image)(resources.GetObject("btnIssueReplacement.Image")));
            this.btnIssueReplacement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueReplacement.Location = new System.Drawing.Point(792, 700);
            this.btnIssueReplacement.Name = "btnIssueReplacement";
            this.btnIssueReplacement.Size = new System.Drawing.Size(237, 33);
            this.btnIssueReplacement.TabIndex = 23;
            this.btnIssueReplacement.Text = "Issue Replacement";
            this.btnIssueReplacement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssueReplacement.UseVisualStyleBackColor = true;
            this.btnIssueReplacement.Click += new System.EventHandler(this.btnIssueReplacement_Click);
            // 
            // frmLicenseReplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 756);
            this.Controls.Add(this.llShowNewLicensesInfo);
            this.Controls.Add(this.llShowLicenseHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssueReplacement);
            this.Controls.Add(this.gbAppNewLicenseInfo);
            this.Controls.Add(this.gbReplacementFor);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFiltter1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLicenseReplacement";
            this.Text = "License Replacement";
            this.Load += new System.EventHandler(this.frmLicenseReplacement_Load);
            this.gbReplacementFor.ResumeLayout(false);
            this.gbReplacementFor.PerformLayout();
            this.gbAppNewLicenseInfo.ResumeLayout(false);
            this.gbAppNewLicenseInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private ctrlDriverLicenseInfoWithFiltter ctrlDriverLicenseInfoWithFiltter1;
        private System.Windows.Forms.GroupBox gbReplacementFor;
        private System.Windows.Forms.RadioButton rbLostLicense;
        private System.Windows.Forms.RadioButton rbDamagedLicense;
        private System.Windows.Forms.GroupBox gbAppNewLicenseInfo;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label lblRLAppId;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label lblRreplacedLicenseID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llShowNewLicensesInfo;
        private System.Windows.Forms.LinkLabel llShowLicenseHistory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssueReplacement;
    }
}