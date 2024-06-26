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
            this.TPanel_SideMenu = new System.Windows.Forms.TableLayoutPanel();
            this.CheckBoxHide = new System.Windows.Forms.CheckBox();
            this.Bt_Close = new System.Windows.Forms.Button();
            this.Bt_Cockpit = new System.Windows.Forms.Button();
            this.Bt_Order_Form = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bt_Start = new System.Windows.Forms.Button();
            this.Bt_Stop = new System.Windows.Forms.Button();
            this.TPanel_SideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TPanel_SideMenu
            // 
            this.TPanel_SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TPanel_SideMenu.ColumnCount = 1;
            this.TPanel_SideMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TPanel_SideMenu.Controls.Add(this.Bt_Order_Form, 0, 2);
            this.TPanel_SideMenu.Controls.Add(this.Bt_Cockpit, 0, 1);
            this.TPanel_SideMenu.Controls.Add(this.CheckBoxHide, 0, 0);
            this.TPanel_SideMenu.Controls.Add(this.Bt_Close, 0, 4);
            this.TPanel_SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.TPanel_SideMenu.Location = new System.Drawing.Point(0, 0);
            this.TPanel_SideMenu.Name = "TPanel_SideMenu";
            this.TPanel_SideMenu.RowCount = 7;
            this.TPanel_SideMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TPanel_SideMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TPanel_SideMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TPanel_SideMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TPanel_SideMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TPanel_SideMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TPanel_SideMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TPanel_SideMenu.Size = new System.Drawing.Size(50, 453);
            this.TPanel_SideMenu.TabIndex = 24;
            // 
            // CheckBoxHide
            // 
            this.CheckBoxHide.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckBoxHide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBoxHide.FlatAppearance.BorderSize = 0;
            this.CheckBoxHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxHide.ForeColor = System.Drawing.Color.White;
            this.CheckBoxHide.Location = new System.Drawing.Point(3, 3);
            this.CheckBoxHide.Name = "CheckBoxHide";
            this.CheckBoxHide.Size = new System.Drawing.Size(44, 44);
            this.CheckBoxHide.TabIndex = 1;
            this.CheckBoxHide.Text = ">";
            this.CheckBoxHide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBoxHide.UseVisualStyleBackColor = true;
            this.CheckBoxHide.CheckedChanged += new System.EventHandler(this.CheckBoxHide_CheckedChanged);
            // 
            // Bt_Close
            // 
            this.Bt_Close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bt_Close.FlatAppearance.BorderSize = 0;
            this.Bt_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Close.ForeColor = System.Drawing.Color.White;
            this.Bt_Close.Location = new System.Drawing.Point(3, 366);
            this.Bt_Close.Name = "Bt_Close";
            this.Bt_Close.Size = new System.Drawing.Size(44, 44);
            this.Bt_Close.TabIndex = 2;
            this.Bt_Close.Text = "X";
            this.Bt_Close.UseVisualStyleBackColor = true;
            this.Bt_Close.Click += new System.EventHandler(this.Bt_Close_Click);
            // 
            // Bt_Cockpit
            // 
            this.Bt_Cockpit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bt_Cockpit.FlatAppearance.BorderSize = 0;
            this.Bt_Cockpit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Cockpit.ForeColor = System.Drawing.Color.White;
            this.Bt_Cockpit.Location = new System.Drawing.Point(3, 53);
            this.Bt_Cockpit.Name = "Bt_Cockpit";
            this.Bt_Cockpit.Size = new System.Drawing.Size(44, 44);
            this.Bt_Cockpit.TabIndex = 3;
            this.Bt_Cockpit.Text = "1";
            this.Bt_Cockpit.UseVisualStyleBackColor = true;
            // 
            // Bt_Order_Form
            // 
            this.Bt_Order_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bt_Order_Form.FlatAppearance.BorderSize = 0;
            this.Bt_Order_Form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Order_Form.ForeColor = System.Drawing.Color.White;
            this.Bt_Order_Form.Location = new System.Drawing.Point(3, 103);
            this.Bt_Order_Form.Name = "Bt_Order_Form";
            this.Bt_Order_Form.Size = new System.Drawing.Size(44, 44);
            this.Bt_Order_Form.TabIndex = 4;
            this.Bt_Order_Form.Text = "2";
            this.Bt_Order_Form.UseVisualStyleBackColor = true;
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
            this.Bt_ClosePLC.Location = new System.Drawing.Point(8, 72);
            this.Bt_ClosePLC.Name = "Bt_ClosePLC";
            this.Bt_ClosePLC.Size = new System.Drawing.Size(144, 34);
            this.Bt_ClosePLC.TabIndex = 11;
            this.Bt_ClosePLC.Text = "PLC 연결 해제";
            this.Bt_ClosePLC.UseVisualStyleBackColor = true;
            this.Bt_ClosePLC.Click += new System.EventHandler(this.Bt_ClosePLC_Click);
            // 
            // Lb_Connect
            // 
            this.Lb_Connect.Location = new System.Drawing.Point(16, 120);
            this.Lb_Connect.Name = "Lb_Connect";
            this.Lb_Connect.Size = new System.Drawing.Size(144, 23);
            this.Lb_Connect.TabIndex = 12;
            this.Lb_Connect.Text = "대기중";
            this.Lb_Connect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_ServoConnect
            // 
            this.Lb_ServoConnect.Location = new System.Drawing.Point(152, 56);
            this.Lb_ServoConnect.Name = "Lb_ServoConnect";
            this.Lb_ServoConnect.Size = new System.Drawing.Size(144, 23);
            this.Lb_ServoConnect.TabIndex = 15;
            this.Lb_ServoConnect.Text = "대기중";
            this.Lb_ServoConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bt_OpenServo
            // 
            this.Bt_OpenServo.Enabled = false;
            this.Bt_OpenServo.Location = new System.Drawing.Point(160, 8);
            this.Bt_OpenServo.Name = "Bt_OpenServo";
            this.Bt_OpenServo.Size = new System.Drawing.Size(144, 34);
            this.Bt_OpenServo.TabIndex = 14;
            this.Bt_OpenServo.Text = "서보 준비";
            this.Bt_OpenServo.UseVisualStyleBackColor = true;
            this.Bt_OpenServo.Click += new System.EventHandler(this.Bt_OpenServo_Click);
            // 
            // Tb_Servo1
            // 
            this.Tb_Servo1.Location = new System.Drawing.Point(392, 104);
            this.Tb_Servo1.Name = "Tb_Servo1";
            this.Tb_Servo1.Size = new System.Drawing.Size(144, 25);
            this.Tb_Servo1.TabIndex = 22;
            this.Tb_Servo1.Text = "59460";
            // 
            // Tb_Servo2
            // 
            this.Tb_Servo2.Location = new System.Drawing.Point(384, 136);
            this.Tb_Servo2.Name = "Tb_Servo2";
            this.Tb_Servo2.Size = new System.Drawing.Size(144, 25);
            this.Tb_Servo2.TabIndex = 22;
            this.Tb_Servo2.Text = "165360";
            // 
            // Tb_Servo3
            // 
            this.Tb_Servo3.Location = new System.Drawing.Point(384, 160);
            this.Tb_Servo3.Name = "Tb_Servo3";
            this.Tb_Servo3.Size = new System.Drawing.Size(144, 25);
            this.Tb_Servo3.TabIndex = 22;
            this.Tb_Servo3.Text = "707170";
            // 
            // Tb_Servo4
            // 
            this.Tb_Servo4.Location = new System.Drawing.Point(376, 192);
            this.Tb_Servo4.Name = "Tb_Servo4";
            this.Tb_Servo4.Size = new System.Drawing.Size(144, 25);
            this.Tb_Servo4.TabIndex = 22;
            this.Tb_Servo4.Text = "821650";
            // 
            // Tb_Servo5
            // 
            this.Tb_Servo5.Location = new System.Drawing.Point(376, 224);
            this.Tb_Servo5.Name = "Tb_Servo5";
            this.Tb_Servo5.Size = new System.Drawing.Size(144, 25);
            this.Tb_Servo5.TabIndex = 22;
            this.Tb_Servo5.Text = "1380260";
            // 
            // Tb_Servo6
            // 
            this.Tb_Servo6.Location = new System.Drawing.Point(368, 256);
            this.Tb_Servo6.Name = "Tb_Servo6";
            this.Tb_Servo6.Size = new System.Drawing.Size(144, 25);
            this.Tb_Servo6.TabIndex = 22;
            this.Tb_Servo6.Text = "1461510";
            // 
            // Tb_Servo7
            // 
            this.Tb_Servo7.Location = new System.Drawing.Point(360, 288);
            this.Tb_Servo7.Name = "Tb_Servo7";
            this.Tb_Servo7.Size = new System.Drawing.Size(144, 25);
            this.Tb_Servo7.TabIndex = 22;
            this.Tb_Servo7.Text = "1460630";
            // 
            // Tb_ServoLoc
            // 
            this.Tb_ServoLoc.Location = new System.Drawing.Point(296, 88);
            this.Tb_ServoLoc.Name = "Tb_ServoLoc";
            this.Tb_ServoLoc.Size = new System.Drawing.Size(144, 25);
            this.Tb_ServoLoc.TabIndex = 21;
            // 
            // Bt_JogDown
            // 
            this.Bt_JogDown.Location = new System.Drawing.Point(304, 48);
            this.Bt_JogDown.Name = "Bt_JogDown";
            this.Bt_JogDown.Size = new System.Drawing.Size(144, 34);
            this.Bt_JogDown.TabIndex = 19;
            this.Bt_JogDown.Text = "조그하";
            this.Bt_JogDown.UseVisualStyleBackColor = true;
            this.Bt_JogDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bt_JogDown_MouseDown);
            this.Bt_JogDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bt_JogDown_MouseUp);
            // 
            // Bt_JogUp
            // 
            this.Bt_JogUp.Location = new System.Drawing.Point(304, 8);
            this.Bt_JogUp.Name = "Bt_JogUp";
            this.Bt_JogUp.Size = new System.Drawing.Size(144, 34);
            this.Bt_JogUp.TabIndex = 18;
            this.Bt_JogUp.Text = "조그상";
            this.Bt_JogUp.UseVisualStyleBackColor = true;
            this.Bt_JogUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bt_JogUp_MouseDown);
            this.Bt_JogUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bt_JogUp_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Bt_Stop);
            this.panel1.Controls.Add(this.Bt_Start);
            this.panel1.Controls.Add(this.Bt_OpenPLC);
            this.panel1.Controls.Add(this.Bt_JogUp);
            this.panel1.Controls.Add(this.Tb_Servo7);
            this.panel1.Controls.Add(this.Tb_ServoLoc);
            this.panel1.Controls.Add(this.Tb_Servo6);
            this.panel1.Controls.Add(this.Bt_JogDown);
            this.panel1.Controls.Add(this.Tb_Servo5);
            this.panel1.Controls.Add(this.Bt_ClosePLC);
            this.panel1.Controls.Add(this.Tb_Servo4);
            this.panel1.Controls.Add(this.Lb_Connect);
            this.panel1.Controls.Add(this.Tb_Servo3);
            this.panel1.Controls.Add(this.Bt_OpenServo);
            this.panel1.Controls.Add(this.Tb_Servo2);
            this.panel1.Controls.Add(this.Tb_Servo1);
            this.panel1.Controls.Add(this.Lb_ServoConnect);
            this.panel1.Location = new System.Drawing.Point(232, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 368);
            this.panel1.TabIndex = 25;
            // 
            // Bt_Start
            // 
            this.Bt_Start.Location = new System.Drawing.Point(152, 168);
            this.Bt_Start.Name = "Bt_Start";
            this.Bt_Start.Size = new System.Drawing.Size(144, 34);
            this.Bt_Start.TabIndex = 23;
            this.Bt_Start.Text = "시작";
            this.Bt_Start.UseVisualStyleBackColor = true;
            this.Bt_Start.Click += new System.EventHandler(this.Bt_Start_Click);
            // 
            // Bt_Stop
            // 
            this.Bt_Stop.Location = new System.Drawing.Point(160, 208);
            this.Bt_Stop.Name = "Bt_Stop";
            this.Bt_Stop.Size = new System.Drawing.Size(144, 34);
            this.Bt_Stop.TabIndex = 24;
            this.Bt_Stop.Text = "정지";
            this.Bt_Stop.UseVisualStyleBackColor = true;
            this.Bt_Stop.Click += new System.EventHandler(this.Bt_Stop_Click);
            // 
            // Operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TPanel_SideMenu);
            this.Name = "Operator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TPanel_SideMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel TPanel_SideMenu;
        private System.Windows.Forms.CheckBox CheckBoxHide;
        private System.Windows.Forms.Button Bt_Close;
        private System.Windows.Forms.Button Bt_Order_Form;
        private System.Windows.Forms.Button Bt_Cockpit;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Bt_Stop;
        private System.Windows.Forms.Button Bt_Start;
    }
}

