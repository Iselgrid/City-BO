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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OrderSearchListOut = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderSearchBut = new System.Windows.Forms.Button();
            this.OrderTextBoxOSF = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NoOrder = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderSearchListOut)).BeginInit();
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
            // OrderSearchListOut
            // 
            this.OrderSearchListOut.AllowUserToAddRows = false;
            this.OrderSearchListOut.AllowUserToDeleteRows = false;
            this.OrderSearchListOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderSearchListOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderSearchListOut.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.OrderSearchListOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderSearchListOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column2,
            this.Column3,
            this.State,
            this.Column5});
            this.OrderSearchListOut.Location = new System.Drawing.Point(7, 47);
            this.OrderSearchListOut.MultiSelect = false;
            this.OrderSearchListOut.Name = "OrderSearchListOut";
            this.OrderSearchListOut.ReadOnly = true;
            this.OrderSearchListOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderSearchListOut.Size = new System.Drawing.Size(697, 109);
            this.OrderSearchListOut.TabIndex = 2;
            this.OrderSearchListOut.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderSearchListOut_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Номер заказа";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CreatTime";
            this.Column2.HeaderText = "Дата оформления";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Price";
            this.Column3.HeaderText = "Стоимость";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "Статус";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Title";
            this.Column5.HeaderText = "Клиент";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
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
            // NoOrder
            // 
            this.NoOrder.AutoSize = true;
            this.NoOrder.Location = new System.Drawing.Point(387, 23);
            this.NoOrder.Name = "NoOrder";
            this.NoOrder.Size = new System.Drawing.Size(0, 13);
            this.NoOrder.TabIndex = 3;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderSearchListOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button OrderSearchBut;
        private System.Windows.Forms.TextBox OrderTextBoxOSF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView OrderSearchListOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label NoOrder;
    }
}