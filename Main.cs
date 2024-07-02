using Project_v01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Documents;
using System.Windows;

namespace cnHRD_MES_Project
{
    public partial class Main : Form
    {
        System.Threading.Timer Timer_Slide; //슬라이드용 타이머
        System.Windows.Forms.Timer Timer_Now = new System.Windows.Forms.Timer();

        cnHRD_MES_Project.Operator Oper = new cnHRD_MES_Project.Operator();   //┐
        Project_v01.Cockpit Cock = new Project_v01.Cockpit();                 //┤
        cnHRD_MES_Project.Warehouse Ware = new cnHRD_MES_Project.Warehouse(); //┼─각 폼들을 선언
        cnHRD_MES_Project.Order Ord = new cnHRD_MES_Project.Order();          //┘

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Oper.setMain(this);
            Ord.TopLevel = false;
            Ord.Order_Load(sender, e);
            Timer_Now.Interval = 1000;
            Timer_Now.Tick += new EventHandler(Timer_No);
            Timer_Now.Start();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 15, 15));
            TPanel_SubMenu.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, -10, TPanel_SubMenu.Width + 10, TPanel_SubMenu.Height, 20, 20));
            Pn_Sub.Width = this.Width - 112;
            Pn_Sub.Height = this.Height - 112;
            Pn_Sub.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Pn_Sub.Width, Pn_Sub.Height, 20, 20));
        }

        private void Timer_No(object sender, EventArgs e)
        {
            Lb_Now.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect,
            int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void CheckBoxHide_CheckedChanged(object sender, EventArgs e) //슬라이드 버튼 이름변경
        {
            if (CheckBoxHide.Checked == false)
            {
                CheckBoxHide.Text = "☰";
                Bt_Operator.Text = "Oper";
                Bt_Cockpit.Text = "Cock";
                Bt_WareHouse.Text = "Ware";
                Bt_Order_Form.Text = "Order";
            }
            else
            {
                CheckBoxHide.Text = "<";
                Bt_Operator.Text = "오퍼레이터";
                Bt_Cockpit.Text = "콕핏";
                Bt_WareHouse.Text = "창고";
                Bt_Order_Form.Text = "주문";
            }
            Timer_Slide = new System.Threading.Timer(Timer_Sl, null, 0, 10); //10ms간격으로 메뉴길이변경 실행
        }

        int Slide_Width = 64; //초기 슬라이드메뉴 사이즈 = 64

        public Warehouse Ware1 { get => Ware; set => Ware = value; }
        public Order Ord1 { get => Ord; set => Ord = value; }
        public Cockpit Cock1 { get => Cock; set => Cock = value; }

        private void Timer_Sl(object sender) //슬라이드 메뉴 사이즈 변경
        {
            if (CheckBoxHide.Checked == false)
            {
                Slide_Width -= 8;
                if (Slide_Width <= 64)
                    Timer_Slide.Dispose();
            }

            if (CheckBoxHide.Checked == true)
            {
                Slide_Width += 8;
                if (Slide_Width >= 200)
                    Timer_Slide.Dispose();
            }
            if(this.TPanel_SideMenu.InvokeRequired) //UI스레드와의 충돌 방지
                this.TPanel_SideMenu.Invoke((MethodInvoker)delegate { TPanel_SideMenu.Width = Slide_Width; });
            else
                TPanel_SideMenu.Width = Slide_Width;
        }

        private void Bt_Close_Click(object sender, EventArgs e) // 종료 버튼
        {
            Dispose();
        }

        private void Bt_Operator_Click(object sender, EventArgs e) // Operator 버튼
        {
            Oper.TopLevel = false;
            Pn_Sub.Controls.Clear();
            Pn_Sub.Controls.Add(Oper);
            Oper.Show();
        }

        private void Bt_Cockpit_Click(object sender, EventArgs e) // Cockpit 버튼
        {
            Cock.TopLevel = false;
            Pn_Sub.Controls.Clear();
            Pn_Sub.Controls.Add(Cock);
            Cock.Show();
        }

        private void Bt_WareHouse_Click(object sender, EventArgs e) // WareHouse 버튼
        {
            Ware1.TopLevel = false;
            Pn_Sub.Controls.Clear();
            Pn_Sub.Controls.Add(Ware1);
            Ware1.Show();
        }

        private void Bt_Order_Form_Click(object sender, EventArgs e) // Order_Form 버튼
        {
            Ord.TopLevel = false;
            Pn_Sub.Controls.Clear();
            Pn_Sub.Controls.Add(Ord);
            Ord.Show();
        }

        private void Bt_Home_Click(object sender, EventArgs e)
        {
            Pn_Sub.Controls.Clear();
            Pn_Sub.Controls.Add(tableLayoutPanel2);
            tableLayoutPanel2.Show();
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
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                Bt_Maximum.Text = "❐";
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 15, 15));
                Bt_Maximum.Font = new Font("굴림", 14, FontStyle.Bold);
                Pn_Sub.Width = this.Width - 112;
                Pn_Sub.Height = this.Height - 112;
                Pn_Sub.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Pn_Sub.Width, Pn_Sub.Height, 20, 20));
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                Bt_Maximum.Text = "□";
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 15, 15));
                Bt_Maximum.Font = new Font("굴림", 9, FontStyle.Bold);
                Pn_Sub.Width = this.Width - 112;
                Pn_Sub.Height = this.Height - 112;
                Pn_Sub.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Pn_Sub.Width, Pn_Sub.Height, 20, 20));
            }
        }


    }
}
