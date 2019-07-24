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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OrderCreateTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.FlightNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureIATAcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalIATAcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassengersListView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderFlightsListView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassengersListView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OrderCreateTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.OrderNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заказ";
            // 
            // OrderCreateTime
            // 
            this.OrderCreateTime.Location = new System.Drawing.Point(272, 17);
            this.OrderCreateTime.Name = "OrderCreateTime";
            this.OrderCreateTime.Size = new System.Drawing.Size(148, 20);
            this.OrderCreateTime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сформирован";
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
            this.OrderFlightsListView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderFlightsListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderFlightsListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlightNumber,
            this.DepartureCountry,
            this.DepartureCity,
            this.DepartureIATAcode,
            this.DepartureDT,
            this.ArrivalCountry,
            this.ArrivalCity,
            this.ArrivalIATAcode,
            this.ArrivalDT,
            this.State,
            this.id});
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
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(938, 219);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Финансовая информация";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(938, 219);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Дополнительно";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(11, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(946, 22);
            this.label9.TabIndex = 5;
            this.label9.Text = "Авиаперелет";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // FlightNumber
            // 
            this.FlightNumber.DataPropertyName = "FlightNumber";
            this.FlightNumber.HeaderText = "Рейс";
            this.FlightNumber.Name = "FlightNumber";
            this.FlightNumber.ReadOnly = true;
            this.FlightNumber.Width = 60;
            // 
            // DepartureCountry
            // 
            this.DepartureCountry.DataPropertyName = "DepartureCountry";
            this.DepartureCountry.HeaderText = "Страна";
            this.DepartureCountry.Name = "DepartureCountry";
            this.DepartureCountry.ReadOnly = true;
            this.DepartureCountry.Width = 50;
            // 
            // DepartureCity
            // 
            this.DepartureCity.DataPropertyName = "DepartureCity";
            this.DepartureCity.HeaderText = "Город";
            this.DepartureCity.Name = "DepartureCity";
            this.DepartureCity.ReadOnly = true;
            this.DepartureCity.Width = 120;
            // 
            // DepartureIATAcode
            // 
            this.DepartureIATAcode.DataPropertyName = "DepartureIATAcode";
            this.DepartureIATAcode.HeaderText = "Код";
            this.DepartureIATAcode.Name = "DepartureIATAcode";
            this.DepartureIATAcode.ReadOnly = true;
            this.DepartureIATAcode.Width = 50;
            // 
            // DepartureDT
            // 
            this.DepartureDT.DataPropertyName = "DepartureDT";
            this.DepartureDT.HeaderText = "Время";
            this.DepartureDT.Name = "DepartureDT";
            this.DepartureDT.ReadOnly = true;
            this.DepartureDT.Width = 150;
            // 
            // ArrivalCountry
            // 
            this.ArrivalCountry.DataPropertyName = "ArrivalCountry";
            this.ArrivalCountry.HeaderText = "Страна";
            this.ArrivalCountry.Name = "ArrivalCountry";
            this.ArrivalCountry.ReadOnly = true;
            this.ArrivalCountry.Width = 50;
            // 
            // ArrivalCity
            // 
            this.ArrivalCity.DataPropertyName = "ArrivalCity";
            this.ArrivalCity.HeaderText = "Город";
            this.ArrivalCity.Name = "ArrivalCity";
            this.ArrivalCity.ReadOnly = true;
            this.ArrivalCity.Width = 120;
            // 
            // ArrivalIATAcode
            // 
            this.ArrivalIATAcode.DataPropertyName = "ArrivalIATAcode";
            this.ArrivalIATAcode.HeaderText = "Код";
            this.ArrivalIATAcode.Name = "ArrivalIATAcode";
            this.ArrivalIATAcode.ReadOnly = true;
            this.ArrivalIATAcode.Width = 50;
            // 
            // ArrivalDT
            // 
            this.ArrivalDT.DataPropertyName = "ArrivalDT";
            this.ArrivalDT.HeaderText = "Время";
            this.ArrivalDT.Name = "ArrivalDT";
            this.ArrivalDT.ReadOnly = true;
            this.ArrivalDT.Width = 150;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "Статус";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 80;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // PassengersListView
            // 
            this.PassengersListView.AllowUserToAddRows = false;
            this.PassengersListView.AllowUserToDeleteRows = false;
            this.PassengersListView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PassengersListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PassengersListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column6,
            this.Column7});
            this.PassengersListView.Location = new System.Drawing.Point(6, 37);
            this.PassengersListView.Name = "PassengersListView";
            this.PassengersListView.ReadOnly = true;
            this.PassengersListView.RowHeadersVisible = false;
            this.PassengersListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PassengersListView.Size = new System.Drawing.Size(926, 176);
            this.PassengersListView.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tipe";
            this.Column2.HeaderText = "Тип";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LastName";
            this.Column3.HeaderText = "Фамилия";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "FirstName";
            this.Column4.HeaderText = "Имя";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DB";
            this.Column5.HeaderText = "Дата рождения";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Citizen";
            this.Column8.HeaderText = "Гражданство";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 120;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Passport";
            this.Column6.HeaderText = "Номер документа";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ED";
            this.Column7.HeaderText = "Срок действия";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 594);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(985, 633);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox OrderCreateTime;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.DataGridView OrderFlightsListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureIATAcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalIATAcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        public System.Windows.Forms.DataGridView PassengersListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}