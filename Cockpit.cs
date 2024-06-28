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
using System.IO;
using System.IO.Ports;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Diagnostics;

//test

namespace Project_v01
{
    public partial class Cockpit : Form
    {
        ActUtlType PLC01 = new ActUtlType();
        System.Windows.Forms.Timer readTimer = new System.Windows.Forms.Timer();
        public Cockpit()
        {
            InitializeComponent();
           
        }

        private void bt_PLC_start_Click(object sender, EventArgs e)
        {

            

            int con_status = 0;
            PLC01.ActLogicalStationNumber = 1;
            con_status = PLC01.Open();
            if (con_status == 0)
            {
                readTimer = new Timer();
                readTimer.Interval = 1; 
                readTimer.Tick += new EventHandler(ReadTimer_Tick);
                readTimer.Start();
               
                bt_Lamp_start.BackColor = Color.Red;
                bt_Lamp_stop.BackColor = Color.LightGray;

            }
            else
            {
                tb_Error_log.ForeColor = Color.Red;
                tb_Error_log.Text = tb_Error_log.Text + "0x" + Convert.ToString(con_status, 16) + " " + $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}" + "\r\n";
                bt_Lamp_start.BackColor = Color.LightGray;
                bt_Lamp_stop.BackColor = Color.Red;

            }
        }

        void ReadTimer_Tick(object sender, EventArgs e)
        {

            int X0, X10, X60,Y20, Y60, X68, X6C, SM0,SD0;

            PLC01.ReadDeviceBlock("X0", 1, out X0);
            PLC01.ReadDeviceBlock("X10", 1, out X10);
            PLC01.ReadDeviceBlock("Y20", 1, out Y20);

            PLC01.GetDevice("SM0", out SM0);
            PLC01.GetDevice("SD0", out SD0);
           PLC01.GetDevice("Y60", out Y60);
           PLC01.GetDevice("X60", out X60);
           PLC01.GetDevice("X6C", out X6C);
           PLC01.GetDevice("X68", out X68);

            //서버 ready
            if (X60==1&& Y60==1)
            {
                bt_Serv_ON.BackColor = Color.Red;
                bt_Serv_ON.Enabled = false;
                bt_Serv_OFF.BackColor = Color.LightGray;
                bt_Serv_OFF.Enabled = false;

            }
           else
            {
                bt_Serv_OFF.BackColor = Color.Red;
                bt_Serv_OFF.Enabled = false;
                bt_Serv_ON.BackColor = Color.LightGray;
                bt_Serv_ON.Enabled = false;
            }

            
            //서보 현재위치 
            if (X6C == 1)
            {
                short[] temp = new short[2];
                PLC01.ReadBuffer(6, 800, 2, out temp[0]);
          
                int temp2 = (ushort)temp[0] | ((ushort)temp[1] << 16); //2워드를 int(32비트)로 합치기

                tb_Server_position.Text = (temp2/10000).ToString();
             
           //서보 현재속도
           
                short[] temp3 = new short[2];
                PLC01.ReadBuffer(6, 812, 2, out temp3[0]);
                int temp4=(ushort) temp3[0] | ((ushort)   temp3[1] << 16);//2워드를 int(32비트)로 합치기
                tb_Server_Speed0.Text = (temp4/100).ToString();
               
            }

            //서보에러출력////확인필요!!!
            if (X68 ==1)
            {
                bt_Server_Error.BackColor = Color.Red;
                bt_Server_Error.Enabled = false;    

                short[] err_code = new short[2];
                short[] old_err = new short[2];
                short[] new_err = new short[2];
               
                old_err[0] = new_err[0];

                PLC01.ReadBuffer(6, 806, 2, out err_code[0]);
                
                new_err[0] = err_code[0];
                //////////////////////////////////////////////////////////////////////
                Debug.WriteLine("new_err[0]" + " " + "old_err[0]");
                /////////////////////////////////////////////////////////////////////
                if (new_err[0] != old_err[0])
                {
                    tb_Error_log.ForeColor = Color.Red;
                    tb_Error_log.Text = tb_Error_log.Text + "에러" + Convert.ToString(err_code[0]) + " " + $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}" + "\r\n";
                    tb_Error_log.Text = tb_Error_log.Text + "경고" + Convert.ToString(err_code[1]) + " " + $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}" + "\r\n";
                }
               
            }
            else
            {
                bt_Server_Error.BackColor = Color.LightGray;
                bt_Server_Error.Enabled = false;
            }
           
            ///// 서버 in move
            if (X6C == 1)
            {
                bt_Server_move.BackColor = Color.Red;
                bt_Server_move.Enabled = false;

            }
            else
            {
                bt_Server_move.BackColor = Color.LightGray;
                bt_Server_move.Enabled = false;
            }
                 


            //PLC 상태점검 SM0...operation error code stored in SD0
            if (SM0 == 0)
            {
                plc_Status_ok.BackColor = Color.Red;
                plc_Status_nok.BackColor = Color.LightGray;
                plc_Status_ok.Enabled = false;
                           
            }
            else
            {
                tb_Error_log.ForeColor = Color.Red;
                tb_Error_log.Text = tb_Error_log.Text + Convert.ToString(SD0) + " " + $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}" + "\r\n";
                plc_Status_ok.BackColor = Color.LightGray;
                plc_Status_nok.BackColor = Color.Red;
                plc_Status_ok.Enabled = false;
            }

            //에어공급//////////////////////통합시 trigger 수정(현재 X0,X1)////////////////
            if ((X0&0x01) == 0x01)
            {
                bt_Airline_ON.BackColor = Color.Red;
                bt_Airline_ON.Enabled = false;
                bt_Airline_OFF.BackColor = Color.LightGray;
                bt_Airline_OFF.Enabled = false;
            }

            if ((X0&0x02) == 0x02)
            {
                bt_Airline_ON.BackColor = Color.LightGray;
                bt_Airline_ON.Enabled = false;
                bt_Airline_OFF.BackColor = Color.Red;
                bt_Airline_OFF.Enabled = false;
            }

            /*

            //물품판별-금속.....작업중

            DateTime S3_time;
            DateTime S4_time;
            if ((X0 & 0x200) == 0x200)
            {
                S3_time = DateTime.Now;
               
            }
          

            if ((X0 & 0x400) == 0x400)
            {
                S4_time = DateTime.Now;
               
            }
            
           // TimeSpan timeSpan = 
             
            //          double time = Math.Abs(timeSpan.TotalSeconds);

            /* 

                      if (time < 0.5)
                      {
                          bt_Lamp_Metal.BackColor = Color.Red;
                          bt_Lamp_Metal.Enabled = false;
                          bt_Lamp_NonMetal.BackColor = Color.LightGray;
                          bt_Lamp_NonMetal.Enabled = false;
                      }


                  }

              }
              /////////////비금속
              else if ((X0 & 0x400) == 0x400)

              {

                  bt_Lamp_Metal.BackColor = Color.LightGray;
                  bt_Lamp_Metal.Enabled = false;
                  bt_Lamp_NonMetal.BackColor = Color.Red;
                  bt_Lamp_NonMetal.Enabled = false;
              }*/

            //////////////////////////////////////////////////////////////////      


            //컨베이어 CW Lamp
            if ((Y20&0x100)==0x100)      
            {
                bt_Conv_CW.BackColor = Color.Red;
                bt_Conv_CW.Enabled = false;
            }
            else
            {
                bt_Conv_CW.BackColor = Color.LightGray;
                bt_Conv_CW.Enabled = false;
            }
           
            //컨베이어CCW Lamp
            if ((Y20 & 0x8000) == 0x8000)
            {
                bt_Conv_CCW.BackColor = Color.Red;
                bt_Conv_CCW.Enabled = false;
            }
            else
            {
                bt_Conv_CCW.BackColor = Color.LightGray;
                bt_Conv_CCW.Enabled = false;
            }
            
            
            ///공급전진
            if ((X10&0x01)==0x01)
            {
                bt_Sup_fwd.BackColor = Color.LightGreen;
                bt_Sup_fwd.Enabled = false;
            
            }
            else
            {
                bt_Sup_fwd.BackColor = Color.LightGray;
                bt_Sup_fwd.Enabled = false;
            }
           
            //공급후진
            if ((X10 & 0x02) == 0x02)
            {
                bt_Sup_bwd.BackColor = Color.LightGreen;
                bt_Sup_bwd.Enabled = false;
            }
            else
            {
                bt_Sup_bwd.BackColor = Color.LightGray;
                bt_Sup_bwd.Enabled = false;
            }
           
            //송출전진
            if ((X10 & 0x10) == 0x10)
            {
                bt_Send_fwd.BackColor = Color.LightGreen;
                bt_Send_fwd.Enabled = false;
            }
            else
            {
                bt_Send_fwd.BackColor = Color.LightGray;
                bt_Send_fwd.Enabled = false;
            }

            //송출후진
            if ((X10 & 0x20) == 0x20)
            {
                bt_Send_bwd.BackColor = Color.LightGreen;
                bt_Send_bwd.Enabled = false;
            }
            else
            {
                bt_Send_bwd.BackColor = Color.LightGray;
                bt_Send_bwd.Enabled = false;
            }
            
            //컨베이어 동작 Lamp
            if (((Y20 & 0x100) == 0x100) || (Y20 & 0x8000) == 0x8000)
            {
                bt_Conv.BackColor = Color.LightGreen;
                bt_Conv.Enabled = false;
            }
            else
            {
                bt_Conv.BackColor = Color.LightGray;
                bt_Conv.Enabled = false;
            }
            
            //배출전진
            if ((X10 & 0x40) == 0x40)
            {
                bt_Push_fwd.BackColor = Color.LightGreen;
                bt_Push_fwd.Enabled = false;
            }
            else
            {
                bt_Push_fwd.BackColor = Color.LightGray;
                bt_Push_fwd.Enabled = false;
            }

            //배출후진
            if ((X10 & 0x80) == 0x80)
            {
                bt_Push_bwd.BackColor = Color.LightGreen;
                bt_Push_bwd.Enabled = false;
            }
            else
            {
                bt_Push_bwd.BackColor = Color.LightGray;
                bt_Push_bwd.Enabled = false;
            }

            //스톱업
            if ((X10 & 0x100) == 0x100)
            {
                bt_Stop_up.BackColor = Color.LightGreen;
                bt_Stop_up.Enabled = false;
            }
            else
            {
                bt_Stop_up.BackColor = Color.LightGray;
                bt_Stop_up.Enabled = false;
            }
           
            //스톱다운
            if ((X10 & 0x200) == 0x200)
            {
                bt_Stop_down.BackColor = Color.LightGreen;
                bt_Stop_down.Enabled = false;
            }
            else
            {
                bt_Stop_down.BackColor = Color.LightGray;
                bt_Stop_down.Enabled = false;
            }

            //흡착전진
            if ((X10 & 0x400) == 0x400)
            {
                bt_Suck_fwd.BackColor = Color.LightGreen;
                bt_Suck_fwd.Enabled = false;
            }
            else
            {
                bt_Suck_fwd.BackColor = Color.LightGray;
                bt_Suck_fwd.Enabled = false;
            }

            //흡착후진
            if ((X10 & 0x800) == 0x800)
            {
                bt_Suck_bwd.BackColor = Color.LightGreen;
                bt_Suck_bwd.Enabled = false;
            }
            else
            {
                bt_Suck_bwd.BackColor = Color.LightGray;
                bt_Suck_bwd.Enabled = false;
            }

            //흡착공정
            if ((Y20 & 0x4000) == 0x4000)
            {
                bt_Sucking_Lamp.BackColor = Color.LightGreen;
                bt_Sucking_Lamp.Enabled = false;
            }
            else
            {
                bt_Sucking_Lamp.BackColor = Color.LightGray;
                bt_Sucking_Lamp.Enabled = false;

            }

            //창고전진
            if ((X10 & 0x1000) == 0x1000)
            {
                bt_Warehouse_fwd.BackColor = Color.LightGreen;
                bt_Warehouse_fwd.Enabled = false;
            }
            else
            {
                bt_Warehouse_fwd.BackColor = Color.LightGray;
                bt_Warehouse_fwd.Enabled = false;
            }

            //창고후진
            if ((X10 & 0x2000) == 0x2000)
            {
                bt_Warehouse_bwd.BackColor = Color.LightGreen;
                bt_Warehouse_bwd.Enabled = false;
            }
            else
            {
                bt_Warehouse_bwd.BackColor = Color.LightGray;
                bt_Warehouse_bwd.Enabled = false;
            }
        }
     
           
        private void bt_PLC_stop_Click(object sender, EventArgs e)
        {
       
             PLC01.Close();
             bt_Lamp_stop.BackColor= Color.Red;
             bt_Lamp_start.BackColor= Color.LightGray ;
             readTimer.Stop();

        }

        
        ////Error Log 처리  
        private void tb_Clear_log_Click(object sender, EventArgs e)
        {
            
           var result= MessageBox.Show("확인를 누르시면 로그정보가 삭제됩니다.","로그삭제" ,MessageBoxButtons.OKCancel);
           if(result==DialogResult.OK)
            tb_Error_log.Text = "";
        }

        private void bt_Save_log_Click(object sender, EventArgs e)
        {
           StreamWriter sw =new StreamWriter("C:\\BackUp\\SmartFactory\\프로젝트\\C#\\Project_v01\\PLClog.txt", true,Encoding.ASCII);
          sw.WriteLine(tb_Error_log.Text);
            if (tb_Error_log.Text == "")
                MessageBox.Show("로그 정보가 없습니다");
            else
                MessageBox.Show("로그정보가 저장되었습니다");
           sw.Close();
          
        }
        
        ///공정시작,정지
        private void bt_Process_start_Click(object sender, EventArgs e)
        {
           
            PLC01.SetDevice("X0", 1);
            PLC01.SetDevice("X1", 0);
            bt_Airline_ON.BackColor= Color.Red;
            bt_Airline_OFF.BackColor= Color.LightGray ;
        }

        private void bt_Process_stop_Click(object sender, EventArgs e)
        {
            PLC01.SetDevice("X0", 0);
            PLC01.SetDevice("X1", 1);
       
            bt_Airline_OFF.BackColor = Color.Red;
            bt_Airline_ON.BackColor = Color.LightGray;
        }

        //서버에러리셋 

        private void bt_Error_Reset_Click(object sender, EventArgs e)
        {
          
            PLC01.WriteBuffer(6, 1502, 1,1);
        }

        //서버원점복귀
        private void bt_OPR_Click(object sender, EventArgs e)
        {
            PLC01.WriteBuffer(6, 1500, 1, 9001);
            PLC01.SetDevice("Y70", 1);
            PLC01.SetDevice("Y70", 0);
        }

       
    }
}
