using BusinessLayer;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace DVLD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async void btnlogin_Click(object sender, EventArgs e)
        {
            clsUser user = clsUser.FindByUserNameAndPassword(txtuserName.Text.Trim(), txtPassword.Text.Trim());

            if (user != null)
            {
                if (cbRemember.Checked)
                    clsGlobal.RememberUsernameAndPassword(txtuserName.Text.Trim(), txtPassword.Text.Trim());
                else
                    clsGlobal.RememberUsernameAndPassword("", "");
                if (!user.IsActive)
                {
                    txtuserName.Focus();
                    MessageBox.Show("Your Account Is Not Active Contact Admin", "In Active", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                clsGlobal.CurrentUser = user;

                Task logging = _Logging();
                lblLogging.Text = "Logging...";
                await logging;
            }
            else
            {
                txtuserName.Focus();
                MessageBox.Show("InValid UserName/Password.", "Wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private async Task _Logging()
        {
            await Task.Delay(500); 
            frmMain frm = new frmMain(this);
            frm.ShowDialog();
            lblLogging.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //txtuserName.Focus();
            string UserName = "", Password = "";
            if(clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                txtuserName.Text = UserName;
                txtPassword.Text = Password;
                cbRemember.Checked = true;
            }
            else
                cbRemember.Checked = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)=> this.Close();
    }
   
    }

