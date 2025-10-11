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
            tpage = new TabControl();
            tpageUserRegistration = new TabPage();
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
            dgvUsers = new DataGridView();
            tpageSectionRegistration = new TabPage();
            tpage.SuspendLayout();
            tpageUserRegistration.SuspendLayout();
            pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
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
            tpageUserRegistration.Controls.Add(pnlSideBar);
            tpageUserRegistration.Controls.Add(panel1);
            tpageUserRegistration.Controls.Add(dgvUsers);
            tpageUserRegistration.Cursor = Cursors.Hand;
            tpageUserRegistration.ForeColor = Color.White;
            tpageUserRegistration.Location = new Point(4, 24);
            tpageUserRegistration.Name = "tpageUserRegistration";
            tpageUserRegistration.Padding = new Padding(3);
            tpageUserRegistration.Size = new Size(1043, 506);
            tpageUserRegistration.TabIndex = 0;
            tpageUserRegistration.Text = "User Registration";
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
            pnlSideBar.Location = new Point(3, 34);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(260, 469);
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
            cbSection.TabIndex = 13;
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
            btnExecute.ForeColor = Color.Black;
            btnExecute.Location = new Point(156, 398);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(75, 26);
            btnExecute.TabIndex = 6;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = true;
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
            panel1.BackColor = Color.FromArgb(39, 58, 74);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 31);
            panel1.TabIndex = 3;
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(3, 3);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ShowCellToolTips = false;
            dgvUsers.Size = new Size(1037, 500);
            dgvUsers.TabIndex = 2;
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
            tpage.ResumeLayout(false);
            tpageUserRegistration.ResumeLayout(false);
            pnlSideBar.ResumeLayout(false);
            pnlSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tpage;
        private TabPage tpageUserRegistration;
        private TabPage tpageSectionRegistration;
        private DataGridView dgvUsers;
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
    }
}