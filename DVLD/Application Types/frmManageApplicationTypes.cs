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
    public partial class frmManageApplicationTypes : Form
    {
        private DataTable _dtAppTypes;
        public frmManageApplicationTypes()=> InitializeComponent();
        private void frmManageApplicationTypes_Load(object sender, EventArgs e) => _LoadAllAppTypes();
        private void _LoadAllAppTypes()
        {
            _dtAppTypes = clsApplicationType.GetAllApplicationTypes();
            dgvManageAppTypes.DataSource = _dtAppTypes;

            lbrecordnum1.Text = dgvManageAppTypes.Rows.Count.ToString();

            if (dgvManageAppTypes.Rows.Count > 0)
            {
                dgvManageAppTypes.Columns["ApplicationTypeID"].HeaderText = "ID";
                dgvManageAppTypes.Columns["ApplicationTypeID"].Width = 130;

                dgvManageAppTypes.Columns["ApplicationTypeTitle"].HeaderText = "Title";
                dgvManageAppTypes.Columns["ApplicationTypeTitle"].Width = 400;

                dgvManageAppTypes.Columns["ApplicationFees"].HeaderText = "Fees";
                dgvManageAppTypes.Columns["ApplicationFees"].Width = 130;
            }
        }
    private void btnClose1_Click(object sender, EventArgs e)=> this.Close();
        private void editeApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditAppTypesInfo frm = new frmEditAppTypesInfo((int)dgvManageAppTypes.CurrentRow.Cells["ApplicationTypeID"].Value);
            frm.ShowDialog();
            frmManageApplicationTypes_Load(null,null);
        }

    }
}
