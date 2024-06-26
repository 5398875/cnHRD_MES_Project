﻿namespace cnHRD_MES_Project
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
            this.bt_OperationLog = new System.Windows.Forms.Button();
            this.bt_Result = new System.Windows.Forms.Button();
            this.Pn_PLC = new System.Windows.Forms.Panel();
            this.Rb_OpenPLC = new System.Windows.Forms.RadioButton();
            this.Rb_ClosePLC = new System.Windows.Forms.RadioButton();
            this.Pn_PLCRb = new System.Windows.Forms.Panel();
            this.Pn_PLC.SuspendLayout();
            this.Pn_PLCRb.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bt_OpenPLC
            // 
            this.Bt_OpenPLC.BackColor = System.Drawing.Color.DarkGray;
            this.Bt_OpenPLC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Bt_OpenPLC.FlatAppearance.BorderSize = 2;
            this.Bt_OpenPLC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.Bt_OpenPLC.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_OpenPLC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bt_OpenPLC.Location = new System.Drawing.Point(136, 80);
            this.Bt_OpenPLC.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_OpenPLC.Name = "Bt_OpenPLC";
            this.Bt_OpenPLC.Size = new System.Drawing.Size(198, 41);
            this.Bt_OpenPLC.TabIndex = 10;
            this.Bt_OpenPLC.Text = "PLC 연결";
            this.Bt_OpenPLC.UseVisualStyleBackColor = false;
            this.Bt_OpenPLC.Click += new System.EventHandler(this.Bt_OpenPLC_Click);
            // 
            // Bt_ClosePLC
            // 
            this.Bt_ClosePLC.BackColor = System.Drawing.Color.DarkGray;
            this.Bt_ClosePLC.Enabled = false;
            this.Bt_ClosePLC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Bt_ClosePLC.FlatAppearance.BorderSize = 2;
            this.Bt_ClosePLC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.Bt_ClosePLC.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_ClosePLC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bt_ClosePLC.Location = new System.Drawing.Point(136, 128);
            this.Bt_ClosePLC.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_ClosePLC.Name = "Bt_ClosePLC";
            this.Bt_ClosePLC.Size = new System.Drawing.Size(198, 41);
            this.Bt_ClosePLC.TabIndex = 11;
            this.Bt_ClosePLC.Text = "PLC 연결 해제";
            this.Bt_ClosePLC.UseVisualStyleBackColor = false;
            this.Bt_ClosePLC.Click += new System.EventHandler(this.Bt_ClosePLC_Click);
            // 
            // Lb_Connect
            // 
            this.Lb_Connect.Location = new System.Drawing.Point(136, 176);
            this.Lb_Connect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Connect.Name = "Lb_Connect";
            this.Lb_Connect.Size = new System.Drawing.Size(198, 28);
            this.Lb_Connect.TabIndex = 12;
            this.Lb_Connect.Text = "대기중";
            this.Lb_Connect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_ServoConnect
            // 
            this.Lb_ServoConnect.Location = new System.Drawing.Point(352, 128);
            this.Lb_ServoConnect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_ServoConnect.Name = "Lb_ServoConnect";
            this.Lb_ServoConnect.Size = new System.Drawing.Size(198, 28);
            this.Lb_ServoConnect.TabIndex = 15;
            this.Lb_ServoConnect.Text = "대기중";
            this.Lb_ServoConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bt_OpenServo
            // 
            this.Bt_OpenServo.BackColor = System.Drawing.Color.DarkGray;
            this.Bt_OpenServo.Enabled = false;
            this.Bt_OpenServo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Bt_OpenServo.FlatAppearance.BorderSize = 2;
            this.Bt_OpenServo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.Bt_OpenServo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_OpenServo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bt_OpenServo.Location = new System.Drawing.Point(352, 80);
            this.Bt_OpenServo.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_OpenServo.Name = "Bt_OpenServo";
            this.Bt_OpenServo.Size = new System.Drawing.Size(198, 41);
            this.Bt_OpenServo.TabIndex = 14;
            this.Bt_OpenServo.Text = "서보 준비";
            this.Bt_OpenServo.UseVisualStyleBackColor = false;
            this.Bt_OpenServo.Click += new System.EventHandler(this.Bt_OpenServo_Click);
            // 
            // Tb_Servo1
            // 
            this.Tb_Servo1.Location = new System.Drawing.Point(782, 82);
            this.Tb_Servo1.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Servo1.Name = "Tb_Servo1";
            this.Tb_Servo1.Size = new System.Drawing.Size(197, 24);
            this.Tb_Servo1.TabIndex = 22;
            this.Tb_Servo1.Text = "59460";
            // 
            // Tb_Servo2
            // 
            this.Tb_Servo2.Location = new System.Drawing.Point(782, 120);
            this.Tb_Servo2.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Servo2.Name = "Tb_Servo2";
            this.Tb_Servo2.Size = new System.Drawing.Size(197, 24);
            this.Tb_Servo2.TabIndex = 22;
            this.Tb_Servo2.Text = "165360";
            // 
            // Tb_Servo3
            // 
            this.Tb_Servo3.Location = new System.Drawing.Point(782, 158);
            this.Tb_Servo3.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Servo3.Name = "Tb_Servo3";
            this.Tb_Servo3.Size = new System.Drawing.Size(197, 24);
            this.Tb_Servo3.TabIndex = 22;
            this.Tb_Servo3.Text = "707170";
            // 
            // Tb_Servo4
            // 
            this.Tb_Servo4.Location = new System.Drawing.Point(782, 197);
            this.Tb_Servo4.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Servo4.Name = "Tb_Servo4";
            this.Tb_Servo4.Size = new System.Drawing.Size(197, 24);
            this.Tb_Servo4.TabIndex = 22;
            this.Tb_Servo4.Text = "821650";
            // 
            // Tb_Servo5
            // 
            this.Tb_Servo5.Location = new System.Drawing.Point(782, 235);
            this.Tb_Servo5.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Servo5.Name = "Tb_Servo5";
            this.Tb_Servo5.Size = new System.Drawing.Size(197, 24);
            this.Tb_Servo5.TabIndex = 22;
            this.Tb_Servo5.Text = "1380260";
            // 
            // Tb_Servo6
            // 
            this.Tb_Servo6.Location = new System.Drawing.Point(782, 274);
            this.Tb_Servo6.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Servo6.Name = "Tb_Servo6";
            this.Tb_Servo6.Size = new System.Drawing.Size(197, 24);
            this.Tb_Servo6.TabIndex = 22;
            this.Tb_Servo6.Text = "1461510";
            // 
            // Tb_Servo7
            // 
            this.Tb_Servo7.Location = new System.Drawing.Point(782, 312);
            this.Tb_Servo7.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Servo7.Name = "Tb_Servo7";
            this.Tb_Servo7.Size = new System.Drawing.Size(197, 24);
            this.Tb_Servo7.TabIndex = 22;
            this.Tb_Servo7.Text = "1460630";
            // 
            // Tb_ServoLoc
            // 
            this.Tb_ServoLoc.Location = new System.Drawing.Point(562, 178);
            this.Tb_ServoLoc.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_ServoLoc.Name = "Tb_ServoLoc";
            this.Tb_ServoLoc.Size = new System.Drawing.Size(197, 24);
            this.Tb_ServoLoc.TabIndex = 21;
            // 
            // Bt_JogDown
            // 
            this.Bt_JogDown.BackColor = System.Drawing.Color.DarkGray;
            this.Bt_JogDown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Bt_JogDown.FlatAppearance.BorderSize = 2;
            this.Bt_JogDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.Bt_JogDown.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_JogDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bt_JogDown.Location = new System.Drawing.Point(562, 130);
            this.Bt_JogDown.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_JogDown.Name = "Bt_JogDown";
            this.Bt_JogDown.Size = new System.Drawing.Size(198, 41);
            this.Bt_JogDown.TabIndex = 19;
            this.Bt_JogDown.Text = "JOG하";
            this.Bt_JogDown.UseVisualStyleBackColor = false;
            this.Bt_JogDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bt_JogDown_MouseDown);
            this.Bt_JogDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bt_JogDown_MouseUp);
            // 
            // Bt_JogUp
            // 
            this.Bt_JogUp.BackColor = System.Drawing.Color.DarkGray;
            this.Bt_JogUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Bt_JogUp.FlatAppearance.BorderSize = 2;
            this.Bt_JogUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.Bt_JogUp.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_JogUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bt_JogUp.Location = new System.Drawing.Point(562, 82);
            this.Bt_JogUp.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_JogUp.Name = "Bt_JogUp";
            this.Bt_JogUp.Size = new System.Drawing.Size(198, 41);
            this.Bt_JogUp.TabIndex = 18;
            this.Bt_JogUp.Text = "JOG상";
            this.Bt_JogUp.UseVisualStyleBackColor = false;
            this.Bt_JogUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bt_JogUp_MouseDown);
            this.Bt_JogUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bt_JogUp_MouseUp);
            // 
            // Bt_Stop
            // 
            this.Bt_Stop.BackColor = System.Drawing.Color.DarkGray;
            this.Bt_Stop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Bt_Stop.FlatAppearance.BorderSize = 2;
            this.Bt_Stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.Bt_Stop.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_Stop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bt_Stop.Location = new System.Drawing.Point(376, 344);
            this.Bt_Stop.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_Stop.Name = "Bt_Stop";
            this.Bt_Stop.Size = new System.Drawing.Size(198, 41);
            this.Bt_Stop.TabIndex = 24;
            this.Bt_Stop.Text = "정지";
            this.Bt_Stop.UseVisualStyleBackColor = false;
            this.Bt_Stop.Click += new System.EventHandler(this.Bt_Stop_Click);
            // 
            // Bt_Start
            // 
            this.Bt_Start.BackColor = System.Drawing.Color.DarkGray;
            this.Bt_Start.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Bt_Start.FlatAppearance.BorderSize = 2;
            this.Bt_Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.Bt_Start.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_Start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bt_Start.Location = new System.Drawing.Point(376, 296);
            this.Bt_Start.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_Start.Name = "Bt_Start";
            this.Bt_Start.Size = new System.Drawing.Size(198, 41);
            this.Bt_Start.TabIndex = 23;
            this.Bt_Start.Text = "시작";
            this.Bt_Start.UseVisualStyleBackColor = false;
            this.Bt_Start.Click += new System.EventHandler(this.Bt_Start_Click);
            // 
            // Bt_WriteServo
            // 
            this.Bt_WriteServo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Bt_WriteServo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_WriteServo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Bt_WriteServo.Location = new System.Drawing.Point(1101, 187);
            this.Bt_WriteServo.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_WriteServo.Name = "Bt_WriteServo";
            this.Bt_WriteServo.Size = new System.Drawing.Size(198, 41);
            this.Bt_WriteServo.TabIndex = 25;
            this.Bt_WriteServo.Text = "서보에 쓰기";
            this.Bt_WriteServo.UseVisualStyleBackColor = false;
            this.Bt_WriteServo.Click += new System.EventHandler(this.Bt_WriteServo_Click);
            // 
            // Tb_ServoSpeed
            // 
            this.Tb_ServoSpeed.Location = new System.Drawing.Point(958, 379);
            this.Tb_ServoSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_ServoSpeed.Name = "Tb_ServoSpeed";
            this.Tb_ServoSpeed.Size = new System.Drawing.Size(197, 24);
            this.Tb_ServoSpeed.TabIndex = 26;
            this.Tb_ServoSpeed.Text = "4000";
            // 
            // Bt_Servo1_Teaching
            // 
            this.Bt_Servo1_Teaching.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Bt_Servo1_Teaching.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_Servo1_Teaching.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Bt_Servo1_Teaching.Location = new System.Drawing.Point(991, 82);
            this.Bt_Servo1_Teaching.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_Servo1_Teaching.Name = "Bt_Servo1_Teaching";
            this.Bt_Servo1_Teaching.Size = new System.Drawing.Size(66, 29);
            this.Bt_Servo1_Teaching.TabIndex = 27;
            this.Bt_Servo1_Teaching.Text = "티칭";
            this.Bt_Servo1_Teaching.UseVisualStyleBackColor = false;
            this.Bt_Servo1_Teaching.Click += new System.EventHandler(this.Bt_Servo1_Teaching_Click);
            // 
            // Bt_Servo2_Teaching
            // 
            this.Bt_Servo2_Teaching.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Bt_Servo2_Teaching.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_Servo2_Teaching.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Bt_Servo2_Teaching.Location = new System.Drawing.Point(991, 120);
            this.Bt_Servo2_Teaching.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_Servo2_Teaching.Name = "Bt_Servo2_Teaching";
            this.Bt_Servo2_Teaching.Size = new System.Drawing.Size(66, 29);
            this.Bt_Servo2_Teaching.TabIndex = 27;
            this.Bt_Servo2_Teaching.Text = "티칭";
            this.Bt_Servo2_Teaching.UseVisualStyleBackColor = false;
            this.Bt_Servo2_Teaching.Click += new System.EventHandler(this.Bt_Servo2_Teaching_Click);
            // 
            // Bt_Servo3_Teaching
            // 
            this.Bt_Servo3_Teaching.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Bt_Servo3_Teaching.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_Servo3_Teaching.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Bt_Servo3_Teaching.Location = new System.Drawing.Point(991, 158);
            this.Bt_Servo3_Teaching.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_Servo3_Teaching.Name = "Bt_Servo3_Teaching";
            this.Bt_Servo3_Teaching.Size = new System.Drawing.Size(66, 29);
            this.Bt_Servo3_Teaching.TabIndex = 27;
            this.Bt_Servo3_Teaching.Text = "티칭";
            this.Bt_Servo3_Teaching.UseVisualStyleBackColor = false;
            this.Bt_Servo3_Teaching.Click += new System.EventHandler(this.Bt_Servo3_Teaching_Click);
            // 
            // Bt_Servo4_Teaching
            // 
            this.Bt_Servo4_Teaching.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Bt_Servo4_Teaching.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_Servo4_Teaching.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Bt_Servo4_Teaching.Location = new System.Drawing.Point(991, 197);
            this.Bt_Servo4_Teaching.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_Servo4_Teaching.Name = "Bt_Servo4_Teaching";
            this.Bt_Servo4_Teaching.Size = new System.Drawing.Size(66, 29);
            this.Bt_Servo4_Teaching.TabIndex = 27;
            this.Bt_Servo4_Teaching.Text = "티칭";
            this.Bt_Servo4_Teaching.UseVisualStyleBackColor = false;
            this.Bt_Servo4_Teaching.Click += new System.EventHandler(this.Bt_Servo4_Teaching_Click);
            // 
            // Bt_Servo5_Teaching
            // 
            this.Bt_Servo5_Teaching.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Bt_Servo5_Teaching.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_Servo5_Teaching.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Bt_Servo5_Teaching.Location = new System.Drawing.Point(991, 235);
            this.Bt_Servo5_Teaching.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_Servo5_Teaching.Name = "Bt_Servo5_Teaching";
            this.Bt_Servo5_Teaching.Size = new System.Drawing.Size(66, 29);
            this.Bt_Servo5_Teaching.TabIndex = 27;
            this.Bt_Servo5_Teaching.Text = "티칭";
            this.Bt_Servo5_Teaching.UseVisualStyleBackColor = false;
            this.Bt_Servo5_Teaching.Click += new System.EventHandler(this.Bt_Servo5_Teaching_Click);
            // 
            // Bt_Servo6_Teaching
            // 
            this.Bt_Servo6_Teaching.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Bt_Servo6_Teaching.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_Servo6_Teaching.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Bt_Servo6_Teaching.Location = new System.Drawing.Point(991, 274);
            this.Bt_Servo6_Teaching.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_Servo6_Teaching.Name = "Bt_Servo6_Teaching";
            this.Bt_Servo6_Teaching.Size = new System.Drawing.Size(66, 29);
            this.Bt_Servo6_Teaching.TabIndex = 27;
            this.Bt_Servo6_Teaching.Text = "티칭";
            this.Bt_Servo6_Teaching.UseVisualStyleBackColor = false;
            this.Bt_Servo6_Teaching.Click += new System.EventHandler(this.Bt_Servo6_Teaching_Click);
            // 
            // Bt_Servo7_Teaching
            // 
            this.Bt_Servo7_Teaching.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Bt_Servo7_Teaching.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_Servo7_Teaching.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Bt_Servo7_Teaching.Location = new System.Drawing.Point(991, 312);
            this.Bt_Servo7_Teaching.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_Servo7_Teaching.Name = "Bt_Servo7_Teaching";
            this.Bt_Servo7_Teaching.Size = new System.Drawing.Size(66, 29);
            this.Bt_Servo7_Teaching.TabIndex = 27;
            this.Bt_Servo7_Teaching.Text = "티칭";
            this.Bt_Servo7_Teaching.UseVisualStyleBackColor = false;
            this.Bt_Servo7_Teaching.Click += new System.EventHandler(this.Bt_Servo7_Teaching_Click);
            // 
            // bt_OperationLog
            // 
            this.bt_OperationLog.BackColor = System.Drawing.Color.DarkGray;
            this.bt_OperationLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_OperationLog.FlatAppearance.BorderSize = 2;
            this.bt_OperationLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.bt_OperationLog.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_OperationLog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_OperationLog.Location = new System.Drawing.Point(216, 304);
            this.bt_OperationLog.Margin = new System.Windows.Forms.Padding(4);
            this.bt_OperationLog.Name = "bt_OperationLog";
            this.bt_OperationLog.Size = new System.Drawing.Size(143, 67);
            this.bt_OperationLog.TabIndex = 33;
            this.bt_OperationLog.Text = "공정 기록";
            this.bt_OperationLog.UseVisualStyleBackColor = false;
            // 
            // bt_Result
            // 
            this.bt_Result.Location = new System.Drawing.Point(584, 312);
            this.bt_Result.Name = "bt_Result";
            this.bt_Result.Size = new System.Drawing.Size(144, 72);
            this.bt_Result.TabIndex = 34;
            this.bt_Result.Text = "공정 결과";
            this.bt_Result.UseVisualStyleBackColor = true;
            this.bt_Result.Click += new System.EventHandler(this.bt_Result_Click);
            // 
            // Pn_PLC
            // 
            this.Pn_PLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(218)))), ((int)(((byte)(225)))));
            this.Pn_PLC.Controls.Add(this.Pn_PLCRb);
            this.Pn_PLC.Location = new System.Drawing.Point(24, 352);
            this.Pn_PLC.Name = "Pn_PLC";
            this.Pn_PLC.Size = new System.Drawing.Size(248, 160);
            this.Pn_PLC.TabIndex = 35;
            // 
            // Rb_OpenPLC
            // 
            this.Rb_OpenPLC.Appearance = System.Windows.Forms.Appearance.Button;
            this.Rb_OpenPLC.Location = new System.Drawing.Point(80, 8);
            this.Rb_OpenPLC.Name = "Rb_OpenPLC";
            this.Rb_OpenPLC.Size = new System.Drawing.Size(56, 56);
            this.Rb_OpenPLC.TabIndex = 36;
            this.Rb_OpenPLC.UseVisualStyleBackColor = true;
            this.Rb_OpenPLC.CheckedChanged += new System.EventHandler(this.Bt_OpenPLC_Click);
            // 
            // Rb_ClosePLC
            // 
            this.Rb_ClosePLC.Appearance = System.Windows.Forms.Appearance.Button;
            this.Rb_ClosePLC.Checked = true;
            this.Rb_ClosePLC.Location = new System.Drawing.Point(8, 8);
            this.Rb_ClosePLC.Name = "Rb_ClosePLC";
            this.Rb_ClosePLC.Size = new System.Drawing.Size(56, 56);
            this.Rb_ClosePLC.TabIndex = 36;
            this.Rb_ClosePLC.TabStop = true;
            this.Rb_ClosePLC.UseVisualStyleBackColor = true;
            this.Rb_ClosePLC.CheckedChanged += new System.EventHandler(this.Bt_ClosePLC_Click);
            // 
            // Pn_PLCRb
            // 
            this.Pn_PLCRb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            this.Pn_PLCRb.Controls.Add(this.Rb_OpenPLC);
            this.Pn_PLCRb.Controls.Add(this.Rb_ClosePLC);
            this.Pn_PLCRb.Location = new System.Drawing.Point(16, 16);
            this.Pn_PLCRb.Name = "Pn_PLCRb";
            this.Pn_PLCRb.Size = new System.Drawing.Size(144, 72);
            this.Pn_PLCRb.TabIndex = 0;
            // 
            // Operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1409, 544);
            this.Controls.Add(this.Pn_PLC);
            this.Controls.Add(this.bt_Result);
            this.Controls.Add(this.bt_OperationLog);
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
            this.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Operator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Pn_PLC.ResumeLayout(false);
            this.Pn_PLCRb.ResumeLayout(false);
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
        private System.Windows.Forms.Button bt_OperationLog;
        private System.Windows.Forms.Button bt_Result;
        private System.Windows.Forms.Panel Pn_PLC;
        private System.Windows.Forms.RadioButton Rb_OpenPLC;
        private System.Windows.Forms.RadioButton Rb_ClosePLC;
        private System.Windows.Forms.Panel Pn_PLCRb;
    }
}

