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
    public partial class Operator_Log : Form
    {
        public Operator_Log()
        {
            InitializeComponent();

            lv_OperatorLog.Columns.Add("공정종류", -2, HorizontalAlignment.Center);
            lv_OperatorLog.Columns.Add("취급물품", -2, HorizontalAlignment.Center);
            lv_OperatorLog.Columns.Add("시작시간", -2, HorizontalAlignment.Center);
            lv_OperatorLog.Columns.Add("종료시간", -2, HorizontalAlignment.Center);
            lv_OperatorLog.Columns.Add("성공여부", -2, HorizontalAlignment.Center);
            lv_OperatorLog.Columns.Add("비고",-2, HorizontalAlignment.Center);

            lv_OperatorLog.View = View.Details;
            lv_OperatorLog.GridLines = true;

            lv_OperatorLog.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        string[] Converted_Log = new string[6];

        public void Get_Log(string[] doneOperation)
        {
            if (Convert.ToInt16(doneOperation[0]) == 1)
            {
                Converted_Log[0] = "배송공정";
            }
            else if (Convert.ToInt16(doneOperation[0]) == 2)
            {
                Converted_Log[0] = "적재공정";
            }

            if (Convert.ToInt16(doneOperation[1]) == 1)
            {
                Converted_Log[1] = "금속";
            }
            else
            {
                Converted_Log[1] = "비금속";
            }
            Converted_Log[2] = doneOperation[2];
            Converted_Log[3] = doneOperation[3];
            if (doneOperation[4] == "True")
            {
                Converted_Log[4] = "공정완료";
            }
            else
            {
                Converted_Log[4] = "공정 중";
            }
            ListViewItem item = new ListViewItem(Converted_Log);
            lv_OperatorLog.Items.Add(item);
        }
    }
}
