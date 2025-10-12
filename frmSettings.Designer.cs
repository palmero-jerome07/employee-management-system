namespace EmployeeManagementSystem
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tpage = new TabControl();
            tpageUserRegistration = new TabPage();
            dgvUsers = new DataGridView();
            pnlSideBar = new Panel();
            lblNumber = new Label();
            lblMatch = new Label();
            cbSection = new ComboBox();
            lblConPass = new Label();
            lblPassword = new Label();
            lblAge = new Label();
            lblSection = new Label();
            lblFullName = new Label();
            lblUsername = new Label();
            btnExecute = new Button();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtAge = new TextBox();
            txtFullName = new TextBox();
            txtUserName = new TextBox();
            panel1 = new Panel();
            lblHeading = new Label();
            tpageSectionRegistration = new TabPage();
            tpage.SuspendLayout();
            tpageUserRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            pnlSideBar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tpage
            // 
            tpage.Controls.Add(tpageUserRegistration);
            tpage.Controls.Add(tpageSectionRegistration);
            tpage.Dock = DockStyle.Fill;
            tpage.Location = new Point(0, 0);
            tpage.Name = "tpage";
            tpage.SelectedIndex = 0;
            tpage.Size = new Size(1051, 534);
            tpage.TabIndex = 0;
            // 
            // tpageUserRegistration
            // 
            tpageUserRegistration.BackColor = Color.FromArgb(39, 58, 74);
            tpageUserRegistration.Controls.Add(dgvUsers);
            tpageUserRegistration.Controls.Add(pnlSideBar);
            tpageUserRegistration.Controls.Add(panel1);
            tpageUserRegistration.Cursor = Cursors.Hand;
            tpageUserRegistration.ForeColor = Color.White;
            tpageUserRegistration.Location = new Point(4, 24);
            tpageUserRegistration.Name = "tpageUserRegistration";
            tpageUserRegistration.Padding = new Padding(3);
            tpageUserRegistration.Size = new Size(1043, 506);
            tpageUserRegistration.TabIndex = 0;
            tpageUserRegistration.Text = "User Registration";
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = Color.FromArgb(245, 246, 250);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.Location = new Point(263, 31);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(777, 472);
            dgvUsers.TabIndex = 4;
            // 
            // pnlSideBar
            // 
            pnlSideBar.AutoScroll = true;
            pnlSideBar.BackColor = Color.FromArgb(43, 77, 95);
            pnlSideBar.Controls.Add(lblNumber);
            pnlSideBar.Controls.Add(lblMatch);
            pnlSideBar.Controls.Add(cbSection);
            pnlSideBar.Controls.Add(lblConPass);
            pnlSideBar.Controls.Add(lblPassword);
            pnlSideBar.Controls.Add(lblAge);
            pnlSideBar.Controls.Add(lblSection);
            pnlSideBar.Controls.Add(lblFullName);
            pnlSideBar.Controls.Add(lblUsername);
            pnlSideBar.Controls.Add(btnExecute);
            pnlSideBar.Controls.Add(txtConfirmPassword);
            pnlSideBar.Controls.Add(txtPassword);
            pnlSideBar.Controls.Add(txtAge);
            pnlSideBar.Controls.Add(txtFullName);
            pnlSideBar.Controls.Add(txtUserName);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(3, 31);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(260, 472);
            pnlSideBar.TabIndex = 1;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.ForeColor = Color.White;
            lblNumber.Location = new Point(41, 364);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(63, 15);
            lblNumber.TabIndex = 15;
            lblNumber.Text = "✓ Number";
            // 
            // lblMatch
            // 
            lblMatch.AutoSize = true;
            lblMatch.ForeColor = Color.White;
            lblMatch.Location = new Point(41, 342);
            lblMatch.Name = "lblMatch";
            lblMatch.Size = new Size(53, 15);
            lblMatch.TabIndex = 14;
            lblMatch.Text = "✓ Match";
            // 
            // cbSection
            // 
            cbSection.FormattingEnabled = true;
            cbSection.Location = new Point(26, 147);
            cbSection.Name = "cbSection";
            cbSection.Size = new Size(205, 23);
            cbSection.TabIndex = 2;
            // 
            // lblConPass
            // 
            lblConPass.AutoSize = true;
            lblConPass.Font = new Font("Segoe UI", 11.25F);
            lblConPass.ForeColor = Color.White;
            lblConPass.Location = new Point(26, 284);
            lblConPass.Name = "lblConPass";
            lblConPass.Size = new Size(161, 20);
            lblConPass.TabIndex = 12;
            lblConPass.Text = "Password Confirmation";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11.25F);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(26, 230);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Password";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 11.25F);
            lblAge.ForeColor = Color.White;
            lblAge.Location = new Point(26, 177);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(36, 20);
            lblAge.TabIndex = 10;
            lblAge.Text = "Age";
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Font = new Font("Segoe UI", 11.25F);
            lblSection.ForeColor = Color.White;
            lblSection.Location = new Point(26, 127);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(58, 20);
            lblSection.TabIndex = 9;
            lblSection.Text = "Section";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 11.25F);
            lblFullName.ForeColor = Color.White;
            lblFullName.Location = new Point(26, 78);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(69, 20);
            lblFullName.TabIndex = 8;
            lblFullName.Text = "Fullname";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 11.25F);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(26, 29);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Username";
            // 
            // btnExecute
            // 
            btnExecute.BackColor = Color.FromArgb(60, 173, 150);
            btnExecute.FlatStyle = FlatStyle.Flat;
            btnExecute.ForeColor = Color.Black;
            btnExecute.Location = new Point(156, 398);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(75, 26);
            btnExecute.TabIndex = 6;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = false;
            btnExecute.Click += btnExecute_Click_1;
            btnExecute.MouseEnter += btnExecute_MouseEnter;
            btnExecute.MouseLeave += btnExecute_MouseLeave;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(26, 305);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(205, 23);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(26, 251);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(205, 23);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(26, 198);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(205, 23);
            txtAge.TabIndex = 3;
            txtAge.KeyPress += txtAge_KeyPress;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(26, 99);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(205, 23);
            txtFullName.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(26, 50);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(205, 23);
            txtUserName.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 77, 95);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblHeading);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 28);
            panel1.TabIndex = 3;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.Location = new Point(31, 3);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(126, 20);
            lblHeading.TabIndex = 1;
            lblHeading.Text = "User Registration";
            // 
            // tpageSectionRegistration
            // 
            tpageSectionRegistration.BackColor = Color.FromArgb(39, 58, 74);
            tpageSectionRegistration.Cursor = Cursors.Hand;
            tpageSectionRegistration.Location = new Point(4, 24);
            tpageSectionRegistration.Name = "tpageSectionRegistration";
            tpageSectionRegistration.Padding = new Padding(3);
            tpageSectionRegistration.Size = new Size(1043, 506);
            tpageSectionRegistration.TabIndex = 1;
            tpageSectionRegistration.Text = "Section Registration";
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1051, 534);
            Controls.Add(tpage);
            Name = "frmSettings";
            Text = "Settings";
            Load += frmSettings_Load_1;
            tpage.ResumeLayout(false);
            tpageUserRegistration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            pnlSideBar.ResumeLayout(false);
            pnlSideBar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tpage;
        private TabPage tpageUserRegistration;
        private TabPage tpageSectionRegistration;
        private Panel pnlSideBar;
        private Label lblConPass;
        private Label lblPassword;
        private Label lblAge;
        private Label lblSection;
        private Label lblFullName;
        private Label lblUsername;
        private Button btnExecute;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtAge;
        private TextBox txtFullName;
        private TextBox txtUserName;
        private ComboBox cbSection;
        private Label lblNumber;
        private Label lblMatch;
        private Panel panel1;
        private Label lblHeading;
        private DataGridView dgvUsers;
    }
}