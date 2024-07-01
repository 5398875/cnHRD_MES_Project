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

namespace cnHRD_MES_Project
{
    public partial class Main : Form
    {
        System.Threading.Timer Timer_Slide; //슬라이드용 타이머

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
            Oper.setMain(this);
            Ord.TopLevel = false;
            Ord.Order_Load(sender, e);
        }
            

        private void CheckBoxHide_CheckedChanged(object sender, EventArgs e) //슬라이드 버튼 이름변경
        {
            if (CheckBoxHide.Checked == false)
            {
                CheckBoxHide.Text = ">";
                Bt_Operator.Text = "Op";
                Bt_Cockpit.Text = "Co";
                Bt_WareHouse.Text = "Wa";
                Bt_Order_Form.Text = "Or";
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

        int Slide_Width = 50; //초기 슬라이드메뉴 사이즈 = 50

        public Warehouse Ware1 { get => Ware; set => Ware = value; }
        public Order Ord1 { get => Ord; set => Ord = value; }
        public Cockpit Cock1 { get => Cock; set => Cock = value; }

        private void Timer_Sl(object sender) //슬라이드 메뉴 사이즈 변경
        {
            if (CheckBoxHide.Checked == false)
            {
                Slide_Width -= 10;
                if (Slide_Width <= 50)
                    Timer_Slide.Dispose();
            }

            if (CheckBoxHide.Checked == true)
            {
                Slide_Width += 10;
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
            Pn_Main.Controls.Clear();
            Pn_Main.Controls.Add(Oper);
            Oper.Show();
        }

        private void Bt_Cockpit_Click(object sender, EventArgs e) // Cockpit 버튼
        {
            Cock.TopLevel = false;
            Pn_Main.Controls.Clear();
            Pn_Main.Controls.Add(Cock);
            Cock.Show();
        }

        private void Bt_WareHouse_Click(object sender, EventArgs e) // WareHouse 버튼
        {
            Ware1.TopLevel = false;
            Pn_Main.Controls.Clear();
            Pn_Main.Controls.Add(Ware1);
            Ware1.Show();
        }

        private void Bt_Order_Form_Click(object sender, EventArgs e) // Order_Form 버튼
        {
            Ord.TopLevel = false;
            Pn_Main.Controls.Clear();
            Pn_Main.Controls.Add(Ord);
            Ord.Show();
        }

        private void Pn_Main_Paint(object sender, PaintEventArgs e)
        {

        }


    }

    
}
