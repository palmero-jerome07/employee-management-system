using static System.Collections.Specialized.BitVector32;
using System.Net.Mail;

namespace EmployeeManagementSystem
{
    public partial class frmMotherForm : Form
    {

        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public frmMotherForm()
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(frmLoginForm.fullname) || string.IsNullOrEmpty(frmLoginForm.section) || string.IsNullOrEmpty(frmLoginForm.age))
            {
                lblFullName.Text = "<FULL NAME>";
                lblSection.Text = "<SECTION>";
                lblAge.Text = "<AGE>";
                return;
            }
            lblFullName.Text = frmLoginForm.fullname;
            lblSection.Text = frmLoginForm.section;
            lblAge.Text = frmLoginForm.age;
            lblWelcome.Text = "WELCOME TO EMPLOYEE \nMANAGEMENT SYSTEM, \n" + frmLoginForm.fullname;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                lblWelcome.Text = "WELCOME TO EMPLOYEE MANAGEMENT SYSTEM, " + frmLoginForm.fullname;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                lblWelcome.Text = "WELCOME TO EMPLOYEE \nMANAGEMENT SYSTEM, \n" + frmLoginForm.fullname;
            }
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Common.ReleaseCapture();
                Common.SendMessage(Handle, Common.WM_NCLBUTTONDOWN, Common.HT_CAPTION, 0);
            }
        }

        private void frmMotherForm_Load(object sender, EventArgs e)
        {
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            lblFooter.Text = $"© {DateTime.Now.Year} EMS. All rights reserved.";
        }

        public void OpenChildForm(Form childform)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pnlStage.Controls.Add(childform);
            pnlStage.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void btnMasterData_Click(object sender, EventArgs e)
        {
            this.Size = new Size(748, 422);
            setDetailsDefault();
            OpenChildForm(new frmMasterData());
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            this.Size = new Size(748, 422);
            setDetailsDefault();
            OpenChildForm(new frmAddEmployee());
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1120, 600);
            OpenChildForm(new frmSettings());
        }

        public void setDetailsDefault()
        {
            frmMasterData.selectedTransaction = "0";
            frmMasterData.RequestorName = "";
            frmMasterData.EmailAddress = "";
            frmMasterData.Section = "";
            frmMasterData.LocalNumber = "";
            frmMasterData.EmployeeNumber = "";
        }

        private void btnMasterData_MouseEnter(object sender, EventArgs e)
        {
            btnMasterData.BackColor = Color.FromArgb(60, 173, 150);
            btnMasterData.ForeColor = Color.Black;
        }

        private void btnMasterData_MouseLeave(object sender, EventArgs e)
        {
            btnMasterData.BackColor = Color.FromArgb(43, 77, 95);
            btnMasterData.ForeColor = Color.White;
        }

        private void btnAddEmp_MouseEnter(object sender, EventArgs e)
        {
            btnAddEmp.BackColor = Color.FromArgb(60, 173, 150);
            btnAddEmp.ForeColor = Color.Black;
        }

        private void btnAddEmp_MouseLeave(object sender, EventArgs e)
        {
            btnAddEmp.BackColor = Color.FromArgb(43, 77, 95);
            btnAddEmp.ForeColor = Color.White;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(231, 76, 60);
            btnClose.ForeColor = Color.White;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
            btnClose.ForeColor = Color.Black;
        }

        private void pnlStage_MouseEnter(object sender, EventArgs e)
        {
            //pnlStage.BackColor = Color.FromArgb(245, 246, 250);
        }

        private void pnlStage_MouseLeave(object sender, EventArgs e)
        {
            //pnlStage.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void LblHeader_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Common.ReleaseCapture();
                Common.SendMessage(Handle, Common.WM_NCLBUTTONDOWN, Common.HT_CAPTION, 0);
            }
        }

        private void pictureBox1_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Common.ReleaseCapture();
                Common.SendMessage(Handle, Common.WM_NCLBUTTONDOWN, Common.HT_CAPTION, 0);
            }
        }

        private void btnMaximize_MouseEnter(object sender, EventArgs e)
        {
            btnMaximize.BackColor = Color.Silver;
        }

        private void btnMaximize_MouseLeave(object sender, EventArgs e)
        {
            btnMaximize.BackColor = Color.Transparent;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.Silver;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.Transparent;
        }

        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(60, 173, 150);
            btnSettings.ForeColor = Color.Black;
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(43, 77, 95);
            btnSettings.ForeColor = Color.White;
        }
    }
}
