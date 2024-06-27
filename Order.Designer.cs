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
            this.Bt_OpenOrder = new System.Windows.Forms.Button();
            this.Lv_Order = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Bt_OpenOrder
            // 
            this.Bt_OpenOrder.Location = new System.Drawing.Point(816, 464);
            this.Bt_OpenOrder.Name = "Bt_OpenOrder";
            this.Bt_OpenOrder.Size = new System.Drawing.Size(96, 56);
            this.Bt_OpenOrder.TabIndex = 0;
            this.Bt_OpenOrder.Text = "주문창";
            this.Bt_OpenOrder.UseVisualStyleBackColor = true;
            this.Bt_OpenOrder.Click += new System.EventHandler(this.Bt_OpenOrder_Click);
            // 
            // Lv_Order
            // 
            this.Lv_Order.HideSelection = false;
            this.Lv_Order.Location = new System.Drawing.Point(8, 8);
            this.Lv_Order.Name = "Lv_Order";
            this.Lv_Order.Size = new System.Drawing.Size(928, 424);
            this.Lv_Order.TabIndex = 1;
            this.Lv_Order.UseCompatibleStateImageBehavior = false;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 573);
            this.Controls.Add(this.Lv_Order);
            this.Controls.Add(this.Bt_OpenOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bt_OpenOrder;
        private System.Windows.Forms.ListView Lv_Order;
    }
}