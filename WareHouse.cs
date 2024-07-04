using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
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

        public int[,] WH_Location = new int[2, 3]; //3행2열 배열 생성, 초기값은 전부 0
        int initial_Value = 0;  //초기값은 0이라는 정수형 변수 선언

        private void Warehouse_Load(object sender, EventArgs e)//폼 실행시,
        {
            pb_DockMonitor.Image = Image.FromFile(System.Environment.CurrentDirectory + "/images/loading dock.png");
            pictureBoxMetal.Image = Image.FromFile(System.Environment.CurrentDirectory + "/images/Metal.png");
            pictureBoxNMetal.Image = Image.FromFile(System.Environment.CurrentDirectory + "/images/Non-Metal.png");
            Round(label1, 12);
            Round(panel1, 36);
            Round(panel2, 36);
            Round(panel3, 36);
            Round(panel4, 36);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect,
            int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void Round(Control c, int i)
        {
            if (i == 0) c.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, c.Width, c.Height, c.Height, c.Height));
            else if (i == 1) c.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, c.Width, c.Height, c.Width, c.Width));
            else c.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, c.Width, c.Height, i, i));
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

        public int[] Ware_Location(int Is_Metal)    //동작부에서 요청한 빈자리/금,비금 창고 위치 반환함수
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

        int Metal = 0;
        int NonMetal = 0;

        public void Is_Load(int Is_Metal, int X, int Y) //동작부에서 넘긴 창고 적재 위치저장 함수
        {
            if (X >= 0 && X < WH_Location.GetLength(0) && Y >= 0 && Y < WH_Location.GetLength(1))
            {
                WH_Location[X, Y] = Is_Metal; //주어진 위치에 금속, 비금속 값 저장
                Update_Type(X + 1, Y + 1, WH_Location[X, Y]);   //위치에 저장된 종류 업데이트
                if (Is_Metal == 1)
                {
                    Metal++;
                    labelMetal.Text = "금속 " + Metal.ToString() + "개";
;                }
                else if (Is_Metal == 2)
                {
                    NonMetal++;
                    labelNMetal.Text = "비금속 " + NonMetal.ToString() + "개";
                    ;
                }
            }
        }

        public void Take_From(int X, int Y) //동작부에서 창고 적재물 추출 시 해당하는 창고 위치정보 클리어
        {
            if (WH_Location[X, Y]  == 1)
            {
                Metal--;
                labelMetal.Text = "금속 " + Metal.ToString() + "개";
                ;
            }
            else if (WH_Location[X, Y] == 2)
            {
                NonMetal--;
                labelNMetal.Text = "비금속 " + NonMetal.ToString() + "개";
                ;
            }
            WH_Location[X, Y] = 0; //주어진 위치의 금속,비금속 제거
                Update_Type(X + 1, Y + 1, 0);  //위치에서 추출해간 상품 라벨에서 제거
        }

        string sType;   //픽쳐박스에 종류 네이밍을 위한 string 선언

        private void Update_Type(int X, int Y, int Type)    //픽쳐박스 네이밍을 위한 함수 선언, 3개의 매개변수 받아옴
        {
            string lbName = $"lb{Y}{X}"; //$(보간된 원시 리터럴)을 이용, lb{Y}{X}라는 이름을 가진 픽쳐박스네임 생성
            Control[] controls = this.Controls.Find(lbName, true);   
            //this.control.find 내장함수 이용, lbname과 같은 이름을 가진 컨트롤 controls 생성 및 반환

            if (controls[0] is PictureBox lb)  //찾은 controls가 픽쳐박스 타입이라면,
            {
                switch (Type)   //case문으로 받은 종류 한글 네이밍
                {
                    case 0:
                        lb.Image = Image.FromFile(System.Environment.CurrentDirectory + "/images/Empty.png");
                        break;

                    case 1:
                        lb.Image = Image.FromFile(System.Environment.CurrentDirectory + "/images/Metal.png");
                        break;

                    case 2:
                        lb.Image = Image.FromFile(System.Environment.CurrentDirectory + "/images/Non-Metal.png");
                        break;
                }
            }
        }
    }
}
