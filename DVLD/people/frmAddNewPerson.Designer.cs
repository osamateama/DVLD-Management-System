namespace DVLD
{
    partial class frmAddNewPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewPerson));
            this.lbladdnew = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblThird = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.Lablepersonid = new System.Windows.Forms.Label();
            this.lblpersonid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldateofbirth = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblgendor = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblcountry = new System.Windows.Forms.Label();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.llremoveimg = new System.Windows.Forms.LinkLabel();
            this.pbimgperson = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimgperson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbladdnew
            // 
            this.lbladdnew.AutoSize = true;
            this.lbladdnew.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdnew.ForeColor = System.Drawing.Color.Firebrick;
            this.lbladdnew.Location = new System.Drawing.Point(365, 24);
            this.lbladdnew.Name = "lbladdnew";
            this.lbladdnew.Size = new System.Drawing.Size(325, 45);
            this.lbladdnew.TabIndex = 0;
            this.lbladdnew.Text = "Add New Person";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 200);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 24);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(178, 200);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(155, 24);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFirstName_KeyPress);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating_1);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(793, 204);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(179, 24);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLastName_KeyPress);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating_1);
            // 
            // txtThirdName
            // 
            this.txtThirdName.Location = new System.Drawing.Point(568, 200);
            this.txtThirdName.MaxLength = 30;
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(162, 24);
            this.txtThirdName.TabIndex = 3;
            this.txtThirdName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbThirdName_KeyPress);
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(373, 200);
            this.txtSecondName.MaxLength = 30;
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(161, 24);
            this.txtSecondName.TabIndex = 2;
            this.txtSecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSecondName_KeyPress);
            this.txtSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating_1);
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblFirst.Location = new System.Drawing.Point(239, 177);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(45, 23);
            this.lblFirst.TabIndex = 6;
            this.lblFirst.Text = "First";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.Location = new System.Drawing.Point(407, 177);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(67, 22);
            this.lblSecond.TabIndex = 7;
            this.lblSecond.Text = "Second";
            // 
            // lblThird
            // 
            this.lblThird.AutoSize = true;
            this.lblThird.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblThird.Location = new System.Drawing.Point(617, 174);
            this.lblThird.Name = "lblThird";
            this.lblThird.Size = new System.Drawing.Size(54, 23);
            this.lblThird.TabIndex = 8;
            this.lblThird.Text = "Third";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblLast.Location = new System.Drawing.Point(846, 176);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(43, 23);
            this.lblLast.TabIndex = 9;
            this.lblLast.Text = "Last";
            // 
            // Lablepersonid
            // 
            this.Lablepersonid.AutoSize = true;
            this.Lablepersonid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lablepersonid.ForeColor = System.Drawing.Color.Firebrick;
            this.Lablepersonid.Location = new System.Drawing.Point(174, 99);
            this.Lablepersonid.Name = "Lablepersonid";
            this.Lablepersonid.Size = new System.Drawing.Size(72, 24);
            this.Lablepersonid.TabIndex = 11;
            this.Lablepersonid.Text = "[????]";
            // 
            // lblpersonid
            // 
            this.lblpersonid.AutoSize = true;
            this.lblpersonid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpersonid.Location = new System.Drawing.Point(12, 99);
            this.lblpersonid.Name = "lblpersonid";
            this.lblpersonid.Size = new System.Drawing.Size(123, 24);
            this.lblpersonid.TabIndex = 12;
            this.lblpersonid.Text = "Person ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "National no: ";
            // 
            // lbldateofbirth
            // 
            this.lbldateofbirth.AutoSize = true;
            this.lbldateofbirth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldateofbirth.Location = new System.Drawing.Point(377, 250);
            this.lbldateofbirth.Name = "lbldateofbirth";
            this.lbldateofbirth.Size = new System.Drawing.Size(155, 24);
            this.lbldateofbirth.TabIndex = 16;
            this.lbldateofbirth.Text = "Date Of Birth: ";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(538, 249);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(192, 24);
            this.dateOfBirth.TabIndex = 6;
            this.dateOfBirth.Value = new System.DateTime(2025, 7, 27, 0, 0, 0, 0);
            // 
            // lblgendor
            // 
            this.lblgendor.AutoSize = true;
            this.lblgendor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgendor.Location = new System.Drawing.Point(12, 302);
            this.lblgendor.Name = "lblgendor";
            this.lblgendor.Size = new System.Drawing.Size(97, 24);
            this.lblgendor.TabIndex = 18;
            this.lblgendor.Text = "Gendor: ";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(115, 303);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(71, 25);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Tag = "0";
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(200, 303);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(92, 25);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.Tag = "-1";
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Phone:  ";
            // 
            // tbphone
            // 
            this.tbphone.Location = new System.Drawing.Point(530, 302);
            this.tbphone.MaxLength = 11;
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(200, 24);
            this.tbphone.TabIndex = 9;
            this.tbphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbphone_KeyPress);
            this.tbphone.Validating += new System.ComponentModel.CancelEventHandler(this.tbphone_Validating);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(12, 352);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(78, 24);
            this.lblemail.TabIndex = 18;
            this.lblemail.Text = "Email: ";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(133, 351);
            this.txtemail.MaxLength = 50;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(217, 24);
            this.txtemail.TabIndex = 10;
            this.txtemail.Validating += new System.ComponentModel.CancelEventHandler(this.txtemail_Validating);
            // 
            // lblcountry
            // 
            this.lblcountry.AutoSize = true;
            this.lblcountry.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcountry.Location = new System.Drawing.Point(369, 347);
            this.lblcountry.Name = "lblcountry";
            this.lblcountry.Size = new System.Drawing.Size(109, 24);
            this.lblcountry.TabIndex = 22;
            this.lblcountry.Text = "Country:  ";
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.Location = new System.Drawing.Point(192, 254);
            this.txtNationalNo.MaxLength = 14;
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Size = new System.Drawing.Size(171, 24);
            this.txtNationalNo.TabIndex = 5;
            this.txtNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtNationalNo_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(530, 347);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(200, 24);
            this.cbCountry.TabIndex = 11;
            this.cbCountry.Validating += new System.ComponentModel.CancelEventHandler(this.cbCountry_Validating);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(9, 402);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(104, 24);
            this.lblAddress.TabIndex = 18;
            this.lblAddress.Text = "Address: ";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(161, 395);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(569, 98);
            this.txtaddress.TabIndex = 12;
            this.txtaddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtaddress_Validating);
            // 
            // llSetImage
            // 
            this.llSetImage.AutoSize = true;
            this.llSetImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llSetImage.Font = new System.Drawing.Font("Tahoma", 14F);
            this.llSetImage.Location = new System.Drawing.Point(817, 420);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(123, 29);
            this.llSetImage.TabIndex = 12;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "Set Image";
            this.llSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImage_LinkClicked);
            // 
            // llremoveimg
            // 
            this.llremoveimg.AutoSize = true;
            this.llremoveimg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llremoveimg.Font = new System.Drawing.Font("Tahoma", 14F);
            this.llremoveimg.Location = new System.Drawing.Point(817, 464);
            this.llremoveimg.Name = "llremoveimg";
            this.llremoveimg.Size = new System.Drawing.Size(99, 29);
            this.llremoveimg.TabIndex = 13;
            this.llremoveimg.TabStop = true;
            this.llremoveimg.Text = "Remove";
            this.llremoveimg.Visible = false;
            this.llremoveimg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pbimgperson
            // 
            this.pbimgperson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbimgperson.Location = new System.Drawing.Point(793, 250);
            this.pbimgperson.Name = "pbimgperson";
            this.pbimgperson.Size = new System.Drawing.Size(179, 154);
            this.pbimgperson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbimgperson.TabIndex = 27;
            this.pbimgperson.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(484, 347);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 24);
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(490, 302);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 24);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(85, 347);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 29);
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(120, 395);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(35, 31);
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(156, 249);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(128, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 30);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(128, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 42);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.White;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(596, 522);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(134, 54);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
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
            this.btnclose.Location = new System.Drawing.Point(434, 522);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(134, 54);
            this.btnclose.TabIndex = 15;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // frmAddNewPerson
            // 
            this.AcceptButton = this.btnsave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btnclose;
            this.ClientSize = new System.Drawing.Size(1006, 588);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.llremoveimg);
            this.Controls.Add(this.llSetImage);
            this.Controls.Add(this.pbimgperson);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.txtNationalNo);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.tbphone);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblcountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblgendor);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.lbldateofbirth);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblpersonid);
            this.Controls.Add(this.Lablepersonid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblThird);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.txtThirdName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lbladdnew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddNewPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Edit Person";
            this.Load += new System.EventHandler(this.frmAddNewPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimgperson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladdnew;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblThird;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lablepersonid;
        private System.Windows.Forms.Label lblpersonid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbldateofbirth;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.Label lblgendor;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblcountry;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtNationalNo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pbimgperson;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.LinkLabel llremoveimg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclose;
    }
}