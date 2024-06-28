namespace cnHRD_MES_Project
{
    partial class Order_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.cb_Location = new System.Windows.Forms.ComboBox();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.bt_Order = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "주문 품목 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "주문 지역 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "주문 수량 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "조이름? 추후 수정 예정";
            // 
            // cb_Type
            // 
            this.cb_Type.AllowDrop = true;
            this.cb_Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_Type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Items.AddRange(new object[] {
            "비금속",
            "금속"});
            this.cb_Type.Location = new System.Drawing.Point(48, 192);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(272, 35);
            this.cb_Type.TabIndex = 7;
            // 
            // cb_Location
            // 
            this.cb_Location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_Location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Location.FormattingEnabled = true;
            this.cb_Location.Items.AddRange(new object[] {
            "서울특별시 서초구",
            "부산광역시 부산진구"});
            this.cb_Location.Location = new System.Drawing.Point(48, 336);
            this.cb_Location.Name = "cb_Location";
            this.cb_Location.Size = new System.Drawing.Size(272, 35);
            this.cb_Location.TabIndex = 8;
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Location = new System.Drawing.Point(48, 448);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(272, 39);
            this.tb_Quantity.TabIndex = 9;
            this.tb_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Quantity_KeyPress);
            // 
            // bt_Order
            // 
            this.bt_Order.Location = new System.Drawing.Point(568, 144);
            this.bt_Order.Name = "bt_Order";
            this.bt_Order.Size = new System.Drawing.Size(112, 112);
            this.bt_Order.TabIndex = 10;
            this.bt_Order.Text = "주문";
            this.bt_Order.UseVisualStyleBackColor = true;
            this.bt_Order.Click += new System.EventHandler(this.bt_Order_Click);
            // 
            // Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 524);
            this.Controls.Add(this.bt_Order);
            this.Controls.Add(this.tb_Quantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Location);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Type);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Order_Form";
            this.Text = "Customer Order UI";
            this.Load += new System.EventHandler(this.Order_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Type;
        private System.Windows.Forms.ComboBox cb_Location;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.Button bt_Order;
    }
}