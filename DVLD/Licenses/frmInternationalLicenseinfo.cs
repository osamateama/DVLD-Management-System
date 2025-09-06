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
    public partial class frmInternationalLicenseinfo : Form
    {
       private int _InterID = -1;
        public frmInternationalLicenseinfo(int InternationalID)
        {
            InitializeComponent();
            _InterID = InternationalID;
        }

        private void btnClose_Click(object sender, EventArgs e)=> this.Close();

        private void frmInternationalLicenseinfo_Load(object sender, EventArgs e)
        {
            ctrlInternationalLicenseInfo1.LoadLicenseInfo(_InterID);
        }
    }
}
