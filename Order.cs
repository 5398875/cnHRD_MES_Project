using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Schema;
using System.Security.Cryptography;

namespace cnHRD_MES_Project
{
    public partial class Order : Form
    {
        public System.Windows.Forms.Timer Timer_Order = new System.Windows.Forms.Timer();

        public Order()
        {
            InitializeComponent();
        }

        public void Order_Load(object sender, EventArgs e)
        {
            Timer_Order.Interval = 1000;
            Timer_Order.Tick += new EventHandler(Timer_Or);
            Timer_Order.Start();
        }

        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)+"/Order.txt";

        public int iCurrent = 0; //현재 주문번호 (=배달 완료 여부와 관계 없이 주문이 몇개나 있는지)
        private void Timer_Or(object sender, EventArgs e)
        {
            string[] Lines = File.ReadAllLines(filePath);
            if (Lines.Length >= 1)
            {
                if (Lines[0] != string.Empty)
                {
                    iCurrent++;
                    ListViewItem item = new ListViewItem(iCurrent.ToString());
                    if (Lines[0].Substring(0,1) == "1")
                        item.SubItems.Add("금속");
                    else if (Lines[0].Substring(0,1) == "2")
                        item.SubItems.Add("비금속");
                    if (Lines[0].Substring(1,1) == "1")
                        item.SubItems.Add("부산");
                    else if (Lines[0].Substring(1,1) == "0")
                        item.SubItems.Add("서울");
                    item.SubItems.Add(Lines[0].Substring(2, 1));
                    item.SubItems.Add("0");
                    item.SubItems.Add(DateTime.Now.ToString("yyyy.MM.dd HH.mm.ss"));
                    item.SubItems.Add("대기중");
                    Lv_Order.Items.Add(item);
                    Lv_Order.Focus();
                    Lv_Order.Items[iCurrent - 1].Focused = true;
                    Lv_Order.Items[iCurrent - 1].Selected = true;
                    Lv_Order.Items[iCurrent - 1].EnsureVisible();
                }
                StreamWriter Order_Delete = new StreamWriter(filePath, false);
                if (Lines.Length == 1)
                    Order_Delete.WriteLine(string.Empty);
                else if (Lines.Length > 1)
                {
                    for (int i = 1; i < Lines.Length; i++)
                    {
                        Order_Delete.WriteLine(Lines[i]);
                    }
                    Order_Delete.Close();
                }
                Order_Delete.Close();
            }
        }

        public int iOrder_Complete = 0; //발송한 주문수
        int iComplete_inOrder = 0; //한 주문 안에서 배송한 물품수
        int iTotal_inOrder = 0; //현재 주문의 총 물품수

        public int[]Is_Order()
        {
            int[] iOrder = new int[] { 0, 0, 0 };
            if (iCurrent <= iOrder_Complete) //배송을 하려면 주문번호가 발송한 숫자보다 커야함
                iOrder[0] = 0;
            else if (iCurrent > iOrder_Complete) //배송을 하려면 주문번호가 발송한 숫자보다 커야함
            {
                if (Lv_Order.Items[iOrder_Complete].SubItems[1].Text == "금속")
                    iOrder[0] = 1;
                else if (Lv_Order.Items[iOrder_Complete].SubItems[1].Text == "비금속")
                    iOrder[0] = 2;
                if (Lv_Order.Items[iOrder_Complete].SubItems[2].Text == "서울")
                    iOrder[1] = 0;
                else if (Lv_Order.Items[iOrder_Complete].SubItems[2].Text == "부산")
                    iOrder[1] = 1;
            }
            return iOrder;
        }

        public void Deliv_Check() //배송 1단계 - 검품
        {
            iComplete_inOrder = 0; //초기화
            iTotal_inOrder = int.Parse(Lv_Order.Items[iOrder_Complete].SubItems[3].Text); //현 주문의 총 수량을 저장
            if (iTotal_inOrder == 1) //주문의 총 수량이 1개일때
                Lv_Order.Items[iOrder_Complete].SubItems[6].Text = "검품중";
            else //주문의 총 수량이 1개보다 많을때
                Lv_Order.Items[iOrder_Complete].SubItems[6].Text = iTotal_inOrder.ToString() + "개중 "
                    + (iComplete_inOrder + 1) + "번째 검품중"; //(총 갯수)중 (완료한 갯수+1)번째 검품중
            Lv_Order.Items[iOrder_Complete].ForeColor = Color.Purple; //보라색
        }

        public void Deliv_Start() //배송 2단계 - 배송
        {
            if (iTotal_inOrder == 1) //주문의 총 수량이 1개일때
                Lv_Order.Items[iOrder_Complete].SubItems[6].Text = "검품완료. 배송중";
            else //주문의 총 수량이 1개보다 많을때
                Lv_Order.Items[iOrder_Complete].SubItems[6].Text = iTotal_inOrder.ToString() + "개중 "
                    + (iComplete_inOrder + 1) + "번째 배송중"; //(총 갯수)중 (완료한 갯수+1)번째 배송중
            Lv_Order.Items[iOrder_Complete].ForeColor = Color.Blue; //파란색
        }

        public void Deliv_Complete() //배송 3단계 - 배송완료
        {
            iComplete_inOrder++; //완료한 갯수+1
            Lv_Order.Items[iOrder_Complete].SubItems[4].Text = iComplete_inOrder.ToString(); //완료한 갯수 업데이트
            if (iComplete_inOrder == iTotal_inOrder) //배송물품을 다 채웠을때
            {
                Lv_Order.Items[iOrder_Complete].SubItems[6].Text = "배송완료";
                iOrder_Complete++; //완료한 주문+1
            }
            else
                Lv_Order.Items[iOrder_Complete].SubItems[6].Text = iTotal_inOrder.ToString() + "개중 "
                    + iComplete_inOrder + "개 배송완료"; //(총 갯수)중 (완료한 갯수)번째 배송완료
            Lv_Order.Items[iOrder_Complete].ForeColor = Color.Blue; //파란색
        }

        public void Reload_Start()
        {
            Lv_Order.Items[iOrder_Complete].SubItems[6].Text = "검품오류. 재적재중";
            Lv_Order.Items[iOrder_Complete].ForeColor = Color.Red;
        }
        public void Reload_Complete()
        {
            Lv_Order.Items[iOrder_Complete].SubItems[6].Text = "검품오류로 재적재함";
            Lv_Order.Items[iOrder_Complete].ForeColor = Color.Red;
        }
    }
}
