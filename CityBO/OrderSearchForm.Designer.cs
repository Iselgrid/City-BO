namespace CityBO
{
    partial class OrderSearchForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NoOrder = new System.Windows.Forms.Label();
            this.OrderSearchListOut = new System.Windows.Forms.DataGridView();
            this.OrderSearchBut = new System.Windows.Forms.Button();
            this.OrderTextBoxOSF = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cTBODBDataSet = new CityBO.CTBODBDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new CityBO.CTBODBDataSetTableAdapters.ordersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderSearchListOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTBODBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.NoOrder);
            this.groupBox1.Controls.Add(this.OrderSearchListOut);
            this.groupBox1.Controls.Add(this.OrderSearchBut);
            this.groupBox1.Controls.Add(this.OrderTextBoxOSF);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // NoOrder
            // 
            this.NoOrder.AutoSize = true;
            this.NoOrder.Location = new System.Drawing.Point(387, 23);
            this.NoOrder.Name = "NoOrder";
            this.NoOrder.Size = new System.Drawing.Size(0, 13);
            this.NoOrder.TabIndex = 3;
            // 
            // OrderSearchListOut
            // 
            this.OrderSearchListOut.AllowUserToAddRows = false;
            this.OrderSearchListOut.AllowUserToDeleteRows = false;
            this.OrderSearchListOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderSearchListOut.AutoGenerateColumns = false;
            this.OrderSearchListOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderSearchListOut.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.OrderSearchListOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderSearchListOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.creatTimeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.Column4,
            this.Column1});
            this.OrderSearchListOut.DataSource = this.ordersBindingSource;
            this.OrderSearchListOut.Location = new System.Drawing.Point(7, 47);
            this.OrderSearchListOut.MultiSelect = false;
            this.OrderSearchListOut.Name = "OrderSearchListOut";
            this.OrderSearchListOut.ReadOnly = true;
            this.OrderSearchListOut.RowHeadersVisible = false;
            this.OrderSearchListOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderSearchListOut.Size = new System.Drawing.Size(697, 109);
            this.OrderSearchListOut.TabIndex = 2;
            this.OrderSearchListOut.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderSearchListOut_CellDoubleClick);
            // 
            // OrderSearchBut
            // 
            this.OrderSearchBut.Location = new System.Drawing.Point(306, 18);
            this.OrderSearchBut.Name = "OrderSearchBut";
            this.OrderSearchBut.Size = new System.Drawing.Size(75, 23);
            this.OrderSearchBut.TabIndex = 1;
            this.OrderSearchBut.Text = "Поиск";
            this.OrderSearchBut.UseVisualStyleBackColor = true;
            this.OrderSearchBut.Click += new System.EventHandler(this.OrderSearchBut_Click);
            // 
            // OrderTextBoxOSF
            // 
            this.OrderTextBoxOSF.Location = new System.Drawing.Point(7, 20);
            this.OrderTextBoxOSF.Name = "OrderTextBoxOSF";
            this.OrderTextBoxOSF.Size = new System.Drawing.Size(293, 20);
            this.OrderTextBoxOSF.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(12, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтры";
            // 
            // cTBODBDataSet
            // 
            this.cTBODBDataSet.DataSetName = "CTBODBDataSet";
            this.cTBODBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.cTBODBDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creatTimeDataGridViewTextBoxColumn
            // 
            this.creatTimeDataGridViewTextBoxColumn.DataPropertyName = "CreatTime";
            this.creatTimeDataGridViewTextBoxColumn.HeaderText = "Дата создания";
            this.creatTimeDataGridViewTextBoxColumn.Name = "creatTimeDataGridViewTextBoxColumn";
            this.creatTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Phone";
            this.Column4.HeaderText = "phone";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Email";
            this.Column1.HeaderText = "email";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // OrderSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Name = "OrderSearchForm";
            this.Text = "OrderSearchForm";
            this.Load += new System.EventHandler(this.OrderSearchForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderSearchListOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTBODBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button OrderSearchBut;
        private System.Windows.Forms.TextBox OrderTextBoxOSF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView OrderSearchListOut;
        private System.Windows.Forms.Label NoOrder;
        private CTBODBDataSet cTBODBDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private CTBODBDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}