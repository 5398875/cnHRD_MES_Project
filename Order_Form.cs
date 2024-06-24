using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cnHRD_MES_Project
{
    public partial class Order_Form : Form
    {
        string Quantity;   //수량 변수 선언
        const string QuantityPlaceHolder = "1~3 사이의 숫자만 입력 가능"; //수량 텍스트박스 PlaceHolder 설정

        public Order_Form()
        {
            InitializeComponent();

            Quantity = Convert.ToString(tb_Quantity.Text);

            tb_Quantity.ForeColor = Color.DarkGray; //수량 PlaceHolder 폰트색 회색 지정
            tb_Quantity.Text = QuantityPlaceHolder; //텍스트박스 placeholder 내용 기입
            tb_Quantity.GotFocus += RemovePlaceHolder;  //Focus를 받을 때
            tb_Quantity.LostFocus += SetPlaceHolder;    //Focus를 잃을 때

        }

        private void RemovePlaceHolder(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            if(tb_Quantity.Text == QuantityPlaceHolder) //수량 란이 Placeholder일 경우
            {
                tb_Quantity.ForeColor = Color.Black;
                tb_Quantity.Text = string.Empty;

            }
        }

        private void SetPlaceHolder(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(tb_Quantity.Text))    //유저 입력란이 비어있는데 focus를 잃으면
            {
                tb_Quantity.ForeColor = Color.DarkGray;
                tb_Quantity.Text = QuantityPlaceHolder;
            }
        }

        private void Order_Form_Load(object sender, EventArgs e)
        {

        }

        //private int[] get_Order = { 0, 0, 0, 0 }; 4칸짜리 배열을 사용한 다면
        int Existence_Order = 0;    //주문 유무 판단 0:무 1:비금속 2:금속
        
        private void bt_Order_Click(object sender, EventArgs e)
        {


            if (cb_Type.Text == "")
            {
                MessageBox.Show("주문 품목란이 비어있습니다", "[Error 1]");
            }

            else if (cb_Location.Text == "")
            {
                MessageBox.Show("주문 지역란이 비어있습니다", "[Error 2]");
            }

            else if (tb_Quantity.Text == QuantityPlaceHolder || tb_Quantity == null)
            {
                MessageBox.Show("주문 수량란이 비어있습니다", "[Error 3]");
                tb_Quantity.Focus();
                tb_Quantity.SelectAll();
                return;
            }

            else if (int.Parse(tb_Quantity.Text) > 3 || int.Parse(tb_Quantity.Text) < 1)
            {
                MessageBox.Show("1회 주문 수량은 최소 1개, 최대 3개입니다", "[Error 4]");
                tb_Quantity.Focus();
                tb_Quantity.SelectAll();
                return;
            }
            else
            {
                var OrderCheck = MessageBox.Show("품목 : " + cb_Type.SelectedItem + System.Environment.NewLine + "주문지 : " + cb_Location.SelectedItem + System.Environment.NewLine + "수량 : " + tb_Quantity.Text, "[주문 확인]", MessageBoxButtons.OKCancel);
                if (OrderCheck == DialogResult.OK)
                {
                    if(cb_Type.SelectedIndex == 0)  //품목이 비금일 때
                    {
                        Existence_Order = 1;
                    }
                    if (cb_Type.SelectedIndex == 1) //품목이 금속일 때
                    {
                        Existence_Order = 2;
                    }
                    /*  4칸짜리 배열로 사용한다면
                    if (cb_Type.SelectedIndex == 0)  //종류에 비금속을 넣었을 경우
                    {
                        get_Order[0] = 1;   //배열[0]: 유무+종류 비금속 코드: 1
                    }
                    if (cb_Type.SelectedIndex == 1)  //종류에 금속을 넣었을 경우
                    {
                        get_Order[0] = 2;   //금속 코드: 2
                    }
                    if(cb_Location.SelectedIndex == 0)
                    {
                        get_Order[3] = 0;   //배열[3]: 주소지 서울시 서초구 코드: 0
                    }
                    if(cb_Location.SelectedIndex == 1)
                    {
                        get_Order[3] = 1;   //부산시 부산진구 코드: 1
                    }
                    Debug.WriteLine("get_Order[3] = " + get_Order[3]);
                    */
                }
            }
            //// 창고로부터 주소지 받아 올 것
        }

        private void tb_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
