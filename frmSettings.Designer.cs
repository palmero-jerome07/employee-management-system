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
            tpageSectionRegistration = new TabPage();
            tpage.SuspendLayout();
            tpageUserRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            pnlSideBar.SuspendLayout();
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
            tpageUserRegistration.Controls.Add(dgvUsers);
            tpageUserRegistration.Controls.Add(pnlSideBar);
            tpageUserRegistration.Location = new Point(4, 24);
            tpageUserRegistration.Name = "tpageUserRegistration";
            tpageUserRegistration.Padding = new Padding(3);
            tpageUserRegistration.Size = new Size(1043, 506);
            tpageUserRegistration.TabIndex = 0;
            tpageUserRegistration.Text = "User Registration";
            tpageUserRegistration.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(263, 3);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ShowCellToolTips = false;
            dgvUsers.Size = new Size(777, 500);
            dgvUsers.TabIndex = 2;
            // 
            // pnlSideBar
            // 
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
            pnlSideBar.Location = new Point(3, 3);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(260, 500);
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
            lblConPass.ForeColor = Color.White;
            lblConPass.Location = new Point(26, 287);
            lblConPass.Name = "lblConPass";
            lblConPass.Size = new Size(131, 15);
            lblConPass.TabIndex = 12;
            lblConPass.Text = "Password Confirmation";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(26, 233);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Password";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.ForeColor = Color.White;
            lblAge.Location = new Point(26, 180);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(28, 15);
            lblAge.TabIndex = 10;
            lblAge.Text = "Age";
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.ForeColor = Color.White;
            lblSection.Location = new Point(26, 129);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(46, 15);
            lblSection.TabIndex = 9;
            lblSection.Text = "Section";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.ForeColor = Color.White;
            lblFullName.Location = new Point(26, 81);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(56, 15);
            lblFullName.TabIndex = 8;
            lblFullName.Text = "Fullname";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(26, 32);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Username";
            // 
            // btnExecute
            // 
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
            txtConfirmPassword.Size = new Size(205, 23);
            txtConfirmPassword.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(26, 251);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(205, 23);
            txtPassword.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(26, 198);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(205, 23);
            txtAge.TabIndex = 3;
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
            // tpageSectionRegistration
            // 
            tpageSectionRegistration.Location = new Point(4, 24);
            tpageSectionRegistration.Name = "tpageSectionRegistration";
            tpageSectionRegistration.Padding = new Padding(3);
            tpageSectionRegistration.Size = new Size(1043, 506);
            tpageSectionRegistration.TabIndex = 1;
            tpageSectionRegistration.Text = "Section Registration";
            tpageSectionRegistration.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 534);
            Controls.Add(tpage);
            Name = "frmSettings";
            Text = "Settings";
            tpage.ResumeLayout(false);
            tpageUserRegistration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            pnlSideBar.ResumeLayout(false);
            pnlSideBar.PerformLayout();
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
    }
}