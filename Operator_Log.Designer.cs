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
            this.SuspendLayout();
            // 
            // lv_OperatorLog
            // 
            this.lv_OperatorLog.HideSelection = false;
            this.lv_OperatorLog.Location = new System.Drawing.Point(32, 64);
            this.lv_OperatorLog.Name = "lv_OperatorLog";
            this.lv_OperatorLog.Size = new System.Drawing.Size(736, 360);
            this.lv_OperatorLog.TabIndex = 0;
            this.lv_OperatorLog.UseCompatibleStateImageBehavior = false;
            // 
            // Operator_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lv_OperatorLog);
            this.Name = "Operator_Log";
            this.Text = "Operator_Log";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_OperatorLog;
    }
}