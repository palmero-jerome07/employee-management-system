namespace EmployeeManagementSystem
{
    partial class frmMotherForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMotherForm));
            pnlSideMenu = new Panel();
            btnSettings = new Button();
            lblFooter = new Label();
            btnAddEmp = new Button();
            btnMasterData = new Button();
            panel1 = new Panel();
            pnlInformation = new Panel();
            picBox1 = new PictureBox();
            lblAge = new Label();
            lblSection = new Label();
            lblFullName = new Label();
            pnlTitleBar = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblHeader = new Label();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            pnlStage = new Panel();
            lblWelcome = new Label();
            TTminimize = new ToolTip(components);
            TTmaximize = new ToolTip(components);
            TTclose = new ToolTip(components);
            TTmasterData = new ToolTip(components);
            TTinsertUpdateEmployee = new ToolTip(components);
            TTversion = new ToolTip(components);
            TTfooter = new ToolTip(components);
            TTsettings = new ToolTip(components);
            pnlSideMenu.SuspendLayout();
            pnlInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBox1).BeginInit();
            pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlStage.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            resources.ApplyResources(pnlSideMenu, "pnlSideMenu");
            pnlSideMenu.BackColor = Color.FromArgb(43, 77, 95);
            pnlSideMenu.BorderStyle = BorderStyle.FixedSingle;
            pnlSideMenu.Controls.Add(btnSettings);
            pnlSideMenu.Controls.Add(lblFooter);
            pnlSideMenu.Controls.Add(btnAddEmp);
            pnlSideMenu.Controls.Add(btnMasterData);
            pnlSideMenu.Controls.Add(panel1);
            pnlSideMenu.Controls.Add(pnlInformation);
            pnlSideMenu.Name = "pnlSideMenu";
            TTmasterData.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip"));
            TTfooter.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip1"));
            TTversion.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip2"));
            TTinsertUpdateEmployee.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip3"));
            TTsettings.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip4"));
            TTmaximize.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip5"));
            TTclose.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip6"));
            TTminimize.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip7"));
            // 
            // btnSettings
            // 
            resources.ApplyResources(btnSettings, "btnSettings");
            btnSettings.BackColor = Color.FromArgb(43, 77, 95);
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = Properties.Resources.settings;
            btnSettings.Name = "btnSettings";
            TTmasterData.SetToolTip(btnSettings, resources.GetString("btnSettings.ToolTip"));
            TTminimize.SetToolTip(btnSettings, resources.GetString("btnSettings.ToolTip1"));
            TTmaximize.SetToolTip(btnSettings, resources.GetString("btnSettings.ToolTip2"));
            TTinsertUpdateEmployee.SetToolTip(btnSettings, resources.GetString("btnSettings.ToolTip3"));
            TTversion.SetToolTip(btnSettings, resources.GetString("btnSettings.ToolTip4"));
            TTclose.SetToolTip(btnSettings, resources.GetString("btnSettings.ToolTip5"));
            TTfooter.SetToolTip(btnSettings, resources.GetString("btnSettings.ToolTip6"));
            TTsettings.SetToolTip(btnSettings, resources.GetString("btnSettings.ToolTip7"));
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            btnSettings.MouseEnter += btnSettings_MouseEnter;
            btnSettings.MouseLeave += btnSettings_MouseLeave;
            // 
            // lblFooter
            // 
            resources.ApplyResources(lblFooter, "lblFooter");
            lblFooter.BackColor = Color.Transparent;
            lblFooter.ForeColor = SystemColors.AppWorkspace;
            lblFooter.Name = "lblFooter";
            TTclose.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip"));
            TTmasterData.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip1"));
            TTminimize.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip2"));
            TTmaximize.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip3"));
            TTinsertUpdateEmployee.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip4"));
            TTversion.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip5"));
            TTfooter.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip6"));
            TTsettings.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip7"));
            // 
            // btnAddEmp
            // 
            resources.ApplyResources(btnAddEmp, "btnAddEmp");
            btnAddEmp.BackColor = Color.FromArgb(43, 77, 95);
            btnAddEmp.Cursor = Cursors.Hand;
            btnAddEmp.FlatAppearance.BorderSize = 0;
            btnAddEmp.ForeColor = Color.White;
            btnAddEmp.Name = "btnAddEmp";
            TTmasterData.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip"));
            TTminimize.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip1"));
            TTmaximize.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip2"));
            TTinsertUpdateEmployee.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip3"));
            TTversion.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip4"));
            TTclose.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip5"));
            TTfooter.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip6"));
            TTsettings.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip7"));
            btnAddEmp.UseVisualStyleBackColor = false;
            btnAddEmp.Click += btnAddEmp_Click;
            btnAddEmp.MouseEnter += btnAddEmp_MouseEnter;
            btnAddEmp.MouseLeave += btnAddEmp_MouseLeave;
            // 
            // btnMasterData
            // 
            resources.ApplyResources(btnMasterData, "btnMasterData");
            btnMasterData.BackColor = Color.FromArgb(43, 77, 95);
            btnMasterData.Cursor = Cursors.Hand;
            btnMasterData.FlatAppearance.BorderSize = 0;
            btnMasterData.ForeColor = Color.White;
            btnMasterData.Name = "btnMasterData";
            TTmasterData.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip"));
            TTminimize.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip1"));
            TTmaximize.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip2"));
            TTinsertUpdateEmployee.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip3"));
            TTversion.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip4"));
            TTclose.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip5"));
            TTfooter.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip6"));
            TTsettings.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip7"));
            btnMasterData.UseVisualStyleBackColor = false;
            btnMasterData.Click += btnMasterData_Click;
            btnMasterData.MouseEnter += btnMasterData_MouseEnter;
            btnMasterData.MouseLeave += btnMasterData_MouseLeave;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            TTmasterData.SetToolTip(panel1, resources.GetString("panel1.ToolTip"));
            TTfooter.SetToolTip(panel1, resources.GetString("panel1.ToolTip1"));
            TTversion.SetToolTip(panel1, resources.GetString("panel1.ToolTip2"));
            TTinsertUpdateEmployee.SetToolTip(panel1, resources.GetString("panel1.ToolTip3"));
            TTsettings.SetToolTip(panel1, resources.GetString("panel1.ToolTip4"));
            TTmaximize.SetToolTip(panel1, resources.GetString("panel1.ToolTip5"));
            TTclose.SetToolTip(panel1, resources.GetString("panel1.ToolTip6"));
            TTminimize.SetToolTip(panel1, resources.GetString("panel1.ToolTip7"));
            // 
            // pnlInformation
            // 
            resources.ApplyResources(pnlInformation, "pnlInformation");
            pnlInformation.BackColor = Color.FromArgb(43, 77, 95);
            pnlInformation.Controls.Add(picBox1);
            pnlInformation.Controls.Add(lblAge);
            pnlInformation.Controls.Add(lblSection);
            pnlInformation.Controls.Add(lblFullName);
            pnlInformation.Name = "pnlInformation";
            TTmasterData.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip"));
            TTfooter.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip1"));
            TTversion.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip2"));
            TTinsertUpdateEmployee.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip3"));
            TTsettings.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip4"));
            TTmaximize.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip5"));
            TTclose.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip6"));
            TTminimize.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip7"));
            // 
            // picBox1
            // 
            resources.ApplyResources(picBox1, "picBox1");
            picBox1.Image = Properties.Resources.account_circle_64dp_E3E3E3;
            picBox1.Name = "picBox1";
            picBox1.TabStop = false;
            TTversion.SetToolTip(picBox1, resources.GetString("picBox1.ToolTip"));
            TTclose.SetToolTip(picBox1, resources.GetString("picBox1.ToolTip1"));
            TTmasterData.SetToolTip(picBox1, resources.GetString("picBox1.ToolTip2"));
            TTminimize.SetToolTip(picBox1, resources.GetString("picBox1.ToolTip3"));
            TTmaximize.SetToolTip(picBox1, resources.GetString("picBox1.ToolTip4"));
            TTinsertUpdateEmployee.SetToolTip(picBox1, resources.GetString("picBox1.ToolTip5"));
            TTfooter.SetToolTip(picBox1, resources.GetString("picBox1.ToolTip6"));
            TTsettings.SetToolTip(picBox1, resources.GetString("picBox1.ToolTip7"));
            // 
            // lblAge
            // 
            resources.ApplyResources(lblAge, "lblAge");
            lblAge.AutoEllipsis = true;
            lblAge.ForeColor = Color.White;
            lblAge.Name = "lblAge";
            TTclose.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip"));
            TTmasterData.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip1"));
            TTminimize.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip2"));
            TTmaximize.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip3"));
            TTinsertUpdateEmployee.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip4"));
            TTversion.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip5"));
            TTfooter.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip6"));
            TTsettings.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip7"));
            // 
            // lblSection
            // 
            resources.ApplyResources(lblSection, "lblSection");
            lblSection.AutoEllipsis = true;
            lblSection.ForeColor = Color.White;
            lblSection.Name = "lblSection";
            TTclose.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip"));
            TTmasterData.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip1"));
            TTminimize.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip2"));
            TTmaximize.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip3"));
            TTinsertUpdateEmployee.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip4"));
            TTversion.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip5"));
            TTfooter.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip6"));
            TTsettings.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip7"));
            // 
            // lblFullName
            // 
            resources.ApplyResources(lblFullName, "lblFullName");
            lblFullName.AutoEllipsis = true;
            lblFullName.ForeColor = Color.White;
            lblFullName.Name = "lblFullName";
            TTclose.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip"));
            TTmasterData.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip1"));
            TTminimize.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip2"));
            TTmaximize.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip3"));
            TTinsertUpdateEmployee.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip4"));
            TTversion.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip5"));
            TTfooter.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip6"));
            TTsettings.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip7"));
            // 
            // pnlTitleBar
            // 
            resources.ApplyResources(pnlTitleBar, "pnlTitleBar");
            pnlTitleBar.BackColor = Color.FromArgb(39, 58, 74);
            pnlTitleBar.BorderStyle = BorderStyle.FixedSingle;
            pnlTitleBar.Controls.Add(label1);
            pnlTitleBar.Controls.Add(pictureBox1);
            pnlTitleBar.Controls.Add(lblHeader);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Controls.Add(btnMaximize);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Name = "pnlTitleBar";
            TTmasterData.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip"));
            TTfooter.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip1"));
            TTversion.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip2"));
            TTinsertUpdateEmployee.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip3"));
            TTsettings.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip4"));
            TTmaximize.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip5"));
            TTclose.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip6"));
            TTminimize.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip7"));
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Help;
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Name = "label1";
            TTclose.SetToolTip(label1, resources.GetString("label1.ToolTip"));
            TTmasterData.SetToolTip(label1, resources.GetString("label1.ToolTip1"));
            TTminimize.SetToolTip(label1, resources.GetString("label1.ToolTip2"));
            TTmaximize.SetToolTip(label1, resources.GetString("label1.ToolTip3"));
            TTinsertUpdateEmployee.SetToolTip(label1, resources.GetString("label1.ToolTip4"));
            TTversion.SetToolTip(label1, resources.GetString("label1.ToolTip5"));
            TTfooter.SetToolTip(label1, resources.GetString("label1.ToolTip6"));
            TTsettings.SetToolTip(label1, resources.GetString("label1.ToolTip7"));
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            TTversion.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            TTclose.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip1"));
            TTmasterData.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip2"));
            TTminimize.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip3"));
            TTmaximize.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip4"));
            TTinsertUpdateEmployee.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip5"));
            TTfooter.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip6"));
            TTsettings.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip7"));
            pictureBox1.MouseDown += pictureBox1_Click;
            // 
            // lblHeader
            // 
            resources.ApplyResources(lblHeader, "lblHeader");
            lblHeader.ForeColor = Color.White;
            lblHeader.Name = "lblHeader";
            TTclose.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip"));
            TTmasterData.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip1"));
            TTminimize.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip2"));
            TTmaximize.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip3"));
            TTinsertUpdateEmployee.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip4"));
            TTversion.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip5"));
            TTfooter.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip6"));
            TTsettings.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip7"));
            lblHeader.MouseDown += LblHeader_Click;
            // 
            // btnClose
            // 
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Name = "btnClose";
            TTmasterData.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip"));
            TTminimize.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip1"));
            TTmaximize.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip2"));
            TTinsertUpdateEmployee.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip3"));
            TTversion.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip4"));
            TTclose.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip5"));
            TTfooter.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip6"));
            TTsettings.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip7"));
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // btnMaximize
            // 
            resources.ApplyResources(btnMaximize, "btnMaximize");
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.Name = "btnMaximize";
            TTmasterData.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip"));
            TTminimize.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip1"));
            TTmaximize.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip2"));
            TTinsertUpdateEmployee.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip3"));
            TTversion.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip4"));
            TTclose.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip5"));
            TTfooter.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip6"));
            TTsettings.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip7"));
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            btnMaximize.MouseEnter += btnMaximize_MouseEnter;
            btnMaximize.MouseLeave += btnMaximize_MouseLeave;
            // 
            // btnMinimize
            // 
            resources.ApplyResources(btnMinimize, "btnMinimize");
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.Name = "btnMinimize";
            TTmasterData.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip"));
            TTminimize.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip1"));
            TTmaximize.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip2"));
            TTinsertUpdateEmployee.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip3"));
            TTversion.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip4"));
            TTclose.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip5"));
            TTfooter.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip6"));
            TTsettings.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip7"));
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            btnMinimize.MouseEnter += btnMinimize_MouseEnter;
            btnMinimize.MouseLeave += btnMinimize_MouseLeave;
            // 
            // pnlStage
            // 
            resources.ApplyResources(pnlStage, "pnlStage");
            pnlStage.BackColor = Color.FromArgb(245, 246, 250);
            pnlStage.Controls.Add(lblWelcome);
            pnlStage.Name = "pnlStage";
            TTmasterData.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip"));
            TTfooter.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip1"));
            TTversion.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip2"));
            TTinsertUpdateEmployee.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip3"));
            TTsettings.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip4"));
            TTmaximize.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip5"));
            TTclose.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip6"));
            TTminimize.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip7"));
            pnlStage.MouseEnter += pnlStage_MouseEnter;
            pnlStage.MouseLeave += pnlStage_MouseLeave;
            // 
            // lblWelcome
            // 
            resources.ApplyResources(lblWelcome, "lblWelcome");
            lblWelcome.ForeColor = Color.FromArgb(43, 77, 95);
            lblWelcome.Name = "lblWelcome";
            TTclose.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip"));
            TTmasterData.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip1"));
            TTminimize.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip2"));
            TTmaximize.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip3"));
            TTinsertUpdateEmployee.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip4"));
            TTversion.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip5"));
            TTfooter.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip6"));
            TTsettings.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip7"));
            // 
            // frmMotherForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(pnlStage);
            Controls.Add(pnlSideMenu);
            Controls.Add(pnlTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMotherForm";
            TTmaximize.SetToolTip(this, resources.GetString("$this.ToolTip"));
            TTfooter.SetToolTip(this, resources.GetString("$this.ToolTip1"));
            TTsettings.SetToolTip(this, resources.GetString("$this.ToolTip2"));
            TTinsertUpdateEmployee.SetToolTip(this, resources.GetString("$this.ToolTip3"));
            TTversion.SetToolTip(this, resources.GetString("$this.ToolTip4"));
            TTclose.SetToolTip(this, resources.GetString("$this.ToolTip5"));
            TTmasterData.SetToolTip(this, resources.GetString("$this.ToolTip6"));
            TTminimize.SetToolTip(this, resources.GetString("$this.ToolTip7"));
            Load += frmMotherForm_Load;
            pnlSideMenu.ResumeLayout(false);
            pnlSideMenu.PerformLayout();
            pnlInformation.ResumeLayout(false);
            pnlInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBox1).EndInit();
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlStage.ResumeLayout(false);
            pnlStage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideMenu;
        private Panel panel1;
        private Panel pnlTitleBar;
        private Button btnMinimize;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMasterData;
        private Button btnAddEmp;
        private Panel pnlStage;
        private Label lblFooter;
        private Label lblHeader;
        private PictureBox pictureBox1;
        private Label label1;
        private ToolTip TTminimize;
        private ToolTip TTmaximize;
        private ToolTip TTclose;
        private ToolTip TTmasterData;
        private ToolTip TTinsertUpdateEmployee;
        private ToolTip TTversion;
        private ToolTip TTfooter;
        private Panel pnlInformation;
        private Label lblAge;
        private Label lblSection;
        private Label lblFullName;
        private Label lblWelcome;
        private Button btnSettings;
        private ToolTip TTsettings;
        private PictureBox picBox1;
    }
}
