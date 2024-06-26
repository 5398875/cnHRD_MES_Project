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

        int[,] WH_Location = new int[2, 3]; //3행2열 배열 생성, 초기값은 전부 0

        private void Warehouse_Load(object sender, EventArgs e)
        {
            pb_DockMonitor.Image = Image.FromFile(System.Environment.CurrentDirectory + "/images/loading dock.png");
        }

        private int[] FindLocationXY(int Type)
        {
            for (int iYCount = 0; iYCount < WH_Location.GetLength(1); iYCount++)
            {
                for (int iXCount = 0; iXCount < WH_Location.GetLength(0); iXCount++)
                {
                    if (WH_Location[iXCount, iYCount] == Type)
                    {
                        return new int[] { iXCount, iYCount }; //조건에 맞는 x,y값 반환
                    }
                }
            }
            return new int[] { 10, 10 }; //조건에 맞는 위치를 찾지 못한 경우 {10, 10} 반환
        }

        public int[] Ware_Location(int Is_Metal)
        {
            int[] WLocation = { 0, 0 };

            switch (Is_Metal)
            {
                case 0: //빈자리 찾기
                    WLocation = FindLocationXY(0);
                    break;

                case 1: //금속 위치 반환
                    WLocation = FindLocationXY(1);
                    break;

                case 2: //비금속 위치 반환
                    WLocation = FindLocationXY(2);
                    break;
            }

            return WLocation;
        }

        public void Is_Load(int Is_Metal, int X, int Y)
        {
            if (X >= 0 && X < WH_Location.GetLength(0) && Y >= 0 && Y < WH_Location.GetLength(1))
            {
                WH_Location[X, Y] = Is_Metal; //주어진 위치에 금속, 비금속 값 저장
            }
        }

        public void Take_From(int X, int Y)
        {
            if (X >= 0 && X < WH_Location.GetLength(0) && Y >= 0 && Y < WH_Location.GetLength(1))
            {
                WH_Location[X, Y] = 0; //주어진 위치의 금속,비금속 제거
            }
        }
    }
}
