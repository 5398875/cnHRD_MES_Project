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


namespace Project_v01
{
    public partial class Cockpit : Form
    {
        ActUtlType PLC01 = new ActUtlType();
        public Cockpit()
        {
            InitializeComponent();
           
        }

      

        private void bt_PLC_start_Click(object sender, EventArgs e)
        {
            int con_status = 0;
            PLC01.ActLogicalStationNumber = 1;
            con_status=PLC01.Open();
            if (con_status != 0)
            {
                tb_Error_log.ForeColor = Color.Red;
                tb_Error_log.Text =tb_Error_log.Text+ "0x" + Convert.ToString(con_status, 16)+" "+ $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}"+"\r\n";
            }
            tmr_Update.Start();
        }

        private void bt_PLC_stop_Click(object sender, EventArgs e)
        {

            int con_status = PLC01.SetDevice("M0", 0);
            if (con_status == 0)
            {
                bt_Lamp_stop.BackColor = Color.Red;
                tmr_Update.Stop();
            }
            else
                bt_Lamp_stop.BackColor = Color.LightGray;
        }

        private void tmr_Update_Tick(object sender, EventArgs e)
        {
            PLC01.GetDevice("M0", out int M0);
                if (M0 == 1) 
                    bt_Lamp_start.BackColor = Color.Red;
                else 
                bt_Lamp_start.BackColor= Color.LightGray;

        }
          
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

       
    }
}
