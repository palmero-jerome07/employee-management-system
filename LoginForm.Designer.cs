namespace EmployeeManagementSystem
{
    partial class LoginForm
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
            lblHeader = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            linklblCreateAccount = new LinkLabel();
            pnlHead = new Panel();
            label1 = new Label();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            pnlHead.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(157, 48);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(164, 86);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "EMS";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(65, 147);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(81, 21);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(70, 194);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 21);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(152, 147);
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(262, 23);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(152, 194);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(262, 23);
            txtPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(350, 233);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(64, 26);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // linklblCreateAccount
            // 
            linklblCreateAccount.AutoSize = true;
            linklblCreateAccount.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linklblCreateAccount.ForeColor = Color.White;
            linklblCreateAccount.LinkColor = Color.White;
            linklblCreateAccount.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            linklblCreateAccount.Location = new Point(311, 262);
            linklblCreateAccount.Name = "linklblCreateAccount";
            linklblCreateAccount.Size = new Size(103, 15);
            linklblCreateAccount.TabIndex = 7;
            linklblCreateAccount.TabStop = true;
            linklblCreateAccount.Text = "Create an account";
            // 
            // pnlHead
            // 
            pnlHead.BackColor = Color.FromArgb(39, 58, 74);
            pnlHead.Controls.Add(label1);
            pnlHead.Controls.Add(btnMinimize);
            pnlHead.Controls.Add(btnMaximize);
            pnlHead.Controls.Add(btnClose);
            pnlHead.Dock = DockStyle.Top;
            pnlHead.Location = new Point(0, 0);
            pnlHead.Name = "pnlHead";
            pnlHead.Size = new Size(488, 28);
            pnlHead.TabIndex = 8;
            pnlHead.MouseDown += pnlHead_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 8);
            label1.Name = "label1";
            label1.Size = new Size(253, 13);
            label1.TabIndex = 11;
            label1.Text = "Employee Management System Login";
            label1.MouseDown += label1_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinimize.Location = new Point(362, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(42, 28);
            btnMinimize.TabIndex = 10;
            btnMinimize.Text = "━";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Enabled = false;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMaximize.Location = new Point(404, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(42, 28);
            btnMaximize.TabIndex = 9;
            btnMaximize.Text = "🗖";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(446, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(42, 28);
            btnClose.TabIndex = 0;
            btnClose.Text = "🗙";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 77, 95);
            ClientSize = new Size(488, 311);
            Controls.Add(pnlHead);
            Controls.Add(linklblCreateAccount);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblHeader);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            pnlHead.ResumeLayout(false);
            pnlHead.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel linklblCreateAccount;
        private Panel pnlHead;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private Label label1;
    }
}