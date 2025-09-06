using BusinessLayer;
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
    public partial class ManagePeople : Form
    {
        private DataTable _dtPeople;
        private int currentPage = 1;
        private int rowsPerPage = 10;
        private int totalRecords = 0;
        private int totalPages = 0;

        public ManagePeople()
        {
            InitializeComponent();
        }

        private void _LoadPeoplePage()
        {

            if (totalRecords == 0)
                totalRecords = clsPerson.GetPeopleCount();

            totalPages = (int)Math.Ceiling((double)totalRecords / rowsPerPage);

            DataTable dtPage = clsPerson.GetPeoplePage(currentPage, rowsPerPage);

            _dtPeople = dtPage.DefaultView.ToTable(false,
                "PersonID", "NationalNo", "FirstName", "SecondName", "ThirdName", "LastName",
                "GenderCaption", "DateOfBirth", "CountryName", "Phone", "Email");

            dgvpeople.DataSource = _dtPeople;
            if (dgvpeople.Rows.Count > 0)
            {
                dgvpeople.Columns[0].HeaderText = "Person ID";
                dgvpeople.Columns[0].Width = 110;

                dgvpeople.Columns[1].HeaderText = "National No.";
                dgvpeople.Columns[1].Width = 120;

                dgvpeople.Columns[2].HeaderText = "First Name";
                dgvpeople.Columns[2].Width = 120;

                dgvpeople.Columns[3].HeaderText = "Second Name";
                dgvpeople.Columns[3].Width = 140;

                dgvpeople.Columns[4].HeaderText = "Third Name";
                dgvpeople.Columns[4].Width = 120;

                dgvpeople.Columns[5].HeaderText = "Last Name";
                dgvpeople.Columns[5].Width = 120;

                dgvpeople.Columns[6].HeaderText = "Gender";
                dgvpeople.Columns[6].Width = 120;

                dgvpeople.Columns[7].HeaderText = "Date Of Birth";
                dgvpeople.Columns[7].Width = 140;

                dgvpeople.Columns[8].HeaderText = "Nationality";
                dgvpeople.Columns[8].Width = 120;

                dgvpeople.Columns[9].HeaderText = "Phone";
                dgvpeople.Columns[9].Width = 120;

                dgvpeople.Columns[10].HeaderText = "Email";
                dgvpeople.Columns[10].Width = 170;
            }
            lblTotalRecoreds.Text = totalRecords.ToString();
            lbltotalpages.Text = totalPages.ToString();
            lblcurentPage.Text = currentPage.ToString();
            lbrecordnum.Text = dgvpeople.Rows.Count.ToString();
        }
        private void _SetupGridColumns()
        {

        }


        private void moreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPerson frm = new ViewPerson((int)dgvpeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson((int)dgvpeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadPeoplePage();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personID = Convert.ToInt32(dgvpeople.CurrentRow.Cells["PersonID"].Value);

            if (MessageBox.Show($"Are you sure you want to delete Person [{personID}]?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsPerson.DeletePerson(personID))
                {
                    MessageBox.Show("Person deleted successfully.");
                    _LoadPeoplePage();
                }
                else
                    MessageBox.Show("Failed to delete person.");
            }
        }
        private void _FillSearchComboBox()
        {
            cbsearch.Items.Clear();

            cbsearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbsearch.BackColor = Color.White;
            cbsearch.ForeColor = Color.Black;
            cbsearch.FlatStyle = FlatStyle.Standard;

            cbsearch.Items.Add("None");
            cbsearch.Items.Add("Person ID");
            cbsearch.Items.Add("National No.");
            cbsearch.Items.Add("First Name");
            cbsearch.Items.Add("Second Name");
            cbsearch.Items.Add("Third Name");
            cbsearch.Items.Add("Last Name");
            cbsearch.Items.Add("Gender");
            cbsearch.Items.Add("Date Of Birth");
            cbsearch.Items.Add("Nationality");
            cbsearch.Items.Add("Phone");
            cbsearch.Items.Add("Email");

            cbsearch.SelectedIndex = 0;
        }


        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbsearch.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID"; break;

                case "National No.":
                    FilterColumn = "NationalNo"; break;
                case "First Name":
                    FilterColumn = "FirstName"; break;
                case "Second Name":
                    FilterColumn = "SecondName"; break;
                case "Third Name":
                    FilterColumn = "ThirdName"; break;
                case "Last Name":
                    FilterColumn = "LastName"; break;
                case "Gender":
                    FilterColumn = "GendorCaption"; break;
                case "Date Of Birth":
                    FilterColumn = "DateOfBirth"; break;
                case "Nationality":
                    FilterColumn = "CountryName"; break;
                case "Phone":
                    FilterColumn = "Phone"; break;
                case "Email":
                    FilterColumn = "Email"; break;
                default:
                    FilterColumn = "None";
                    break;
            }
            if (txtsearch.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lbrecordnum.Text = dgvpeople.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonID")
            {
                if (int.TryParse(txtsearch.Text.Trim(), out int id))
                    _dtPeople.DefaultView.RowFilter = $"[PersonID] = {id}";
                else
                    _dtPeople.DefaultView.RowFilter = "1=0"; // invalid input → no results
            }
            else
            {
                _dtPeople.DefaultView.RowFilter = $"[{FilterColumn}] LIKE '{txtsearch.Text.Trim()}%'";
            }

            lbrecordnum.Text = dgvpeople.Rows.Count.ToString();


        }
        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void cbsearch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtsearch.Visible = (cbsearch.Text != "None" || cbsearch.SelectedIndex !=0);
            if (txtsearch.Visible)
            {
                txtsearch.Text = "";
                txtsearch.Focus();
            }
        }
        private void ManagePeople_Load(object sender, EventArgs e)
        {
            _LoadPeoplePage();
            _FillSearchComboBox();

        }
        private void btnClose_Click_1(object sender, EventArgs e) => this.Close();
        private void btnAddNew_Click_1(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson();
            frm.ShowDialog();
            _LoadPeoplePage();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                _LoadPeoplePage();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                _LoadPeoplePage();
            }
        }

       
    }
}
