using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace cnHRD_MES_Project
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        Order_Form Order_Form = new Order_Form();

        private void Bt_OpenOrder_Click(object sender, EventArgs e)
        {
            Order_Form.Show();
        }

        public void List_Add(int Order_Type, int Order_Location, int Order_Num)
        {
        }
    }
}
