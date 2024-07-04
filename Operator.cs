using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActUtlTypeLib;
using Project_v01;

namespace cnHRD_MES_Project
{
     public partial class Operator : Form
    {
        System.Windows.Forms.Timer Timer_Operation = new System.Windows.Forms.Timer(); //동작용 타이머
        System.Windows.Forms.Timer Timer_Jog = new System.Windows.Forms.Timer(); //조그용 타이머
        ActUtlType PLC01 = new ActUtlType();

        Main main = null;

        public void setMain(Main main)
        {
            this.main = main;
        }

        public Operator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer_Operation.Interval = 100;
            Timer_Operation.Tick += new EventHandler(Timer_Op); //오퍼레이팅 타이머 생성
            Timer_Jog.Interval = 50;
            Timer_Jog.Tick += new EventHandler(Timer_Jo); //JOG 타이머 생성
            operatorLogForm = new Operator_Log(); //공정결과 같이 생성

            Round(Pn_Open, 36);            Round(Pn_JOG, 36);            Round(Pn_Oper, 36);

            Round(Pn_PLCOuter, 0);            Round(Bt_PLC, 0);            Round(Bt_PLCOn, 0);            Round(Bt_PLCOff, 0);
            Round(Pn_ServoOuter, 0);            Round(Bt_Servo, 0);            Round(Bt_ServoOn, 0);            Round(Bt_ServoOff, 0);
            Round(Pn_StartOuter, 0);            Round(Bt_Start, 0);            Round(Bt_StartOn, 0);            Round(Bt_StartOff, 0);

            Round(panel1, 16);            Round(panel2, 16);            Round(panel3, 16);            Round(panel4, 16);
            Round(panel5, 16);            Round(panel6, 16);            Round(panel7, 16);            Round(panel8, 16);
            Round(panel9, 16);

            Round(Pn_JogFull, 12);            Round(Pn_JogOuter, 12);

            Round(label3, 12);            Round(label11, 12);            Round(label12, 12); //모서리 다듬기
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect,
            int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void Round(Control c, int i) //모서리 다듬는 함수. 0이면 가로기준, 1이면 세로기준, 이외에는 그 숫자만큼 다듬기
        {
            if (i == 0) c.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, c.Width, c.Height, c.Height, c.Height));
            else if (i == 1) c.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, c.Width, c.Height, c.Width, c.Width));
            else c.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, c.Width, c.Height, i, i));
        }

        //------------------------------------------버튼-----------------------------------------
        public int PLC_Open = 1; //PLC 연결상태

        private void Bt_PLC_Click(object sender, EventArgs e) //PLC버튼
        {
            if (PLC_Open == 0) //PLC에 연결되어있다면
            {
                PLC01.Close(); //PLC 연결종료
                Pn_PLCOuter.BackColor = Color.Black; //┐
                Bt_PLC.BackColor = Color.White;      //┤
                Bt_PLCOff.Visible = true;            //┤
                Bt_PLCOn.Visible = false;            //┼토글버튼을 위한 비쥬얼 세팅
                Bt_PLC.Text = "OFF";                 //┤
                Bt_PLC.ForeColor = Color.Black;      //┘
                PLC_Open = 1; //연결 성공을 지움
                Cockpit CP = new Cockpit();
                CP.bt_PLC_stop_Click(sender, e); //콕핏의 시작버튼을 동시에 누르도록 함
            }
            else if (PLC_Open != 0) //PLC에 연결되어있지 않다면
            {
                PLC01.ActLogicalStationNumber = 1; //개인 MXComponent에 따라 수정할것
                PLC_Open = PLC01.Open(); //연결시도
                if (PLC_Open == 0) //연결에 성공하면
                {
                    Pn_PLCOuter.BackColor = Color.FromArgb(255, 0, 120, 215); //┐
                    Bt_PLC.BackColor = Color.FromArgb(255, 0, 120, 215);      //┤
                    Bt_PLCOff.Visible = false;                                //┤
                    Bt_PLCOn.Visible = true;                                  //┼토글버튼을 위한 비쥬얼 세팅
                    Bt_PLC.Text = "ON";                                       //┤
                    Bt_PLC.ForeColor = Color.White;                           //┘
                    PLC01.SetDevice("Y60", 1); //서보에 PLC레디(Y60)을 미리 보낸다
                    Cockpit CP = main.Cock1;
                    CP.bt_PLC_start_Click(sender, e); //콕핏의 정지버튼을 동시에 누르도록 함
                }
            }
        }

        private void Bt_Servo_Click(object sender, EventArgs e) //서보버튼
        {
            if (Bt_Servo.Text == "ON") //서보가 켜져있으면
            {
                Pn_ServoOuter.BackColor = Color.Black; //┐
                Bt_Servo.BackColor = Color.White;      //┤
                Bt_ServoOff.Visible = true;            //┤
                Bt_ServoOn.Visible = false;            //┼토글버튼을 위한 비쥬얼 세팅
                Bt_Servo.Text = "OFF";                 //┤
                Bt_Servo.ForeColor = Color.Black;      //┘
            }
            else if (Get_Device("X60") && Get_Device("Y60")) //PLC레디(Y60),서보레디(X60)이 전부 true면
            {
                Pn_ServoOuter.BackColor = Color.FromArgb(255, 0, 120, 215); //┐
                Bt_Servo.BackColor = Color.FromArgb(255, 0, 120, 215);      //┤
                Bt_ServoOff.Visible = false;                                //┼토글버튼을 위한 비쥬얼 세팅
                Bt_ServoOn.Visible = true;                                  //┤
                Bt_Servo.Text = "ON";                                       //┤
                Bt_Servo.ForeColor = Color.White;                           //┘

                Servo_Move(9001); //원점복귀

                int JogSpeed = 200000; //JOG 속도
                ushort[] uJog_Speed = new ushort[2];      //┐
                uJog_Speed[0] = (ushort)JogSpeed;         //┼─JOG속도를 ushort의 배열로 바꾸기 위함
                uJog_Speed[1] = (ushort)(JogSpeed >> 16); //┘

                PLC01.WriteBuffer(6, 1518, 1, (short)uJog_Speed[0]); //┐
                PLC01.WriteBuffer(6, 1519, 1, (short)uJog_Speed[1]); //┴─U6\G1518번에 JOG속도
            }
        }

        public static int Air = 0; //Cockpit에서 쓸 공압유무

        private void Bt_Start_Click(object sender, EventArgs e) //"시작" 버튼
        {
            if (Bt_Start.Text == "RUN") //동작중일때
            {
                Air = 0; //공압 꺼짐
                Timer_Operation.Stop(); //타이머 정지
                PLC01.SetDevice("Y70", 0); //서보 기동신호 초기화
                Sup_Bwd();     //┐
                Trans_Bwd();   //┤
                Con_Off();     //┤
                Stop_Bwd();    //┼─공정 초기화
                Out_Bwd();     //┤
                Comp_Bwd();    //┤
                CompPad_Off(); //┤
                bStart = true; //┘

                Pn_StartOuter.BackColor = Color.Red; //┐
                Bt_Start.BackColor = Color.White;    //┤
                Bt_StartOff.Visible = true;          //┤
                Bt_StartOn.Visible = false;          //┼토글버튼을 위한 비쥬얼 세팅
                Bt_Start.Text = "STOP";              //┤
                Bt_Start.ForeColor = Color.Red;      //┘
            }
            else if (Bt_Start.Text == "STOP") //정지상태일때
            {
                Air = 1; //공압 켜짐
                Timer_Operation.Start(); //타이머 시작
                Pn_StartOuter.BackColor = Color.Green; //┐
                Bt_Start.BackColor = Color.Green;      //┤
                Bt_StartOff.Visible = false;           //┤
                Bt_StartOn.Visible = true;             //┼토글버튼을 위한 비쥬얼 세팅
                Bt_Start.Text = "RUN";                 //┤
                Bt_Start.ForeColor = Color.White;      //┘
            }
        }

        private void Bt_JogUp_MouseDown(object sender, MouseEventArgs e) //"JOG상" 버튼을 눌렀을때
        {
            Timer_Jog.Start(); //조그타이머 시작
            PLC01.SetDevice("Y69", 1); //역기동(Y69) ON
        }

        private void Bt_JogUp_MouseUp(object sender, MouseEventArgs e) //"JOG상" 버튼을 뗏을때
        {
            PLC01.SetDevice("Y69", 0); //역기동(Y69) OFF
            Timer_Jog.Stop(); //조그타이머 정지
        }

        private void Bt_JogDown_MouseDown(object sender, MouseEventArgs e) //"JOG하" 버튼을 눌렀을때
        {
            Timer_Jog.Start(); //조그타이머 시작
            PLC01.SetDevice("Y68", 1); //정기동(Y68) ON
        }

        private void Bt_JogDown_MouseUp(object sender, MouseEventArgs e) //"JOG하" 버튼을 뗏을때
        {
            PLC01.SetDevice("Y68", 0); //정기동(Y68) OFF
            Timer_Jog.Stop(); //조그타이머 정지
        }

        //-------------------------------------사용자 함수-----------------------------------------
        private bool Get_Device(string s) //s = PLC01의 parameter를
        {
            PLC01.GetDevice(s, out i); //PLC01에서 불러와서
            if (i == 0) return false; //1이면 false
            else return true;  //0이면 true를 내보내는 함수
        }

        private void Servo_Move(short iLocation) //iLocation = 위치결정데이터 번호를
        {
            if (!Get_Device("X6C")) //서보가 기동중이 아닐때
            {
                PLC01.WriteBuffer(6, 1500, 1, iLocation); //U6\G1500에 입력후
                PLC01.SetDevice("Y70", 1); //서보 기동신호(Y70)를
                PLC01.SetDevice("Y70", 0); //잠시동안만 주고 끊기
            }
        }

        void Sup_Fwd() { PLC01.SetDevice("Y20", 1); PLC01.SetDevice("Y21", 0); } //공급전진
        void Sup_Bwd() { PLC01.SetDevice("Y20", 0); PLC01.SetDevice("Y21", 1); } //공급후진
        void Trans_Fwd() { PLC01.SetDevice("Y22", 1); PLC01.SetDevice("Y23", 0); } //송출전진
        void Trans_Bwd() { PLC01.SetDevice("Y22", 0); PLC01.SetDevice("Y23", 1); } //송출후진
        void Con_On() { PLC01.SetDevice("Y28", 1); PLC01.SetDevice("Y2F", 0); } //컨베이어정회전
        void Con_Off() { PLC01.SetDevice("Y28", 0); PLC01.SetDevice("Y2F", 0); } //컨베이어정지
        void CCon_On() { PLC01.SetDevice("Y28", 0); PLC01.SetDevice("Y2F", 1); } //컨베이어역회전
        void Out_Fwd() { PLC01.SetDevice("Y24", 1); PLC01.SetDevice("Y25", 0); } //배출전진
        void Out_Bwd() { PLC01.SetDevice("Y24", 0); PLC01.SetDevice("Y25", 1); } //배출후진
        void Stop_Fwd() { PLC01.SetDevice("Y2D", 1); } //스톱전진
        void Stop_Bwd() { PLC01.SetDevice("Y2D", 0); } //스톱후진
        void Comp_Fwd() { PLC01.SetDevice("Y29", 1); PLC01.SetDevice("Y2A", 0); } //흡착전진
        void Comp_Bwd() { PLC01.SetDevice("Y29", 0); PLC01.SetDevice("Y2A", 1); } //흡착후진
        void Ware_Fwd() { PLC01.SetDevice("Y2B", 1); PLC01.SetDevice("Y2C", 0); } //창고전진
        void Ware_Bwd() { PLC01.SetDevice("Y2B", 0); PLC01.SetDevice("Y2C", 1); } //창고후진
        void CompPad_On() { PLC01.SetDevice("Y2E", 1); } //흡착패드온
        void CompPad_Off() { PLC01.SetDevice("Y2E", 0); } //흡착패드오프


        public static int iLoad = 0; //적재모드일때 기동순서
        public static int iDeliv = 0; //배송모드일때 기동순서
        public static int iReload = 0; //재적재모드일때 기동순서
        public static int Is_Metal; //금속과 관련된 공정에서 사용(1:금속, 2:비금속)
        public static int iMetal; //다른 Form에서 볼 금속여부(0:판별되지않음 1:금속 2:비금속)

        public bool bStart = true; //초기상태를 나타냄. 공정중 False였다가 공정 1사이클이 완료되면 True
        public static int iMode = 2; //공정모드. 1=배송 2=적재 3=재적재
        int i;
        DateTime tBefore, tAfter; //공정중에 시간지연이 필요할때 사용
        short iLocUp, iLocDown; //서보의 위치결정데이터 1,3,5 and 2,4,6
        public static int[] iLocation = { 0, 0, 0, 0, 0 }; //공정에서 사용하는 인수들 집합
                                             //[0](1:금속주문,2:비금속주문) [1]:X좌표 [2]:Y좌표 [3]:배송지 [4]:남은수량
        /// <summary>
        /// 로그기록용 변수선언
        /// </summary>
        DateTime processStartTime;      //공정 시작 시점
        DateTime processEndTime;        //공정 종료 시점
        bool processStarted = false;    //공정 시작 알림용
        bool is_Done = false;           //초기 성공여부 기록

        private TextBox[] ServoInput; //서보 티칭에 사용

        private void Bt_WriteServo_Click(object sender, EventArgs e) //서보에 위치결정데이터 쓰기
        {
            int Servo_Speed = int.Parse(Tb_ServoSpeed.Text) * 100; //서보속도
            ushort[] uServo_Speed = new ushort[2];         //┐
            uServo_Speed[0] = (ushort)Servo_Speed;         //┼─서보속도를 ushort의 배열로 바꾸기 위함
            uServo_Speed[1] = (ushort)(Servo_Speed >> 16); //┘

            ServoInput = new TextBox[] { Tb_Servo1, Tb_Servo2, Tb_Servo3, Tb_Servo4, Tb_Servo5, Tb_Servo6, Tb_Servo7 };
            //각 서보위치를 나타내는 TextBox의 이름을 배열화
            for (i = 0; i < 7; i++) //위치결정데이터 1~7번을 쓰는과정
            {
                int Servo_Loc = int.Parse(ServoInput[i].Text); //각 위치결정데이터의 위치
                ushort[] uServo_Loc = new ushort[2];       //┐
                uServo_Loc[0] = (ushort)Servo_Loc;         //┼─위치를 ushort의 배열로 바꾸기 위함
                uServo_Loc[1] = (ushort)(Servo_Loc >> 16); //┘

                PLC01.WriteBuffer(6, 2000 + (i * 10), 1, 256); //U6\G20i0번에 H100
                PLC01.WriteBuffer(6, 2004 + (i * 10), 1, (short)uServo_Speed[0]); //┐
                PLC01.WriteBuffer(6, 2005 + (i * 10), 1, (short)uServo_Speed[1]); //┴─U6\G20i4번에 서보속도
                PLC01.WriteBuffer(6, 2006 + (i * 10), 1, (short)uServo_Loc[0]); //┐
                PLC01.WriteBuffer(6, 2007 + (i * 10), 1, (short)uServo_Loc[1]); //┴─U6\G20i6번에 위치
            }
        }

        //서보위치를 티칭하기 위한 버튼들
        private void Bt_Servo1_Teaching_Click(object sender, EventArgs e) { Tb_Servo1.Text = Tb_ServoLoc.Text; }
        private void Bt_Servo2_Teaching_Click(object sender, EventArgs e) { Tb_Servo2.Text = Tb_ServoLoc.Text; }
        private void Bt_Servo3_Teaching_Click(object sender, EventArgs e) { Tb_Servo3.Text = Tb_ServoLoc.Text; }
        private void Bt_Servo4_Teaching_Click(object sender, EventArgs e) { Tb_Servo4.Text = Tb_ServoLoc.Text; }
        private void Bt_Servo5_Teaching_Click(object sender, EventArgs e) { Tb_Servo5.Text = Tb_ServoLoc.Text; }
        private void Bt_Servo6_Teaching_Click(object sender, EventArgs e) { Tb_Servo6.Text = Tb_ServoLoc.Text; }
        private void Bt_Servo7_Teaching_Click(object sender, EventArgs e) { Tb_Servo7.Text = Tb_ServoLoc.Text; }

        //-------------------------------------공정-----------------------------------------

        void Timer_Jo(object sender, EventArgs e) //JOG할때 위치출력
        {
            short[] temp = new short[2];
            PLC01.ReadBuffer(6, 800, 2, out temp[0]); //U6\G800(현재위치)
            if (temp[0] > 0)
            {
                int temp2 = (ushort)temp[0] | ((int)temp[1] << 16); //2워드를 int(32비트)로 합치기
                Tb_ServoLoc.Text = temp2.ToString(); //현재 위치를 기록
                int i = (int)(temp2 * Pn_JogFull.Size.Height / 1500000); //위치를 나타내는 바(bar)의 필요값을 계산((현재위치/150만)*전체길이)
                Pn_JogNow.Location = new Point(0, i); //바의 움직임을 갱신
            }
        }

        public void Timer_Op(object sender, EventArgs e) //타이머 Tick마다 실행
        {
            Warehouse WH = main.Ware1; //┐
            Order ORD = main.Ord1;     //┴호출용 선언

            if (bStart == true) //초기상태에서 가동모드(발송, 적재, 재적재)를 결정
            {
                if (ORD.Is_Order()[0] != 0 && WH.Ware_Location(ORD.Is_Order()[0])[0] != 10) //주문이 있고 그게 창고에 있다면
                {
                    iMode = 1; //배송모드
                    iLocation[0] = ORD.Is_Order()[0]; //주문여부 or 물품종류를 주문에 물어봐서 기입
                    iLocation[1] = WH.Ware_Location(iLocation[0])[0]; //┐
                    iLocation[2] = WH.Ware_Location(iLocation[0])[1]; //┴─해당 물품 위치를 창고에 물어봐서 기입
                    iLocation[3] = ORD.Is_Order()[1]; //배송지를 주문에 물어봐서 기입
                }
                else // 주문이 없거나 주문물품이 창고에 없다면
                {
                    iMode = 2; //기본적재모드
                    iLocation[1] = WH.Ware_Location(0)[0]; //┐
                    iLocation[2] = WH.Ware_Location(0)[1]; //┴─빈자리를 창고에 물어봐서 기입
                }
                
                iLocUp = (short)(((2 - iLocation[2]) * 2) + 1); //Y좌표가 0,1,2일때 위치결정데이터 5,3,1로 변환
                iLocDown = (short)(((2 - iLocation[2]) + 1) * 2); //Y좌표가 0,1,2일때 위치결정데이터 6,4,2으로 변환
                iLoad = 0;   //┐
                iDeliv = 0;  //├─각 공정순서 초기화
                iReload = 0; //┘
                Is_Metal = 2; //물품은 공정초기에 비금속으로 간주, 이후 자기센서가 한번이라도 들어오면 금속(1)로 전환
                iMetal = 0; //물품은 초기에 금속판별되지 않은상태
                bStart = false; //초기상태 False. 공정시작
            }

            else if (iMode == 1) //배송모드
            {
                switch (iDeliv)
                {
                    case 0: //1위치 서보이동 if 이동완료(X6C)까지
                        if (processStarted == false)
                        {
                            processStartTime = DateTime.Now;
                            processStarted = true;
                            is_Done = false;
                            Done(iMode, iMetal, processStartTime, processEndTime, is_Done);    //Done함수 필요한 인수 저장
                        }
                        Servo_Move(iLocUp); //1,3,5위치
                        ORD.Deliv_Check(); //주문폼에 "검품중" 신호
                        if (iLocation[1] == 0) //창고이동
                            Ware_Fwd();
                        else
                            Ware_Bwd();
                        if (!Get_Device("X6C"))
                            iDeliv++;
                        break;
                    case 1: //흡착전진 if 흡착전(X1A)까지
                        Comp_Fwd();
                        if (Get_Device("X1A"))
                        {
                            Stop_Fwd(); //물품이 걸리지 않게 내려놓는다
                            iDeliv++;
                        }
                        break;
                    case 2: //2위치 서보이동 if 이동완료(X6C)까지
                        Servo_Move(iLocDown); //2,4,6위치
                        if (!Get_Device("X6C"))
                        {
                            tBefore = DateTime.Now;
                            iDeliv++;
                        }
                        break;
                    case 3: //흡착온 - 1위치 재이동 if 이동완료(X6C)까지
                        CompPad_On();
                        tAfter = DateTime.Now;
                        if (tAfter > tBefore.AddMilliseconds(500)) //0.5초 지연
                        {
                            Servo_Move(iLocUp); //1,3,5위치
                            if (!Get_Device("X6C"))
                                iDeliv++;
                        }
                        break;
                    case 4: //흡착후진 if흡착후(X1B)까지
                        Comp_Bwd();
                        if (Get_Device("X1B"))
                        {
                            WH.Take_From(iLocation[1], iLocation[2]); //창고에서 빼냈다는 신호를 줌
                            iDeliv++;
                        }
                        break;
                    case 5: //컨위치까지 이동 if 이동완료(X6C)까지
                        Servo_Move(7);
                        if (!Get_Device("X6C"))
                        {
                            tBefore = DateTime.Now;
                            iDeliv++;
                        }
                        break;
                    case 6: //흡착오프 - 컨위치상승(3),컨역회전기동 if 용량형센서(X0A)까지
                        CompPad_Off();
                        tAfter = DateTime.Now;
                        if (tAfter > tBefore.AddMilliseconds(500)) //0.5초 지연
                        {
                            Servo_Move(3);
                            CCon_On();
                            Stop_Bwd();
                            if (Get_Device("X0A"))
                                iDeliv++;
                        }
                        break;
                    case 7: // if 용량형센서(X0A)가 꺼졌을때 금속판별
                        if (!Get_Device("X0A"))
                        {
                            if (iLocation[0] == 1 && Get_Device("X09") || (iLocation[0] == 2 && !Get_Device("X09")))
                            //주문한게 금속이고 자기센서(X09)가 켜졌을때 or 주문한게 비금속이고 자기센서가 꺼졌을때 = 주문과 맞을때
                            {
                                ORD.Deliv_Start(); //주문폼에 "배송중" 신호
                                tBefore = DateTime.Now;
                                iMetal = iLocation[0]; //금속 위치를 업데이트
                                if (iLocation[3] == 1) //배송지가 1이면
                                    iDeliv = 8;        //8번공정으로
                                else            //배송지가 0이면
                                    iDeliv = 9; //9번공정으로
                            }
                            else //주문과 다를경우
                            {
                                ORD.Reload_Start(); //주문폼에 "재적재중" 신호
                                iMode = 3; //재적재모드로
                            }
                        }
                        break;
                    case 8: //배송지1 : 2초후 배출전진 if 배출전(X16)까지
                        Con_On();
                        tAfter = DateTime.Now;
                        if (tAfter > tBefore.AddMilliseconds(2000)) //2초지연
                        {
                            Out_Fwd();
                            if (Get_Device("X16"))
                            {
                                Out_Bwd();
                                Con_Off();
                                iLocation[4]--; //배송수량 -1
                                ORD.Deliv_Complete();
                                bStart = true; //공정종료. 초기상태로
                                is_Done = true;
                                processEndTime = DateTime.Now;  //종료시점 일시기록
                                Done(iMode, iMetal, processStartTime, processEndTime, is_Done);    //Done함수 필요한 인수 저장
                                processStarted = false; //시작지점 종료지점 저장소 초기화
                            }
                        }
                        break;
                    case 9: //배송지2 : 8초후 정지
                        Con_On();
                        tAfter = DateTime.Now;
                        if (tAfter > tBefore.AddMilliseconds(8000)) //8초지연
                        {
                            Con_Off();
                            iLocation[4]--; //주문수량 -1
                            ORD.Deliv_Complete();
                            bStart = true; //공정종료. 초기상태로
                            is_Done = true;
                            processEndTime = DateTime.Now;  //종료시점 일시기록
                            Done(iMode, iMetal, processStartTime, processEndTime, is_Done);    //Done함수 필요한 인수 저장
                            processStarted = false; //시작지점 종료지점 저장소 초기화
                        }
                        break;
                }
            }

            else if (iMode == 2) //적재모드
            {
                switch (iLoad)
                {
                    case 0: //물품판별
                        if (processStarted == false)
                        {
                            processStarted = true;
                            is_Done = false;
                                                    }
                        if (Get_Device("X08")) //물품이 있다면
                        { iLoad++;
                            processStartTime = DateTime.Now;
                            Done(iMode, iMetal, processStartTime, processEndTime, is_Done);    //Done함수 필요한 인수 저장
                        }
                        else if (!Get_Device("X08") || WH.Ware_Location(0)[0] == 10) //물품이 없거나 창고가 꽉찼다면
                            bStart = true; //초기상태로

                        break;
                    case 1: //공급전진 if 공급전(X10)까지
                        Sup_Fwd();
                        if (Get_Device("X10"))
                            iLoad++;
                        break;
                    case 2: //공급후진 if 공급후(X11)까지
                        Sup_Bwd();
                        if (Get_Device("X11"))
                            iLoad++;
                        break;
                    case 3: //송출전진 if 송출전(X14)까지
                        Trans_Fwd();
                        if (Get_Device("X14"))
                            iLoad++;
                        break;
                    case 4: //송출후진, 컨구동 if 용량형(X0A)켜질때 까지 금속판별
                        Trans_Bwd(); Con_On();
                        if (Get_Device("X09")) //고주파센서(X09)가 한번이라도 감지되면 금속
                            Is_Metal = 1;
                        if (Get_Device("X0A"))
                            iLoad++;
                        break;
                    case 5: //if 용량형(X0A)이 꺼질때 금속판별, 스톱다운 if 스토퍼(X0B)까지
                        if (Get_Device("X09")) //고주파센서(X09)가 한번이라도 감지되면 금속
                            Is_Metal = 1;
                        if (!Get_Device("X0A"))
                        {
                            Stop_Fwd();
                            iMetal = Is_Metal;
                            if (Get_Device("X0B"))
                                iLoad++;
                        }
                        break;
                    case 6: //if 스토퍼(X0B) - 컨위치 서보이동 if 이동완료(X6C)까지
                        Servo_Move(7);
                        if (!Get_Device("X6C"))
                        {
                            tBefore = DateTime.Now;
                            iLoad++;
                        }
                        break;
                    case 7: //컨정지, 흡착온 - 1위치 서보이동 if 이동완료(X6C)까지                  
                        Con_Off();
                        CompPad_On();
                        tAfter = DateTime.Now;
                        if (tAfter > tBefore.AddMilliseconds(500)) //0.5초지연
                        {
                            Servo_Move(iLocUp); //1,3,5
                            if (iLocation[1] == 0) //창고이동
                                Ware_Fwd();
                            else
                                Ware_Bwd();
                            if (!Get_Device("X6C"))
                                iLoad++;
                        }
                        break;
                    case 8: //흡착전진 if 흡착전(X1A)까지
                        Comp_Fwd();
                        if (Get_Device("X1A"))
                            iLoad++;
                        break;
                    case 9: //스톱업, 2위치 서보이동 if 이동완료(X6C)까지
                        Stop_Bwd();
                        Servo_Move(iLocDown); //2,4,6
                        if (!Get_Device("X6C"))
                        {
                            tBefore = DateTime.Now;
                            iLoad++;
                        }
                        break;
                    case 10: //흡착오프 - 1위치 재이동 if 이동완료(X6C)까지
                        CompPad_Off();
                        tAfter = DateTime.Now;
                        if (tAfter > tBefore.AddMilliseconds(500)) //0.5초지연
                        {
                            Servo_Move(iLocUp); //1,3,5
                            if (!Get_Device("X6C"))
                                iLoad++;
                        }
                        break;
                    case 11: //흡착후진 - if흡착후(X1B)까지
                        Comp_Bwd();
                        if (Get_Device("X1B"))
                        {
                            if (Is_Metal == 1) WH.Is_Load(1, iLocation[1], iLocation[2]); //금속 적재
                            else if (Is_Metal == 2) WH.Is_Load(2, iLocation[1], iLocation[2]); //비금속적재
                            bStart = true; //공정종료. 초기상태로
                            is_Done = true;
                            processEndTime = DateTime.Now;  //종료시점 일시기록
                            Done(iMode, iMetal, processStartTime, processEndTime, is_Done);    //Done함수 필요한 인수 저장
                            processStarted = false; //시작지점 종료지점 저장소 초기화
                        }
                        break;
                }
            }

            else if (iMode == 3) //재적재모드
            {
                switch (iReload)
                {
                    case 0: //컨구동, 스톱다운 if 스토퍼(X0B)까지
                        if(processStarted == false)
                        {
                            processStartTime = DateTime.Now;
                            processStarted = true;
                            is_Done = false;
                            Done(iMode, iMetal, processStartTime, processEndTime, is_Done);    //Done함수 필요한 인수 저장
                        }
                        Con_On();
                        Stop_Fwd();
                        if (Get_Device("X0B"))
                            iReload++;
                        break;
                    case 1: //컨위치 서보이동 if 이동완료(X6C)까지
                        Servo_Move(7);
                        if (!Get_Device("X6C"))
                        {
                            tBefore = DateTime.Now; //다음단계 500ms 지연을 위함
                            iReload++;
                        }
                        break;
                    case 2: //스톱업, 컨정지, 흡착온 - 1위치 서보이동 if 이동완료(X6C)까지                  
                        Stop_Bwd();
                        Con_Off();
                        CompPad_On();
                        tAfter = DateTime.Now;
                        if (tAfter > tBefore.AddMilliseconds(500)) //0.5초지연
                        {
                            Servo_Move(iLocUp); //1,3,5
                            if (iLocation[1] == 0) //창고이동
                                Ware_Fwd();
                            else
                                Ware_Bwd();
                            if (!Get_Device("X6C"))
                                iReload++;
                        }
                        break;
                    case 3: //흡착전진 if 흡착전(X1A)까지
                        Comp_Fwd();
                        if (Get_Device("X1A"))
                            iReload++;
                        break;
                    case 4: //2위치 서보이동 if 이동완료(X6C)까지
                        Servo_Move(iLocDown); //2,4,6
                        if (!Get_Device("X6C"))
                        {
                            tBefore = DateTime.Now;
                            iReload++;
                        }
                        break;
                    case 5: //흡착오프 - 1위치 재이동 if 이동완료(X6C)까지
                        CompPad_Off();
                        tAfter = DateTime.Now;
                        if (tAfter > tBefore.AddMilliseconds(500)) //0.5초지연
                        {
                            Servo_Move(iLocUp); //1,3,5
                            if (!Get_Device("X6C"))
                                iReload++;
                        }
                        break;
                    case 6: //흡착후진 - if흡착후(X1B)까지
                        Comp_Bwd();
                        if (Get_Device("X1B"))
                        {
                            if (iLocation[0] == 1) WH.Is_Load(2, iLocation[1], iLocation[2]); //금속인줄 알았다면 비금속 적재
                            else if (iLocation[0] == 2) WH.Is_Load(1, iLocation[1], iLocation[2]); //비금속인줄 알았다면 금속 적재
                            ORD.Reload_Complete();
                            bStart = true; //공정종료. 초기상태로
                            is_Done = true;
                            processEndTime = DateTime.Now;  //종료시점 일시기록
                            Done(iMode, iMetal, processStartTime, processEndTime, is_Done);    //Done함수 필요한 인수 저장
                            processStarted = false; //진행 상황 표현
                        }
                        break;
                }
            }
        }
        public class DoneOperation  //클래스 선언
        {
            public string Process_Type { get; set; }     //공정종류
            public string DoneItem_Type { get; set; }    //취급물품
            public DateTime Start_Time { get; set; }     //시작시간
            public DateTime End_Time { get; set; }       //종료시간
            public bool IsDone { get; set; }             //성공여부
        }

        private Operator_Log operatorLogForm;

        private void bt_Result_Click(object sender, EventArgs e)
        {
            operatorLogForm.Visible = true;
        }



        public string[] Done_Operation = new string[5];

        public void Done(int ProcessType, int DoneItemType, DateTime StartTime, DateTime EndTime, Boolean IsDone)
        {
            Done_Operation[0] = ProcessType.ToString();
            Done_Operation[1] = DoneItemType.ToString();
            Done_Operation[2] = StartTime.ToString();
            Done_Operation[3] = EndTime.ToString();
            Done_Operation[4] = IsDone.ToString();

            if (operatorLogForm != null)
            {
                operatorLogForm.Get_Log(Done_Operation);
            }
        }
    }
}

