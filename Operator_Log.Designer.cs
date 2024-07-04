namespace cnHRD_MES_Project
{
    partial class Operator_Log
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
            this.lv_OperatorLog = new System.Windows.Forms.ListView();
            this.TPanel_TopMenu = new System.Windows.Forms.TableLayoutPanel();
            this.TPanel_SubMenu = new System.Windows.Forms.TableLayoutPanel();
            this.Bt_Close = new System.Windows.Forms.Button();
            this.Bt_Maximum = new System.Windows.Forms.Button();
            this.Bt_Minimum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TPanel_TopMenu.SuspendLayout();
            this.TPanel_SubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_OperatorLog
            // 
            this.lv_OperatorLog.HideSelection = false;
            this.lv_OperatorLog.Location = new System.Drawing.Point(24, 88);
            this.lv_OperatorLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_OperatorLog.Name = "lv_OperatorLog";
            this.lv_OperatorLog.Size = new System.Drawing.Size(644, 368);
            this.lv_OperatorLog.TabIndex = 0;
            this.lv_OperatorLog.UseCompatibleStateImageBehavior = false;
            // 
            // TPanel_TopMenu
            // 
            this.TPanel_TopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.TPanel_TopMenu.ColumnCount = 5;
            this.TPanel_TopMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.TPanel_TopMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.TPanel_TopMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TPanel_TopMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.TPanel_TopMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.TPanel_TopMenu.Controls.Add(this.TPanel_SubMenu, 4, 0);
            this.TPanel_TopMenu.Controls.Add(this.label1, 0, 0);
            this.TPanel_TopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.TPanel_TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TPanel_TopMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPanel_TopMenu.Name = "TPanel_TopMenu";
            this.TPanel_TopMenu.RowCount = 1;
            this.TPanel_TopMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TPanel_TopMenu.Size = new System.Drawing.Size(697, 32);
            this.TPanel_TopMenu.TabIndex = 28;
            this.TPanel_TopMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TPanel_MouseDown);
            this.TPanel_TopMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TPanel_MouseMove);
            this.TPanel_TopMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TPanel_MouseUP);
            // 
            // TPanel_SubMenu
            // 
            this.TPanel_SubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.TPanel_SubMenu.ColumnCount = 5;
            this.TPanel_SubMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.TPanel_SubMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.TPanel_SubMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.TPanel_SubMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.TPanel_SubMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.TPanel_SubMenu.Controls.Add(this.Bt_Close, 4, 0);
            this.TPanel_SubMenu.Controls.Add(this.Bt_Maximum, 3, 0);
            this.TPanel_SubMenu.Controls.Add(this.Bt_Minimum, 2, 0);
            this.TPanel_SubMenu.Location = new System.Drawing.Point(487, 0);
            this.TPanel_SubMenu.Margin = new System.Windows.Forms.Padding(0);
            this.TPanel_SubMenu.Name = "TPanel_SubMenu";
            this.TPanel_SubMenu.RowCount = 1;
            this.TPanel_SubMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TPanel_SubMenu.Size = new System.Drawing.Size(210, 32);
            this.TPanel_SubMenu.TabIndex = 1;
            // 
            // Bt_Close
            // 
            this.Bt_Close.FlatAppearance.BorderSize = 0;
            this.Bt_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Close.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_Close.ForeColor = System.Drawing.Color.White;
            this.Bt_Close.Location = new System.Drawing.Point(171, 2);
            this.Bt_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bt_Close.Name = "Bt_Close";
            this.Bt_Close.Size = new System.Drawing.Size(36, 27);
            this.Bt_Close.TabIndex = 0;
            this.Bt_Close.Text = "✕";
            this.Bt_Close.UseVisualStyleBackColor = true;
            this.Bt_Close.Click += new System.EventHandler(this.Bt_Close_Click);
            // 
            // Bt_Maximum
            // 
            this.Bt_Maximum.FlatAppearance.BorderSize = 0;
            this.Bt_Maximum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Maximum.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_Maximum.ForeColor = System.Drawing.Color.White;
            this.Bt_Maximum.Location = new System.Drawing.Point(129, 2);
            this.Bt_Maximum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bt_Maximum.Name = "Bt_Maximum";
            this.Bt_Maximum.Size = new System.Drawing.Size(36, 27);
            this.Bt_Maximum.TabIndex = 0;
            this.Bt_Maximum.Text = "□";
            this.Bt_Maximum.UseVisualStyleBackColor = true;
            this.Bt_Maximum.Click += new System.EventHandler(this.Bt_Maximum_Click);
            // 
            // Bt_Minimum
            // 
            this.Bt_Minimum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.Bt_Minimum.FlatAppearance.BorderSize = 0;
            this.Bt_Minimum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Minimum.ForeColor = System.Drawing.Color.White;
            this.Bt_Minimum.Location = new System.Drawing.Point(87, 2);
            this.Bt_Minimum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bt_Minimum.Name = "Bt_Minimum";
            this.Bt_Minimum.Size = new System.Drawing.Size(36, 27);
            this.Bt_Minimum.TabIndex = 0;
            this.Bt_Minimum.Text = "━";
            this.Bt_Minimum.UseVisualStyleBackColor = false;
            this.Bt_Minimum.Click += new System.EventHandler(this.Bt_Minimum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "공정기록";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Operator_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(218)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(697, 478);
            this.Controls.Add(this.TPanel_TopMenu);
            this.Controls.Add(this.lv_OperatorLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Operator_Log";
            this.Text = "Operator_Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Operator_Log_Closing);
            this.Load += new System.EventHandler(this.Operator_Log_Load);
            this.TPanel_TopMenu.ResumeLayout(false);
            this.TPanel_TopMenu.PerformLayout();
            this.TPanel_SubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_OperatorLog;
        private System.Windows.Forms.TableLayoutPanel TPanel_TopMenu;
        private System.Windows.Forms.TableLayoutPanel TPanel_SubMenu;
        private System.Windows.Forms.Button Bt_Close;
        private System.Windows.Forms.Button Bt_Maximum;
        private System.Windows.Forms.Button Bt_Minimum;
        private System.Windows.Forms.Label label1;
    }
}