using BusinessLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmManageTestTypes : Form
    {
        private DataTable _dtTestTypes;

        public frmManageTestTypes()
        {
            InitializeComponent();
        }
        private void frmManageTestTypes_Load(object sender, EventArgs e)=> _LoadAllAppTypes();
        private void _LoadAllAppTypes()
        {
            _dtTestTypes = clsTestType.GetAll();
            dgvTestTypes.DataSource = _dtTestTypes;

            lbrecordnum1.Text = dgvTestTypes.Rows.Count.ToString();

            if (dgvTestTypes.Rows.Count > 0)
            {
                dgvTestTypes.Columns["TestTypeID"].HeaderText = "ID";
                dgvTestTypes.Columns["TestTypeID"].Width = 70;

                dgvTestTypes.Columns["TestTypeTitle"].HeaderText = "Title";
                dgvTestTypes.Columns["TestTypeTitle"].Width = 185;

                dgvTestTypes.Columns["TestTypeDescription"].HeaderText = "Description";
                dgvTestTypes.Columns["TestTypeDescription"].Width = 620;
                
                dgvTestTypes.Columns["TestTypeFees"].HeaderText = "Fees";
                dgvTestTypes.Columns["TestTypeFees"].Width = 80;
            }
        }

        private void btnClose1_Click(object sender, EventArgs e)=>this.Close();
        private void editeTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditeTestType frm = new frmEditeTestType((clsTestType.enTestType)dgvTestTypes.CurrentRow.Cells["TestTypeID"].Value);
            frm.ShowDialog();
        }
    }
}
