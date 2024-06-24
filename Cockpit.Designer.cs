namespace Project_v01
{
    partial class Cockpit
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_PLC_stop = new System.Windows.Forms.Button();
            this.bt_PLC_start = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_Server_off = new System.Windows.Forms.Button();
            this.bt_Server_on = new System.Windows.Forms.Button();
            this.bt_Lamp_stop = new System.Windows.Forms.Button();
            this.bt_Lamp_start = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tb_Error_log = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Clear_log = new System.Windows.Forms.Button();
            this.tmr_Update = new System.Windows.Forms.Timer(this.components);
            this.bt_Save_log = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_PLC_stop);
            this.groupBox1.Controls.Add(this.bt_PLC_start);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.bt_Server_off);
            this.groupBox1.Controls.Add(this.bt_Server_on);
            this.groupBox1.Controls.Add(this.bt_Lamp_stop);
            this.groupBox1.Controls.Add(this.bt_Lamp_start);
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(143, 178);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication";
            // 
            // bt_PLC_stop
            // 
            this.bt_PLC_stop.Location = new System.Drawing.Point(15, 48);
            this.bt_PLC_stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_PLC_stop.Name = "bt_PLC_stop";
            this.bt_PLC_stop.Size = new System.Drawing.Size(78, 21);
            this.bt_PLC_stop.TabIndex = 4;
            this.bt_PLC_stop.Text = "PLC Stop";
            this.bt_PLC_stop.UseVisualStyleBackColor = true;
            this.bt_PLC_stop.Click += new System.EventHandler(this.bt_PLC_stop_Click);
            // 
            // bt_PLC_start
            // 
            this.bt_PLC_start.Location = new System.Drawing.Point(14, 22);
            this.bt_PLC_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_PLC_start.Name = "bt_PLC_start";
            this.bt_PLC_start.Size = new System.Drawing.Size(78, 21);
            this.bt_PLC_start.TabIndex = 4;
            this.bt_PLC_start.Text = "PLC Start";
            this.bt_PLC_start.UseVisualStyleBackColor = true;
            this.bt_PLC_start.Click += new System.EventHandler(this.bt_PLC_start_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "SERVER OFF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "SERVER ON";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "통신속도";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "통신포트";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(106, 98);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 20);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 74);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 20);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bt_Server_off
            // 
            this.bt_Server_off.Location = new System.Drawing.Point(81, 146);
            this.bt_Server_off.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Server_off.Name = "bt_Server_off";
            this.bt_Server_off.Size = new System.Drawing.Size(46, 20);
            this.bt_Server_off.TabIndex = 2;
            this.bt_Server_off.UseVisualStyleBackColor = true;
            // 
            // bt_Server_on
            // 
            this.bt_Server_on.Location = new System.Drawing.Point(81, 122);
            this.bt_Server_on.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Server_on.Name = "bt_Server_on";
            this.bt_Server_on.Size = new System.Drawing.Size(46, 20);
            this.bt_Server_on.TabIndex = 2;
            this.bt_Server_on.UseVisualStyleBackColor = true;
            // 
            // bt_Lamp_stop
            // 
            this.bt_Lamp_stop.Location = new System.Drawing.Point(106, 49);
            this.bt_Lamp_stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Lamp_stop.Name = "bt_Lamp_stop";
            this.bt_Lamp_stop.Size = new System.Drawing.Size(22, 20);
            this.bt_Lamp_stop.TabIndex = 2;
            this.bt_Lamp_stop.UseVisualStyleBackColor = true;
            // 
            // bt_Lamp_start
            // 
            this.bt_Lamp_start.Location = new System.Drawing.Point(106, 24);
            this.bt_Lamp_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Lamp_start.Name = "bt_Lamp_start";
            this.bt_Lamp_start.Size = new System.Drawing.Size(22, 20);
            this.bt_Lamp_start.TabIndex = 2;
            this.bt_Lamp_start.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "서보현재위치";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 12);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 21);
            this.textBox1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "서보현재속도";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "mm/min";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(248, 37);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 21);
            this.textBox2.TabIndex = 4;
            // 
            // tb_Error_log
            // 
            this.tb_Error_log.Location = new System.Drawing.Point(676, 26);
            this.tb_Error_log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Error_log.Multiline = true;
            this.tb_Error_log.Name = "tb_Error_log";
            this.tb_Error_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Error_log.Size = new System.Drawing.Size(246, 78);
            this.tb_Error_log.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Error_log";
            // 
            // tb_Clear_log
            // 
            this.tb_Clear_log.Location = new System.Drawing.Point(676, 115);
            this.tb_Clear_log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Clear_log.Name = "tb_Clear_log";
            this.tb_Clear_log.Size = new System.Drawing.Size(106, 26);
            this.tb_Clear_log.TabIndex = 7;
            this.tb_Clear_log.Text = "Clear";
            this.tb_Clear_log.UseVisualStyleBackColor = true;
            this.tb_Clear_log.Click += new System.EventHandler(this.tb_Clear_log_Click);
            // 
            // tmr_Update
            // 
            this.tmr_Update.Enabled = true;
            this.tmr_Update.Interval = 1;
            this.tmr_Update.Tick += new System.EventHandler(this.tmr_Update_Tick);
            // 
            // bt_Save_log
            // 
            this.bt_Save_log.Location = new System.Drawing.Point(804, 115);
            this.bt_Save_log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Save_log.Name = "bt_Save_log";
            this.bt_Save_log.Size = new System.Drawing.Size(89, 25);
            this.bt_Save_log.TabIndex = 8;
            this.bt_Save_log.Text = "Save";
            this.bt_Save_log.UseVisualStyleBackColor = true;
            this.bt_Save_log.Click += new System.EventHandler(this.bt_Save_log_Click);
            // 
            // Cockpit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 417);
            this.Controls.Add(this.bt_Save_log);
            this.Controls.Add(this.tb_Clear_log);
            this.Controls.Add(this.tb_Error_log);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cockpit";
            this.Text = "CockpitMonitor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Server_off;
        private System.Windows.Forms.Button bt_Server_on;
        private System.Windows.Forms.Button bt_Lamp_stop;
        private System.Windows.Forms.Button bt_Lamp_start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bt_PLC_stop;
        private System.Windows.Forms.Button bt_PLC_start;
        private System.Windows.Forms.TextBox tb_Error_log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tb_Clear_log;
        private System.Windows.Forms.Timer tmr_Update;
        private System.Windows.Forms.Button bt_Save_log;
    }
}

