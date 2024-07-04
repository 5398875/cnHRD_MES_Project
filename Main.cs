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
        System.Windows.Forms.Timer Timer_Now = new System.Windows.Forms.Timer(); //현재시간용 타이머

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
            Ord.TopLevel = false;      //┐
            Ord.Order_Load(sender, e); //┴주문을 미리 로드
            Timer_Now.Interval = 1000;                    //┐
            Timer_Now.Tick += new EventHandler(Timer_No); //├현재시간 타이머 설정 & 스타트
            Timer_Now.Start();                            //┘
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 15, 15)); //창의 모서리 다듬기
            TPanel_SubMenu.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, -10, TPanel_SubMenu.Width + 10, TPanel_SubMenu.Height, 20, 20)); //서브메뉴의 좌하단 모서리 다듬기
            Pn_Sub.Width = this.Width - 112;   //┐
            Pn_Sub.Height = this.Height - 112; //┴서브판넬 초기 크기
            Pn_Sub.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Pn_Sub.Width, Pn_Sub.Height, 20, 20)); //서브판넬 모서리 다듬기
            pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/images/Main.png"); //메인 아이콘(블랙)
            pictureBox2.Image = Image.FromFile(System.Environment.CurrentDirectory + "/images/Sub.png"); //서브 아이콘(화이트)
        }

        private void Timer_No(object sender, EventArgs e)
        {
            Lb_Now.Text = DateTime.Now.ToString("hh:mm:ss"); //현재시간 표시
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect,
            int nBottomRect, int nWidthEllipse, int nHeightEllipse); //모서리 다듬는 함수

        private void CheckBoxHide_CheckedChanged(object sender, EventArgs e) //슬라이드 버튼 이름변경
        {
            if (CheckBoxHide.Checked == false) //슬라이드 들어가있을때
            {
                CheckBoxHide.Text = "☰";
                Bt_Operator.Text = "Oper";
                Bt_Cockpit.Text = "Cock";
                Bt_WareHouse.Text = "Ware";
                Bt_Order_Form.Text = "Order";
            }
            else //슬라이드 나와있을때
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

        public Warehouse Ware1 { get => Ware; set => Ware = value; } //┐
        public Order Ord1 { get => Ord; set => Ord = value; }        //├각 폼들에게 값을 넘겨줌
        public Cockpit Cock1 { get => Cock; set => Cock = value; }   //┘

        private void Timer_Sl(object sender) //타이머에 따라 슬라이드 메뉴 사이즈 변경
        {
            if (CheckBoxHide.Checked == false) //슬라이드 작아질때
            {
                Slide_Width -= 8;
                if (Slide_Width <= 64)
                    Timer_Slide.Dispose();
            }

            if (CheckBoxHide.Checked == true) //슬라이드 커질때
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
            Oper.TopLevel = false; //operator의 상위컨트롤을 없애고
            Pn_Sub.Controls.Clear(); //판넬을 비우고
            Pn_Sub.Controls.Add(Oper); //판넬이 operator을 컨트롤하게 하고
            Oper.Show(); //operator을 보여준다
        }

        private void Bt_Cockpit_Click(object sender, EventArgs e) // Cockpit 버튼
        {
            Cock.TopLevel = false;
            Pn_Sub.Controls.Clear();
            Pn_Sub.Controls.Add(Cock);
            Cock.Show(); //operator와 동일
        }

        private void Bt_WareHouse_Click(object sender, EventArgs e) // WareHouse 버튼
        {
            Ware1.TopLevel = false;
            Pn_Sub.Controls.Clear();
            Pn_Sub.Controls.Add(Ware1);
            Ware1.Show(); //operator와 동일
        }

        private void Bt_Order_Form_Click(object sender, EventArgs e) // Order_Form 버튼
        {
            Ord.TopLevel = false;
            Pn_Sub.Controls.Clear();
            Pn_Sub.Controls.Add(Ord);
            Ord.Show(); //operator와 동일
        }

        private void Bt_Home_Click(object sender, EventArgs e)
        {
            Pn_Sub.Controls.Clear();
            Pn_Sub.Controls.Add(tableLayoutPanel2);
            Pn_Sub.Controls.Add(pictureBox1);
            tableLayoutPanel2.Show();
            pictureBox2.Show(); //operator와 동일. picturebox도 동시에 수향
        }

        bool bMouseDown;
        Point pLocation;

        private void TPanel_MouseDown(object sender, MouseEventArgs e) //마우스버튼이 눌리면
        {
            if (e.Button == MouseButtons.Left) //좌클릭이 눌리면
            {
                bMouseDown = true; //마우스 눌림 true
                pLocation = e.Location; //그 위치를 저장
            }
        }

        private void TPanel_MouseUP(object sender, MouseEventArgs e) //마우스버튼이 떨어지면
        {
            bMouseDown = false; //마우스 눌림 false
        }

        private void TPanel_MouseMove(object sender, MouseEventArgs e) //마우스가 움직이면
        {
            if (bMouseDown) //마우스가 눌려있을때
            {
                this.Location = new Point((this.Location.X - pLocation.X) + e.X, (this.Location.Y - pLocation.Y) + e.Y);
                this.Update(); //창의 위치를 (초기 창위치와 초기 마우스 위치의 차이)+마우스의 현재위치로 마우스를 따라 창이 움직이도록 한다
            }
        }

        private void Bt_Minimum_Click(object sender, EventArgs e) //최소화버튼 클릭
        {
            this.WindowState = FormWindowState.Minimized; //최소화
        }

        private void Bt_Maximum_Click(object sender, EventArgs e) //최대화 버튼 클릭
        {
            if(this.WindowState == FormWindowState.Normal) //현재창이 일반상태일때(=최대가 아닐때)
            {
                this.WindowState = FormWindowState.Maximized; //최대화
                Bt_Maximum.Text = "❐"; //특수문자 변경
                Bt_Maximum.Font = new Font("굴림", 14, FontStyle.Bold); //가시성을 위해 특수문자 사이즈 변경
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 15, 15)); //창 다듬기 재실행
                Pn_Sub.Width = this.Width - 112;   //┐
                Pn_Sub.Height = this.Height - 112; //┴서브판넬 위치 재설정
                Pn_Sub.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Pn_Sub.Width, Pn_Sub.Height, 20, 20)); //서브판넬 다듬기 재실행
            }
            else
            {
                this.WindowState = FormWindowState.Normal; //일반화
                Bt_Maximum.Text = "□"; //특수문자 변경
                Bt_Maximum.Font = new Font("굴림", 9, FontStyle.Bold); //가시성을 위해 특수문자 사이즈 변경
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 15, 15)); //창 다듬기 재실행
                Pn_Sub.Width = this.Width - 112;   //┐
                Pn_Sub.Height = this.Height - 112; //┴서브판넬 위치 재설정
                Pn_Sub.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Pn_Sub.Width, Pn_Sub.Height, 20, 20)); //서브판넬 다듬기 재실행
            }
        }
    }
}
