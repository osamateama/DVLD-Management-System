using BusinessLayer;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        public event Action<int> OnPersonSelected;
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID);
            }
        }
        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get {return _ShowAddPerson; }
            set
            {
                _ShowAddPerson = value;
                btnAdd.Visible = _ShowAddPerson;
            }
        }
        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get => _FilterEnabled; 
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }
        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }
        private int _PersonID = -1;
        public int PersonID
        {
            get { return ctrlPerson1.PersonID; }
        }
        public clsPerson SelectedPersonInfo
        {
            get { return ctrlPerson1.SelectedPersonInfo; }
        }

        public void LoadPersonInfo(int PersonID)
        {
            cbFilterBy.SelectedIndex = 1;
            txtinput.Text = PersonID.ToString();
            FindNow();

        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFilterBy.Text = "";
            cbFilterBy.Focus();
        }
        private void FindNow()
        {
            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    ctrlPerson1.LoadPersonInfo(int.Parse(txtinput.Text)); break;
                case "National No":
                    ctrlPerson1.LoadPersonInfo(txtinput.Text); break;
                default:
                    ctrlPerson1.LoadPersonInfo(int.Parse(txtinput.Text)); break;
            }
            if (OnPersonSelected != null && FilterEnabled)
                OnPersonSelected(ctrlPerson1.PersonID);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtinput.Text))
            {
                MessageBox.Show("Please enter a value to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtinput.Focus(); // set focus back to the textbox
                return;
            }
            FindNow();
        }
        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.Items.Clear(); 

            cbFilterBy.Items.Add("None");
            cbFilterBy.Items.Add("Person ID");
            cbFilterBy.Items.Add("National No");

            cbFilterBy.SelectedIndex = 1;
            txtinput.Focus();
        }
        private void txtinput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtinput.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtinput, "This field is required.");
            }
            else
                errorProvider1.SetError(txtinput, null);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson();
            frm.DataBack += DataBackevent;
            frm.ShowDialog();
        }
        private void DataBackevent(object sender, int PersonID)
        {
            cbFilterBy.SelectedIndex = 1;
            txtinput.Text = PersonID.ToString();
            ctrlPerson1.LoadPersonInfo(PersonID);
        }
        public void FilterFoucs() => txtinput.Focus();
        private void txtinput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnSearch.PerformClick();
            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
       
    }
}
