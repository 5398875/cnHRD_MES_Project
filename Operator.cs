using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActUtlTypeLib;

namespace cnHRD_MES_Project
{
    public partial class Operator : Form
    {
        System.Windows.Forms.Timer Timer_Slide = new System.Windows.Forms.Timer(); //슬라이드용 타이머
        System.Windows.Forms.Timer Timer_Operation = new System.Windows.Forms.Timer(); //동작용 타이머
        ActUtlType PLC01 = new ActUtlType();

        public Operator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer_Slide.Interval = 10; //슬라이드메뉴
            Timer_Slide.Tick += new EventHandler(Timer_Sl); //슬라이드 메뉴
            Timer_Operation.Interval = 100;
            Timer_Operation.Tick += new EventHandler(Timer_Op); //오퍼레이팅 타이머
        }

        private void CheckBoxHide_CheckedChanged(object sender, EventArgs e) //슬라이드 메뉴
        {
            if (CheckBoxHide.Checked == false)
            {
                CheckBoxHide.Text = ">";
            }
            else
            {
                CheckBoxHide.Text = "<";
            }
            Timer_Slide.Start();
        }

        int Slide_Width = 50; //슬라이드 메뉴

        void Timer_Sl(object sender, EventArgs e) //슬라이드 메뉴
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

            Panel_SideMenu.Width = Slide_Width;
        }

        public int PLC_Open; //PLC 연결상태

        private void Bt_OpenPLC_Click(object sender, EventArgs e) //PLC 연결버튼
        {
            PLC01.ActLogicalStationNumber = 2;
            PLC_Open = PLC01.Open();
            if (PLC_Open == 0)
            {
                Lb_Connect.Text = "연결됨";
                Lb_Connect.ForeColor = Color.Green;
                Bt_ClosePLC.Enabled = true;
                Bt_OpenServo.Enabled = true;
                Bt_OpenPLC.Enabled = false;
            }
            else
            {
                Lb_Connect.Text = "연결실패 : 0x" + PLC_Open;
                Lb_Connect.ForeColor = Color.Red;
            }
        }

        private void Bt_ClosePLC_Click(object sender, EventArgs e) //PLC 연결종료버튼
        {
            PLC01.Close();
            Lb_Connect.Text = "연결종료";
            Lb_Connect.ForeColor = Color.Red;

            Bt_OpenPLC.Enabled = true;
            Bt_OpenServo.Enabled = false;
            Bt_Start.Enabled = false;
        }

        private void Bt_Start_Click(object sender, EventArgs e)
        {
            int iServoSpeed = (Convert.ToInt32(Tb_ServoSpeed.Text)) * 100;

            ushort[] temp = new ushort[2];

            temp[0] = (ushort)iServoSpeed;
            temp[1] = (ushort)(iServoSpeed >> 16);
            Timer_Operation.Start();

            PLC01.WriteBuffer(6, 1518, 1, (short)temp[0]);
            PLC01.WriteBuffer(6, 1519, 1, (short)temp[1]);

            Bt_Stop.Enabled = true;
        }

        private void Bt_OpenServo_Click(object sender, EventArgs e)
        {
            PLC01.SetDevice("Y60", 1);
            PLC01.GetDevice("X60", out int i);
            PLC01.GetDevice("Y60", out int j);

            if (i == 1 && j == 1)
            {
                Lb_ServoConnect.Text = "서보 준비완료";
                Lb_ServoConnect.ForeColor = Color.Green;
                Bt_Start.Enabled = true;
                PLC01.WriteBuffer(6, 1500, 1, 9001);
                PLC01.SetDevice("Y70", 1);
            }
            else
            {
                Lb_ServoConnect.Text = "서보 준비실패";
                Lb_ServoConnect.ForeColor = Color.Red;
            }
        }

        private void Bt_Stop_Click(object sender, EventArgs e)
        {
            iMode = 0;
        }

        void Sup_Fwd() //공급전진
        {
            PLC01.SetDevice("Y20", 1);
            PLC01.SetDevice("Y21", 0);
        }

        void Sup_Bwd() //공급후진
        {
            PLC01.SetDevice("Y20", 0);
            PLC01.SetDevice("Y21", 1);
        }

        void Trans_Fwd() //송출전진
        {
            PLC01.SetDevice("Y22", 1);
            PLC01.SetDevice("Y23", 0);
        }

        void Trans_Bwd() //송출후진
        {
            PLC01.SetDevice("Y22", 0);
            PLC01.SetDevice("Y23", 1);
        }

        void Con_On() //컨베이어정회전
        {
            PLC01.SetDevice("Y28", 1);
            PLC01.SetDevice("Y2F", 0);
        }

        void Con_Off() //컨베이어정지
        {
            PLC01.SetDevice("Y28", 0);
            PLC01.SetDevice("Y2F", 0);
        }

        void CCon_On() //컨베이어역회전
        {
            PLC01.SetDevice("Y28", 0);
            PLC01.SetDevice("Y2F", 1);
        }

        void Out_Fwd() //배출전진
        {
            PLC01.SetDevice("Y24", 1);
            PLC01.SetDevice("Y25", 0);
        }

        void Out_Bwd() //배출후진
        {
            PLC01.SetDevice("Y24", 0);
            PLC01.SetDevice("Y25", 1);
        }

        void Stop_Fwd() //스톱전진
        {
            PLC01.SetDevice("Y2D", 1);
        }

        void Stop_Bwd() //스톱후진
        {
            PLC01.SetDevice("Y2D", 0);
        }

        void Comp_Fwd() //흡착전진
        {
            PLC01.SetDevice("Y29", 1);
            PLC01.SetDevice("Y2A", 0);
        }

        void Comp_Bwd() //흡착후진
        {
            PLC01.SetDevice("Y29", 0);
            PLC01.SetDevice("Y2A", 1);
        }

        void Ware_Fwd() //창고전진
        {
            PLC01.SetDevice("Y2B", 1);
            PLC01.SetDevice("Y2C", 0);
        }

        void Ware_Bwd() //창고후진
        {
            PLC01.SetDevice("Y2B", 0);
            PLC01.SetDevice("Y2C", 1);
        }

        void CompPad_On() //흡착패드온
        {
            PLC01.SetDevice("Y2E", 1);
        }

        void CompPad_Off() //흡착패드오프
        {
            PLC01.SetDevice("Y2E", 0);
        }

        private static bool Check_Bit(int iData, int iLoc) //X를 위한 체크비트
        {
            int iVal = (0x1 << iLoc);
            return ((int)iData & iVal) == iVal;
        }

        int[] X_DATA = new int[8];
        public bool[,] X = new bool[8, 16];
        public int[] Is_Order = { 0, 0, 0, 0 }; //[0]:종류(0:주문X 1:비금속 2:금속) [1]X [2]Y [3]주소
        int iLoad = 0;
        int iDeliv = 0;
        public bool Is_Metal;
        public int[] Ware_Location = { 0, 0 };
        bool bStart = true;
        int iMode = 2;
        int[] iLocation = { 0, 0, 0, 0 };
        int i;
        short Ware_Loc;

        void Is_Load(string Is_Metal, int X, int Y)
        {

        }

        void Timer_Op(object sender, EventArgs e)
        {
            PLC01.ReadDeviceBlock("X0", 2, out X_DATA[0]);

            //x차원 배열에 값을 저장
            for (int ct1 = 0; ct1 <= 1; ct1++)
            {
                for (int ct2 = 0; ct2 <= 15; ct2++)
                {
                    X[ct1, ct2] = Check_Bit(X_DATA[ct1], ct2);
                }
            }

            if (iMode == 0) //비상정지
            {
                Bt_Start.Enabled = false;
                Sup_Bwd();
                Trans_Bwd();
                Con_Off();
                Ware_Bwd();
                Stop_Bwd();
                Out_Bwd();
                Comp_Bwd();
                CompPad_Off();
                Task.Delay(2000);
                Timer_Operation.Stop();
                bStart = true;
                Bt_Start.Enabled = true;
                iMode = 2;
            }

            else if (bStart == true)
            {
                if (Is_Order[0] == 1) //주문이 있다면
                {
                    iMode = 1;
                    iLocation = Is_Order;
                }
                else if (Is_Order[0] == 0) //주문이 없다면
                {
                    iMode = 2;
                    iLocation[2] = Ware_Location[0];
                    iLocation[3] = Ware_Location[1];
                }
                iLoad = 0;
                iDeliv = 0;
                bStart = false;
            }

            else if (iMode == 1)
            {
                switch (iDeliv)
                {
                    case 0: //1위치 서보이동
                        Ware_Loc = (short)(Ware_Location[1] * 2 + 1); //1,3,5
                        PLC01.WriteBuffer(6, 1500, 1, Ware_Loc);
                        PLC01.SetDevice("Y70", 1);
                        if (Ware_Location[0] == 0) //창고이동
                            Ware_Fwd();
                        else
                            Ware_Bwd();
                        iDeliv++;
                        break;
                    case 2: //if 1위치 이동완료 - 흡착전진 if 흡착전(X1A)까지 - 2위치 서보이동
                        PLC01.GetDevice("X74", out int i);
                        if (i == 1)
                            Comp_Fwd();
                        if (X[1, 10] == true)
                        {
                            Ware_Loc = (short)((Ware_Location[1] + 1) * 2); //2,4,6
                            PLC01.WriteBuffer(6, 1500, 1, Ware_Loc);
                            PLC01.SetDevice("Y70", 1);
                            iDeliv++;
                        }
                        break;
                    case 3: //if 2위치 이동완료 - 흡착온 - 1위치 재이동
                        PLC01.GetDevice("X74", out i);
                        if (i == 1)
                        {
                            CompPad_On();
                            Task.Delay(500); //딜레이 0.5초
                            Ware_Loc = (short)(Ware_Location[1] * 2 + 1); //1,3,5
                            PLC01.WriteBuffer(6, 1500, 1, Ware_Loc);
                            PLC01.SetDevice("Y70", 1);
                            iDeliv++;
                        }
                        break;
                    case 4: //if 1위치 재이동완료 - 흡착후진 - if흡착후(X1B)까지 - 컨위치까지 이동
                        PLC01.GetDevice("X74", out i);
                        if (i == 1)
                            Comp_Bwd();
                        if (X[1, 11] == true)
                        {
                            PLC01.WriteBuffer(6, 1500, 1, 7); //7위치
                            PLC01.SetDevice("Y70", 1);
                            iDeliv++;
                        }
                        break;
                    case 5: //if 컨위치 이동완료 - 흡착오프 - 컨역회전기동
                        PLC01.GetDevice("X74", out i);
                        if (i == 1)
                        {
                            CompPad_Off();
                            Task.Delay(500); //딜레이 0.5초
                            CCon_On();
                            iDeliv++;
                        }
                        break;
                }
            }

            else if (iMode == 2) //주문이 없다면
            {
                switch (iLoad)
                {
                    case 0: //공급전진 if 공급전(X10)까지
                        if (X[0, 8] && X[1, 1])
                            Sup_Fwd();
                        if (X[1, 0] == true)
                            iLoad++; break;
                    case 1: //공급후진 if 공급후(X11)까지
                        Sup_Bwd();
                        if (X[1, 1] == true)
                            iLoad++; break;
                    case 2: //송출전진 if 송출전(X14)까지
                        Trans_Fwd();
                        if (X[1, 4] == true)
                            iLoad++; break;
                    case 3: //송출후진, 컨구동 if 용량형(X0A)까지
                        Trans_Bwd(); Con_On();
                        if (X[0, 10] == true)
                            iLoad++; break;
                    case 4: //금속판별, 스톱다운
                        Stop_Fwd();
                        if (X[0, 9] == true) //고주파센서 감지
                            Is_Metal = true;
                        else //고주파센서 감지x
                            Is_Metal = false;
                        iLoad++; break;
                    case 5: //if 스토퍼(X0B) - 1위치 서보이동
                        if (X[0, 11] == true)
                        {
                            PLC01.WriteBuffer(6, 1500, 1, 7); //7위치
                            PLC01.SetDevice("Y70", 1);
                            iLoad++;
                        }
                        break;
                    case 6: //if 컨위치 이동완료 - 스톱업, 컨정지, 흡착온 - 1위치 서보이동
                        PLC01.GetDevice("X74", out int i);
                        if (i == 1)
                        {
                            Stop_Bwd();
                            Con_Off();
                            CompPad_On();
                            Task.Delay(500); //딜레이 0.5초
                            Ware_Loc = (short)(Ware_Location[1] * 2 + 1); //1,3,5
                            PLC01.WriteBuffer(6, 1500, 1, Ware_Loc);
                            PLC01.SetDevice("Y70", 1);
                            if (Ware_Location[0] == 0) //창고이동
                                Ware_Fwd();
                            else
                                Ware_Bwd();
                            iLoad++;
                        }
                        break;
                    case 7: //if 1위치 이동완료 - 흡착전진 if 흡착전(X1A)까지 - 2위치 서보이동
                        PLC01.GetDevice("X74", out i);
                        if (i == 1)
                            Comp_Fwd();
                        if (X[1, 10] == true)
                        {
                            Ware_Loc = (short)((Ware_Location[1] + 1) * 2); //2,4,6
                            PLC01.WriteBuffer(6, 1500, 1, Ware_Loc);
                            PLC01.SetDevice("Y70", 1);
                            iLoad++;
                        }
                        break;
                    case 8: //if 2위치 이동완료 - 흡착오프 - 1위치 재이동
                        PLC01.GetDevice("X74", out i);
                        if (i == 1)
                        {
                            CompPad_Off();
                            Task.Delay(500); //딜레이 0.5초
                            Ware_Loc = (short)(Ware_Location[1] * 2 + 1); //1,3,5
                            PLC01.WriteBuffer(6, 1500, 1, Ware_Loc);
                            PLC01.SetDevice("Y70", 1);
                            iLoad++;
                        }
                        break;
                    case 9: //if 1위치 재이동완료 - 흡착후진 - if흡착후(X1B)까지
                        PLC01.GetDevice("X74", out i);
                        if (i == 1)
                            Comp_Bwd();
                        if (X[1, 11] == true)
                        {
                            if (Is_Metal == true) Is_Load("금속", Ware_Location[0], Ware_Location[1]);
                            else if (Is_Metal == false) Is_Load("비금속", Ware_Location[0], Ware_Location[1]);
                            bStart = true;
                        }
                        break;
                }
            }
        }

        private void Bt_JogUp_Click(object sender, EventArgs e)
        {
            int jogSpeed = (Convert.ToInt32(Tb_ServoSpeed.Text)) * 100;

            //Console.WriteLine(jogSpeed);

            ushort[] temp = new ushort[2];

            temp[0] = (ushort)jogSpeed;
            temp[1] = (ushort)(jogSpeed >> 16);

            PLC01.WriteBuffer(6, 1518, 1, (short)temp[0]);
            PLC01.WriteBuffer(6, 1519, 1, (short)temp[1]);
        }


        private void Bt_JogUP_up(object sender, EventArgs e)
        {
            PLC01.SetDevice("Y69", 1);
        }

        private void Bt_JogUP_down(object sender, EventArgs e)
        {
            PLC01.SetDevice("Y69", 1);
        }

        private void Bt_JogDown_Click(object sender, EventArgs e)
        {
            int jogSpeed = (Convert.ToInt32(Tb_ServoSpeed.Text)) * 100;

            //Console.WriteLine(jogSpeed);

            ushort[] temp = new ushort[2];

            temp[0] = (ushort)jogSpeed;
            temp[1] = (ushort)(jogSpeed >> 16);

            PLC01.WriteBuffer(6, 1518, 1, (short)temp[0]);
            PLC01.WriteBuffer(6, 1519, 1, (short)temp[1]);
        }

        private void Bt_JogDown_up(object sender, EventArgs e)
        {
            PLC01.SetDevice("Y68", 1);
        }

        private void Bt_JogDown_down(object sender, EventArgs e)
        {
            PLC01.SetDevice("Y68", 1);
        }

        private void Bt_Test_Click(object sender, EventArgs e)
        {
            Sup_Fwd();
        }
    }
}
