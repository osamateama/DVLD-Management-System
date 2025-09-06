namespace DVLD
{
    partial class ctrlUser
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
            this.ctrlPerson1 = new DVLD.ctrlPerson();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIsactive = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUserid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.lable3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPerson1
            // 
            this.ctrlPerson1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlPerson1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPerson1.Name = "ctrlPerson1";
            this.ctrlPerson1.Size = new System.Drawing.Size(906, 317);
            this.ctrlPerson1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIsactive);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.lblUserid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lable2);
            this.groupBox1.Controls.Add(this.lable3);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Information ";
            // 
            // lblIsactive
            // 
            this.lblIsactive.AutoSize = true;
            this.lblIsactive.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsactive.Location = new System.Drawing.Point(764, 53);
            this.lblIsactive.Name = "lblIsactive";
            this.lblIsactive.Size = new System.Drawing.Size(40, 22);
            this.lblIsactive.TabIndex = 9;
            this.lblIsactive.Text = "???";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(490, 53);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(40, 22);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "???";
            // 
            // lblUserid
            // 
            this.lblUserid.AutoSize = true;
            this.lblUserid.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserid.Location = new System.Drawing.Point(269, 53);
            this.lblUserid.Name = "lblUserid";
            this.lblUserid.Size = new System.Drawing.Size(40, 22);
            this.lblUserid.TabIndex = 8;
            this.lblUserid.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(663, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Is Active:";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable2.Location = new System.Drawing.Point(368, 53);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(116, 22);
            this.lable2.TabIndex = 6;
            this.lable2.Text = "User Name:";
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable3.Location = new System.Drawing.Point(177, 53);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(86, 22);
            this.lable3.TabIndex = 1;
            this.lable3.Text = "User ID:";
            // 
            // ctrlUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlPerson1);
            this.Name = "ctrlUser";
            this.Size = new System.Drawing.Size(910, 452);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPerson ctrlPerson1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label lblIsactive;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUserid;
    }
}
