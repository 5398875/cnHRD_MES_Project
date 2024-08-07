﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cnHRD_MES_Project
{
    public partial class Operator_Log : Form
    {
        public Operator_Log()
        {
            InitializeComponent();

            lv_OperatorLog.Columns.Add("공정종류", -2, HorizontalAlignment.Center);
            lv_OperatorLog.Columns.Add("취급물품", -2, HorizontalAlignment.Center);
            lv_OperatorLog.Columns.Add("시작시간", -2, HorizontalAlignment.Center);
            lv_OperatorLog.Columns.Add("종료시간", -2, HorizontalAlignment.Center);
            lv_OperatorLog.Columns.Add("성공여부", -2, HorizontalAlignment.Center);
            lv_OperatorLog.Columns.Add("비고", -2, HorizontalAlignment.Center);

            lv_OperatorLog.View = View.Details;
            lv_OperatorLog.GridLines = true;

            lv_OperatorLog.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect,
            int nBottomRect, int nWidthEllipse, int nHeightEllipse);


        Dictionary<string, ListViewItem> logItems = new Dictionary<string, ListViewItem>();
        string[] Converted_Log = new string[6];

        public void Get_Log(string[] doneOperation)
        {
            string key = doneOperation[2];  //시작시간을 키로 사용

            if (!logItems.ContainsKey(key)) //공정초기 호출 시
            {
                if (Convert.ToInt16(doneOperation[0]) == 1)
                {
                    Converted_Log[0] = "배송공정";
                }
                else if (Convert.ToInt16(doneOperation[0]) == 2)
                {
                    Converted_Log[0] = "적재공정";
                }
                if (Convert.ToInt16(doneOperation[1]) == 0)
                {
                    Converted_Log[1] = "판별중";
                }
                else if (Convert.ToInt16(doneOperation[1]) == 1)
                {
                    Converted_Log[0] = "판별중";
                }
                else if (Convert.ToInt16(doneOperation[1]) == 1)
                {
                    Converted_Log[1] = "금속";
                }
                else
                {
                    Converted_Log[1] = "비금속";
                }
                Converted_Log[2] = doneOperation[2];
                Converted_Log[3] = doneOperation[3];
                Converted_Log[4] = "공정 중";  //공정상태 초기값

                ListViewItem item = new ListViewItem(Converted_Log);
                lv_OperatorLog.Items.Add(item);
                logItems[key] = item;
            }
            else    //완료시점에 호출되면 리스트뷰(종료시간 및 성공여부) 업데이트
            {
                ListViewItem item = logItems[key];
                if (Convert.ToInt16(doneOperation[1]) == 1)
                {
                    item.SubItems[1].Text = "금속";
                }
                else if(Convert.ToInt16(doneOperation[1]) == 2)
                {
                    item.SubItems[1].Text = "비금속";
                }
                item.SubItems[3].Text = doneOperation[3]; //종료시간
                item.SubItems[4].Text = doneOperation[4] == "True" ? "공정완료" : "공정 중"; //성공여부 업데이트
            }
        }

        private void Operator_Log_Closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void Operator_Log_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 15, 15));
        }

        private void Bt_Close_Click(object sender, EventArgs e)
        {
            Hide();
        }

        bool bMouseDown;
        Point pLocation;

        private void TPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bMouseDown = true;
                pLocation = e.Location;
            }
        }

        private void TPanel_MouseUP(object sender, MouseEventArgs e)
        {
            bMouseDown = false;
        }

        private void TPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (bMouseDown)
            {
                this.Location = new Point((this.Location.X - pLocation.X) + e.X, (this.Location.Y - pLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Bt_Minimum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Bt_Maximum_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                Bt_Maximum.Text = "❐";
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 15, 15));
                Bt_Maximum.Font = new Font("굴림", 14, FontStyle.Bold);
                lv_OperatorLog.Size = new Size(this.Width - 50, this.Height - 120);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                Bt_Maximum.Text = "□";
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 15, 15));
                Bt_Maximum.Font = new Font("굴림", 9, FontStyle.Bold);
                lv_OperatorLog.Size = new Size(this.Width - 50, this.Height - 120);
            }
        }

    }
}
