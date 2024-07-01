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
            this.Rb_Manual = new System.Windows.Forms.RadioButton();
            this.Rb_Auto = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Lv_Order
            // 
            this.Lv_Order.CheckBoxes = true;
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
            this.Lv_Order.Location = new System.Drawing.Point(16, 80);
            this.Lv_Order.Name = "Lv_Order";
            this.Lv_Order.Size = new System.Drawing.Size(768, 360);
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
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "위치";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "주문수량";
            this.columnHeader4.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "배송완료수량";
            this.columnHeader5.Width = 142;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "접수시간";
            this.columnHeader6.Width = 148;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "상태";
            this.columnHeader7.Width = 87;
            // 
            // Rb_Manual
            // 
            this.Rb_Manual.AutoSize = true;
            this.Rb_Manual.Checked = true;
            this.Rb_Manual.Location = new System.Drawing.Point(488, 120);
            this.Rb_Manual.Name = "Rb_Manual";
            this.Rb_Manual.Size = new System.Drawing.Size(123, 19);
            this.Rb_Manual.TabIndex = 1;
            this.Rb_Manual.TabStop = true;
            this.Rb_Manual.Text = "물품 자동배송";
            this.Rb_Manual.UseVisualStyleBackColor = true;
            this.Rb_Manual.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Rb_Auto
            // 
            this.Rb_Auto.AutoSize = true;
            this.Rb_Auto.Location = new System.Drawing.Point(656, 120);
            this.Rb_Auto.Name = "Rb_Auto";
            this.Rb_Auto.Size = new System.Drawing.Size(88, 19);
            this.Rb_Auto.TabIndex = 1;
            this.Rb_Auto.Text = "배송정지";
            this.Rb_Auto.UseVisualStyleBackColor = true;
            this.Rb_Auto.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lv_Order);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.RadioButton Rb_Manual;
        private System.Windows.Forms.RadioButton Rb_Auto;
    }
}