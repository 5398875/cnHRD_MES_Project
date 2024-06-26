using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cnHRD_MES_Project
{
    public partial class Main : Form
    {
        System.Windows.Forms.Timer Timer_Slide = new System.Windows.Forms.Timer(); //슬라이드용 타이머

        cnHRD_MES_Project.Operator Oper = new cnHRD_MES_Project.Operator();
        Project_v01.Cockpit Cock = new Project_v01.Cockpit();
        cnHRD_MES_Project.Warehouse Ware = new cnHRD_MES_Project.Warehouse();
        cnHRD_MES_Project.Order_Form Order = new cnHRD_MES_Project.Order_Form();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Timer_Slide.Interval = 10; //슬라이드메뉴
            Timer_Slide.Tick += new EventHandler(Timer_Sl); //슬라이드 메뉴
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
            Timer_Slide.Start();
        }

        int Slide_Width = 50; //초기 슬라이드메뉴 사이즈 = 50

        void Timer_Sl(object sender, EventArgs e) //슬라이드 메뉴 사이즈 변경
        {
            if (CheckBoxHide.Checked == false)
            {
                Slide_Width -= 10;
                if (Slide_Width <= 50)
                    Timer_Slide.Stop();
            }

            if (CheckBoxHide.Checked == true)
            {
                Slide_Width += 10;
                if (Slide_Width >= 200)
                    Timer_Slide.Stop();
            }

            TPanel_SideMenu.Width = Slide_Width;
        }

        private void Bt_Close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Bt_Operator_Click(object sender, EventArgs e)
        {
            Oper.TopLevel = false;
            Pn_Main.Controls.Clear();
            Pn_Main.Controls.Add(Oper);
            Oper.Show();
        }

        private void Bt_Cockpit_Click(object sender, EventArgs e)
        {
            Cock.TopLevel = false;
            Pn_Main.Controls.Clear();
            Pn_Main.Controls.Add(Cock);
            Cock.Show();
        }

        private void Bt_WareHouse_Click(object sender, EventArgs e)
        {
            Ware.TopLevel = false;
            Pn_Main.Controls.Clear();
            Pn_Main.Controls.Add(Ware);
            Ware.Show();
        }

        private void Bt_Order_Form_Click(object sender, EventArgs e)
        {
            Order.TopLevel = false;
            Pn_Main.Controls.Clear();
            Pn_Main.Controls.Add(Order);
            Order.Show();
        }
    }
}
