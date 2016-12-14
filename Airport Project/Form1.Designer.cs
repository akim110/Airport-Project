namespace Airport_Project
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
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.countries = new System.Windows.Forms.ComboBox();
            this.searchCountryAirports = new System.Windows.Forms.Button();
            this.searchCountryAirlines = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.searchConnectedCities = new System.Windows.Forms.Button();
            this.searchMostAirports = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tab2Results = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.routesTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.srcCity = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.srcCountry = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dstCity = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dstCountry = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.numStops = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.routeSearch = new System.Windows.Forms.Button();
            this.airportsTab = new System.Windows.Forms.TabPage();
            this.airlinesTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.routesTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStops)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.airportsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.94039F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.05961F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(669, 316);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.searchMostAirports, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.3125F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.6875F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(261, 310);
            this.tableLayoutPanel9.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.countries);
            this.flowLayoutPanel1.Controls.Add(this.searchCountryAirports);
            this.flowLayoutPanel1.Controls.Add(this.searchCountryAirlines);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(253, 89);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // countries
            // 
            this.countries.FormattingEnabled = true;
            this.countries.Location = new System.Drawing.Point(40, 3);
            this.countries.Name = "countries";
            this.countries.Size = new System.Drawing.Size(210, 24);
            this.countries.TabIndex = 1;
            this.countries.Text = "Select Country";
            this.countries.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // searchCountryAirports
            // 
            this.searchCountryAirports.Location = new System.Drawing.Point(122, 33);
            this.searchCountryAirports.Name = "searchCountryAirports";
            this.searchCountryAirports.Size = new System.Drawing.Size(128, 23);
            this.searchCountryAirports.TabIndex = 2;
            this.searchCountryAirports.Text = "Find Airports";
            this.searchCountryAirports.UseVisualStyleBackColor = true;
            this.searchCountryAirports.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchCountryAirlines
            // 
            this.searchCountryAirlines.Location = new System.Drawing.Point(122, 62);
            this.searchCountryAirlines.Name = "searchCountryAirlines";
            this.searchCountryAirlines.Size = new System.Drawing.Size(128, 23);
            this.searchCountryAirlines.TabIndex = 3;
            this.searchCountryAirlines.Text = "Find Airlines";
            this.searchCountryAirlines.UseVisualStyleBackColor = true;
            this.searchCountryAirlines.Click += new System.EventHandler(this.button4_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.textBox7);
            this.flowLayoutPanel2.Controls.Add(this.numericUpDown2);
            this.flowLayoutPanel2.Controls.Add(this.textBox6);
            this.flowLayoutPanel2.Controls.Add(this.searchConnectedCities);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 141);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(253, 165);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Window;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(151, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(99, 15);
            this.textBox7.TabIndex = 3;
            this.textBox7.Text = "connected cities";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(95, 3);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(50, 22);
            this.numericUpDown2.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Window;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(12, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(77, 15);
            this.textBox6.TabIndex = 1;
            this.textBox6.Text = "Find the top";
            // 
            // searchConnectedCities
            // 
            this.searchConnectedCities.Location = new System.Drawing.Point(117, 31);
            this.searchConnectedCities.Name = "searchConnectedCities";
            this.searchConnectedCities.Size = new System.Drawing.Size(133, 23);
            this.searchConnectedCities.TabIndex = 4;
            this.searchConnectedCities.Text = "Search Cities";
            this.searchConnectedCities.UseVisualStyleBackColor = true;
            // 
            // searchMostAirports
            // 
            this.searchMostAirports.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchMostAirports.Location = new System.Drawing.Point(4, 100);
            this.searchMostAirports.Name = "searchMostAirports";
            this.searchMostAirports.Size = new System.Drawing.Size(253, 34);
            this.searchMostAirports.TabIndex = 3;
            this.searchMostAirports.Text = "Find Country With Most Airports";
            this.searchMostAirports.UseVisualStyleBackColor = true;
            this.searchMostAirports.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.tab2Results);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(270, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(396, 310);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // tab2Results
            // 
            this.tab2Results.Location = new System.Drawing.Point(3, 3);
            this.tab2Results.Multiline = true;
            this.tab2Results.Name = "tab2Results";
            this.tab2Results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tab2Results.Size = new System.Drawing.Size(392, 305);
            this.tab2Results.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.routesTab);
            this.tabControl1.Controls.Add(this.airportsTab);
            this.tabControl1.Controls.Add(this.airlinesTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(683, 351);
            this.tabControl1.TabIndex = 1;
            // 
            // routesTab
            // 
            this.routesTab.Controls.Add(this.tableLayoutPanel2);
            this.routesTab.Location = new System.Drawing.Point(4, 25);
            this.routesTab.Name = "routesTab";
            this.routesTab.Size = new System.Drawing.Size(675, 322);
            this.routesTab.TabIndex = 2;
            this.routesTab.Text = "Routes";
            this.routesTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel8, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.92086F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.07914F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(675, 322);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.srcCity, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.20833F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.79166F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(331, 97);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.MinimumSize = new System.Drawing.Size(78, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(78, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Source City";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // srcCity
            // 
            this.srcCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.srcCity.Location = new System.Drawing.Point(3, 32);
            this.srcCity.Name = "srcCity";
            this.srcCity.Size = new System.Drawing.Size(325, 22);
            this.srcCity.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.srcCountry, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBox2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(340, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.20833F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.79166F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(332, 97);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // srcCountry
            // 
            this.srcCountry.FormattingEnabled = true;
            this.srcCountry.Location = new System.Drawing.Point(3, 32);
            this.srcCountry.Name = "srcCountry";
            this.srcCountry.Size = new System.Drawing.Size(178, 24);
            this.srcCountry.TabIndex = 2;
            this.srcCountry.Text = "Select Country";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.MinimumSize = new System.Drawing.Size(100, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Source Country";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.textBox3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.dstCity, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 106);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(331, 101);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 3);
            this.textBox3.MinimumSize = new System.Drawing.Size(105, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(105, 22);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "Destination City";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dstCity
            // 
            this.dstCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dstCity.Location = new System.Drawing.Point(3, 33);
            this.dstCity.Name = "dstCity";
            this.dstCity.Size = new System.Drawing.Size(325, 22);
            this.dstCity.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.textBox4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.dstCountry, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(340, 106);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(332, 101);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 3);
            this.textBox4.MinimumSize = new System.Drawing.Size(128, 22);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(128, 22);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "Destination Country";
            // 
            // dstCountry
            // 
            this.dstCountry.FormattingEnabled = true;
            this.dstCountry.Location = new System.Drawing.Point(3, 32);
            this.dstCountry.Name = "dstCountry";
            this.dstCountry.Size = new System.Drawing.Size(178, 24);
            this.dstCountry.TabIndex = 1;
            this.dstCountry.Text = "Select Country";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.textBox5, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.numStops, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 213);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.24528F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.75471F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(331, 106);
            this.tableLayoutPanel7.TabIndex = 4;
            this.tableLayoutPanel7.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel7_Paint);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(3, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(135, 22);
            this.textBox5.TabIndex = 0;
            this.textBox5.Text = "Num Stops (or Hops)";
            // 
            // numStops
            // 
            this.numStops.Location = new System.Drawing.Point(3, 34);
            this.numStops.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numStops.Name = "numStops";
            this.numStops.Size = new System.Drawing.Size(120, 22);
            this.numStops.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.routeSearch, 1, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(340, 213);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(332, 106);
            this.tableLayoutPanel8.TabIndex = 5;
            // 
            // routeSearch
            // 
            this.routeSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.routeSearch.Location = new System.Drawing.Point(169, 76);
            this.routeSearch.Name = "routeSearch";
            this.routeSearch.Size = new System.Drawing.Size(160, 27);
            this.routeSearch.TabIndex = 0;
            this.routeSearch.Text = "Search";
            this.routeSearch.UseVisualStyleBackColor = true;
            this.routeSearch.Click += new System.EventHandler(this.search_Click);
            // 
            // airportsTab
            // 
            this.airportsTab.Controls.Add(this.tableLayoutPanel1);
            this.airportsTab.Location = new System.Drawing.Point(4, 25);
            this.airportsTab.Name = "airportsTab";
            this.airportsTab.Padding = new System.Windows.Forms.Padding(3);
            this.airportsTab.Size = new System.Drawing.Size(675, 322);
            this.airportsTab.TabIndex = 0;
            this.airportsTab.Text = "Airports";
            this.airportsTab.UseVisualStyleBackColor = true;
            this.airportsTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // airlinesTab
            // 
            this.airlinesTab.Location = new System.Drawing.Point(4, 25);
            this.airlinesTab.Name = "airlinesTab";
            this.airlinesTab.Padding = new System.Windows.Forms.Padding(3);
            this.airlinesTab.Size = new System.Drawing.Size(675, 322);
            this.airlinesTab.TabIndex = 1;
            this.airlinesTab.Text = "Airlines";
            this.airlinesTab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(683, 351);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.routesTab.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStops)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.airportsTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox countries;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage airportsTab;
        private System.Windows.Forms.TabPage airlinesTab;
        private System.Windows.Forms.TabPage routesTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox srcCity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox srcCountry;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox dstCountry;
        private System.Windows.Forms.TextBox dstCity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.NumericUpDown numStops;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button routeSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button searchCountryAirports;
        private System.Windows.Forms.Button searchMostAirports;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button searchCountryAirlines;
        private System.Windows.Forms.Button searchConnectedCities;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox tab2Results;
    }
}

