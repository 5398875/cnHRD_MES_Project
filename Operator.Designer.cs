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
            this.Tb_ServoSpeed = new System.Windows.Forms.TextBox();
            this.Bt_Stop = new System.Windows.Forms.Button();
            this.Lb_ServoConnect = new System.Windows.Forms.Label();
            this.Bt_OpenServo = new System.Windows.Forms.Button();
            this.Panel_SideMenu = new System.Windows.Forms.Panel();
            this.CheckBoxHide = new System.Windows.Forms.CheckBox();
            this.Bt_Start = new System.Windows.Forms.Button();
            this.Lb_Connect = new System.Windows.Forms.Label();
            this.Bt_ClosePLC = new System.Windows.Forms.Button();
            this.Bt_OpenPLC = new System.Windows.Forms.Button();
            this.Panel_SideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tb_ServoSpeed
            // 
            this.Tb_ServoSpeed.Location = new System.Drawing.Point(224, 24);
            this.Tb_ServoSpeed.Name = "Tb_ServoSpeed";
            this.Tb_ServoSpeed.Size = new System.Drawing.Size(144, 25);
            this.Tb_ServoSpeed.TabIndex = 17;
            // 
            // Bt_Stop
            // 
            this.Bt_Stop.Enabled = false;
            this.Bt_Stop.Location = new System.Drawing.Point(376, 80);
            this.Bt_Stop.Name = "Bt_Stop";
            this.Bt_Stop.Size = new System.Drawing.Size(144, 48);
            this.Bt_Stop.TabIndex = 16;
            this.Bt_Stop.Text = "정지 및 초기화";
            this.Bt_Stop.UseVisualStyleBackColor = true;
            this.Bt_Stop.Click += new System.EventHandler(this.Bt_Stop_Click);
            // 
            // Lb_ServoConnect
            // 
            this.Lb_ServoConnect.Location = new System.Drawing.Point(224, 136);
            this.Lb_ServoConnect.Name = "Lb_ServoConnect";
            this.Lb_ServoConnect.Size = new System.Drawing.Size(144, 23);
            this.Lb_ServoConnect.TabIndex = 15;
            this.Lb_ServoConnect.Text = "대기중";
            this.Lb_ServoConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bt_OpenServo
            // 
            this.Bt_OpenServo.Enabled = false;
            this.Bt_OpenServo.Location = new System.Drawing.Point(224, 56);
            this.Bt_OpenServo.Name = "Bt_OpenServo";
            this.Bt_OpenServo.Size = new System.Drawing.Size(144, 48);
            this.Bt_OpenServo.TabIndex = 14;
            this.Bt_OpenServo.Text = "서보 준비";
            this.Bt_OpenServo.UseVisualStyleBackColor = true;
            this.Bt_OpenServo.Click += new System.EventHandler(this.Bt_OpenServo_Click);
            // 
            // Panel_SideMenu
            // 
            this.Panel_SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel_SideMenu.Controls.Add(this.CheckBoxHide);
            this.Panel_SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_SideMenu.Location = new System.Drawing.Point(0, 0);
            this.Panel_SideMenu.Name = "Panel_SideMenu";
            this.Panel_SideMenu.Size = new System.Drawing.Size(50, 450);
            this.Panel_SideMenu.TabIndex = 9;
            // 
            // CheckBoxHide
            // 
            this.CheckBoxHide.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckBoxHide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CheckBoxHide.FlatAppearance.BorderSize = 0;
            this.CheckBoxHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxHide.ForeColor = System.Drawing.Color.White;
            this.CheckBoxHide.Location = new System.Drawing.Point(0, 392);
            this.CheckBoxHide.Name = "CheckBoxHide";
            this.CheckBoxHide.Size = new System.Drawing.Size(50, 58);
            this.CheckBoxHide.TabIndex = 0;
            this.CheckBoxHide.Text = ">";
            this.CheckBoxHide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBoxHide.UseVisualStyleBackColor = true;
            this.CheckBoxHide.CheckedChanged += new System.EventHandler(this.CheckBoxHide_CheckedChanged);
            // 
            // Bt_Start
            // 
            this.Bt_Start.Enabled = false;
            this.Bt_Start.Location = new System.Drawing.Point(376, 24);
            this.Bt_Start.Name = "Bt_Start";
            this.Bt_Start.Size = new System.Drawing.Size(144, 48);
            this.Bt_Start.TabIndex = 13;
            this.Bt_Start.Text = "시작";
            this.Bt_Start.UseVisualStyleBackColor = true;
            this.Bt_Start.Click += new System.EventHandler(this.Bt_Start_Click);
            // 
            // Lb_Connect
            // 
            this.Lb_Connect.Location = new System.Drawing.Point(72, 136);
            this.Lb_Connect.Name = "Lb_Connect";
            this.Lb_Connect.Size = new System.Drawing.Size(144, 23);
            this.Lb_Connect.TabIndex = 12;
            this.Lb_Connect.Text = "대기중";
            this.Lb_Connect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bt_ClosePLC
            // 
            this.Bt_ClosePLC.Enabled = false;
            this.Bt_ClosePLC.Location = new System.Drawing.Point(72, 80);
            this.Bt_ClosePLC.Name = "Bt_ClosePLC";
            this.Bt_ClosePLC.Size = new System.Drawing.Size(144, 48);
            this.Bt_ClosePLC.TabIndex = 11;
            this.Bt_ClosePLC.Text = "PLC 연결 해제";
            this.Bt_ClosePLC.UseVisualStyleBackColor = true;
            this.Bt_ClosePLC.Click += new System.EventHandler(this.Bt_ClosePLC_Click);
            // 
            // Bt_OpenPLC
            // 
            this.Bt_OpenPLC.Location = new System.Drawing.Point(72, 24);
            this.Bt_OpenPLC.Name = "Bt_OpenPLC";
            this.Bt_OpenPLC.Size = new System.Drawing.Size(144, 48);
            this.Bt_OpenPLC.TabIndex = 10;
            this.Bt_OpenPLC.Text = "PLC 연결";
            this.Bt_OpenPLC.UseVisualStyleBackColor = true;
            this.Bt_OpenPLC.Click += new System.EventHandler(this.Bt_OpenPLC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel_SideMenu);
            this.Controls.Add(this.Tb_ServoSpeed);
            this.Controls.Add(this.Bt_Stop);
            this.Controls.Add(this.Lb_ServoConnect);
            this.Controls.Add(this.Bt_OpenServo);
            this.Controls.Add(this.Bt_Start);
            this.Controls.Add(this.Lb_Connect);
            this.Controls.Add(this.Bt_ClosePLC);
            this.Controls.Add(this.Bt_OpenPLC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_SideMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_ServoSpeed;
        private System.Windows.Forms.Button Bt_Stop;
        private System.Windows.Forms.Label Lb_ServoConnect;
        private System.Windows.Forms.Button Bt_OpenServo;
        private System.Windows.Forms.Panel Panel_SideMenu;
        private System.Windows.Forms.CheckBox CheckBoxHide;
        private System.Windows.Forms.Button Bt_Start;
        private System.Windows.Forms.Label Lb_Connect;
        private System.Windows.Forms.Button Bt_ClosePLC;
        private System.Windows.Forms.Button Bt_OpenPLC;
    }
}
