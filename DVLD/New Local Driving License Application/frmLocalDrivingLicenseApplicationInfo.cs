using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmLocalDrivingLicenseApplicationInfo : Form
    {
        private int _LDLAppID;
        public frmLocalDrivingLicenseApplicationInfo(int LDLAppID)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID;
        }

        private void frmLocalDrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
        {
            ctrlDrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalDrivingAppID(_LDLAppID);
        }

        private void btnClose2_Click(object sender, EventArgs e)=>this.Close();
    }
}
