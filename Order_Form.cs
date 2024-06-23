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

        private void bt_Order_Click(object sender, EventArgs e)
        {
            

            if(cb_Type.Text == "")
            {
                MessageBox.Show("주문 품목란이 비어있습니다", "[Error 1]");
            }

            else if(cb_Location.Text == "")
            {
                MessageBox.Show("주문 지역란이 비어있습니다", "[Error 2]");
            }

            else  if(tb_Quantity.Text == QuantityPlaceHolder || tb_Quantity == null)
            {
                MessageBox.Show("주문 수량란이 비어있습니다", "[Error 3]");
                tb_Quantity.Focus();
                tb_Quantity.SelectAll();
                return;
            }

            else if(int.Parse(tb_Quantity.Text) > 3 || int.Parse(tb_Quantity.Text) < 1)
            {
                MessageBox.Show("1회 주문 수량은 최소 1개, 최대 3개입니다", "[Error 4]");
                tb_Quantity.Focus();
                tb_Quantity.SelectAll();
                return;
            }
            else
            {
                MessageBox.Show("품목 : " + cb_Type.SelectedItem + System.Environment.NewLine + "주문지 : " + cb_Location.SelectedItem + System.Environment.NewLine + "수량 : " + tb_Quantity.Text, "[주문 확인]");
                ////06.24 작업 이어서 할것
            }
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
