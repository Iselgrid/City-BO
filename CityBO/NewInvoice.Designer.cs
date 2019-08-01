namespace CityBO
{
    partial class NewInvoice
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
            this.CancelBut = new System.Windows.Forms.Button();
            this.OKBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderNum = new System.Windows.Forms.TextBox();
            this.InvoiceNum = new System.Windows.Forms.TextBox();
            this.ToPay = new System.Windows.Forms.TextBox();
            this.NoExtraAmount = new System.Windows.Forms.TextBox();
            this.Comment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TimeLimitDatas = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // CancelBut
            // 
            this.CancelBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBut.Location = new System.Drawing.Point(523, 143);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(75, 23);
            this.CancelBut.TabIndex = 0;
            this.CancelBut.Text = "Отмена";
            this.CancelBut.UseVisualStyleBackColor = true;
            this.CancelBut.Click += new System.EventHandler(this.CancelBut_Click);
            // 
            // OKBut
            // 
            this.OKBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKBut.Location = new System.Drawing.Point(442, 143);
            this.OKBut.Name = "OKBut";
            this.OKBut.Size = new System.Drawing.Size(75, 23);
            this.OKBut.TabIndex = 1;
            this.OKBut.Text = "Выставить";
            this.OKBut.UseVisualStyleBackColor = true;
            this.OKBut.Click += new System.EventHandler(this.OKBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Заказ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Счет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сумма";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Нетто";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Оплатить до";
            // 
            // OrderNum
            // 
            this.OrderNum.Location = new System.Drawing.Point(112, 10);
            this.OrderNum.Name = "OrderNum";
            this.OrderNum.Size = new System.Drawing.Size(167, 20);
            this.OrderNum.TabIndex = 7;
            // 
            // InvoiceNum
            // 
            this.InvoiceNum.Location = new System.Drawing.Point(112, 35);
            this.InvoiceNum.Name = "InvoiceNum";
            this.InvoiceNum.Size = new System.Drawing.Size(167, 20);
            this.InvoiceNum.TabIndex = 8;
            // 
            // ToPay
            // 
            this.ToPay.Location = new System.Drawing.Point(112, 61);
            this.ToPay.Name = "ToPay";
            this.ToPay.Size = new System.Drawing.Size(167, 20);
            this.ToPay.TabIndex = 9;
            // 
            // NoExtraAmount
            // 
            this.NoExtraAmount.Location = new System.Drawing.Point(112, 87);
            this.NoExtraAmount.Name = "NoExtraAmount";
            this.NoExtraAmount.Size = new System.Drawing.Size(167, 20);
            this.NoExtraAmount.TabIndex = 10;
            // 
            // Comment
            // 
            this.Comment.Location = new System.Drawing.Point(285, 38);
            this.Comment.Multiline = true;
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(313, 95);
            this.Comment.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Комментарий";
            // 
            // TimeLimitDatas
            // 
            this.TimeLimitDatas.CustomFormat = "dd.MM.yyyy hh:mm";
            this.TimeLimitDatas.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeLimitDatas.Location = new System.Drawing.Point(112, 110);
            this.TimeLimitDatas.Name = "TimeLimitDatas";
            this.TimeLimitDatas.Size = new System.Drawing.Size(167, 20);
            this.TimeLimitDatas.TabIndex = 15;
            // 
            // NewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 178);
            this.Controls.Add(this.TimeLimitDatas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.NoExtraAmount);
            this.Controls.Add(this.ToPay);
            this.Controls.Add(this.InvoiceNum);
            this.Controls.Add(this.OrderNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OKBut);
            this.Controls.Add(this.CancelBut);
            this.Name = "NewInvoice";
            this.Text = "NewInvoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBut;
        private System.Windows.Forms.Button OKBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OrderNum;
        private System.Windows.Forms.TextBox InvoiceNum;
        private System.Windows.Forms.TextBox ToPay;
        private System.Windows.Forms.TextBox NoExtraAmount;
        private System.Windows.Forms.TextBox Comment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker TimeLimitDatas;
    }
}