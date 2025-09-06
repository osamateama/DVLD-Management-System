using BusinessLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmManageUsers : Form
    {
        private DataTable _dtUsers;
        public frmManageUsers()
        {
            InitializeComponent();
        }
        private void _LoadAllUsers()
        {
            _dtUsers = clsUser.GetAll();
            //            
            dgvUsers.DataSource = _dtUsers;
            cbsearch1.SelectedIndex = 0;
            cbIsActive.SelectedIndex = 0;
            cbIsActive.Visible = false;
            //
            lbrecordnum.Text = dgvUsers.Rows.Count.ToString();
            if (dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns["UserID"].HeaderText = "User ID";
                dgvUsers.Columns["UserID"].Width = 130;

                dgvUsers.Columns["PersonID"].HeaderText = "Person ID";
                dgvUsers.Columns["PersonID"].Width = 130;

                dgvUsers.Columns["FullName"].HeaderText = "Full Name";
                dgvUsers.Columns["FullName"].Width = 400;

                dgvUsers.Columns["UserName"].HeaderText = "User Name";
                dgvUsers.Columns["UserName"].Width = 170;

                dgvUsers.Columns["IsActive"].HeaderText = "Active";
                dgvUsers.Columns["IsActive"].Width = 100;

                // حول العمود لمربع اختيار
                dgvUsers.Columns["IsActive"].ReadOnly = false;
                dgvUsers.Columns["IsActive"].CellTemplate = new DataGridViewCheckBoxCell();
            }
        }
        private void frmManageUsers_Load(object sender, EventArgs e) => _LoadAllUsers();
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddOrEditUser frm = new frmAddOrEditUser();
            frm.ShowDialog();
            frmManageUsers_Load(null, null);
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbsearch1.Text)
            {
                case "User ID":
                    FilterColumn = "UserID"; break;

                case "Person ID":
                    FilterColumn = "PersonID"; break;
                case "Full Name":
                    FilterColumn = "FullName"; break;
                case "User Name":
                    FilterColumn = "UserName"; break;
                case "Is Active":
                    FilterColumn = "IsActive"; break;
                default:
                    FilterColumn = "None";
                    break;
            }
            if (txtsearch1.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtUsers.DefaultView.RowFilter = "";
                lbrecordnum.Text = dgvUsers.Rows.Count.ToString();
                return;
            }
            if (FilterColumn == "PersonID" || FilterColumn == "UserID")
            {
                if (int.TryParse(txtsearch1.Text.Trim(), out int id))
                    _dtUsers.DefaultView.RowFilter = $"[{FilterColumn}] = {id}";
                else
                    _dtUsers.DefaultView.RowFilter = "1=0"; // invalid input → no results
            }
            else if (FilterColumn == "FullName" || FilterColumn == "UserName")
            {
                _dtUsers.DefaultView.RowFilter = $"[{FilterColumn}] LIKE '{txtsearch1.Text.Trim()}%'";
            }

            lbrecordnum.Text = dgvUsers.Rows.Count.ToString();
        }
        private void cbsearch1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsearch1.Visible = (cbsearch1.Text != "None" && cbsearch1.Text != "Is Active");
            cbIsActive.Visible = (cbsearch1.Text == "Is Active" && cbsearch1.Text != "None");
            if (txtsearch1.Visible)
            {
                txtsearch1.Text = "";
                txtsearch1.Focus();
            }
        }
        private void cbIsActive_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbIsActive.SelectedItem.ToString())
            {
                case "Yes":
                    FilterColumn = "IsActive = 1";
                    break;

                case "No":
                    FilterColumn = "IsActive = 0";
                    break;

                case "All":
                default:
                    FilterColumn = ""; // بدون فلترة
                    break;
            }
            _dtUsers.DefaultView.RowFilter = FilterColumn;
            lbrecordnum.Text = dgvUsers.Rows.Count.ToString();
        }
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddOrEditUser frm = new frmAddOrEditUser();
            frm.ShowDialog();
            frmManageUsers_Load(null, null);
        }
        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);

            if (MessageBox.Show($"Are you sure you want to delete User [{UserID}]?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsUser.DeleteUser(UserID))
                {
                    MessageBox.Show("Person deleted successfully.");
                    frmManageUsers_Load(null, null);
                }
                else
                    MessageBox.Show("Failed to delete User.");
            }
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateUser frm = new frmUpdateUser((int)dgvUsers.CurrentRow.Cells["UserID"].Value);
            frm.ShowDialog();
        }
        private void moreInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo((int)dgvUsers.CurrentRow.Cells["UserID"].Value);
            frm.ShowDialog();
        }
        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddOrEditUser frm = new frmAddOrEditUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmManageUsers_Load(null,null);
        }
        private void btnClose_Click(object sender, EventArgs e) => this.Close();
        private void cbsearch1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Skip if no item
            if (e.Index < 0) return;
            // Get the text of the item
            string text = cbsearch1.Items[e.Index].ToString();
            // Draw background
            e.DrawBackground();
            // Create format with padding
            using (SolidBrush brush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString("   " + text, e.Font, brush, e.Bounds.X, e.Bounds.Y); // <-- Add space here
            }
            // Draw focus rectangle if needed
            e.DrawFocusRectangle();
        }
        private void cbIsActive_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            string text = cbsearch1.Items[e.Index].ToString();
            e.DrawBackground();
            using (SolidBrush brush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString("   " + text, e.Font, brush, e.Bounds.X, e.Bounds.Y); // <-- Add space here
            }
            e.DrawFocusRectangle();
        }
    }
}
