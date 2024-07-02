namespace Project_v01
{
    partial class Cockpit
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_PLC_stop = new System.Windows.Forms.Button();
            this.bt_PLC_start = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Serv_OFF = new System.Windows.Forms.Button();
            this.bt_Serv_ON = new System.Windows.Forms.Button();
            this.bt_Server_off = new System.Windows.Forms.Button();
            this.bt_Server_on = new System.Windows.Forms.Button();
            this.bt_Lamp_stop = new System.Windows.Forms.Button();
            this.bt_Lamp_start = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Server_Speed0 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Server_position = new System.Windows.Forms.TextBox();
            this.tb_Error_log = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Clear_log = new System.Windows.Forms.Button();
            this.bt_Save_log = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bt_Lamp_NonMetal = new System.Windows.Forms.Button();
            this.bt_Lamp_Metal = new System.Windows.Forms.Button();
            this.Conveyor = new System.Windows.Forms.GroupBox();
            this.bt_Conv_CCW = new System.Windows.Forms.TextBox();
            this.bt_Conv_CW = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Airline = new System.Windows.Forms.GroupBox();
            this.bt_Airline_OFF = new System.Windows.Forms.TextBox();
            this.bt_Airline_ON = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.PLC = new System.Windows.Forms.GroupBox();
            this.plc_Status_nok = new System.Windows.Forms.TextBox();
            this.plc_Status_ok = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.bt_Process_start = new System.Windows.Forms.Button();
            this.bt_Process_stop = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bt_Sup_fwd = new System.Windows.Forms.Button();
            this.bt_Sup_bwd = new System.Windows.Forms.Button();
            this.bt_Send_fwd = new System.Windows.Forms.Button();
            this.bt_Send_bwd = new System.Windows.Forms.Button();
            this.bt_Conv = new System.Windows.Forms.Button();
            this.bt_Stop_down = new System.Windows.Forms.Button();
            this.bt_Push_fwd = new System.Windows.Forms.Button();
            this.bt_Stop_up = new System.Windows.Forms.Button();
            this.bt_Push_bwd = new System.Windows.Forms.Button();
            this.bt_Suck_fwd = new System.Windows.Forms.Button();
            this.bt_Suck_bwd = new System.Windows.Forms.Button();
            this.bt_Sucking_Lamp = new System.Windows.Forms.Button();
            this.bt_Warehouse_fwd = new System.Windows.Forms.Button();
            this.bt_Warehouse_bwd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pb_Load = new System.Windows.Forms.ProgressBar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pb_Delivery = new System.Windows.Forms.ProgressBar();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.bt_OPR = new System.Windows.Forms.Button();
            this.bt_Server_move = new System.Windows.Forms.Button();
            this.bt_Error_Reset = new System.Windows.Forms.Button();
            this.bt_Server_Error = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.pb_reLoad = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Conveyor.SuspendLayout();
            this.Airline.SuspendLayout();
            this.PLC.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_PLC_stop);
            this.groupBox1.Controls.Add(this.bt_PLC_start);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bt_Serv_OFF);
            this.groupBox1.Controls.Add(this.bt_Serv_ON);
            this.groupBox1.Controls.Add(this.bt_Server_off);
            this.groupBox1.Controls.Add(this.bt_Server_on);
            this.groupBox1.Controls.Add(this.bt_Lamp_stop);
            this.groupBox1.Controls.Add(this.bt_Lamp_start);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(224, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(163, 254);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "통신";
            // 
            // bt_PLC_stop
            // 
            this.bt_PLC_stop.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_PLC_stop.Location = new System.Drawing.Point(17, 66);
            this.bt_PLC_stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_PLC_stop.Name = "bt_PLC_stop";
            this.bt_PLC_stop.Size = new System.Drawing.Size(89, 26);
            this.bt_PLC_stop.TabIndex = 4;
            this.bt_PLC_stop.Text = "PLC Stop";
            this.bt_PLC_stop.UseVisualStyleBackColor = true;
            this.bt_PLC_stop.Click += new System.EventHandler(this.bt_PLC_stop_Click);
            // 
            // bt_PLC_start
            // 
            this.bt_PLC_start.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_PLC_start.Location = new System.Drawing.Point(16, 34);
            this.bt_PLC_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_PLC_start.Name = "bt_PLC_start";
            this.bt_PLC_start.Size = new System.Drawing.Size(89, 26);
            this.bt_PLC_start.TabIndex = 4;
            this.bt_PLC_start.Text = "PLC Start";
            this.bt_PLC_start.UseVisualStyleBackColor = true;
            this.bt_PLC_start.Click += new System.EventHandler(this.bt_PLC_start_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(17, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "서버 OFF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(17, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "서버 ON";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(17, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "통신속도";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(17, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "통신포트";
            // 
            // bt_Serv_OFF
            // 
            this.bt_Serv_OFF.Location = new System.Drawing.Point(121, 128);
            this.bt_Serv_OFF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Serv_OFF.Name = "bt_Serv_OFF";
            this.bt_Serv_OFF.Size = new System.Drawing.Size(25, 25);
            this.bt_Serv_OFF.TabIndex = 2;
            this.bt_Serv_OFF.UseVisualStyleBackColor = true;
            // 
            // bt_Serv_ON
            // 
            this.bt_Serv_ON.Location = new System.Drawing.Point(121, 98);
            this.bt_Serv_ON.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Serv_ON.Name = "bt_Serv_ON";
            this.bt_Serv_ON.Size = new System.Drawing.Size(25, 25);
            this.bt_Serv_ON.TabIndex = 2;
            this.bt_Serv_ON.UseVisualStyleBackColor = true;
            // 
            // bt_Server_off
            // 
            this.bt_Server_off.Location = new System.Drawing.Point(93, 188);
            this.bt_Server_off.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Server_off.Name = "bt_Server_off";
            this.bt_Server_off.Size = new System.Drawing.Size(53, 25);
            this.bt_Server_off.TabIndex = 2;
            this.bt_Server_off.UseVisualStyleBackColor = true;
            // 
            // bt_Server_on
            // 
            this.bt_Server_on.Location = new System.Drawing.Point(93, 158);
            this.bt_Server_on.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Server_on.Name = "bt_Server_on";
            this.bt_Server_on.Size = new System.Drawing.Size(53, 25);
            this.bt_Server_on.TabIndex = 2;
            this.bt_Server_on.UseVisualStyleBackColor = true;
            // 
            // bt_Lamp_stop
            // 
            this.bt_Lamp_stop.Location = new System.Drawing.Point(121, 68);
            this.bt_Lamp_stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Lamp_stop.Name = "bt_Lamp_stop";
            this.bt_Lamp_stop.Size = new System.Drawing.Size(25, 25);
            this.bt_Lamp_stop.TabIndex = 2;
            this.bt_Lamp_stop.UseVisualStyleBackColor = true;
            // 
            // bt_Lamp_start
            // 
            this.bt_Lamp_start.Location = new System.Drawing.Point(121, 36);
            this.bt_Lamp_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Lamp_start.Name = "bt_Lamp_start";
            this.bt_Lamp_start.Size = new System.Drawing.Size(25, 25);
            this.bt_Lamp_start.TabIndex = 2;
            this.bt_Lamp_start.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(8, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "서보현재위치";
            // 
            // tb_Server_Speed0
            // 
            this.tb_Server_Speed0.Location = new System.Drawing.Point(111, 26);
            this.tb_Server_Speed0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Server_Speed0.Name = "tb_Server_Speed0";
            this.tb_Server_Speed0.Size = new System.Drawing.Size(60, 25);
            this.tb_Server_Speed0.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(8, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "서보현재속도";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(169, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "mm/min";
            // 
            // tb_Server_position
            // 
            this.tb_Server_position.Location = new System.Drawing.Point(110, 61);
            this.tb_Server_position.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Server_position.Name = "tb_Server_position";
            this.tb_Server_position.Size = new System.Drawing.Size(60, 25);
            this.tb_Server_position.TabIndex = 4;
            // 
            // tb_Error_log
            // 
            this.tb_Error_log.BackColor = System.Drawing.Color.White;
            this.tb_Error_log.ForeColor = System.Drawing.Color.Red;
            this.tb_Error_log.Location = new System.Drawing.Point(229, 618);
            this.tb_Error_log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Error_log.Multiline = true;
            this.tb_Error_log.Name = "tb_Error_log";
            this.tb_Error_log.ReadOnly = true;
            this.tb_Error_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Error_log.Size = new System.Drawing.Size(345, 65);
            this.tb_Error_log.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(231, 592);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Error_log";
            // 
            // tb_Clear_log
            // 
            this.tb_Clear_log.Location = new System.Drawing.Point(231, 686);
            this.tb_Clear_log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Clear_log.Name = "tb_Clear_log";
            this.tb_Clear_log.Size = new System.Drawing.Size(121, 32);
            this.tb_Clear_log.TabIndex = 7;
            this.tb_Clear_log.Text = "Clear";
            this.tb_Clear_log.UseVisualStyleBackColor = true;
            this.tb_Clear_log.Click += new System.EventHandler(this.tb_Clear_log_Click);
            // 
            // bt_Save_log
            // 
            this.bt_Save_log.Location = new System.Drawing.Point(447, 686);
            this.bt_Save_log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Save_log.Name = "bt_Save_log";
            this.bt_Save_log.Size = new System.Drawing.Size(102, 31);
            this.bt_Save_log.TabIndex = 8;
            this.bt_Save_log.Text = "Save";
            this.bt_Save_log.UseVisualStyleBackColor = true;
            this.bt_Save_log.Click += new System.EventHandler(this.bt_Save_log_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(22, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "금속";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(21, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "비금속";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bt_Lamp_NonMetal);
            this.groupBox4.Controls.Add(this.bt_Lamp_Metal);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(648, 361);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(155, 100);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "제품판별";
            // 
            // bt_Lamp_NonMetal
            // 
            this.bt_Lamp_NonMetal.Location = new System.Drawing.Point(97, 61);
            this.bt_Lamp_NonMetal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Lamp_NonMetal.Name = "bt_Lamp_NonMetal";
            this.bt_Lamp_NonMetal.Size = new System.Drawing.Size(23, 25);
            this.bt_Lamp_NonMetal.TabIndex = 4;
            this.bt_Lamp_NonMetal.UseVisualStyleBackColor = true;
            // 
            // bt_Lamp_Metal
            // 
            this.bt_Lamp_Metal.Location = new System.Drawing.Point(97, 30);
            this.bt_Lamp_Metal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Lamp_Metal.Name = "bt_Lamp_Metal";
            this.bt_Lamp_Metal.Size = new System.Drawing.Size(23, 25);
            this.bt_Lamp_Metal.TabIndex = 4;
            this.bt_Lamp_Metal.UseVisualStyleBackColor = true;
            // 
            // Conveyor
            // 
            this.Conveyor.Controls.Add(this.bt_Conv_CCW);
            this.Conveyor.Controls.Add(this.bt_Conv_CW);
            this.Conveyor.Controls.Add(this.label11);
            this.Conveyor.Controls.Add(this.label12);
            this.Conveyor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Conveyor.Location = new System.Drawing.Point(21, 40);
            this.Conveyor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Conveyor.Name = "Conveyor";
            this.Conveyor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Conveyor.Size = new System.Drawing.Size(129, 84);
            this.Conveyor.TabIndex = 11;
            this.Conveyor.TabStop = false;
            this.Conveyor.Text = "컨베이어";
            // 
            // bt_Conv_CCW
            // 
            this.bt_Conv_CCW.Location = new System.Drawing.Point(87, 52);
            this.bt_Conv_CCW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Conv_CCW.Name = "bt_Conv_CCW";
            this.bt_Conv_CCW.Size = new System.Drawing.Size(23, 25);
            this.bt_Conv_CCW.TabIndex = 4;
            // 
            // bt_Conv_CW
            // 
            this.bt_Conv_CW.Location = new System.Drawing.Point(88, 18);
            this.bt_Conv_CW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Conv_CW.Name = "bt_Conv_CW";
            this.bt_Conv_CW.Size = new System.Drawing.Size(23, 25);
            this.bt_Conv_CW.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "CCW";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "CW";
            // 
            // Airline
            // 
            this.Airline.Controls.Add(this.bt_Airline_OFF);
            this.Airline.Controls.Add(this.bt_Airline_ON);
            this.Airline.Controls.Add(this.label13);
            this.Airline.Controls.Add(this.label14);
            this.Airline.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Airline.Location = new System.Drawing.Point(177, 40);
            this.Airline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Airline.Name = "Airline";
            this.Airline.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Airline.Size = new System.Drawing.Size(135, 84);
            this.Airline.TabIndex = 11;
            this.Airline.TabStop = false;
            this.Airline.Text = "에어공급";
            // 
            // bt_Airline_OFF
            // 
            this.bt_Airline_OFF.Location = new System.Drawing.Point(87, 52);
            this.bt_Airline_OFF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Airline_OFF.Name = "bt_Airline_OFF";
            this.bt_Airline_OFF.Size = new System.Drawing.Size(23, 25);
            this.bt_Airline_OFF.TabIndex = 4;
            // 
            // bt_Airline_ON
            // 
            this.bt_Airline_ON.Location = new System.Drawing.Point(88, 18);
            this.bt_Airline_ON.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Airline_ON.Name = "bt_Airline_ON";
            this.bt_Airline_ON.Size = new System.Drawing.Size(23, 25);
            this.bt_Airline_ON.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "OFF";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "ON";
            // 
            // PLC
            // 
            this.PLC.Controls.Add(this.plc_Status_nok);
            this.PLC.Controls.Add(this.plc_Status_ok);
            this.PLC.Controls.Add(this.label15);
            this.PLC.Controls.Add(this.label16);
            this.PLC.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PLC.Location = new System.Drawing.Point(333, 40);
            this.PLC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PLC.Name = "PLC";
            this.PLC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PLC.Size = new System.Drawing.Size(135, 84);
            this.PLC.TabIndex = 11;
            this.PLC.TabStop = false;
            this.PLC.Text = "PLC";
            // 
            // plc_Status_nok
            // 
            this.plc_Status_nok.Location = new System.Drawing.Point(87, 52);
            this.plc_Status_nok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plc_Status_nok.Name = "plc_Status_nok";
            this.plc_Status_nok.Size = new System.Drawing.Size(23, 25);
            this.plc_Status_nok.TabIndex = 4;
            // 
            // plc_Status_ok
            // 
            this.plc_Status_ok.Location = new System.Drawing.Point(88, 18);
            this.plc_Status_ok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plc_Status_ok.Name = "plc_Status_ok";
            this.plc_Status_ok.Size = new System.Drawing.Size(23, 25);
            this.plc_Status_ok.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 15);
            this.label15.TabIndex = 3;
            this.label15.Text = "OFF";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 15);
            this.label16.TabIndex = 3;
            this.label16.Text = "ON";
            // 
            // bt_Process_start
            // 
            this.bt_Process_start.Location = new System.Drawing.Point(658, 552);
            this.bt_Process_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Process_start.Name = "bt_Process_start";
            this.bt_Process_start.Size = new System.Drawing.Size(99, 28);
            this.bt_Process_start.TabIndex = 12;
            this.bt_Process_start.Text = "공정시작";
            this.bt_Process_start.UseVisualStyleBackColor = true;
            this.bt_Process_start.Click += new System.EventHandler(this.bt_Process_start_Click);
            // 
            // bt_Process_stop
            // 
            this.bt_Process_stop.Location = new System.Drawing.Point(762, 552);
            this.bt_Process_stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Process_stop.Name = "bt_Process_stop";
            this.bt_Process_stop.Size = new System.Drawing.Size(99, 28);
            this.bt_Process_stop.TabIndex = 12;
            this.bt_Process_stop.Text = "공정정지";
            this.bt_Process_stop.UseVisualStyleBackColor = true;
            this.bt_Process_stop.Click += new System.EventHandler(this.bt_Process_stop_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.PLC);
            this.groupBox5.Controls.Add(this.Airline);
            this.groupBox5.Controls.Add(this.Conveyor);
            this.groupBox5.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox5.Location = new System.Drawing.Point(394, 83);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(489, 146);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "설비관리";
            // 
            // bt_Sup_fwd
            // 
            this.bt_Sup_fwd.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Sup_fwd.Location = new System.Drawing.Point(27, 30);
            this.bt_Sup_fwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Sup_fwd.Name = "bt_Sup_fwd";
            this.bt_Sup_fwd.Size = new System.Drawing.Size(70, 30);
            this.bt_Sup_fwd.TabIndex = 9;
            this.bt_Sup_fwd.Text = "공급전진";
            this.bt_Sup_fwd.UseVisualStyleBackColor = true;
            // 
            // bt_Sup_bwd
            // 
            this.bt_Sup_bwd.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Sup_bwd.Location = new System.Drawing.Point(27, 66);
            this.bt_Sup_bwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Sup_bwd.Name = "bt_Sup_bwd";
            this.bt_Sup_bwd.Size = new System.Drawing.Size(70, 30);
            this.bt_Sup_bwd.TabIndex = 9;
            this.bt_Sup_bwd.Text = "공급후진";
            this.bt_Sup_bwd.UseVisualStyleBackColor = true;
            // 
            // bt_Send_fwd
            // 
            this.bt_Send_fwd.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Send_fwd.Location = new System.Drawing.Point(27, 102);
            this.bt_Send_fwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Send_fwd.Name = "bt_Send_fwd";
            this.bt_Send_fwd.Size = new System.Drawing.Size(70, 30);
            this.bt_Send_fwd.TabIndex = 9;
            this.bt_Send_fwd.Text = "송출전진";
            this.bt_Send_fwd.UseVisualStyleBackColor = true;
            // 
            // bt_Send_bwd
            // 
            this.bt_Send_bwd.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Send_bwd.Location = new System.Drawing.Point(27, 138);
            this.bt_Send_bwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Send_bwd.Name = "bt_Send_bwd";
            this.bt_Send_bwd.Size = new System.Drawing.Size(70, 30);
            this.bt_Send_bwd.TabIndex = 9;
            this.bt_Send_bwd.Text = "송출후진";
            this.bt_Send_bwd.UseVisualStyleBackColor = true;
            // 
            // bt_Conv
            // 
            this.bt_Conv.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Conv.Location = new System.Drawing.Point(27, 175);
            this.bt_Conv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Conv.Name = "bt_Conv";
            this.bt_Conv.Size = new System.Drawing.Size(70, 30);
            this.bt_Conv.TabIndex = 9;
            this.bt_Conv.Text = "컨베이어";
            this.bt_Conv.UseVisualStyleBackColor = true;
            // 
            // bt_Stop_down
            // 
            this.bt_Stop_down.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Stop_down.Location = new System.Drawing.Point(27, 282);
            this.bt_Stop_down.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Stop_down.Name = "bt_Stop_down";
            this.bt_Stop_down.Size = new System.Drawing.Size(70, 30);
            this.bt_Stop_down.TabIndex = 9;
            this.bt_Stop_down.Text = "스탑다운";
            this.bt_Stop_down.UseVisualStyleBackColor = true;
            // 
            // bt_Push_fwd
            // 
            this.bt_Push_fwd.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Push_fwd.Location = new System.Drawing.Point(27, 211);
            this.bt_Push_fwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Push_fwd.Name = "bt_Push_fwd";
            this.bt_Push_fwd.Size = new System.Drawing.Size(70, 30);
            this.bt_Push_fwd.TabIndex = 9;
            this.bt_Push_fwd.Text = "배출전진";
            this.bt_Push_fwd.UseVisualStyleBackColor = true;
            // 
            // bt_Stop_up
            // 
            this.bt_Stop_up.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Stop_up.Location = new System.Drawing.Point(27, 319);
            this.bt_Stop_up.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Stop_up.Name = "bt_Stop_up";
            this.bt_Stop_up.Size = new System.Drawing.Size(70, 30);
            this.bt_Stop_up.TabIndex = 9;
            this.bt_Stop_up.Text = "스탑업";
            this.bt_Stop_up.UseVisualStyleBackColor = true;
            // 
            // bt_Push_bwd
            // 
            this.bt_Push_bwd.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Push_bwd.Location = new System.Drawing.Point(27, 248);
            this.bt_Push_bwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Push_bwd.Name = "bt_Push_bwd";
            this.bt_Push_bwd.Size = new System.Drawing.Size(70, 30);
            this.bt_Push_bwd.TabIndex = 9;
            this.bt_Push_bwd.Text = "배출후진";
            this.bt_Push_bwd.UseVisualStyleBackColor = true;
            // 
            // bt_Suck_fwd
            // 
            this.bt_Suck_fwd.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Suck_fwd.Location = new System.Drawing.Point(27, 355);
            this.bt_Suck_fwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Suck_fwd.Name = "bt_Suck_fwd";
            this.bt_Suck_fwd.Size = new System.Drawing.Size(70, 30);
            this.bt_Suck_fwd.TabIndex = 9;
            this.bt_Suck_fwd.Text = "흡착전진";
            this.bt_Suck_fwd.UseVisualStyleBackColor = true;
            // 
            // bt_Suck_bwd
            // 
            this.bt_Suck_bwd.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Suck_bwd.Location = new System.Drawing.Point(27, 391);
            this.bt_Suck_bwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Suck_bwd.Name = "bt_Suck_bwd";
            this.bt_Suck_bwd.Size = new System.Drawing.Size(70, 30);
            this.bt_Suck_bwd.TabIndex = 9;
            this.bt_Suck_bwd.Text = "흡착후진";
            this.bt_Suck_bwd.UseVisualStyleBackColor = true;
            // 
            // bt_Sucking_Lamp
            // 
            this.bt_Sucking_Lamp.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Sucking_Lamp.Location = new System.Drawing.Point(27, 428);
            this.bt_Sucking_Lamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Sucking_Lamp.Name = "bt_Sucking_Lamp";
            this.bt_Sucking_Lamp.Size = new System.Drawing.Size(70, 30);
            this.bt_Sucking_Lamp.TabIndex = 12;
            this.bt_Sucking_Lamp.Text = "흡착온";
            this.bt_Sucking_Lamp.UseVisualStyleBackColor = true;
            // 
            // bt_Warehouse_fwd
            // 
            this.bt_Warehouse_fwd.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Warehouse_fwd.Location = new System.Drawing.Point(27, 461);
            this.bt_Warehouse_fwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Warehouse_fwd.Name = "bt_Warehouse_fwd";
            this.bt_Warehouse_fwd.Size = new System.Drawing.Size(70, 30);
            this.bt_Warehouse_fwd.TabIndex = 13;
            this.bt_Warehouse_fwd.Text = "창고전진";
            this.bt_Warehouse_fwd.UseVisualStyleBackColor = true;
            // 
            // bt_Warehouse_bwd
            // 
            this.bt_Warehouse_bwd.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Warehouse_bwd.Location = new System.Drawing.Point(27, 498);
            this.bt_Warehouse_bwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Warehouse_bwd.Name = "bt_Warehouse_bwd";
            this.bt_Warehouse_bwd.Size = new System.Drawing.Size(70, 30);
            this.bt_Warehouse_bwd.TabIndex = 13;
            this.bt_Warehouse_bwd.Text = "창고후진";
            this.bt_Warehouse_bwd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_Warehouse_bwd);
            this.groupBox2.Controls.Add(this.bt_Warehouse_fwd);
            this.groupBox2.Controls.Add(this.bt_Sucking_Lamp);
            this.groupBox2.Controls.Add(this.bt_Suck_bwd);
            this.groupBox2.Controls.Add(this.bt_Suck_fwd);
            this.groupBox2.Controls.Add(this.bt_Stop_up);
            this.groupBox2.Controls.Add(this.bt_Push_bwd);
            this.groupBox2.Controls.Add(this.bt_Stop_down);
            this.groupBox2.Controls.Add(this.bt_Push_fwd);
            this.groupBox2.Controls.Add(this.bt_Conv);
            this.groupBox2.Controls.Add(this.bt_Send_bwd);
            this.groupBox2.Controls.Add(this.bt_Send_fwd);
            this.groupBox2.Controls.Add(this.bt_Sup_fwd);
            this.groupBox2.Controls.Add(this.bt_Sup_bwd);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(901, 83);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(123, 542);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "센서모니터링";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pb_Load);
            this.groupBox3.Location = new System.Drawing.Point(223, 339);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(397, 80);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "적재공정";
            // 
            // pb_Load
            // 
            this.pb_Load.Location = new System.Drawing.Point(11, 22);
            this.pb_Load.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_Load.Name = "pb_Load";
            this.pb_Load.Size = new System.Drawing.Size(360, 34);
            this.pb_Load.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pb_Delivery);
            this.groupBox6.Location = new System.Drawing.Point(223, 424);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(397, 80);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "발송공정";
            // 
            // pb_Delivery
            // 
            this.pb_Delivery.Location = new System.Drawing.Point(11, 22);
            this.pb_Delivery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_Delivery.Name = "pb_Delivery";
            this.pb_Delivery.Size = new System.Drawing.Size(360, 35);
            this.pb_Delivery.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.bt_OPR);
            this.groupBox7.Controls.Add(this.bt_Server_move);
            this.groupBox7.Controls.Add(this.bt_Error_Reset);
            this.groupBox7.Controls.Add(this.bt_Server_Error);
            this.groupBox7.Controls.Add(this.tb_Server_position);
            this.groupBox7.Controls.Add(this.tb_Server_Speed0);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox7.Location = new System.Drawing.Point(395, 242);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(486, 92);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "서보모니터링";
            // 
            // bt_OPR
            // 
            this.bt_OPR.Location = new System.Drawing.Point(345, 55);
            this.bt_OPR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_OPR.Name = "bt_OPR";
            this.bt_OPR.Size = new System.Drawing.Size(137, 30);
            this.bt_OPR.TabIndex = 19;
            this.bt_OPR.Text = "서버원점복귀";
            this.bt_OPR.UseVisualStyleBackColor = true;
            this.bt_OPR.Click += new System.EventHandler(this.bt_OPR_Click);
            // 
            // bt_Server_move
            // 
            this.bt_Server_move.Location = new System.Drawing.Point(307, 28);
            this.bt_Server_move.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Server_move.Name = "bt_Server_move";
            this.bt_Server_move.Size = new System.Drawing.Size(23, 25);
            this.bt_Server_move.TabIndex = 5;
            this.bt_Server_move.UseVisualStyleBackColor = true;
            // 
            // bt_Error_Reset
            // 
            this.bt_Error_Reset.Location = new System.Drawing.Point(343, 20);
            this.bt_Error_Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Error_Reset.Name = "bt_Error_Reset";
            this.bt_Error_Reset.Size = new System.Drawing.Size(137, 30);
            this.bt_Error_Reset.TabIndex = 18;
            this.bt_Error_Reset.Text = "서버에러리셋";
            this.bt_Error_Reset.UseVisualStyleBackColor = true;
            // 
            // bt_Server_Error
            // 
            this.bt_Server_Error.Location = new System.Drawing.Point(307, 58);
            this.bt_Server_Error.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Server_Error.Name = "bt_Server_Error";
            this.bt_Server_Error.Size = new System.Drawing.Size(23, 25);
            this.bt_Server_Error.TabIndex = 5;
            this.bt_Server_Error.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(230, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 15);
            this.label18.TabIndex = 3;
            this.label18.Text = "서보에러";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(169, 68);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 15);
            this.label19.TabIndex = 3;
            this.label19.Text = "mm";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(230, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 15);
            this.label17.TabIndex = 3;
            this.label17.Text = "서보기동";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.pb_reLoad);
            this.groupBox8.Location = new System.Drawing.Point(224, 509);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Size = new System.Drawing.Size(397, 80);
            this.groupBox8.TabIndex = 16;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "재적재공정";
            // 
            // pb_reLoad
            // 
            this.pb_reLoad.Location = new System.Drawing.Point(11, 22);
            this.pb_reLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_reLoad.Name = "pb_reLoad";
            this.pb_reLoad.Size = new System.Drawing.Size(360, 35);
            this.pb_reLoad.TabIndex = 0;
            // 
            // Cockpit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.bt_Process_stop);
            this.Controls.Add(this.bt_Process_start);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.bt_Save_log);
            this.Controls.Add(this.tb_Clear_log);
            this.Controls.Add(this.tb_Error_log);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cockpit";
            this.Text = "CockpitMonitor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Conveyor.ResumeLayout(false);
            this.Conveyor.PerformLayout();
            this.Airline.ResumeLayout(false);
            this.Airline.PerformLayout();
            this.PLC.ResumeLayout(false);
            this.PLC.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Server_off;
        private System.Windows.Forms.Button bt_Server_on;
        private System.Windows.Forms.Button bt_Lamp_stop;
        private System.Windows.Forms.Button bt_Lamp_start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Server_Speed0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_Serv_OFF;
        private System.Windows.Forms.Button bt_Serv_ON;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Server_position;
        private System.Windows.Forms.Button bt_PLC_stop;
        private System.Windows.Forms.Button bt_PLC_start;
        private System.Windows.Forms.TextBox tb_Error_log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tb_Clear_log;
        private System.Windows.Forms.Button bt_Save_log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox Conveyor;
        private System.Windows.Forms.TextBox bt_Conv_CCW;
        private System.Windows.Forms.TextBox bt_Conv_CW;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox Airline;
        private System.Windows.Forms.TextBox bt_Airline_OFF;
        private System.Windows.Forms.TextBox bt_Airline_ON;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox PLC;
        private System.Windows.Forms.TextBox plc_Status_nok;
        private System.Windows.Forms.TextBox plc_Status_ok;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button bt_Process_start;
        private System.Windows.Forms.Button bt_Process_stop;
        private System.Windows.Forms.Button bt_Lamp_NonMetal;
        private System.Windows.Forms.Button bt_Lamp_Metal;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button bt_Sup_fwd;
        private System.Windows.Forms.Button bt_Sup_bwd;
        private System.Windows.Forms.Button bt_Send_fwd;
        private System.Windows.Forms.Button bt_Send_bwd;
        private System.Windows.Forms.Button bt_Conv;
        private System.Windows.Forms.Button bt_Stop_down;
        private System.Windows.Forms.Button bt_Push_fwd;
        private System.Windows.Forms.Button bt_Stop_up;
        private System.Windows.Forms.Button bt_Push_bwd;
        private System.Windows.Forms.Button bt_Suck_fwd;
        private System.Windows.Forms.Button bt_Suck_bwd;
        private System.Windows.Forms.Button bt_Sucking_Lamp;
        private System.Windows.Forms.Button bt_Warehouse_fwd;
        private System.Windows.Forms.Button bt_Warehouse_bwd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button bt_Server_move;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button bt_Server_Error;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button bt_Error_Reset;
        private System.Windows.Forms.Button bt_OPR;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ProgressBar pb_Load;
        private System.Windows.Forms.ProgressBar pb_Delivery;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ProgressBar pb_reLoad;
    }
}

