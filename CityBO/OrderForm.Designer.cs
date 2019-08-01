namespace CityBO
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label creatTimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.creatTimeTextBox = new System.Windows.Forms.TextBox();
            this.OrderNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ToPayAmount = new System.Windows.Forms.TextBox();
            this.TimeLimit = new System.Windows.Forms.TextBox();
            this.PaidAmount = new System.Windows.Forms.TextBox();
            this.PriceAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OrderFlightsListView = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PassengersListView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.InvoicesListView = new System.Windows.Forms.DataGridView();
            this.ToPayButton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AviaLabelState = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeState = new System.Windows.Forms.Button();
            this.ordersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ordersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cTBODBDataSet2 = new CityBO.CTBODBDataSet2();
            this.flightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightsTableAdapter = new CityBO.CTBODBDataSet2TableAdapters.flightsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureIATAcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalIATAcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTBODBDataSet1 = new CityBO.CTBODBDataSet1();
            this.ordersTableAdapter = new CityBO.CTBODBDataSet1TableAdapters.ordersTableAdapter();
            this.tableAdapterManager = new CityBO.CTBODBDataSet1TableAdapters.TableAdapterManager();
            this.cTBODBDataSet3 = new CityBO.CTBODBDataSet3();
            this.paxesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paxesTableAdapter = new CityBO.CTBODBDataSet3TableAdapters.paxesTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citizenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTBODBDataSet4 = new CityBO.CTBODBDataSet4();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoicesTableAdapter = new CityBO.CTBODBDataSet4TableAdapters.invoicesTableAdapter();
            this.ordernumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timelimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            creatTimeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderFlightsListView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassengersListView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicesListView)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).BeginInit();
            this.ordersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTBODBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTBODBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTBODBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paxesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTBODBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // creatTimeLabel
            // 
            creatTimeLabel.AutoSize = true;
            creatTimeLabel.Location = new System.Drawing.Point(188, 20);
            creatTimeLabel.Name = "creatTimeLabel";
            creatTimeLabel.Size = new System.Drawing.Size(78, 13);
            creatTimeLabel.TabIndex = 4;
            creatTimeLabel.Text = "Сформирован";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(creatTimeLabel);
            this.groupBox1.Controls.Add(this.creatTimeTextBox);
            this.groupBox1.Controls.Add(this.OrderNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заказ";
            // 
            // creatTimeTextBox
            // 
            this.creatTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "CreatTime", true));
            this.creatTimeTextBox.Location = new System.Drawing.Point(272, 17);
            this.creatTimeTextBox.Name = "creatTimeTextBox";
            this.creatTimeTextBox.Size = new System.Drawing.Size(148, 20);
            this.creatTimeTextBox.TabIndex = 5;
            // 
            // OrderNum
            // 
            this.OrderNum.Location = new System.Drawing.Point(75, 17);
            this.OrderNum.Name = "OrderNum";
            this.OrderNum.Size = new System.Drawing.Size(101, 20);
            this.OrderNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ToPayAmount);
            this.groupBox2.Controls.Add(this.TimeLimit);
            this.groupBox2.Controls.Add(this.PaidAmount);
            this.groupBox2.Controls.Add(this.PriceAmount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Стоимость";
            // 
            // ToPayAmount
            // 
            this.ToPayAmount.Location = new System.Drawing.Point(272, 56);
            this.ToPayAmount.Name = "ToPayAmount";
            this.ToPayAmount.Size = new System.Drawing.Size(148, 20);
            this.ToPayAmount.TabIndex = 3;
            // 
            // TimeLimit
            // 
            this.TimeLimit.Location = new System.Drawing.Point(272, 25);
            this.TimeLimit.Name = "TimeLimit";
            this.TimeLimit.Size = new System.Drawing.Size(148, 20);
            this.TimeLimit.TabIndex = 3;
            // 
            // PaidAmount
            // 
            this.PaidAmount.Location = new System.Drawing.Point(75, 56);
            this.PaidAmount.Name = "PaidAmount";
            this.PaidAmount.Size = new System.Drawing.Size(101, 20);
            this.PaidAmount.TabIndex = 3;
            // 
            // PriceAmount
            // 
            this.PriceAmount.Location = new System.Drawing.Point(75, 25);
            this.PriceAmount.Name = "PriceAmount";
            this.PriceAmount.Size = new System.Drawing.Size(101, 20);
            this.PriceAmount.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Оплачено";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "К оплате";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Срок оплаты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Стоимость";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PhoneNumber);
            this.groupBox3.Controls.Add(this.Email);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(449, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 160);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Контакты";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(70, 42);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(136, 20);
            this.PhoneNumber.TabIndex = 2;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(70, 17);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(136, 20);
            this.Email.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Телефон";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "E-mail";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(670, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 160);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Опции";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(11, 205);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(946, 245);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OrderFlightsListView);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(938, 219);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Перелет";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OrderFlightsListView
            // 
            this.OrderFlightsListView.AllowUserToAddRows = false;
            this.OrderFlightsListView.AllowUserToDeleteRows = false;
            this.OrderFlightsListView.AutoGenerateColumns = false;
            this.OrderFlightsListView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderFlightsListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderFlightsListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.flightNumberDataGridViewTextBoxColumn,
            this.departureCountryDataGridViewTextBoxColumn,
            this.departureCityDataGridViewTextBoxColumn,
            this.departureIATAcodeDataGridViewTextBoxColumn,
            this.departureDTDataGridViewTextBoxColumn,
            this.arrivalCountryDataGridViewTextBoxColumn,
            this.arrivalCityDataGridViewTextBoxColumn,
            this.arrivalIATAcodeDataGridViewTextBoxColumn,
            this.arrivalDTDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn});
            this.OrderFlightsListView.DataSource = this.flightsBindingSource;
            this.OrderFlightsListView.Location = new System.Drawing.Point(6, 37);
            this.OrderFlightsListView.Name = "OrderFlightsListView";
            this.OrderFlightsListView.ReadOnly = true;
            this.OrderFlightsListView.RowHeadersVisible = false;
            this.OrderFlightsListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderFlightsListView.Size = new System.Drawing.Size(926, 176);
            this.OrderFlightsListView.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(857, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Позиции";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Конфигурация заказа";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PassengersListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(938, 219);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Пассажиры";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PassengersListView
            // 
            this.PassengersListView.AllowUserToAddRows = false;
            this.PassengersListView.AllowUserToDeleteRows = false;
            this.PassengersListView.AutoGenerateColumns = false;
            this.PassengersListView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PassengersListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PassengersListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.tipeDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dBDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn,
            this.citizenDataGridViewTextBoxColumn,
            this.eDDataGridViewTextBoxColumn});
            this.PassengersListView.DataSource = this.paxesBindingSource;
            this.PassengersListView.Location = new System.Drawing.Point(6, 37);
            this.PassengersListView.Name = "PassengersListView";
            this.PassengersListView.ReadOnly = true;
            this.PassengersListView.RowHeadersVisible = false;
            this.PassengersListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PassengersListView.Size = new System.Drawing.Size(926, 176);
            this.PassengersListView.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.InvoicesListView);
            this.tabPage3.Controls.Add(this.ToPayButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(938, 219);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Финансовая информация";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Только активные";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // InvoicesListView
            // 
            this.InvoicesListView.AllowUserToAddRows = false;
            this.InvoicesListView.AllowUserToDeleteRows = false;
            this.InvoicesListView.AutoGenerateColumns = false;
            this.InvoicesListView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InvoicesListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoicesListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordernumDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn2,
            this.sumDataGridViewTextBoxColumn,
            this.timelimitDataGridViewTextBoxColumn,
            this.psumDataGridViewTextBoxColumn,
            this.ptimeDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn1});
            this.InvoicesListView.DataSource = this.invoicesBindingSource;
            this.InvoicesListView.Location = new System.Drawing.Point(6, 37);
            this.InvoicesListView.Name = "InvoicesListView";
            this.InvoicesListView.ReadOnly = true;
            this.InvoicesListView.RowHeadersVisible = false;
            this.InvoicesListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InvoicesListView.Size = new System.Drawing.Size(926, 176);
            this.InvoicesListView.TabIndex = 4;
            // 
            // ToPayButton
            // 
            this.ToPayButton.Location = new System.Drawing.Point(761, 6);
            this.ToPayButton.Name = "ToPayButton";
            this.ToPayButton.Size = new System.Drawing.Size(171, 23);
            this.ToPayButton.TabIndex = 0;
            this.ToPayButton.Text = "Выставить доплату";
            this.ToPayButton.UseVisualStyleBackColor = true;
            this.ToPayButton.Click += new System.EventHandler(this.ToPayButton_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(938, 219);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Общение";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(938, 219);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Дополнительно";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(925, 206);
            this.dataGridView1.TabIndex = 0;
            // 
            // AviaLabelState
            // 
            this.AviaLabelState.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AviaLabelState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AviaLabelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AviaLabelState.Location = new System.Drawing.Point(11, 180);
            this.AviaLabelState.Name = "AviaLabelState";
            this.AviaLabelState.Size = new System.Drawing.Size(946, 22);
            this.AviaLabelState.TabIndex = 5;
            this.AviaLabelState.Text = "Авиаперелет";
            this.AviaLabelState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(13, 453);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(944, 22);
            this.label10.TabIndex = 5;
            this.label10.Text = "Услуги";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.contextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(270, 224);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(269, 22);
            this.toolStripMenuItem1.Text = "Аннулировать";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(269, 22);
            this.toolStripMenuItem2.Text = "Заказ оформлен и ожидает оплаты";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(269, 22);
            this.toolStripMenuItem3.Text = "Взять в обработку";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(269, 22);
            this.toolStripMenuItem4.Text = "Все позиции выписаны";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(269, 22);
            this.toolStripMenuItem5.Text = "Вернуть в обработку";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(269, 22);
            this.toolStripMenuItem6.Text = "Ожидать доплату";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(269, 22);
            this.toolStripMenuItem7.Text = "Начать возврат билетов";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(269, 22);
            this.toolStripMenuItem8.Text = "Возврат проведен";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(269, 22);
            this.toolStripMenuItem9.Text = "Начать обмен билетов";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(269, 22);
            this.toolStripMenuItem10.Text = "Обмен завершен";
            // 
            // ChangeState
            // 
            this.ChangeState.Location = new System.Drawing.Point(935, 180);
            this.ChangeState.Name = "ChangeState";
            this.ChangeState.Size = new System.Drawing.Size(22, 22);
            this.ChangeState.TabIndex = 7;
            this.ChangeState.Text = "@";
            this.ChangeState.UseVisualStyleBackColor = true;
            this.ChangeState.Click += new System.EventHandler(this.Button4_Click);
            // 
            // ordersBindingNavigator
            // 
            this.ordersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ordersBindingNavigator.BindingSource = this.ordersBindingSource;
            this.ordersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ordersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ordersBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.ordersBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ordersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ordersBindingNavigatorSaveItem});
            this.ordersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ordersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ordersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ordersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ordersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ordersBindingNavigator.Name = "ordersBindingNavigator";
            this.ordersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ordersBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ordersBindingNavigator.ShowItemToolTips = false;
            this.ordersBindingNavigator.Size = new System.Drawing.Size(277, 25);
            this.ordersBindingNavigator.TabIndex = 8;
            this.ordersBindingNavigator.Text = "bindingNavigator1";
            this.ordersBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ordersBindingNavigatorSaveItem
            // 
            this.ordersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ordersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ordersBindingNavigatorSaveItem.Image")));
            this.ordersBindingNavigatorSaveItem.Name = "ordersBindingNavigatorSaveItem";
            this.ordersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ordersBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.ordersBindingNavigatorSaveItem.Click += new System.EventHandler(this.ordersBindingNavigatorSaveItem_Click);
            // 
            // cTBODBDataSet2
            // 
            this.cTBODBDataSet2.DataSetName = "CTBODBDataSet2";
            this.cTBODBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightsBindingSource
            // 
            this.flightsBindingSource.DataMember = "flights";
            this.flightsBindingSource.DataSource = this.cTBODBDataSet2;
            // 
            // flightsTableAdapter
            // 
            this.flightsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // flightNumberDataGridViewTextBoxColumn
            // 
            this.flightNumberDataGridViewTextBoxColumn.DataPropertyName = "FlightNumber";
            this.flightNumberDataGridViewTextBoxColumn.HeaderText = "Рейс";
            this.flightNumberDataGridViewTextBoxColumn.Name = "flightNumberDataGridViewTextBoxColumn";
            this.flightNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.flightNumberDataGridViewTextBoxColumn.Width = 70;
            // 
            // departureCountryDataGridViewTextBoxColumn
            // 
            this.departureCountryDataGridViewTextBoxColumn.DataPropertyName = "DepartureCountry";
            this.departureCountryDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.departureCountryDataGridViewTextBoxColumn.Name = "departureCountryDataGridViewTextBoxColumn";
            this.departureCountryDataGridViewTextBoxColumn.ReadOnly = true;
            this.departureCountryDataGridViewTextBoxColumn.Width = 60;
            // 
            // departureCityDataGridViewTextBoxColumn
            // 
            this.departureCityDataGridViewTextBoxColumn.DataPropertyName = "DepartureCity";
            this.departureCityDataGridViewTextBoxColumn.HeaderText = "Город";
            this.departureCityDataGridViewTextBoxColumn.Name = "departureCityDataGridViewTextBoxColumn";
            this.departureCityDataGridViewTextBoxColumn.ReadOnly = true;
            this.departureCityDataGridViewTextBoxColumn.Width = 160;
            // 
            // departureIATAcodeDataGridViewTextBoxColumn
            // 
            this.departureIATAcodeDataGridViewTextBoxColumn.DataPropertyName = "DepartureIATAcode";
            this.departureIATAcodeDataGridViewTextBoxColumn.HeaderText = "IATA";
            this.departureIATAcodeDataGridViewTextBoxColumn.Name = "departureIATAcodeDataGridViewTextBoxColumn";
            this.departureIATAcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.departureIATAcodeDataGridViewTextBoxColumn.Width = 50;
            // 
            // departureDTDataGridViewTextBoxColumn
            // 
            this.departureDTDataGridViewTextBoxColumn.DataPropertyName = "DepartureDT";
            this.departureDTDataGridViewTextBoxColumn.HeaderText = "Вылет";
            this.departureDTDataGridViewTextBoxColumn.Name = "departureDTDataGridViewTextBoxColumn";
            this.departureDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arrivalCountryDataGridViewTextBoxColumn
            // 
            this.arrivalCountryDataGridViewTextBoxColumn.DataPropertyName = "ArrivalCountry";
            this.arrivalCountryDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.arrivalCountryDataGridViewTextBoxColumn.Name = "arrivalCountryDataGridViewTextBoxColumn";
            this.arrivalCountryDataGridViewTextBoxColumn.ReadOnly = true;
            this.arrivalCountryDataGridViewTextBoxColumn.Width = 60;
            // 
            // arrivalCityDataGridViewTextBoxColumn
            // 
            this.arrivalCityDataGridViewTextBoxColumn.DataPropertyName = "ArrivalCity";
            this.arrivalCityDataGridViewTextBoxColumn.HeaderText = "Город";
            this.arrivalCityDataGridViewTextBoxColumn.Name = "arrivalCityDataGridViewTextBoxColumn";
            this.arrivalCityDataGridViewTextBoxColumn.ReadOnly = true;
            this.arrivalCityDataGridViewTextBoxColumn.Width = 160;
            // 
            // arrivalIATAcodeDataGridViewTextBoxColumn
            // 
            this.arrivalIATAcodeDataGridViewTextBoxColumn.DataPropertyName = "ArrivalIATAcode";
            this.arrivalIATAcodeDataGridViewTextBoxColumn.HeaderText = "IATA";
            this.arrivalIATAcodeDataGridViewTextBoxColumn.Name = "arrivalIATAcodeDataGridViewTextBoxColumn";
            this.arrivalIATAcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.arrivalIATAcodeDataGridViewTextBoxColumn.Width = 50;
            // 
            // arrivalDTDataGridViewTextBoxColumn
            // 
            this.arrivalDTDataGridViewTextBoxColumn.DataPropertyName = "ArrivalDT";
            this.arrivalDTDataGridViewTextBoxColumn.HeaderText = "Прилет";
            this.arrivalDTDataGridViewTextBoxColumn.Name = "arrivalDTDataGridViewTextBoxColumn";
            this.arrivalDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.cTBODBDataSet1;
            // 
            // cTBODBDataSet1
            // 
            this.cTBODBDataSet1.DataSetName = "CTBODBDataSet1";
            this.cTBODBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.flightsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.paxesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CityBO.CTBODBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // cTBODBDataSet3
            // 
            this.cTBODBDataSet3.DataSetName = "CTBODBDataSet3";
            this.cTBODBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paxesBindingSource
            // 
            this.paxesBindingSource.DataMember = "paxes";
            this.paxesBindingSource.DataSource = this.cTBODBDataSet3;
            // 
            // paxesTableAdapter
            // 
            this.paxesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // tipeDataGridViewTextBoxColumn
            // 
            this.tipeDataGridViewTextBoxColumn.DataPropertyName = "Tipe";
            this.tipeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.tipeDataGridViewTextBoxColumn.Name = "tipeDataGridViewTextBoxColumn";
            this.tipeDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipeDataGridViewTextBoxColumn.Width = 50;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 50;
            // 
            // dBDataGridViewTextBoxColumn
            // 
            this.dBDataGridViewTextBoxColumn.DataPropertyName = "DB";
            this.dBDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.dBDataGridViewTextBoxColumn.Name = "dBDataGridViewTextBoxColumn";
            this.dBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "Passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "Номер документа";
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            this.passportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // citizenDataGridViewTextBoxColumn
            // 
            this.citizenDataGridViewTextBoxColumn.DataPropertyName = "Citizen";
            this.citizenDataGridViewTextBoxColumn.HeaderText = "Гражданство";
            this.citizenDataGridViewTextBoxColumn.Name = "citizenDataGridViewTextBoxColumn";
            this.citizenDataGridViewTextBoxColumn.ReadOnly = true;
            this.citizenDataGridViewTextBoxColumn.Width = 120;
            // 
            // eDDataGridViewTextBoxColumn
            // 
            this.eDDataGridViewTextBoxColumn.DataPropertyName = "ED";
            this.eDDataGridViewTextBoxColumn.HeaderText = "Срок действия";
            this.eDDataGridViewTextBoxColumn.Name = "eDDataGridViewTextBoxColumn";
            this.eDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cTBODBDataSet4
            // 
            this.cTBODBDataSet4.DataSetName = "CTBODBDataSet4";
            this.cTBODBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "invoices";
            this.invoicesBindingSource.DataSource = this.cTBODBDataSet4;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // ordernumDataGridViewTextBoxColumn
            // 
            this.ordernumDataGridViewTextBoxColumn.DataPropertyName = "ordernum";
            this.ordernumDataGridViewTextBoxColumn.HeaderText = "ordernum";
            this.ordernumDataGridViewTextBoxColumn.Name = "ordernumDataGridViewTextBoxColumn";
            this.ordernumDataGridViewTextBoxColumn.ReadOnly = true;
            this.ordernumDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Номер";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Width = 50;
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            this.sumDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumDataGridViewTextBoxColumn.Width = 120;
            // 
            // timelimitDataGridViewTextBoxColumn
            // 
            this.timelimitDataGridViewTextBoxColumn.DataPropertyName = "timelimit";
            this.timelimitDataGridViewTextBoxColumn.HeaderText = "Тайм-лимит";
            this.timelimitDataGridViewTextBoxColumn.Name = "timelimitDataGridViewTextBoxColumn";
            this.timelimitDataGridViewTextBoxColumn.ReadOnly = true;
            this.timelimitDataGridViewTextBoxColumn.Width = 200;
            // 
            // psumDataGridViewTextBoxColumn
            // 
            this.psumDataGridViewTextBoxColumn.DataPropertyName = "psum";
            this.psumDataGridViewTextBoxColumn.HeaderText = "Оплачено";
            this.psumDataGridViewTextBoxColumn.Name = "psumDataGridViewTextBoxColumn";
            this.psumDataGridViewTextBoxColumn.ReadOnly = true;
            this.psumDataGridViewTextBoxColumn.Width = 120;
            // 
            // ptimeDataGridViewTextBoxColumn
            // 
            this.ptimeDataGridViewTextBoxColumn.DataPropertyName = "ptime";
            this.ptimeDataGridViewTextBoxColumn.HeaderText = "Дата оплаты";
            this.ptimeDataGridViewTextBoxColumn.Name = "ptimeDataGridViewTextBoxColumn";
            this.ptimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.ptimeDataGridViewTextBoxColumn.Width = 200;
            // 
            // stateDataGridViewTextBoxColumn1
            // 
            this.stateDataGridViewTextBoxColumn1.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn1.HeaderText = "Статус";
            this.stateDataGridViewTextBoxColumn1.Name = "stateDataGridViewTextBoxColumn1";
            this.stateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.stateDataGridViewTextBoxColumn1.Width = 200;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 594);
            this.Controls.Add(this.ordersBindingNavigator);
            this.Controls.Add(this.ChangeState);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AviaLabelState);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(985, 633);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderFlightsListView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PassengersListView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicesListView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).EndInit();
            this.ordersBindingNavigator.ResumeLayout(false);
            this.ordersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTBODBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTBODBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTBODBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paxesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTBODBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox OrderNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ToPayAmount;
        private System.Windows.Forms.TextBox TimeLimit;
        private System.Windows.Forms.TextBox PaidAmount;
        private System.Windows.Forms.TextBox PriceAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label AviaLabelState;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.DataGridView OrderFlightsListView;
        public System.Windows.Forms.DataGridView PassengersListView;
        private System.Windows.Forms.Button ToPayButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.Button ChangeState;
        public System.Windows.Forms.DataGridView InvoicesListView;
        private System.Windows.Forms.CheckBox checkBox1;
        private CTBODBDataSet1 cTBODBDataSet1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private CTBODBDataSet1TableAdapters.ordersTableAdapter ordersTableAdapter;
        private CTBODBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ordersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ordersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox creatTimeTextBox;
        private CTBODBDataSet2 cTBODBDataSet2;
        private System.Windows.Forms.BindingSource flightsBindingSource;
        private CTBODBDataSet2TableAdapters.flightsTableAdapter flightsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureIATAcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalIATAcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private CTBODBDataSet3 cTBODBDataSet3;
        private System.Windows.Forms.BindingSource paxesBindingSource;
        private CTBODBDataSet3TableAdapters.paxesTableAdapter paxesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn citizenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDDataGridViewTextBoxColumn;
        private CTBODBDataSet4 cTBODBDataSet4;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private CTBODBDataSet4TableAdapters.invoicesTableAdapter invoicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordernumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timelimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn psumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn1;
    }
}