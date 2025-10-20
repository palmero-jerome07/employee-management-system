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
            TTfullname = new ToolTip(components);
            TTsection = new ToolTip(components);
            TTage = new ToolTip(components);
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
            TTfullname.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip1"));
            TTage.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip2"));
            TTsection.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip3"));
            TTmaximize.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip4"));
            TTminimize.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip5"));
            TTfooter.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip6"));
            TTclose.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip7"));
            TTversion.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip8"));
            TTinsertUpdateEmployee.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip9"));
            TTsettings.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip10"));
            // 
            // btnSettings
            // 
            resources.ApplyResources(btnSettings, "btnSettings");
            btnSettings.BackColor = Color.FromArgb(43, 77, 95);
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = Properties.Resources.setting;
            btnSettings.Name = "btnSettings";
            TTsection.SetToolTip(btnSettings, resources.GetString("btnSettings.ToolTip"));
            TTfooter.SetToolTip(btnSettings, resources.GetString("btnSettings.ToolTip1"));
            TTsettings.SetToolTip(btnSettings, resources.GetString("btnSettings.ToolTip2"));
            TTinsertUpdateEmployee.SetToolTip(btnSettings, resources.GetString("btnSettings.ToolTip3"));
            TTversion.SetToolTip(btnSettings, resources.GetString("btnSettings.ToolTip4"));
            TTclose.SetToolTip(btnSettings, resources.GetString("btnSettings.ToolTip5"));
            TTmasterData.SetToolTip(btnSettings, resources.GetString("btnSettings.ToolTip6"));
            TTminimize.SetToolTip(btnSettings, resources.GetString("btnSettings.ToolTip7"));
            TTmaximize.SetToolTip(btnSettings, resources.GetString("btnSettings.ToolTip8"));
            TTage.SetToolTip(btnSettings, resources.GetString("btnSettings.ToolTip9"));
            TTfullname.SetToolTip(btnSettings, resources.GetString("btnSettings.ToolTip10"));
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
            TTfooter.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip"));
            TTsettings.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip1"));
            TTinsertUpdateEmployee.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip2"));
            TTversion.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip3"));
            TTclose.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip4"));
            TTmasterData.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip5"));
            TTminimize.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip6"));
            TTsection.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip7"));
            TTage.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip8"));
            TTfullname.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip9"));
            TTmaximize.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip10"));
            // 
            // btnAddEmp
            // 
            resources.ApplyResources(btnAddEmp, "btnAddEmp");
            btnAddEmp.BackColor = Color.FromArgb(43, 77, 95);
            btnAddEmp.Cursor = Cursors.Hand;
            btnAddEmp.FlatAppearance.BorderSize = 0;
            btnAddEmp.ForeColor = Color.White;
            btnAddEmp.Image = Properties.Resources.person;
            btnAddEmp.Name = "btnAddEmp";
            TTsection.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip"));
            TTfooter.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip1"));
            TTsettings.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip2"));
            TTinsertUpdateEmployee.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip3"));
            TTversion.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip4"));
            TTclose.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip5"));
            TTmasterData.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip6"));
            TTminimize.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip7"));
            TTmaximize.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip8"));
            TTage.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip9"));
            TTfullname.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip10"));
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
            btnMasterData.Image = Properties.Resources.folder1;
            btnMasterData.Name = "btnMasterData";
            TTsection.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip"));
            TTfooter.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip1"));
            TTsettings.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip2"));
            TTinsertUpdateEmployee.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip3"));
            TTversion.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip4"));
            TTclose.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip5"));
            TTmasterData.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip6"));
            TTminimize.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip7"));
            TTmaximize.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip8"));
            TTage.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip9"));
            TTfullname.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip10"));
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
            TTfullname.SetToolTip(panel1, resources.GetString("panel1.ToolTip1"));
            TTage.SetToolTip(panel1, resources.GetString("panel1.ToolTip2"));
            TTsection.SetToolTip(panel1, resources.GetString("panel1.ToolTip3"));
            TTmaximize.SetToolTip(panel1, resources.GetString("panel1.ToolTip4"));
            TTminimize.SetToolTip(panel1, resources.GetString("panel1.ToolTip5"));
            TTfooter.SetToolTip(panel1, resources.GetString("panel1.ToolTip6"));
            TTclose.SetToolTip(panel1, resources.GetString("panel1.ToolTip7"));
            TTversion.SetToolTip(panel1, resources.GetString("panel1.ToolTip8"));
            TTinsertUpdateEmployee.SetToolTip(panel1, resources.GetString("panel1.ToolTip9"));
            TTsettings.SetToolTip(panel1, resources.GetString("panel1.ToolTip10"));
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
            TTfullname.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip1"));
            TTage.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip2"));
            TTsection.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip3"));
            TTmaximize.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip4"));
            TTminimize.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip5"));
            TTfooter.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip6"));
            TTclose.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip7"));
            TTversion.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip8"));
            TTinsertUpdateEmployee.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip9"));
            TTsettings.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip10"));
            // 
            // picBox1
            // 
            resources.ApplyResources(picBox1, "picBox1");
            picBox1.Image = Properties.Resources.account_circle_64dp_E3E3E3;
            picBox1.Name = "picBox1";
            picBox1.TabStop = false;
            TTsection.SetToolTip(picBox1, resources.GetString("picBox1.ToolTip"));
            TTfooter.SetToolTip(picBox1, resources.GetString("picBox1.ToolTip1"));
            TTsettings.SetToolTip(picBox1, resources.GetString("picBox1.ToolTip2"));
            TTinsertUpdateEmployee.SetToolTip(picBox1, resources.GetString("picBox1.ToolTip3"));
            TTversion.SetToolTip(picBox1, resources.GetString("picBox1.ToolTip4"));
            TTclose.SetToolTip(picBox1, resources.GetString("picBox1.ToolTip5"));
            TTmasterData.SetToolTip(picBox1, resources.GetString("picBox1.ToolTip6"));
            TTminimize.SetToolTip(picBox1, resources.GetString("picBox1.ToolTip7"));
            TTage.SetToolTip(picBox1, resources.GetString("picBox1.ToolTip8"));
            TTfullname.SetToolTip(picBox1, resources.GetString("picBox1.ToolTip9"));
            TTmaximize.SetToolTip(picBox1, resources.GetString("picBox1.ToolTip10"));
            // 
            // lblAge
            // 
            resources.ApplyResources(lblAge, "lblAge");
            lblAge.AutoEllipsis = true;
            lblAge.ForeColor = Color.White;
            lblAge.Name = "lblAge";
            TTfooter.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip"));
            TTsettings.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip1"));
            TTinsertUpdateEmployee.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip2"));
            TTversion.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip3"));
            TTclose.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip4"));
            TTmasterData.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip5"));
            TTminimize.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip6"));
            TTsection.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip7"));
            TTage.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip8"));
            TTfullname.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip9"));
            TTmaximize.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip10"));
            // 
            // lblSection
            // 
            resources.ApplyResources(lblSection, "lblSection");
            lblSection.AutoEllipsis = true;
            lblSection.ForeColor = Color.White;
            lblSection.Name = "lblSection";
            TTfooter.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip"));
            TTsettings.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip1"));
            TTinsertUpdateEmployee.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip2"));
            TTversion.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip3"));
            TTclose.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip4"));
            TTmasterData.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip5"));
            TTminimize.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip6"));
            TTsection.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip7"));
            TTage.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip8"));
            TTfullname.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip9"));
            TTmaximize.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip10"));
            // 
            // lblFullName
            // 
            resources.ApplyResources(lblFullName, "lblFullName");
            lblFullName.AutoEllipsis = true;
            lblFullName.ForeColor = Color.White;
            lblFullName.Name = "lblFullName";
            TTfooter.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip"));
            TTsettings.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip1"));
            TTinsertUpdateEmployee.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip2"));
            TTversion.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip3"));
            TTclose.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip4"));
            TTmasterData.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip5"));
            TTminimize.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip6"));
            TTsection.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip7"));
            TTage.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip8"));
            TTfullname.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip9"));
            TTmaximize.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip10"));
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
            TTfullname.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip1"));
            TTage.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip2"));
            TTsection.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip3"));
            TTmaximize.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip4"));
            TTminimize.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip5"));
            TTfooter.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip6"));
            TTclose.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip7"));
            TTversion.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip8"));
            TTinsertUpdateEmployee.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip9"));
            TTsettings.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip10"));
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Help;
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Name = "label1";
            TTfooter.SetToolTip(label1, resources.GetString("label1.ToolTip"));
            TTsettings.SetToolTip(label1, resources.GetString("label1.ToolTip1"));
            TTinsertUpdateEmployee.SetToolTip(label1, resources.GetString("label1.ToolTip2"));
            TTversion.SetToolTip(label1, resources.GetString("label1.ToolTip3"));
            TTclose.SetToolTip(label1, resources.GetString("label1.ToolTip4"));
            TTmasterData.SetToolTip(label1, resources.GetString("label1.ToolTip5"));
            TTminimize.SetToolTip(label1, resources.GetString("label1.ToolTip6"));
            TTsection.SetToolTip(label1, resources.GetString("label1.ToolTip7"));
            TTage.SetToolTip(label1, resources.GetString("label1.ToolTip8"));
            TTfullname.SetToolTip(label1, resources.GetString("label1.ToolTip9"));
            TTmaximize.SetToolTip(label1, resources.GetString("label1.ToolTip10"));
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            TTsection.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            TTfooter.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip1"));
            TTsettings.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip2"));
            TTinsertUpdateEmployee.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip3"));
            TTversion.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip4"));
            TTclose.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip5"));
            TTmasterData.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip6"));
            TTminimize.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip7"));
            TTage.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip8"));
            TTfullname.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip9"));
            TTmaximize.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip10"));
            pictureBox1.MouseDown += pictureBox1_Click;
            // 
            // lblHeader
            // 
            resources.ApplyResources(lblHeader, "lblHeader");
            lblHeader.ForeColor = Color.White;
            lblHeader.Name = "lblHeader";
            TTfooter.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip"));
            TTsettings.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip1"));
            TTinsertUpdateEmployee.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip2"));
            TTversion.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip3"));
            TTclose.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip4"));
            TTmasterData.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip5"));
            TTminimize.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip6"));
            TTsection.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip7"));
            TTage.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip8"));
            TTfullname.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip9"));
            TTmaximize.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip10"));
            lblHeader.MouseDown += LblHeader_Click;
            // 
            // btnClose
            // 
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Name = "btnClose";
            TTsection.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip"));
            TTfooter.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip1"));
            TTsettings.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip2"));
            TTinsertUpdateEmployee.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip3"));
            TTversion.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip4"));
            TTclose.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip5"));
            TTmasterData.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip6"));
            TTminimize.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip7"));
            TTmaximize.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip8"));
            TTage.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip9"));
            TTfullname.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip10"));
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
            TTsection.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip"));
            TTfooter.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip1"));
            TTsettings.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip2"));
            TTinsertUpdateEmployee.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip3"));
            TTversion.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip4"));
            TTclose.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip5"));
            TTmasterData.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip6"));
            TTminimize.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip7"));
            TTmaximize.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip8"));
            TTage.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip9"));
            TTfullname.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip10"));
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
            TTsection.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip"));
            TTfooter.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip1"));
            TTsettings.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip2"));
            TTinsertUpdateEmployee.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip3"));
            TTversion.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip4"));
            TTclose.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip5"));
            TTmasterData.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip6"));
            TTminimize.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip7"));
            TTmaximize.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip8"));
            TTage.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip9"));
            TTfullname.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip10"));
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
            TTfullname.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip1"));
            TTage.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip2"));
            TTsection.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip3"));
            TTmaximize.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip4"));
            TTminimize.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip5"));
            TTfooter.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip6"));
            TTclose.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip7"));
            TTversion.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip8"));
            TTinsertUpdateEmployee.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip9"));
            TTsettings.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip10"));
            pnlStage.MouseEnter += pnlStage_MouseEnter;
            pnlStage.MouseLeave += pnlStage_MouseLeave;
            // 
            // lblWelcome
            // 
            resources.ApplyResources(lblWelcome, "lblWelcome");
            lblWelcome.ForeColor = Color.FromArgb(43, 77, 95);
            lblWelcome.Name = "lblWelcome";
            TTfooter.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip"));
            TTsettings.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip1"));
            TTinsertUpdateEmployee.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip2"));
            TTversion.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip3"));
            TTclose.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip4"));
            TTmasterData.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip5"));
            TTminimize.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip6"));
            TTsection.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip7"));
            TTage.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip8"));
            TTfullname.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip9"));
            TTmaximize.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip10"));
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
            TTminimize.SetToolTip(this, resources.GetString("$this.ToolTip"));
            TTage.SetToolTip(this, resources.GetString("$this.ToolTip1"));
            TTfullname.SetToolTip(this, resources.GetString("$this.ToolTip2"));
            TTsection.SetToolTip(this, resources.GetString("$this.ToolTip3"));
            TTfooter.SetToolTip(this, resources.GetString("$this.ToolTip4"));
            TTsettings.SetToolTip(this, resources.GetString("$this.ToolTip5"));
            TTinsertUpdateEmployee.SetToolTip(this, resources.GetString("$this.ToolTip6"));
            TTversion.SetToolTip(this, resources.GetString("$this.ToolTip7"));
            TTclose.SetToolTip(this, resources.GetString("$this.ToolTip8"));
            TTmaximize.SetToolTip(this, resources.GetString("$this.ToolTip9"));
            TTmasterData.SetToolTip(this, resources.GetString("$this.ToolTip10"));
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
        private ToolTip TTsection;
        private ToolTip TTage;
        private ToolTip TTfullname;
    }
}
