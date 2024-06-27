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

namespace cnHRD_MES_Project
{
    public partial class Order : Form
    {
        System.Windows.Forms.Timer Timer_Order = new System.Windows.Forms.Timer();

        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            Timer_Order.Interval = 1000;
            Timer_Order.Tick += new EventHandler(Timer_Or);
            Timer_Order.Start();
        }

        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)+"/Order.txt";

        int n = 0;
        private void Timer_Or(object sender, EventArgs e)
        {
            string[] Lines = File.ReadAllLines(filePath);
            if (Lines.Length >= 1)
            {
                if (Lines[0] != string.Empty)
                {
                    n++;
                    ListViewItem item = new ListViewItem(n.ToString());
                    if (Lines[0].Substring(0,1) == "1")
                        item.SubItems.Add("금속");
                    else if (Lines[0].Substring(0,1) == "2")
                        item.SubItems.Add("비금속");
                    if (Lines[0].Substring(1,1) == "1")
                        item.SubItems.Add("부산");
                    else if (Lines[0].Substring(1,1) == "0")
                        item.SubItems.Add("서울");
                    item.SubItems.Add(Lines[0].Substring(2,1));
                    item.SubItems.Add(DateTime.Now.ToString("yyyy.MM.dd HH.mm.ss"));
                    Lv_Order.Items.Add(item);
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

        public int[]Is_Order()
        {
            int[] iOrder = new int[] { 0, 0, 0 };
            if (Lv_Order.Items.Count == 0)
                iOrder[0] = 0;
            else if (Lv_Order.Items.Count > 0)
            {
                if (Lv_Order.Items[0].SubItems[1].Text == "금속")
                    iOrder[0] = 1;
                else if (Lv_Order.Items[0].SubItems[1].Text == "비금속")
                    iOrder[0] = 2;
                if (Lv_Order.Items[0].SubItems[1].Text == "서울")
                    iOrder[1] = 1;
                else if (Lv_Order.Items[0].SubItems[1].Text == "부산")
                    iOrder[1] = 2;
            }
            return iOrder;
        }


        public void Deliv_Start()
        {
            Lv_Order.Items.RemoveAt(0);
        }
    }
}
