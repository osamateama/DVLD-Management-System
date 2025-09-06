namespace DVLD
{
    partial class ViewPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPerson));
            this.ctrlPerson2 = new DVLD.ctrlPerson();
            this.btnclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlPerson2
            // 
            this.ctrlPerson2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlPerson2.Location = new System.Drawing.Point(3, 75);
            this.ctrlPerson2.Name = "ctrlPerson2";
            this.ctrlPerson2.Size = new System.Drawing.Size(906, 317);
            this.ctrlPerson2.TabIndex = 0;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.White;
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(775, 408);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(134, 54);
            this.btnclose.TabIndex = 16;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(323, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 48);
            this.label1.TabIndex = 17;
            this.label1.Text = "Person Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ViewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btnclose;
            this.ClientSize = new System.Drawing.Size(916, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.ctrlPerson2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "More Details";
            this.Load += new System.EventHandler(this.ViewPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlPerson ctrlPerson1;
        private ctrlPerson ctrlPerson2;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label1;
    }
}