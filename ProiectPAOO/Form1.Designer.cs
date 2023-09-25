using System.Drawing;
using System.Windows.Forms;

namespace ProiectPAOO
{
    partial class Form1
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
        /// 

        private void AddPlaceholderToTextBox(System.Windows.Forms.TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = System.Drawing.Color.Gray;

            textBox.Enter += (sender, args) =>
            {
                if (textBox.ForeColor == System.Drawing.Color.Gray)
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
            };

            textBox.Leave += (sender, args) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }




        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.createAccountPanel = new System.Windows.Forms.Panel();
            this.firstnameCreate = new System.Windows.Forms.TextBox();
            this.cancelCreate = new System.Windows.Forms.Button();
            this.createCreate = new System.Windows.Forms.Button();
            this.employeeCode = new System.Windows.Forms.TextBox();
            this.passwordCreate = new System.Windows.Forms.TextBox();
            this.managerCode = new System.Windows.Forms.TextBox();
            this.emailCreate = new System.Windows.Forms.TextBox();
            this.lastnameCreate = new System.Windows.Forms.TextBox();
            this.accountTypeCreate = new System.Windows.Forms.ComboBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reset = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.trackBarMax = new System.Windows.Forms.TrackBar();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.trackBarMin = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.hidePanel = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageShop = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addToCart = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPageManager = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LOGS = new System.Windows.Forms.Panel();
            this.log = new System.Windows.Forms.RichTextBox();
            this.btnLOG = new System.Windows.Forms.Button();
            this.printPDF = new System.Windows.Forms.Button();
            this.employeeHidden1 = new System.Windows.Forms.Panel();
            this.tabControlReports = new System.Windows.Forms.TabControl();
            this.tabPageReportsTable = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPageReportsChart = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.proceed = new System.Windows.Forms.Button();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.tabControlManager = new System.Windows.Forms.TabControl();
            this.tabPageManagerAdd = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.addProdPanel = new System.Windows.Forms.Panel();
            this.textBoxAdd6 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.textBoxAdd5 = new System.Windows.Forms.TextBox();
            this.textBoxAdd4 = new System.Windows.Forms.TextBox();
            this.textBoxAdd3 = new System.Windows.Forms.TextBox();
            this.textBoxAdd2 = new System.Windows.Forms.TextBox();
            this.textBoxAdd1 = new System.Windows.Forms.TextBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageManagerRemove = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.removeProdPanel = new System.Windows.Forms.Panel();
            this.remove = new System.Windows.Forms.Button();
            this.textBoxRemove5 = new System.Windows.Forms.TextBox();
            this.textBoxRemove4 = new System.Windows.Forms.TextBox();
            this.textBoxRemove3 = new System.Windows.Forms.TextBox();
            this.textBoxRemove2 = new System.Windows.Forms.TextBox();
            this.textBoxRemove1 = new System.Windows.Forms.TextBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.login = new System.Windows.Forms.Button();
            this.cancelLogin = new System.Windows.Forms.Button();
            this.passwordLogin = new System.Windows.Forms.TextBox();
            this.createLogin = new System.Windows.Forms.Button();
            this.usernameLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accountTypeLogin = new System.Windows.Forms.ComboBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.createAccountPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMin)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageManager.SuspendLayout();
            this.panel1.SuspendLayout();
            this.LOGS.SuspendLayout();
            this.employeeHidden1.SuspendLayout();
            this.tabControlReports.SuspendLayout();
            this.tabPageReportsTable.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPageReportsChart.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControlManager.SuspendLayout();
            this.tabPageManagerAdd.SuspendLayout();
            this.panel5.SuspendLayout();
            this.addProdPanel.SuspendLayout();
            this.tabPageManagerRemove.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.removeProdPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createAccountPanel
            // 
            this.createAccountPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.createAccountPanel.Controls.Add(this.firstnameCreate);
            this.createAccountPanel.Controls.Add(this.cancelCreate);
            this.createAccountPanel.Controls.Add(this.createCreate);
            this.createAccountPanel.Controls.Add(this.employeeCode);
            this.createAccountPanel.Controls.Add(this.passwordCreate);
            this.createAccountPanel.Controls.Add(this.managerCode);
            this.createAccountPanel.Controls.Add(this.emailCreate);
            this.createAccountPanel.Controls.Add(this.lastnameCreate);
            this.createAccountPanel.Controls.Add(this.accountTypeCreate);
            this.createAccountPanel.Location = new System.Drawing.Point(951, 196);
            this.createAccountPanel.Name = "createAccountPanel";
            this.createAccountPanel.Size = new System.Drawing.Size(147, 252);
            this.createAccountPanel.TabIndex = 4;
            this.createAccountPanel.TabStop = true;
            this.createAccountPanel.Visible = false;
            // 
            // firstnameCreate
            // 
            this.firstnameCreate.Location = new System.Drawing.Point(0, 56);
            this.firstnameCreate.Name = "firstnameCreate";
            this.firstnameCreate.Size = new System.Drawing.Size(144, 20);
            this.firstnameCreate.TabIndex = 8;
            this.firstnameCreate.Text = "Username";
            // 
            // cancelCreate
            // 
            this.cancelCreate.BackColor = System.Drawing.Color.SeaGreen;
            this.cancelCreate.ForeColor = System.Drawing.Color.White;
            this.cancelCreate.Location = new System.Drawing.Point(77, 215);
            this.cancelCreate.Name = "cancelCreate";
            this.cancelCreate.Size = new System.Drawing.Size(70, 23);
            this.cancelCreate.TabIndex = 7;
            this.cancelCreate.Text = "Cancel";
            this.cancelCreate.UseVisualStyleBackColor = false;
            this.cancelCreate.Click += new System.EventHandler(this.cancelCreate_Click);
            // 
            // createCreate
            // 
            this.createCreate.BackColor = System.Drawing.Color.SeaGreen;
            this.createCreate.ForeColor = System.Drawing.Color.White;
            this.createCreate.Location = new System.Drawing.Point(3, 215);
            this.createCreate.Name = "createCreate";
            this.createCreate.Size = new System.Drawing.Size(74, 23);
            this.createCreate.TabIndex = 6;
            this.createCreate.Text = "Create";
            this.createCreate.UseVisualStyleBackColor = false;
            this.createCreate.Click += new System.EventHandler(this.createCreate_Click);
            // 
            // employeeCode
            // 
            this.employeeCode.BackColor = System.Drawing.Color.LightSkyBlue;
            this.employeeCode.Location = new System.Drawing.Point(0, 186);
            this.employeeCode.Name = "employeeCode";
            this.employeeCode.Size = new System.Drawing.Size(144, 20);
            this.employeeCode.TabIndex = 5;
            this.employeeCode.Text = "employee code";
            // 
            // passwordCreate
            // 
            this.passwordCreate.Location = new System.Drawing.Point(0, 108);
            this.passwordCreate.Name = "passwordCreate";
            this.passwordCreate.Size = new System.Drawing.Size(144, 20);
            this.passwordCreate.TabIndex = 4;
            this.passwordCreate.UseSystemPasswordChar = true;
            // 
            // managerCode
            // 
            this.managerCode.BackColor = System.Drawing.Color.SkyBlue;
            this.managerCode.Location = new System.Drawing.Point(0, 160);
            this.managerCode.Name = "managerCode";
            this.managerCode.Size = new System.Drawing.Size(144, 20);
            this.managerCode.TabIndex = 3;
            this.managerCode.Text = "manager code";
            // 
            // emailCreate
            // 
            this.emailCreate.Location = new System.Drawing.Point(0, 134);
            this.emailCreate.Name = "emailCreate";
            this.emailCreate.Size = new System.Drawing.Size(144, 20);
            this.emailCreate.TabIndex = 2;
            this.emailCreate.Text = "email";
            // 
            // lastnameCreate
            // 
            this.lastnameCreate.Location = new System.Drawing.Point(0, 82);
            this.lastnameCreate.Name = "lastnameCreate";
            this.lastnameCreate.Size = new System.Drawing.Size(144, 20);
            this.lastnameCreate.TabIndex = 1;
            this.lastnameCreate.Text = "Username";
            // 
            // accountTypeCreate
            // 
            this.accountTypeCreate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.accountTypeCreate.FormattingEnabled = true;
            this.accountTypeCreate.Items.AddRange(new object[] {
            "Customer",
            "Employee",
            "Manager"});
            this.accountTypeCreate.Location = new System.Drawing.Point(3, 12);
            this.accountTypeCreate.Name = "accountTypeCreate";
            this.accountTypeCreate.Size = new System.Drawing.Size(146, 21);
            this.accountTypeCreate.TabIndex = 0;
            this.accountTypeCreate.Text = "Desired Account Type";
            this.accountTypeCreate.SelectedIndexChanged += new System.EventHandler(this.accountTypeCreate_SelectedIndexChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Moccasin;
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.hidePanel);
            this.mainPanel.Controls.Add(this.tabControl);
            this.mainPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainPanel.Location = new System.Drawing.Point(2, 1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1110, 537);
            this.mainPanel.TabIndex = 9;
            this.mainPanel.TabStop = true;
            this.mainPanel.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Aquamarine;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(13, 410);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 73);
            this.panel3.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(3, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 28);
            this.button3.TabIndex = 16;
            this.button3.Text = "Empty Cart";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(133, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 32);
            this.button4.TabIndex = 17;
            this.button4.Text = "Purchase";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.reset);
            this.panel2.Controls.Add(this.priceLabel);
            this.panel2.Controls.Add(this.findTextBox);
            this.panel2.Controls.Add(this.findBtn);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.comboBoxColor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBoxSex);
            this.panel2.Controls.Add(this.trackBarMax);
            this.panel2.Controls.Add(this.comboBoxBrand);
            this.panel2.Controls.Add(this.trackBarMin);
            this.panel2.Location = new System.Drawing.Point(13, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 295);
            this.panel2.TabIndex = 18;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.CornflowerBlue;
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.Location = new System.Drawing.Point(63, 247);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(100, 23);
            this.reset.TabIndex = 15;
            this.reset.Text = "Reset Filters";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(87, 160);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 13);
            this.priceLabel.TabIndex = 15;
            // 
            // findTextBox
            // 
            this.findTextBox.BackColor = System.Drawing.Color.Turquoise;
            this.findTextBox.Location = new System.Drawing.Point(3, 3);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(178, 20);
            this.findTextBox.TabIndex = 1;
            // 
            // findBtn
            // 
            this.findBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.findBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.findBtn.Location = new System.Drawing.Point(187, 1);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(56, 23);
            this.findBtn.TabIndex = 2;
            this.findBtn.Text = "find";
            this.findBtn.UseVisualStyleBackColor = false;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.comboBox1.Location = new System.Drawing.Point(3, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Order (Price)";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.BackColor = System.Drawing.Color.CornflowerBlue;
            this.comboBoxColor.ForeColor = System.Drawing.Color.White;
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Color"});
            this.comboBoxColor.Location = new System.Drawing.Point(133, 54);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(110, 21);
            this.comboBoxColor.TabIndex = 4;
            this.comboBoxColor.Text = "Color";
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Price Range:";
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.BackColor = System.Drawing.Color.CornflowerBlue;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Sex"});
            this.comboBoxSex.Location = new System.Drawing.Point(133, 95);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(110, 21);
            this.comboBoxSex.TabIndex = 6;
            this.comboBoxSex.Text = "Sex";
            this.comboBoxSex.SelectedIndexChanged += new System.EventHandler(this.comboBoxSex_SelectedIndexChanged);
            // 
            // trackBarMax
            // 
            this.trackBarMax.Location = new System.Drawing.Point(3, 196);
            this.trackBarMax.Maximum = 2000;
            this.trackBarMax.Minimum = 100;
            this.trackBarMax.Name = "trackBarMax";
            this.trackBarMax.Size = new System.Drawing.Size(237, 45);
            this.trackBarMax.TabIndex = 12;
            this.trackBarMax.Value = 2000;
            this.trackBarMax.Scroll += new System.EventHandler(this.trackBarMax_Scroll);
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.BackColor = System.Drawing.Color.CornflowerBlue;
            this.comboBoxBrand.ForeColor = System.Drawing.Color.White;
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Items.AddRange(new object[] {
            "Brand"});
            this.comboBoxBrand.Location = new System.Drawing.Point(3, 95);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(110, 21);
            this.comboBoxBrand.TabIndex = 9;
            this.comboBoxBrand.Text = "Brand";
            this.comboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            // 
            // trackBarMin
            // 
            this.trackBarMin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.trackBarMin.Location = new System.Drawing.Point(3, 161);
            this.trackBarMin.Maximum = 2000;
            this.trackBarMin.Name = "trackBarMin";
            this.trackBarMin.Size = new System.Drawing.Size(237, 45);
            this.trackBarMin.TabIndex = 11;
            this.trackBarMin.Scroll += new System.EventHandler(this.trackBarMin_Scroll);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(13, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Log Off..";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hidePanel
            // 
            this.hidePanel.BackColor = System.Drawing.Color.Transparent;
            this.hidePanel.Location = new System.Drawing.Point(318, 51);
            this.hidePanel.Name = "hidePanel";
            this.hidePanel.Size = new System.Drawing.Size(101, 38);
            this.hidePanel.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageShop);
            this.tabControl.Controls.Add(this.tabPageManager);
            this.tabControl.Location = new System.Drawing.Point(267, 69);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(805, 457);
            this.tabControl.TabIndex = 22;
            // 
            // tabPageShop
            // 
            this.tabPageShop.Controls.Add(this.dataGridView1);
            this.tabPageShop.Location = new System.Drawing.Point(4, 22);
            this.tabPageShop.Name = "tabPageShop";
            this.tabPageShop.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShop.Size = new System.Drawing.Size(797, 431);
            this.tabPageShop.TabIndex = 0;
            this.tabPageShop.Text = "Shop";
            this.tabPageShop.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addToCart});
            this.dataGridView1.GridColor = System.Drawing.Color.OliveDrab;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.Size = new System.Drawing.Size(801, 431);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addToCart
            // 
            this.addToCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addToCart.HeaderText = "Add to Cart";
            this.addToCart.Name = "addToCart";
            this.addToCart.ReadOnly = true;
            // 
            // tabPageManager
            // 
            this.tabPageManager.Controls.Add(this.panel1);
            this.tabPageManager.Location = new System.Drawing.Point(4, 22);
            this.tabPageManager.Name = "tabPageManager";
            this.tabPageManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManager.Size = new System.Drawing.Size(797, 431);
            this.tabPageManager.TabIndex = 1;
            this.tabPageManager.Text = "Manager Panel";
            this.tabPageManager.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.LOGS);
            this.panel1.Controls.Add(this.btnLOG);
            this.panel1.Controls.Add(this.printPDF);
            this.panel1.Controls.Add(this.employeeHidden1);
            this.panel1.Controls.Add(this.proceed);
            this.panel1.Controls.Add(this.comboBox7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox6);
            this.panel1.Controls.Add(this.tabControlManager);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 427);
            this.panel1.TabIndex = 0;
            // 
            // LOGS
            // 
            this.LOGS.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.LOGS.Controls.Add(this.log);
            this.LOGS.ForeColor = System.Drawing.SystemColors.Control;
            this.LOGS.Location = new System.Drawing.Point(18, 172);
            this.LOGS.Name = "LOGS";
            this.LOGS.Size = new System.Drawing.Size(766, 245);
            this.LOGS.TabIndex = 21;
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.OliveDrab;
            this.log.ForeColor = System.Drawing.SystemColors.Info;
            this.log.Location = new System.Drawing.Point(3, 3);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(757, 236);
            this.log.TabIndex = 0;
            this.log.Text = "";
            // 
            // btnLOG
            // 
            this.btnLOG.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLOG.ForeColor = System.Drawing.Color.White;
            this.btnLOG.Location = new System.Drawing.Point(678, 134);
            this.btnLOG.Name = "btnLOG";
            this.btnLOG.Size = new System.Drawing.Size(77, 23);
            this.btnLOG.TabIndex = 20;
            this.btnLOG.Text = "LOG";
            this.btnLOG.UseVisualStyleBackColor = false;
            this.btnLOG.Click += new System.EventHandler(this.btnLOG_Click);
            // 
            // printPDF
            // 
            this.printPDF.BackColor = System.Drawing.Color.Crimson;
            this.printPDF.ForeColor = System.Drawing.Color.White;
            this.printPDF.Location = new System.Drawing.Point(581, 134);
            this.printPDF.Name = "printPDF";
            this.printPDF.Size = new System.Drawing.Size(75, 23);
            this.printPDF.TabIndex = 19;
            this.printPDF.Text = "PDF";
            this.printPDF.UseVisualStyleBackColor = false;
            this.printPDF.Click += new System.EventHandler(this.printPDF_Click);
            // 
            // employeeHidden1
            // 
            this.employeeHidden1.Controls.Add(this.tabControlReports);
            this.employeeHidden1.Controls.Add(this.label7);
            this.employeeHidden1.Location = new System.Drawing.Point(18, 200);
            this.employeeHidden1.Name = "employeeHidden1";
            this.employeeHidden1.Size = new System.Drawing.Size(773, 224);
            this.employeeHidden1.TabIndex = 18;
            this.employeeHidden1.Visible = false;
            // 
            // tabControlReports
            // 
            this.tabControlReports.Controls.Add(this.tabPageReportsTable);
            this.tabControlReports.Controls.Add(this.tabPageReportsChart);
            this.tabControlReports.Location = new System.Drawing.Point(3, 25);
            this.tabControlReports.Name = "tabControlReports";
            this.tabControlReports.SelectedIndex = 0;
            this.tabControlReports.Size = new System.Drawing.Size(757, 196);
            this.tabControlReports.TabIndex = 1;
            // 
            // tabPageReportsTable
            // 
            this.tabPageReportsTable.Controls.Add(this.panel7);
            this.tabPageReportsTable.Location = new System.Drawing.Point(4, 22);
            this.tabPageReportsTable.Name = "tabPageReportsTable";
            this.tabPageReportsTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReportsTable.Size = new System.Drawing.Size(749, 170);
            this.tabPageReportsTable.TabIndex = 0;
            this.tabPageReportsTable.Text = "Sales";
            this.tabPageReportsTable.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridView2);
            this.panel7.Location = new System.Drawing.Point(3, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(743, 170);
            this.panel7.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.DarkGreen;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(747, 156);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPageReportsChart
            // 
            this.tabPageReportsChart.Controls.Add(this.panel8);
            this.tabPageReportsChart.Location = new System.Drawing.Point(4, 22);
            this.tabPageReportsChart.Name = "tabPageReportsChart";
            this.tabPageReportsChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReportsChart.Size = new System.Drawing.Size(749, 170);
            this.tabPageReportsChart.TabIndex = 1;
            this.tabPageReportsChart.Text = "Chart";
            this.tabPageReportsChart.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.chart1);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(743, 164);
            this.panel8.TabIndex = 0;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Linen;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(737, 157);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Reports:";
            // 
            // proceed
            // 
            this.proceed.BackColor = System.Drawing.Color.SeaGreen;
            this.proceed.ForeColor = System.Drawing.Color.White;
            this.proceed.Location = new System.Drawing.Point(386, 134);
            this.proceed.Name = "proceed";
            this.proceed.Size = new System.Drawing.Size(75, 23);
            this.proceed.TabIndex = 15;
            this.proceed.Text = "Proceed";
            this.proceed.UseVisualStyleBackColor = false;
            this.proceed.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox7
            // 
            this.comboBox7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "Export",
            "Import"});
            this.comboBox7.Location = new System.Drawing.Point(308, 136);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(72, 21);
            this.comboBox7.TabIndex = 14;
            this.comboBox7.Text = "Select..";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Select a Table";
            // 
            // comboBox6
            // 
            this.comboBox6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Angajati     (Employees)",
            "Clienti        (Customers)",
            "Comenzi    (Orders)",
            "Manageri\t (Managers)",
            "Produse     (Products)"});
            this.comboBox6.Location = new System.Drawing.Point(131, 136);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(147, 21);
            this.comboBox6.TabIndex = 11;
            this.comboBox6.Text = "Select Table...";
            // 
            // tabControlManager
            // 
            this.tabControlManager.Controls.Add(this.tabPageManagerAdd);
            this.tabControlManager.Controls.Add(this.tabPageManagerRemove);
            this.tabControlManager.Location = new System.Drawing.Point(14, 11);
            this.tabControlManager.Name = "tabControlManager";
            this.tabControlManager.SelectedIndex = 0;
            this.tabControlManager.Size = new System.Drawing.Size(780, 104);
            this.tabControlManager.TabIndex = 0;
            // 
            // tabPageManagerAdd
            // 
            this.tabPageManagerAdd.Controls.Add(this.panel5);
            this.tabPageManagerAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPageManagerAdd.Name = "tabPageManagerAdd";
            this.tabPageManagerAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManagerAdd.Size = new System.Drawing.Size(772, 78);
            this.tabPageManagerAdd.TabIndex = 0;
            this.tabPageManagerAdd.Text = "Add";
            this.tabPageManagerAdd.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.addProdPanel);
            this.panel5.Controls.Add(this.comboBox8);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(770, 78);
            this.panel5.TabIndex = 0;
            // 
            // addProdPanel
            // 
            this.addProdPanel.Controls.Add(this.textBoxAdd6);
            this.addProdPanel.Controls.Add(this.add);
            this.addProdPanel.Controls.Add(this.textBoxAdd5);
            this.addProdPanel.Controls.Add(this.textBoxAdd4);
            this.addProdPanel.Controls.Add(this.textBoxAdd3);
            this.addProdPanel.Controls.Add(this.textBoxAdd2);
            this.addProdPanel.Controls.Add(this.textBoxAdd1);
            this.addProdPanel.Location = new System.Drawing.Point(0, 24);
            this.addProdPanel.Name = "addProdPanel";
            this.addProdPanel.Size = new System.Drawing.Size(772, 54);
            this.addProdPanel.TabIndex = 2;
            // 
            // textBoxAdd6
            // 
            this.textBoxAdd6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxAdd6.Location = new System.Drawing.Point(593, 21);
            this.textBoxAdd6.Name = "textBoxAdd6";
            this.textBoxAdd6.Size = new System.Drawing.Size(64, 20);
            this.textBoxAdd6.TabIndex = 6;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.SeaGreen;
            this.add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add.Location = new System.Drawing.Point(691, 18);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 5;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // textBoxAdd5
            // 
            this.textBoxAdd5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxAdd5.Location = new System.Drawing.Point(493, 21);
            this.textBoxAdd5.Name = "textBoxAdd5";
            this.textBoxAdd5.Size = new System.Drawing.Size(77, 20);
            this.textBoxAdd5.TabIndex = 4;
            // 
            // textBoxAdd4
            // 
            this.textBoxAdd4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxAdd4.Location = new System.Drawing.Point(371, 21);
            this.textBoxAdd4.Name = "textBoxAdd4";
            this.textBoxAdd4.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdd4.TabIndex = 3;
            // 
            // textBoxAdd3
            // 
            this.textBoxAdd3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxAdd3.Location = new System.Drawing.Point(248, 21);
            this.textBoxAdd3.Name = "textBoxAdd3";
            this.textBoxAdd3.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdd3.TabIndex = 2;
            // 
            // textBoxAdd2
            // 
            this.textBoxAdd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxAdd2.Location = new System.Drawing.Point(130, 21);
            this.textBoxAdd2.Name = "textBoxAdd2";
            this.textBoxAdd2.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdd2.TabIndex = 1;
            // 
            // textBoxAdd1
            // 
            this.textBoxAdd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxAdd1.Location = new System.Drawing.Point(10, 21);
            this.textBoxAdd1.Name = "textBoxAdd1";
            this.textBoxAdd1.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdd1.TabIndex = 0;
            // 
            // comboBox8
            // 
            this.comboBox8.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "Angajati     (Employees)",
            "Manageri\t (Managers)",
            "Produse     (Products)",
            "Clienti        (Customers)",
            "Comenzi    (Orders)"});
            this.comboBox8.Location = new System.Drawing.Point(103, 0);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(139, 21);
            this.comboBox8.TabIndex = 1;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Select the table";
            // 
            // tabPageManagerRemove
            // 
            this.tabPageManagerRemove.Controls.Add(this.panel4);
            this.tabPageManagerRemove.Location = new System.Drawing.Point(4, 22);
            this.tabPageManagerRemove.Name = "tabPageManagerRemove";
            this.tabPageManagerRemove.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManagerRemove.Size = new System.Drawing.Size(772, 78);
            this.tabPageManagerRemove.TabIndex = 1;
            this.tabPageManagerRemove.Text = "Remove";
            this.tabPageManagerRemove.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(770, 78);
            this.panel4.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.removeProdPanel);
            this.panel9.Controls.Add(this.comboBox9);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(770, 78);
            this.panel9.TabIndex = 1;
            // 
            // removeProdPanel
            // 
            this.removeProdPanel.Controls.Add(this.remove);
            this.removeProdPanel.Controls.Add(this.textBoxRemove5);
            this.removeProdPanel.Controls.Add(this.textBoxRemove4);
            this.removeProdPanel.Controls.Add(this.textBoxRemove3);
            this.removeProdPanel.Controls.Add(this.textBoxRemove2);
            this.removeProdPanel.Controls.Add(this.textBoxRemove1);
            this.removeProdPanel.Location = new System.Drawing.Point(0, 24);
            this.removeProdPanel.Name = "removeProdPanel";
            this.removeProdPanel.Size = new System.Drawing.Size(772, 54);
            this.removeProdPanel.TabIndex = 2;
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.Red;
            this.remove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.remove.Location = new System.Drawing.Point(660, 19);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 5;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // textBoxRemove5
            // 
            this.textBoxRemove5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBoxRemove5.Location = new System.Drawing.Point(487, 21);
            this.textBoxRemove5.Name = "textBoxRemove5";
            this.textBoxRemove5.Size = new System.Drawing.Size(100, 20);
            this.textBoxRemove5.TabIndex = 4;
            // 
            // textBoxRemove4
            // 
            this.textBoxRemove4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBoxRemove4.Location = new System.Drawing.Point(371, 21);
            this.textBoxRemove4.Name = "textBoxRemove4";
            this.textBoxRemove4.Size = new System.Drawing.Size(100, 20);
            this.textBoxRemove4.TabIndex = 3;
            // 
            // textBoxRemove3
            // 
            this.textBoxRemove3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBoxRemove3.Location = new System.Drawing.Point(248, 21);
            this.textBoxRemove3.Name = "textBoxRemove3";
            this.textBoxRemove3.Size = new System.Drawing.Size(100, 20);
            this.textBoxRemove3.TabIndex = 2;
            // 
            // textBoxRemove2
            // 
            this.textBoxRemove2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBoxRemove2.Location = new System.Drawing.Point(130, 21);
            this.textBoxRemove2.Name = "textBoxRemove2";
            this.textBoxRemove2.Size = new System.Drawing.Size(100, 20);
            this.textBoxRemove2.TabIndex = 1;
            // 
            // textBoxRemove1
            // 
            this.textBoxRemove1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBoxRemove1.Location = new System.Drawing.Point(10, 21);
            this.textBoxRemove1.Name = "textBoxRemove1";
            this.textBoxRemove1.Size = new System.Drawing.Size(100, 20);
            this.textBoxRemove1.TabIndex = 0;
            // 
            // comboBox9
            // 
            this.comboBox9.BackColor = System.Drawing.Color.Red;
            this.comboBox9.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "Angajati     (Employees)",
            "Manageri\t (Managers)",
            "Produse     (Products)",
            "Clienti        (Customers)",
            "Comenzi    (Orders)"});
            this.comboBox9.Location = new System.Drawing.Point(103, 0);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(139, 21);
            this.comboBox9.TabIndex = 1;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Select the table";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.SeaGreen;
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(4, 104);
            this.login.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(74, 21);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // cancelLogin
            // 
            this.cancelLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.cancelLogin.ForeColor = System.Drawing.Color.White;
            this.cancelLogin.Location = new System.Drawing.Point(79, 104);
            this.cancelLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelLogin.Name = "cancelLogin";
            this.cancelLogin.Size = new System.Drawing.Size(71, 21);
            this.cancelLogin.TabIndex = 5;
            this.cancelLogin.Text = "Cancel";
            this.cancelLogin.UseVisualStyleBackColor = false;
            this.cancelLogin.Click += new System.EventHandler(this.cancelLogin_Click);
            // 
            // passwordLogin
            // 
            this.passwordLogin.Location = new System.Drawing.Point(4, 65);
            this.passwordLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordLogin.Name = "passwordLogin";
            this.passwordLogin.Size = new System.Drawing.Size(146, 20);
            this.passwordLogin.TabIndex = 3;
            this.passwordLogin.UseSystemPasswordChar = true;
            // 
            // createLogin
            // 
            this.createLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.createLogin.ForeColor = System.Drawing.Color.White;
            this.createLogin.Location = new System.Drawing.Point(42, 146);
            this.createLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.createLogin.Name = "createLogin";
            this.createLogin.Size = new System.Drawing.Size(108, 22);
            this.createLogin.TabIndex = 6;
            this.createLogin.Text = "Create Account";
            this.createLogin.UseVisualStyleBackColor = false;
            this.createLogin.Click += new System.EventHandler(this.createLogin_Click);
            // 
            // usernameLogin
            // 
            this.usernameLogin.Location = new System.Drawing.Point(4, 39);
            this.usernameLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.usernameLogin.Name = "usernameLogin";
            this.usernameLogin.Size = new System.Drawing.Size(146, 20);
            this.usernameLogin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "new?";
            // 
            // accountTypeLogin
            // 
            this.accountTypeLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.accountTypeLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.accountTypeLogin.ForeColor = System.Drawing.Color.White;
            this.accountTypeLogin.FormattingEnabled = true;
            this.accountTypeLogin.Items.AddRange(new object[] {
            "Customer",
            "Employee",
            "Manager"});
            this.accountTypeLogin.Location = new System.Drawing.Point(4, 3);
            this.accountTypeLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.accountTypeLogin.Name = "accountTypeLogin";
            this.accountTypeLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.accountTypeLogin.Size = new System.Drawing.Size(146, 21);
            this.accountTypeLogin.TabIndex = 1;
            this.accountTypeLogin.Text = "Select Account Type";
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.loginPanel.Controls.Add(this.accountTypeLogin);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.usernameLogin);
            this.loginPanel.Controls.Add(this.createLogin);
            this.loginPanel.Controls.Add(this.passwordLogin);
            this.loginPanel.Controls.Add(this.cancelLogin);
            this.loginPanel.Controls.Add(this.login);
            this.loginPanel.Location = new System.Drawing.Point(951, 12);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(153, 178);
            this.loginPanel.TabIndex = 8;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1110, 538);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.createAccountPanel);
            this.Controls.Add(this.loginPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Login to Shoe Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.createAccountPanel.ResumeLayout(false);
            this.createAccountPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMin)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageShop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageManager.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.LOGS.ResumeLayout(false);
            this.employeeHidden1.ResumeLayout(false);
            this.employeeHidden1.PerformLayout();
            this.tabControlReports.ResumeLayout(false);
            this.tabPageReportsTable.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPageReportsChart.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControlManager.ResumeLayout(false);
            this.tabPageManagerAdd.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.addProdPanel.ResumeLayout(false);
            this.addProdPanel.PerformLayout();
            this.tabPageManagerRemove.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.removeProdPanel.ResumeLayout(false);
            this.removeProdPanel.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel createAccountPanel;
        private System.Windows.Forms.Button cancelCreate;
        private System.Windows.Forms.Button createCreate;
        private System.Windows.Forms.TextBox employeeCode;
        private System.Windows.Forms.TextBox passwordCreate;
        private System.Windows.Forms.TextBox managerCode;
        private System.Windows.Forms.TextBox emailCreate;
        private System.Windows.Forms.TextBox lastnameCreate;
        private System.Windows.Forms.ComboBox accountTypeCreate;
        private Panel mainPanel;
        private Button findBtn;
        private TextBox findTextBox;
        private ComboBox comboBoxColor;
        private ComboBox comboBox1;
        private ComboBox comboBoxSex;
        private ComboBox comboBoxBrand;
        private TrackBar trackBarMax;
        private TrackBar trackBarMin;
        private Button button4;
        private Button button3;
        private Button reset;
        private Label label3;
        private Panel panel3;
        private Panel panel2;
        private Button button1;
        private TabControl tabControl;
        private TabPage tabPageShop;
        private DataGridView dataGridView1;
        private TabPage tabPageManager;
        private Panel panel1;
        private TabControl tabControlManager;
        private TabPage tabPageManagerAdd;
        private TabPage tabPageManagerRemove;
        private Panel panel4;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel5;
        private Button proceed;
        private ComboBox comboBox7;
        private Label label5;
        private Label label4;
        private ComboBox comboBox6;
        private Panel employeeHidden1;
        private TabControl tabControlReports;
        private TabPage tabPageReportsTable;
        private TabPage tabPageReportsChart;
        private Label label7;
        private Panel panel7;
        private DataGridView dataGridView2;
        private Panel panel8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel hidePanel;
        private ComboBox comboBox8;
        private Label label8;
        private Panel addProdPanel;
        private TextBox textBoxAdd5;
        private TextBox textBoxAdd4;
        private TextBox textBoxAdd3;
        private TextBox textBoxAdd2;
        private TextBox textBoxAdd1;
        private Button add;
        private Panel panel9;
        private Panel removeProdPanel;
        private Button remove;
        private TextBox textBoxRemove5;
        private TextBox textBoxRemove4;
        private TextBox textBoxRemove3;
        private TextBox textBoxRemove2;
        private TextBox textBoxRemove1;
        private ComboBox comboBox9;
        private Label label9;
        private Button login;
        private Button cancelLogin;
        private TextBox passwordLogin;
        private Button createLogin;
        private TextBox usernameLogin;
        private Label label1;
        private ComboBox accountTypeLogin;
        private Panel loginPanel;
        private TextBox firstnameCreate;
        private Label priceLabel;
        private DataGridViewButtonColumn addToCart;
        private TextBox textBoxAdd6;
        private Button btnLOG;
        private Button printPDF;
        private Panel LOGS;
        private RichTextBox log;
    }
}

