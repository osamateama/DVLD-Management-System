using BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ViewPerson : Form
    {
        public ViewPerson(int PersonID)
        {
            InitializeComponent();
            ctrlPerson2.LoadPersonInfo(PersonID);
        }
        public ViewPerson(string NationalNo)
        {
            InitializeComponent();
            ctrlPerson2.LoadPersonInfo(NationalNo);
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
