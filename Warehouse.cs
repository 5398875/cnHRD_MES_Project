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
    public partial class Warehouse : Form
    {
        

        public Warehouse()
        {
            InitializeComponent();
        }



        private void Warehouse_Load(object sender, EventArgs e)
        {
            pb_DockMonitor.Image = Image.FromFile(System.Environment.CurrentDirectory + "/images/loading dock.png");
        }

        int[] here_Location = new int[2];

        public int[] Ware_Location(int Is_Metal)
        {
            switch (Is_Metal)
            {
                case 0: //빈자리 찾는 것 [0]: x축, [1]: y축 반환하면 됨

                    break;
                
                case 1: //금속 위치 반환 x,y축

                    break;

                case 2: //비금속 위치 반환, xy축

                    break;

            }

            return here_Location;
        }

        public int[] WH_Y = new int[3];
        public int[] WH_X = new int[2];

        public void Is_Load(int Is_Metal, int X, int Y)
        {
            // 데이터 베이스에 입력할 것
        }

        public void Take_From(int X, int Y)
        {
            // 데이터 베이스에서 제거할 것
        }
    }
}
