using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmFindPerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;
        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
        DataBack?.Invoke(this, ctrlPersonCardWithFilter1.PersonID);
            this.Close();
        }

        private void frmFindPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
