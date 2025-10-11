using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void btnExecute_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to register?", "Confirmation",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "Insert into [Users] ([UserName], [Password],[Section],[Age], [FullName]) values ('" + txtUserName.Text + "','" + txtPassword.Text + "','" + cbSection.Text + "','" + txtAge.Text + "','" + txtFullName.Text + "')";
                CRUD.CRUD.CUD(query);
                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CRUD.CRUD.RETRIEVEDTG(dgvUsers, "Select * From [Users] ");
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            CRUD.CRUD.RETRIEVECBO(cbSection, "SELECT [ID], [Section] FROM [tblSection] ORDER BY [Section] asc", "Section", "ID");
            CRUD.CRUD.RETRIEVEDTG(dgvUsers, "Select * From [Users]");

            lblNumber.Text = "❌ Number";
            lblNumber.ForeColor = Color.Red;

            lblMatch.Text = "✓ Green";
            lblMatch.ForeColor = Color.Green;
        }
    }
}
