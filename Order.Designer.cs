namespace cnHRD_MES_Project
{
    partial class Order
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
            this.Lv_Order = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rb_Auto = new System.Windows.Forms.RadioButton();
            this.Rb_Stop = new System.Windows.Forms.RadioButton();
            this.Lb_Now = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lv_Order
            // 
            this.Lv_Order.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.Lv_Order.FullRowSelect = true;
            this.Lv_Order.GridLines = true;
            this.Lv_Order.HideSelection = false;
            this.Lv_Order.Location = new System.Drawing.Point(32, 168);
            this.Lv_Order.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Lv_Order.Name = "Lv_Order";
            this.Lv_Order.Size = new System.Drawing.Size(1016, 368);
            this.Lv_Order.TabIndex = 0;
            this.Lv_Order.UseCompatibleStateImageBehavior = false;
            this.Lv_Order.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "번호";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "제품";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "위치";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "주문수량";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "배송완료";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 99;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "접수시간";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 148;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "상태";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 620;
            // 
            // Rb_Auto
            // 
            this.Rb_Auto.AutoSize = true;
            this.Rb_Auto.Checked = true;
            this.Rb_Auto.Location = new System.Drawing.Point(325, 128);
            this.Rb_Auto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rb_Auto.Name = "Rb_Auto";
            this.Rb_Auto.Size = new System.Drawing.Size(99, 16);
            this.Rb_Auto.TabIndex = 1;
            this.Rb_Auto.TabStop = true;
            this.Rb_Auto.Text = "물품 자동배송";
            this.Rb_Auto.UseVisualStyleBackColor = true;
            this.Rb_Auto.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Rb_Stop
            // 
            this.Rb_Stop.AutoSize = true;
            this.Rb_Stop.Location = new System.Drawing.Point(472, 128);
            this.Rb_Stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rb_Stop.Name = "Rb_Stop";
            this.Rb_Stop.Size = new System.Drawing.Size(71, 16);
            this.Rb_Stop.TabIndex = 1;
            this.Rb_Stop.Text = "배송정지";
            this.Rb_Stop.UseVisualStyleBackColor = true;
            this.Rb_Stop.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Lb_Now
            // 
            this.Lb_Now.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lb_Now.Location = new System.Drawing.Point(784, 120);
            this.Lb_Now.Name = "Lb_Now";
            this.Lb_Now.Size = new System.Drawing.Size(264, 40);
            this.Lb_Now.TabIndex = 2;
            this.Lb_Now.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(113)))), ((int)(((byte)(129)))));
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1016, 80);
            this.label1.TabIndex = 3;
            this.label1.Text = "주문관리 / 배송현황";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(218)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1083, 570);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lb_Now);
            this.Controls.Add(this.Rb_Stop);
            this.Controls.Add(this.Rb_Auto);
            this.Controls.Add(this.Lv_Order);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Order";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView Lv_Order;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.RadioButton Rb_Auto;
        private System.Windows.Forms.RadioButton Rb_Stop;
        private System.Windows.Forms.Label Lb_Now;
        private System.Windows.Forms.Label label1;
    }
}