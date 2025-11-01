using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Number
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPassword.Text, @"\d"))
            {
                lblNumber.Text = "✓ Number";
                lblNumber.ForeColor = Color.Green;
            }
            else
            {
                lblNumber.Text = "❌ Number";
                lblNumber.ForeColor = Color.Red;
            }
            Match();
        }
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            Match();
        }
        private void Match()
        {
            if (!string.IsNullOrEmpty(txtPassword.Text) &&
                !string.IsNullOrEmpty(txtConfirmPassword.Text) &&
                txtPassword.Text == txtConfirmPassword.Text)
            {
                lblMatch.Text = "✓ Match";
                lblMatch.ForeColor = Color.Green;
            }
            else
            {
                lblMatch.Text = "❌ Match";
                lblMatch.ForeColor = Color.Red;
            }
        }

        private void frmSettings_Load_1(object sender, EventArgs e)
        {
            CRUD.CRUD.RETRIEVECBO(cbSection, "SELECT [ID], [Section] FROM [tblSection] ORDER BY [Section] asc", "Section", "ID");
            CRUD.CRUD.RETRIEVEDTG(dgvUsers, "SELECT * FROM [tblUsers] ORDER BY id ASC");
            cbSection.SelectedIndex = 4; // Default to No Section (In my db it's ID 4)

            lblNumber.Text = "❌ Number";
            lblNumber.ForeColor = Color.Red;

            lblMatch.Text = "❌ Match";
            lblMatch.ForeColor = Color.Red;
        }

        private void btnExecute_Click_1(object sender, EventArgs e)
        {
            //Proper Validations

            if (string.IsNullOrWhiteSpace(txtUserName.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text) ||
                string.IsNullOrWhiteSpace(cbSection.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtUserName.Text.Contains(" "))
            {
                MessageBox.Show("Username cannot contain spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtPassword.Text.Contains(" "))
            {
                MessageBox.Show("Password cannot contain spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtPassword.Text, @"[a-z]"))
            {
                MessageBox.Show("Password must contain at least one lowercase letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtPassword.Text, @"[A-Z]"))
            {
                MessageBox.Show("Password must contain at least one uppercase letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtAge.Text) || int.Parse(txtAge.Text) < 18 || int.Parse(txtAge.Text) > 65)
            {
                MessageBox.Show("Please enter a valid age between 18 and 65.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtFullName.Text) || txtFullName.Text.Length < 3)
            {
                MessageBox.Show("Please enter a valid full name with at least 3 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtPassword.Text, @"\d"))
            {
                MessageBox.Show("Password must contain at least one number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (CRUD.CRUD.RETRIEVESINGLE("Select * From [tblUsers] where [UserName] = '" + txtUserName.Text + "'"))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to register?", "Confirmation",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "Insert into [tblUsers] ([UserName], [Password],[Section],[Age], [FullName]) values ('" + txtUserName.Text + "','" + txtPassword.Text + "','" + cbSection.Text + "','" + txtAge.Text + "','" + txtFullName.Text + "')";
                CRUD.CRUD.CUD(query);
                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearDetails();
                CRUD.CRUD.RETRIEVEDTG(dgvUsers, "Select * From [tblUsers] ORDER BY id ASC");
                //this.Close();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }
        private void clearDetails()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            cbSection.Text = "";
            txtAge.Clear();
            txtFullName.Clear();
            lblNumber.Text = "❌ Number";
            lblNumber.ForeColor = Color.Red;
            lblMatch.Text = "❌ Match";
            lblMatch.ForeColor = Color.Red;
        }

        private void btnExecute_MouseEnter(object sender, EventArgs e)
        {
            btnExecute.BackColor = Color.FromArgb(14, 102, 85);
        }

        private void btnExecute_MouseLeave(object sender, EventArgs e)
        {
            btnExecute.BackColor = Color.FromArgb(26, 188, 156);
        }

        public void tpage_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // used disable to select the 'tpageSectionRegistration' tab
            if (e.TabPage == tpage.TabPages[1])
            {
                e.Cancel = true;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to export the data to Excel?", "Export to Excel",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            ExportDgv.ExportToExcel(dgvUsers, "ExportedData_" + DateTime.Now.ToString("MM-dd-yyyy"));

        }
        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to export this user's data to Excel?", "Export to Excel",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.No) return;

                string TemplatePath = @"D:\LOCALDB\template.xlsx";
            string SavePath = @"D:\LOCALDB\dataSaved_.xlsx"; ;
            ExportCellFromDGV.ExportFromTemplate(TemplatePath, SavePath,
        "B1", dgvUsers.Rows[e.RowIndex].Cells["FullName"].Value,
        "H1", dgvUsers.Rows[e.RowIndex].Cells["Section"].Value,
        "B2", dgvUsers.Rows[e.RowIndex].Cells["Username"].Value,
        "H2", dgvUsers.Rows[e.RowIndex].Cells["Age"].Value,
        "A32", frmLoginForm.fullname,
        "A33", DateTime.Now.ToString("yyyy-MM-dd"));
        }

        private void btnDownload_MouseEnter(object sender, EventArgs e)
        {
            btnDownload.BackColor = Color.FromArgb(14, 102, 85);
        }

        private void btnDownload_MouseLeave(object sender, EventArgs e)
        {
            btnDownload.BackColor = Color.FromArgb(26, 188, 156);
        }
    }
}
