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
    public partial class frmLicenseHistory : Form
    {
        private int _PersonID = -1;
        public frmLicenseHistory()
        {
            InitializeComponent();
        }
         public frmLicenseHistory(int personID)
         {
            InitializeComponent();
            _PersonID = personID;
         }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            if(_PersonID!= -1)
            {
                ctrlPersonCardWithFilter1.LoadPersonInfo(_PersonID);
                ctrlPersonCardWithFilter1.Enabled = false;
                ctrlDriverLicense1.LoadInfoByPersonID(_PersonID);

            }
            else
            {
                ctrlPersonCardWithFilter1.Enabled = true;
                ctrlPersonCardWithFilter1.FilterFoucs();
            }
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            _PersonID = obj;
            if (_PersonID == -1)
            {
                ctrlDriverLicense1.Clear();
            }
            else
            {
                ctrlDriverLicense1.LoadInfoByPersonID(_PersonID);
                ctrlPersonCardWithFilter1.Enabled = false;
            }
        }

       
    }
}
