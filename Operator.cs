using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            Timer_Operation.Tick += new EventHandler(Timer_Op); //오퍼레이팅 타이머
            Timer_Jog.Interval = 100;
            Timer_Jog.Tick += new EventHandler(Timer_Jo); //JOG 타이머
        }

        //------------------------------------------버튼-----------------------------------------
        public int PLC_Open; //PLC 연결상태

        private void Bt_OpenPLC_Click(object sender, EventArgs e) //"PLC 연결"버튼
        {
            PLC01.ActLogicalStationNumber = 1; //개인 MXComponent에 따라 수정할것
            PLC_Open = PLC01.Open(); //연결시도
            if (PLC_Open == 0) //연결에 성공하면
            {
                Lb_Connect.Text = "연결됨";         //┐
                Lb_Connect.ForeColor = Color.Green; //┴─초록글씨로 "연결됨"
                Bt_ClosePLC.Enabled = true;  //┐
                Bt_OpenServo.Enabled = true; //┼─버튼의 중복동작을 방지하기 위함
                Bt_OpenPLC.Enabled = false;  //┘
                PLC01.SetDevice("Y60", 1); //서보에 PLC레디(Y60)을 미리 보낸다
            }
            else //연결에 실패하면
            {
                Lb_Connect.Text = "연결실패 : 0x" + PLC_Open; //┐
                Lb_Connect.ForeColor = Color.Red;             //┴─빨강글씨로 "연결실패"+오류번호
            }
        }

        private void Bt_ClosePLC_Click(object sender, EventArgs e) //"PLC 연결 해제"버튼
        {
            PLC01.Close(); //PLC연결종료
            Lb_Connect.Text = "연결종료";     //┐
            Lb_Connect.ForeColor = Color.Red; //┴─빨강글씨로 "연결종료"
            Bt_OpenPLC.Enabled = true;    //┐
            Bt_OpenServo.Enabled = false; //┼─버튼의 중복동작을 방지하기 위함
            Bt_Start.Enabled = false;     //┘
        }

        private void Bt_OpenServo_Click(object sender, EventArgs e) //"서보 준비" 버튼
        {
            if (Get_Device("X60") && Get_Device("Y60")) //PLC레디(Y60),서보레디(X60)이 전부 true면
            {
                Lb_ServoConnect.Text = "서보 준비완료";  //┐
                Lb_ServoConnect.ForeColor = Color.Green; //┴─초록글씨로 "서보 준비완료"
                Bt_Start.Enabled = true;     //┐
                Bt_OpenServo.Enabled = false;//┴─버튼의 중복동작을 방지하기 위함
                Servo_Move(9001); //원점복귀
            }
            else
            {
                Lb_ServoConnect.Text = "서보 준비실패"; //┐
                Lb_ServoConnect.ForeColor = Color.Red;  //┴─빨간글씨로 "서보 준비실패"
            }

            int JogSpeed = 200000; //JOG 속도
            ushort[] uJog_Speed = new ushort[2];      //┐
            uJog_Speed[0] = (ushort)JogSpeed;         //┼─JOG속도를 ushort의 배열로 바꾸기 위함
            uJog_Speed[1] = (ushort)(JogSpeed >> 16); //┘

            PLC01.WriteBuffer(6, 1518, 1, (short)uJog_Speed[0]); //┐
            PLC01.WriteBuffer(6, 1519, 1, (short)uJog_Speed[1]); //┴─U6\G1518번에 JOG속도
        }

        private void Bt_Start_Click(object sender, EventArgs e) //"시작" 버튼
        {
            
            Bt_Stop.Enabled = true;   //┐
            Bt_Start.Enabled = false; //┴─버튼의 중복동작을 방지하기 위함

            Timer_Operation.Start(); //타이머 시작
        }

       private void Bt_Stop_Click(object sender, EventArgs e) //"정지 및 초기화" 버튼
       {
           Timer_Operation.Stop(); //타이머 정지
           PLC01.SetDevice("Y70", 0); //서보 기동신호 초기화
           Sup_Bwd();     //┐
           Trans_Bwd();   //┤
           Con_Off();     //┤
           Stop_Bwd();    //┼─공정 초기화
           Out_Bwd();     //┤
           Comp_Bwd();    //┤
           CompPad_Off(); //┘
           Bt_Start.Enabled = true;     //┐
           bStart = true;               //┼─버튼의 중복동작을 방지하기 위함
           Bt_OpenServo.Enabled = true; //┘
        }

       private void Bt_JogUp_MouseDown(object sender, MouseEventArgs e) //"JOG상" 버튼을 눌렀을때
       {
            Timer_Jog.Start();
            PLC01.SetDevice("Y69", 1); //역기동(Y69) ON
        }

       private void Bt_JogUp_MouseUp(object sender, MouseEventArgs e) //"JOG상" 버튼을 뗏을때
        {
            PLC01.SetDevice("Y69", 0); //역기동(Y69) OFF
            Timer_Jog.Stop();
        }

       private void Bt_JogDown_MouseDown(object sender, MouseEventArgs e) //"JOG하" 버튼을 눌렀을때
        {
            Timer_Jog.Start();
            PLC01.SetDevice("Y68", 1); //정기동(Y68) ON
        }

       private void Bt_JogDown_MouseUp(object sender, MouseEventArgs e) //"JOG하" 버튼을 뗏을때
        {
           PLC01.SetDevice("Y68", 0); //정기동(Y68) OFF
            Timer_Jog.Stop();
        }

       //-------------------------------------사용자 함수-----------------------------------------
       private bool Get_Device(string s) //s = PLC01의 parameter를
       {
           PLC01.GetDevice(s, out i); //PLC01에서 불러와서
           if (i == 0) return false; //1이면 false
           else        return true;  //0이면 true를 내보내는 함수
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

        int iLoad = 0; //적재모드일때 기동순서
        int iDeliv = 0; //배송모드일때 기동순서
        int iReload = 0; //재적재모드일때 기동순서
        int Is_Metal; //금속과 관련된 공정에서 사용. True=금속, False=비금속
        public bool bStart = true; //초기상태를 나타냄. 공정중 False였다가 공정 1사이클이 완료되면 True
        int iMode = 2; //공정모드. 1=배송 2=적재 3=재적재
        int i;
        DateTime tBefore, tAfter; //공정중에 시간지연이 필요할때 사용
        short iLocUp, iLocDown; //서보의 위치결정데이터 1,3,5 and 2,4,6
        int[] iLocation = { 0, 0, 0, 0, 0 }; //공정에서 사용하는 인수들 집합
        //[0](1:금속주문,2:비금속주문) [1]:X좌표 [2]:Y좌표 [3]:배송지 [4]:남은수량

        public int[] Is_Order() //주문에 물어보는 값을 답하는 함수. [0]:주문여부(0:주문X 1:금속 2:비금속) [1]주소, [2]수량
        {
            int[] temp = new int[] { 0, 2, 1 };
            return temp; //리턴하면 주문에서 빼야한다
        }

        private TextBox[] ServoInput; //서보 티칭에 사용

        private void Bt_WriteServo_Click(object sender, EventArgs e) //서보에 위치결정데이터 쓰기
        {
            int Servo_Speed = int.Parse(Tb_ServoSpeed.Text)*100; //서보속도
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

        //public Warehouse WH = new Warehouse();

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
            int temp2 = (ushort)temp[0] | ((int)temp[1] << 16); //2워드를 int(32비트)로 합치기
            Tb_ServoLoc.Text = temp2.ToString();
        }

        void Timer_Op(object sender, EventArgs e) //타이머 Tick마다 실행
        {
            Warehouse WH = main.Ware1;

            if (bStart == true) //초기상태에서 가동모드(발송, 적재, 재적재)를 결정
            {
                if (iLocation[4] != 0 && WH.Ware_Location(iLocation[0])[0] != 10) //남은 주문수량이 있고 그 물품이 창고에 있다면
                {
                    iMode = 1; //배송모드 - 배송할 물품이나 수량은 그대로
                    iLocation[1] = WH.Ware_Location(iLocation[0])[0]; //┐
                    iLocation[2] = WH.Ware_Location(iLocation[0])[1]; //┴─해당 물품 위치를 창고에 물어봐서 기입
                }
                else if (Is_Order()[0] != 0 && WH.Ware_Location(iLocation[0])[0] != 10) //주문이 있고 그 물품이 창고에 있다면
                {
                    iMode = 1; //배송모드
                    iLocation[0] = Is_Order()[0]; //주문여부 or 물품종류를 주문에 물어봐서 기입
                    iLocation[1] = WH.Ware_Location(iLocation[0])[0]; //┐
                    iLocation[2] = WH.Ware_Location(iLocation[0])[1]; //┴─해당 물품 위치를 창고에 물어봐서 기입
                    iLocation[3] = Is_Order()[1]; //배송지를 주문에 물어봐서 기입
                    iLocation[4] = Is_Order()[2]; //물품수량을 주문에 물어봐서 기입
                }
                else if (Is_Order()[0] == 0) //위의 주문이 용의치 않으면
                {
                    iMode = 2; //적재모드
                    iLocation[1] = WH.Ware_Location(0)[0]; //┐
                    iLocation[2] = WH.Ware_Location(0)[1]; //┴─빈자리를 창고에 물어봐서 기입
                }
                iLocUp = (short)(((2 - iLocation[2]) * 2) + 1); //Y좌표가 0,1,2일때 위치결정데이터 5,3,1로 변환
                iLocDown = (short)(((2 - iLocation[2]) + 1) * 2); //Y좌표가 0,1,2일때 위치결정데이터 6,4,2으로 변환
                iLoad = 0;   //┐
                iDeliv = 0;  //├─각 공정순서 초기화
                iReload = 0; //┘
                Is_Metal = 2; //물품은 공정초기에 비금속으로 간주, 이후 자기센서가 한번이라도 들어오면 금속(1)로 전환
                bStart = false; //초기상태 False. 공정시작
            }

            else if (iMode == 1) //배송모드
            {
                switch (iDeliv)
                {
                    case 0: //1위치 서보이동 if 이동완료(X6C)까지
                        Servo_Move(iLocUp); //1,3,5위치
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
                            iDeliv++;
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
                            WH.Take_From(iLocation[1], iLocation[2]);
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
                            if (Get_Device("X0A"))
                                iDeliv++;
                        }
                        break;
                    case 7: // if 용량형센서(X0A)가 꺼졌을때 금속판별
                        if (!Get_Device("X0A"))
                        {
                            if (iLocation[0] == 1 && Get_Device("X09") || (iLocation[0] == 2 && !Get_Device("X09")))
                                //주문한게 금속이고 자기센서(X09)가 켜졌을때 or 주문한게 비금속이고 자기센서가 꺼졌을때
                            {
                                tBefore = DateTime.Now;
                                if (iLocation[3] == 1) //배송지가 1이면
                                    iDeliv = 8;        //8번공정으로
                                else            //배송지가 0이면
                                    iDeliv = 9; //9번공정으로
                            }
                            else           //주문과 다를경우
                                iMode = 3; //재적재모드로
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
                                bStart = true; //공정종료. 초기상태로
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
                            bStart = true; //공정종료. 초기상태로
                        }
                        break;
                }
            }

            else if (iMode == 2) //적재모드
            {
                switch (iLoad)
                {
                    case 0: //공급전진 if 공급전(X10)까지
                        if (!Get_Device("X08")) //물품이 없다면
                            bStart = true; //초기상태로
                        else if (Get_Device("X08"))
                            Sup_Fwd();
                        if (Get_Device("X10"))
                            iLoad++;
                        break;
                    case 1: //공급후진 if 공급후(X11)까지
                        Sup_Bwd();
                        if (Get_Device("X11"))
                            iLoad++;
                        break;
                    case 2: //송출전진 if 송출전(X14)까지
                        Trans_Fwd();
                        if (Get_Device("X14"))
                            iLoad++;
                        break;
                    case 3: //송출후진, 컨구동 if 용량형(X0A)켜질때 까지 금속판별
                        Trans_Bwd(); Con_On();
                        if (Get_Device("X09")) //고주파센서(X09)가 한번이라도 감지되면 금속
                            Is_Metal = 1;
                        if (Get_Device("X0A"))
                            iLoad++;
                        break;
                    case 4: //if 용량형(X0A)이 꺼질때 금속판별, 스톱다운 if 스토퍼(X0B)까지
                        if (Get_Device("X09")) //고주파센서(X09)가 한번이라도 감지되면 금속
                            Is_Metal = 1;
                        if (!Get_Device("X0A"))
                        {
                            Stop_Fwd();
                            if (Get_Device("X0B"))
                                iLoad++;
                        }
                        break;
                    case 5: //if 스토퍼(X0B) - 컨위치 서보이동 if 이동완료(X6C)까지
                        Servo_Move(7);
                        if (!Get_Device("X6C"))
                        {
                            tBefore = DateTime.Now;
                            iLoad++;
                        }
                        break;
                    case 6: //컨정지, 흡착온 - 1위치 서보이동 if 이동완료(X6C)까지                  
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
                    case 7: //흡착전진 if 흡착전(X1A)까지
                        Comp_Fwd();
                        if (Get_Device("X1A"))
                            iLoad++;
                        break;
                    case 8: //스톱업, 2위치 서보이동 if 이동완료(X6C)까지
                        Stop_Bwd();
                        Servo_Move(iLocDown); //2,4,6
                        if (!Get_Device("X6C"))
                        {
                            tBefore = DateTime.Now;
                            iLoad++;
                        }
                        break;
                    case 9: //흡착오프 - 1위치 재이동 if 이동완료(X6C)까지
                        CompPad_Off();
                        tAfter = DateTime.Now;
                        if (tAfter > tBefore.AddMilliseconds(500)) //0.5초지연
                        {
                            Servo_Move(iLocUp); //1,3,5
                            if (!Get_Device("X6C"))
                                iLoad++;
                        }
                        break;
                    case 10: //흡착후진 - if흡착후(X1B)까지
                        Comp_Bwd();
                        if (Get_Device("X1B"))
                        {
                            if (Is_Metal == 1) WH.Is_Load(1, iLocation[1], iLocation[2]); //금속 적재
                            else if (Is_Metal == 2) WH.Is_Load(2, iLocation[1], iLocation[2]); //비금속적재
                            bStart = true; //공정종료. 초기상태로
                        }
                        break;
                }
            }

            else if (iMode == 3) //재적재모드
            {
                switch(iReload)
                {
                    case 0: //컨구동, 스톱다운 if 스토퍼(X0B)까지
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
                            if (Is_Metal == 1) WH.Is_Load(1, iLocation[1], iLocation[2]); //금속 적재
                            else if (Is_Metal == 2) WH.Is_Load(2, iLocation[1], iLocation[2]); //비금속적재
                            bStart = true; //공정종료. 초기상태로
                        }
                        break;
                }
            }
        }
    }

   // public static WareHouseEventHandler WareHouseEvent;
}
