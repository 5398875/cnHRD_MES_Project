namespace cnHRD_MES_Project
{
    partial class Operator
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
            this.Bt_OpenPLC = new System.Windows.Forms.Button();
            this.Bt_ClosePLC = new System.Windows.Forms.Button();
            this.Lb_Connect = new System.Windows.Forms.Label();
            this.Lb_ServoConnect = new System.Windows.Forms.Label();
            this.Bt_OpenServo = new System.Windows.Forms.Button();
            this.Tb_Servo1 = new System.Windows.Forms.TextBox();
            this.Tb_Servo2 = new System.Windows.Forms.TextBox();
            this.Tb_Servo3 = new System.Windows.Forms.TextBox();
            this.Tb_Servo4 = new System.Windows.Forms.TextBox();
            this.Tb_Servo5 = new System.Windows.Forms.TextBox();
            this.Tb_Servo6 = new System.Windows.Forms.TextBox();
            this.Tb_Servo7 = new System.Windows.Forms.TextBox();
            this.Tb_ServoLoc = new System.Windows.Forms.TextBox();
            this.Bt_JogDown = new System.Windows.Forms.Button();
            this.Bt_JogUp = new System.Windows.Forms.Button();
            this.Bt_Stop = new System.Windows.Forms.Button();
            this.Bt_Start = new System.Windows.Forms.Button();
            this.Bt_WriteServo = new System.Windows.Forms.Button();
            this.Tb_ServoSpeed = new System.Windows.Forms.TextBox();
            this.Bt_Servo1_Teaching = new System.Windows.Forms.Button();
            this.Bt_Servo2_Teaching = new System.Windows.Forms.Button();
            this.Bt_Servo3_Teaching = new System.Windows.Forms.Button();
            this.Bt_Servo4_Teaching = new System.Windows.Forms.Button();
            this.Bt_Servo5_Teaching = new System.Windows.Forms.Button();
            this.Bt_Servo6_Teaching = new System.Windows.Forms.Button();
            this.Bt_Servo7_Teaching = new System.Windows.Forms.Button();
            this.lb00 = new System.Windows.Forms.Label();
            this.lb10 = new System.Windows.Forms.Label();
            this.lb01 = new System.Windows.Forms.Label();
            this.lb11 = new System.Windows.Forms.Label();
            this.lb02 = new System.Windows.Forms.Label();
            this.lb12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_OperationLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bt_OpenPLC
            // 
            this.Bt_OpenPLC.Location = new System.Drawing.Point(8, 8);
            this.Bt_OpenPLC.Name = "Bt_OpenPLC";
            this.Bt_OpenPLC.Size = new System.Drawing.Size(144, 34);
            this.Bt_OpenPLC.TabIndex = 10;
            this.Bt_OpenPLC.Text = "PLC 연결";
            this.Bt_OpenPLC.UseVisualStyleBackColor = true;
            this.Bt_OpenPLC.Click += new System.EventHandler(this.Bt_OpenPLC_Click);
            // 
            // Bt_ClosePLC
            // 
            this.Bt_ClosePLC.Enabled = false;
            this.Bt_ClosePLC.Location = new System.Drawing.Point(8, 48);
            this.Bt_ClosePLC.Name = "Bt_ClosePLC";
            this.Bt_ClosePLC.Size = new System.Drawing.Size(144, 34);
            this.Bt_ClosePLC.TabIndex = 11;
            this.Bt_ClosePLC.Text = "PLC 연결 해제";
            this.Bt_ClosePLC.UseVisualStyleBackColor = true;
            this.Bt_ClosePLC.Click += new System.EventHandler(this.Bt_ClosePLC_Click);
            // 
            // Lb_Connect
            // 
            this.Lb_Connect.Location = new System.Drawing.Point(8, 88);
            this.Lb_Connect.Name = "Lb_Connect";
            this.Lb_Connect.Size = new System.Drawing.Size(144, 23);
            this.Lb_Connect.TabIndex = 12;
            this.Lb_Connect.Text = "대기중";
            this.Lb_Connect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_ServoConnect
            // 
            this.Lb_ServoConnect.Location = new System.Drawing.Point(184, 48);
            this.Lb_ServoConnect.Name = "Lb_ServoConnect";
            this.Lb_ServoConnect.Size = new System.Drawing.Size(144, 23);
            this.Lb_ServoConnect.TabIndex = 15;
            this.Lb_ServoConnect.Text = "대기중";
            this.Lb_ServoConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bt_OpenServo
            // 
            this.Bt_OpenServo.Enabled = false;
            this.Bt_OpenServo.Location = new System.Drawing.Point(184, 8);
            this.Bt_OpenServo.Name = "Bt_OpenServo";
            this.Bt_OpenServo.Size = new System.Drawing.Size(144, 34);
            this.Bt_OpenServo.TabIndex = 14;
            this.Bt_OpenServo.Text = "서보 준비";
            this.Bt_OpenServo.UseVisualStyleBackColor = true;
            this.Bt_OpenServo.Click += new System.EventHandler(this.Bt_OpenServo_Click);
            // 
            // Tb_Servo1
            // 
            this.Tb_Servo1.Location = new System.Drawing.Point(528, 8);
            this.Tb_Servo1.Name = "Tb_Servo1";
            this.Tb_Servo1.Size = new System.Drawing.Size(144, 25);
            this.Tb_Servo1.TabIndex = 22;
            this.Tb_Servo1.Text = "59460";
            // 
            // Tb_Servo2
            // 
            this.Tb_Servo2.Location = new System.Drawing.Point(528, 40);
            this.Tb_Servo2.Name = "Tb_Servo2";
            this.Tb_Servo2.Size = new System.Drawing.Size(144, 25);
            this.Tb_Servo2.TabIndex = 22;
            this.Tb_Servo2.Text = "165360";
            // 
            // Tb_Servo3
            // 
            this.Tb_Servo3.Location = new System.Drawing.Point(528, 72);
            this.Tb_Servo3.Name = "Tb_Servo3";
            this.Tb_Servo3.Size = new System.Drawing.Size(144, 25);
            this.Tb_Servo3.TabIndex = 22;
            this.Tb_Servo3.Text = "707170";
            // 
            // Tb_Servo4
            // 
            this.Tb_Servo4.Location = new System.Drawing.Point(528, 104);
            this.Tb_Servo4.Name = "Tb_Servo4";
            this.Tb_Servo4.Size = new System.Drawing.Size(144, 25);
            this.Tb_Servo4.TabIndex = 22;
            this.Tb_Servo4.Text = "821650";
            // 
            // Tb_Servo5
            // 
            this.Tb_Servo5.Location = new System.Drawing.Point(528, 136);
            this.Tb_Servo5.Name = "Tb_Servo5";
            this.Tb_Servo5.Size = new System.Drawing.Size(144, 25);
            this.Tb_Servo5.TabIndex = 22;
            this.Tb_Servo5.Text = "1380260";
            // 
            // Tb_Servo6
            // 
            this.Tb_Servo6.Location = new System.Drawing.Point(528, 168);
            this.Tb_Servo6.Name = "Tb_Servo6";
            this.Tb_Servo6.Size = new System.Drawing.Size(144, 25);
            this.Tb_Servo6.TabIndex = 22;
            this.Tb_Servo6.Text = "1461510";
            // 
            // Tb_Servo7
            // 
            this.Tb_Servo7.Location = new System.Drawing.Point(528, 200);
            this.Tb_Servo7.Name = "Tb_Servo7";
            this.Tb_Servo7.Size = new System.Drawing.Size(144, 25);
            this.Tb_Servo7.TabIndex = 22;
            this.Tb_Servo7.Text = "1460630";
            // 
            // Tb_ServoLoc
            // 
            this.Tb_ServoLoc.Location = new System.Drawing.Point(368, 88);
            this.Tb_ServoLoc.Name = "Tb_ServoLoc";
            this.Tb_ServoLoc.Size = new System.Drawing.Size(144, 25);
            this.Tb_ServoLoc.TabIndex = 21;
            // 
            // Bt_JogDown
            // 
            this.Bt_JogDown.Location = new System.Drawing.Point(368, 48);
            this.Bt_JogDown.Name = "Bt_JogDown";
            this.Bt_JogDown.Size = new System.Drawing.Size(144, 34);
            this.Bt_JogDown.TabIndex = 19;
            this.Bt_JogDown.Text = "JOG하";
            this.Bt_JogDown.UseVisualStyleBackColor = true;
            this.Bt_JogDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bt_JogDown_MouseDown);
            this.Bt_JogDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bt_JogDown_MouseUp);
            // 
            // Bt_JogUp
            // 
            this.Bt_JogUp.Location = new System.Drawing.Point(368, 8);
            this.Bt_JogUp.Name = "Bt_JogUp";
            this.Bt_JogUp.Size = new System.Drawing.Size(144, 34);
            this.Bt_JogUp.TabIndex = 18;
            this.Bt_JogUp.Text = "JOG상";
            this.Bt_JogUp.UseVisualStyleBackColor = true;
            this.Bt_JogUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bt_JogUp_MouseDown);
            this.Bt_JogUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bt_JogUp_MouseUp);
            // 
            // Bt_Stop
            // 
            this.Bt_Stop.Location = new System.Drawing.Point(200, 240);
            this.Bt_Stop.Name = "Bt_Stop";
            this.Bt_Stop.Size = new System.Drawing.Size(144, 34);
            this.Bt_Stop.TabIndex = 24;
            this.Bt_Stop.Text = "정지";
            this.Bt_Stop.UseVisualStyleBackColor = true;
            this.Bt_Stop.Click += new System.EventHandler(this.Bt_Stop_Click);
            // 
            // Bt_Start
            // 
            this.Bt_Start.Location = new System.Drawing.Point(200, 200);
            this.Bt_Start.Name = "Bt_Start";
            this.Bt_Start.Size = new System.Drawing.Size(144, 34);
            this.Bt_Start.TabIndex = 23;
            this.Bt_Start.Text = "시작";
            this.Bt_Start.UseVisualStyleBackColor = true;
            this.Bt_Start.Click += new System.EventHandler(this.Bt_Start_Click);
            // 
            // Bt_WriteServo
            // 
            this.Bt_WriteServo.Location = new System.Drawing.Point(760, 96);
            this.Bt_WriteServo.Name = "Bt_WriteServo";
            this.Bt_WriteServo.Size = new System.Drawing.Size(144, 34);
            this.Bt_WriteServo.TabIndex = 25;
            this.Bt_WriteServo.Text = "서보에 쓰기";
            this.Bt_WriteServo.UseVisualStyleBackColor = true;
            this.Bt_WriteServo.Click += new System.EventHandler(this.Bt_WriteServo_Click);
            // 
            // Tb_ServoSpeed
            // 
            this.Tb_ServoSpeed.Location = new System.Drawing.Point(656, 256);
            this.Tb_ServoSpeed.Name = "Tb_ServoSpeed";
            this.Tb_ServoSpeed.Size = new System.Drawing.Size(144, 25);
            this.Tb_ServoSpeed.TabIndex = 26;
            this.Tb_ServoSpeed.Text = "4000";
            // 
            // Bt_Servo1_Teaching
            // 
            this.Bt_Servo1_Teaching.Location = new System.Drawing.Point(680, 8);
            this.Bt_Servo1_Teaching.Name = "Bt_Servo1_Teaching";
            this.Bt_Servo1_Teaching.Size = new System.Drawing.Size(48, 24);
            this.Bt_Servo1_Teaching.TabIndex = 27;
            this.Bt_Servo1_Teaching.Text = "티칭";
            this.Bt_Servo1_Teaching.UseVisualStyleBackColor = true;
            this.Bt_Servo1_Teaching.Click += new System.EventHandler(this.Bt_Servo1_Teaching_Click);
            // 
            // Bt_Servo2_Teaching
            // 
            this.Bt_Servo2_Teaching.Location = new System.Drawing.Point(680, 40);
            this.Bt_Servo2_Teaching.Name = "Bt_Servo2_Teaching";
            this.Bt_Servo2_Teaching.Size = new System.Drawing.Size(48, 24);
            this.Bt_Servo2_Teaching.TabIndex = 27;
            this.Bt_Servo2_Teaching.Text = "티칭";
            this.Bt_Servo2_Teaching.UseVisualStyleBackColor = true;
            this.Bt_Servo2_Teaching.Click += new System.EventHandler(this.Bt_Servo2_Teaching_Click);
            // 
            // Bt_Servo3_Teaching
            // 
            this.Bt_Servo3_Teaching.Location = new System.Drawing.Point(680, 72);
            this.Bt_Servo3_Teaching.Name = "Bt_Servo3_Teaching";
            this.Bt_Servo3_Teaching.Size = new System.Drawing.Size(48, 24);
            this.Bt_Servo3_Teaching.TabIndex = 27;
            this.Bt_Servo3_Teaching.Text = "티칭";
            this.Bt_Servo3_Teaching.UseVisualStyleBackColor = true;
            this.Bt_Servo3_Teaching.Click += new System.EventHandler(this.Bt_Servo3_Teaching_Click);
            // 
            // Bt_Servo4_Teaching
            // 
            this.Bt_Servo4_Teaching.Location = new System.Drawing.Point(680, 104);
            this.Bt_Servo4_Teaching.Name = "Bt_Servo4_Teaching";
            this.Bt_Servo4_Teaching.Size = new System.Drawing.Size(48, 24);
            this.Bt_Servo4_Teaching.TabIndex = 27;
            this.Bt_Servo4_Teaching.Text = "티칭";
            this.Bt_Servo4_Teaching.UseVisualStyleBackColor = true;
            this.Bt_Servo4_Teaching.Click += new System.EventHandler(this.Bt_Servo4_Teaching_Click);
            // 
            // Bt_Servo5_Teaching
            // 
            this.Bt_Servo5_Teaching.Location = new System.Drawing.Point(680, 136);
            this.Bt_Servo5_Teaching.Name = "Bt_Servo5_Teaching";
            this.Bt_Servo5_Teaching.Size = new System.Drawing.Size(48, 24);
            this.Bt_Servo5_Teaching.TabIndex = 27;
            this.Bt_Servo5_Teaching.Text = "티칭";
            this.Bt_Servo5_Teaching.UseVisualStyleBackColor = true;
            this.Bt_Servo5_Teaching.Click += new System.EventHandler(this.Bt_Servo5_Teaching_Click);
            // 
            // Bt_Servo6_Teaching
            // 
            this.Bt_Servo6_Teaching.Location = new System.Drawing.Point(680, 168);
            this.Bt_Servo6_Teaching.Name = "Bt_Servo6_Teaching";
            this.Bt_Servo6_Teaching.Size = new System.Drawing.Size(48, 24);
            this.Bt_Servo6_Teaching.TabIndex = 27;
            this.Bt_Servo6_Teaching.Text = "티칭";
            this.Bt_Servo6_Teaching.UseVisualStyleBackColor = true;
            this.Bt_Servo6_Teaching.Click += new System.EventHandler(this.Bt_Servo6_Teaching_Click);
            // 
            // Bt_Servo7_Teaching
            // 
            this.Bt_Servo7_Teaching.Location = new System.Drawing.Point(680, 200);
            this.Bt_Servo7_Teaching.Name = "Bt_Servo7_Teaching";
            this.Bt_Servo7_Teaching.Size = new System.Drawing.Size(48, 24);
            this.Bt_Servo7_Teaching.TabIndex = 27;
            this.Bt_Servo7_Teaching.Text = "티칭";
            this.Bt_Servo7_Teaching.UseVisualStyleBackColor = true;
            this.Bt_Servo7_Teaching.Click += new System.EventHandler(this.Bt_Servo7_Teaching_Click);
            // 
            // lb00
            // 
            this.lb00.AutoSize = true;
            this.lb00.Location = new System.Drawing.Point(104, 400);
            this.lb00.Name = "lb00";
            this.lb00.Size = new System.Drawing.Size(15, 15);
            this.lb00.TabIndex = 28;
            this.lb00.Text = "1";
            // 
            // lb10
            // 
            this.lb10.AutoSize = true;
            this.lb10.Location = new System.Drawing.Point(160, 400);
            this.lb10.Name = "lb10";
            this.lb10.Size = new System.Drawing.Size(15, 15);
            this.lb10.TabIndex = 28;
            this.lb10.Text = "1";
            // 
            // lb01
            // 
            this.lb01.AutoSize = true;
            this.lb01.Location = new System.Drawing.Point(104, 384);
            this.lb01.Name = "lb01";
            this.lb01.Size = new System.Drawing.Size(15, 15);
            this.lb01.TabIndex = 28;
            this.lb01.Text = "1";
            // 
            // lb11
            // 
            this.lb11.AutoSize = true;
            this.lb11.Location = new System.Drawing.Point(160, 384);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(15, 15);
            this.lb11.TabIndex = 28;
            this.lb11.Text = "1";
            // 
            // lb02
            // 
            this.lb02.AutoSize = true;
            this.lb02.Location = new System.Drawing.Point(104, 368);
            this.lb02.Name = "lb02";
            this.lb02.Size = new System.Drawing.Size(15, 15);
            this.lb02.TabIndex = 28;
            this.lb02.Text = "1";
            // 
            // lb12
            // 
            this.lb12.AutoSize = true;
            this.lb12.Location = new System.Drawing.Point(160, 368);
            this.lb12.Name = "lb12";
            this.lb12.Size = new System.Drawing.Size(15, 15);
            this.lb12.TabIndex = 28;
            this.lb12.Text = "1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 360);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 25);
            this.textBox1.TabIndex = 29;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(472, 360);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 25);
            this.textBox2.TabIndex = 29;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(624, 360);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 25);
            this.textBox3.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "imode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "ideliv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "label3";
            // 
            // bt_OperationLog
            // 
            this.bt_OperationLog.Location = new System.Drawing.Point(40, 216);
            this.bt_OperationLog.Name = "bt_OperationLog";
            this.bt_OperationLog.Size = new System.Drawing.Size(104, 56);
            this.bt_OperationLog.TabIndex = 33;
            this.bt_OperationLog.Text = "공정 기록";
            this.bt_OperationLog.UseVisualStyleBackColor = true;
            // 
            // Operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.bt_OperationLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb12);
            this.Controls.Add(this.lb02);
            this.Controls.Add(this.lb11);
            this.Controls.Add(this.lb01);
            this.Controls.Add(this.lb10);
            this.Controls.Add(this.lb00);
            this.Controls.Add(this.Bt_Servo7_Teaching);
            this.Controls.Add(this.Bt_Servo6_Teaching);
            this.Controls.Add(this.Bt_Servo5_Teaching);
            this.Controls.Add(this.Bt_Servo4_Teaching);
            this.Controls.Add(this.Bt_Servo3_Teaching);
            this.Controls.Add(this.Bt_Servo2_Teaching);
            this.Controls.Add(this.Bt_Servo1_Teaching);
            this.Controls.Add(this.Tb_ServoSpeed);
            this.Controls.Add(this.Bt_WriteServo);
            this.Controls.Add(this.Tb_Servo7);
            this.Controls.Add(this.Bt_Stop);
            this.Controls.Add(this.Tb_Servo6);
            this.Controls.Add(this.Bt_OpenPLC);
            this.Controls.Add(this.Tb_Servo5);
            this.Controls.Add(this.Bt_Start);
            this.Controls.Add(this.Tb_Servo4);
            this.Controls.Add(this.Bt_ClosePLC);
            this.Controls.Add(this.Tb_Servo3);
            this.Controls.Add(this.Bt_JogUp);
            this.Controls.Add(this.Tb_Servo2);
            this.Controls.Add(this.Tb_ServoLoc);
            this.Controls.Add(this.Tb_Servo1);
            this.Controls.Add(this.Lb_Connect);
            this.Controls.Add(this.Bt_OpenServo);
            this.Controls.Add(this.Bt_JogDown);
            this.Controls.Add(this.Lb_ServoConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Operator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Bt_OpenPLC;
        private System.Windows.Forms.Button Bt_ClosePLC;
        private System.Windows.Forms.Label Lb_Connect;
        private System.Windows.Forms.Label Lb_ServoConnect;
        private System.Windows.Forms.Button Bt_OpenServo;
        private System.Windows.Forms.TextBox Tb_Servo1;
        private System.Windows.Forms.TextBox Tb_Servo2;
        private System.Windows.Forms.TextBox Tb_Servo3;
        private System.Windows.Forms.TextBox Tb_Servo4;
        private System.Windows.Forms.TextBox Tb_Servo5;
        private System.Windows.Forms.TextBox Tb_Servo6;
        private System.Windows.Forms.TextBox Tb_Servo7;
        private System.Windows.Forms.TextBox Tb_ServoLoc;
        private System.Windows.Forms.Button Bt_JogDown;
        private System.Windows.Forms.Button Bt_JogUp;
        private System.Windows.Forms.Button Bt_Stop;
        private System.Windows.Forms.Button Bt_Start;
        private System.Windows.Forms.Button Bt_WriteServo;
        private System.Windows.Forms.TextBox Tb_ServoSpeed;
        private System.Windows.Forms.Button Bt_Servo1_Teaching;
        private System.Windows.Forms.Button Bt_Servo2_Teaching;
        private System.Windows.Forms.Button Bt_Servo3_Teaching;
        private System.Windows.Forms.Button Bt_Servo4_Teaching;
        private System.Windows.Forms.Button Bt_Servo5_Teaching;
        private System.Windows.Forms.Button Bt_Servo6_Teaching;
        private System.Windows.Forms.Button Bt_Servo7_Teaching;
        private System.Windows.Forms.Label lb00;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.Label lb01;
        private System.Windows.Forms.Label lb11;
        private System.Windows.Forms.Label lb02;
        private System.Windows.Forms.Label lb12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_OperationLog;
    }
}

