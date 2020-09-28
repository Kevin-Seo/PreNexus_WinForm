namespace LoL_Assistant
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.labStatus = new System.Windows.Forms.Label();
            this.labAliTop = new System.Windows.Forms.Label();
            this.labAliJungle = new System.Windows.Forms.Label();
            this.labAliMid = new System.Windows.Forms.Label();
            this.labAliAd = new System.Windows.Forms.Label();
            this.labAliSup = new System.Windows.Forms.Label();
            this.labAnSup = new System.Windows.Forms.Label();
            this.labEnAd = new System.Windows.Forms.Label();
            this.labEnMid = new System.Windows.Forms.Label();
            this.labEnJungle = new System.Windows.Forms.Label();
            this.labEnTop = new System.Windows.Forms.Label();
            this.cboxAliTop = new System.Windows.Forms.ComboBox();
            this.cboxAliJungle = new System.Windows.Forms.ComboBox();
            this.cboxAliMid = new System.Windows.Forms.ComboBox();
            this.cboxAliAd = new System.Windows.Forms.ComboBox();
            this.cboxAliSup = new System.Windows.Forms.ComboBox();
            this.cboxEnSup = new System.Windows.Forms.ComboBox();
            this.cboxEnAd = new System.Windows.Forms.ComboBox();
            this.cboxEnMid = new System.Windows.Forms.ComboBox();
            this.cboxEnJungle = new System.Windows.Forms.ComboBox();
            this.cboxEnTop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxGameNumber = new System.Windows.Forms.ComboBox();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labTopLane = new System.Windows.Forms.Label();
            this.labJungleLane = new System.Windows.Forms.Label();
            this.labMidLane = new System.Windows.Forms.Label();
            this.labAdLane = new System.Windows.Forms.Label();
            this.labSupLane = new System.Windows.Forms.Label();
            this.labTrend1 = new System.Windows.Forms.Label();
            this.labTrend2 = new System.Windows.Forms.Label();
            this.labTrend3 = new System.Windows.Forms.Label();
            this.labTrend4 = new System.Windows.Forms.Label();
            this.labTrend5 = new System.Windows.Forms.Label();
            this.tboxComment = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1399, 22);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "시작";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(1489, 22);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "중지";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(1328, 27);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(41, 12);
            this.labStatus.TabIndex = 2;
            this.labStatus.Text = "실행중";
            // 
            // labAliTop
            // 
            this.labAliTop.AutoSize = true;
            this.labAliTop.Location = new System.Drawing.Point(36, 93);
            this.labAliTop.Name = "labAliTop";
            this.labAliTop.Size = new System.Drawing.Size(57, 12);
            this.labAliTop.TabIndex = 3;
            this.labAliTop.Text = "우리팀 탑";
            // 
            // labAliJungle
            // 
            this.labAliJungle.AutoSize = true;
            this.labAliJungle.Location = new System.Drawing.Point(36, 123);
            this.labAliJungle.Name = "labAliJungle";
            this.labAliJungle.Size = new System.Drawing.Size(69, 12);
            this.labAliJungle.TabIndex = 4;
            this.labAliJungle.Text = "우리팀 정글";
            // 
            // labAliMid
            // 
            this.labAliMid.AutoSize = true;
            this.labAliMid.Location = new System.Drawing.Point(36, 154);
            this.labAliMid.Name = "labAliMid";
            this.labAliMid.Size = new System.Drawing.Size(69, 12);
            this.labAliMid.TabIndex = 4;
            this.labAliMid.Text = "우리팀 미드";
            // 
            // labAliAd
            // 
            this.labAliAd.AutoSize = true;
            this.labAliAd.Location = new System.Drawing.Point(36, 184);
            this.labAliAd.Name = "labAliAd";
            this.labAliAd.Size = new System.Drawing.Size(69, 12);
            this.labAliAd.TabIndex = 4;
            this.labAliAd.Text = "우리팀 원딜";
            // 
            // labAliSup
            // 
            this.labAliSup.AutoSize = true;
            this.labAliSup.Location = new System.Drawing.Point(36, 215);
            this.labAliSup.Name = "labAliSup";
            this.labAliSup.Size = new System.Drawing.Size(69, 12);
            this.labAliSup.TabIndex = 4;
            this.labAliSup.Text = "우리팀 서폿";
            // 
            // labAnSup
            // 
            this.labAnSup.AutoSize = true;
            this.labAnSup.Location = new System.Drawing.Point(36, 440);
            this.labAnSup.Name = "labAnSup";
            this.labAnSup.Size = new System.Drawing.Size(57, 12);
            this.labAnSup.TabIndex = 6;
            this.labAnSup.Text = "적팀 서폿";
            // 
            // labEnAd
            // 
            this.labEnAd.AutoSize = true;
            this.labEnAd.Location = new System.Drawing.Point(36, 409);
            this.labEnAd.Name = "labEnAd";
            this.labEnAd.Size = new System.Drawing.Size(57, 12);
            this.labEnAd.TabIndex = 7;
            this.labEnAd.Text = "적팀 원딜";
            // 
            // labEnMid
            // 
            this.labEnMid.AutoSize = true;
            this.labEnMid.Location = new System.Drawing.Point(36, 379);
            this.labEnMid.Name = "labEnMid";
            this.labEnMid.Size = new System.Drawing.Size(57, 12);
            this.labEnMid.TabIndex = 8;
            this.labEnMid.Text = "적팀 미드";
            // 
            // labEnJungle
            // 
            this.labEnJungle.AutoSize = true;
            this.labEnJungle.Location = new System.Drawing.Point(36, 348);
            this.labEnJungle.Name = "labEnJungle";
            this.labEnJungle.Size = new System.Drawing.Size(57, 12);
            this.labEnJungle.TabIndex = 9;
            this.labEnJungle.Text = "적팀 정글";
            // 
            // labEnTop
            // 
            this.labEnTop.AutoSize = true;
            this.labEnTop.Location = new System.Drawing.Point(36, 318);
            this.labEnTop.Name = "labEnTop";
            this.labEnTop.Size = new System.Drawing.Size(45, 12);
            this.labEnTop.TabIndex = 5;
            this.labEnTop.Text = "적팀 탑";
            // 
            // cboxAliTop
            // 
            this.cboxAliTop.Enabled = false;
            this.cboxAliTop.FormattingEnabled = true;
            this.cboxAliTop.Location = new System.Drawing.Point(119, 90);
            this.cboxAliTop.Name = "cboxAliTop";
            this.cboxAliTop.Size = new System.Drawing.Size(130, 20);
            this.cboxAliTop.TabIndex = 16;
            this.cboxAliTop.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // cboxAliJungle
            // 
            this.cboxAliJungle.Enabled = false;
            this.cboxAliJungle.FormattingEnabled = true;
            this.cboxAliJungle.Location = new System.Drawing.Point(119, 120);
            this.cboxAliJungle.Name = "cboxAliJungle";
            this.cboxAliJungle.Size = new System.Drawing.Size(130, 20);
            this.cboxAliJungle.TabIndex = 17;
            this.cboxAliJungle.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // cboxAliMid
            // 
            this.cboxAliMid.Enabled = false;
            this.cboxAliMid.FormattingEnabled = true;
            this.cboxAliMid.Location = new System.Drawing.Point(119, 151);
            this.cboxAliMid.Name = "cboxAliMid";
            this.cboxAliMid.Size = new System.Drawing.Size(130, 20);
            this.cboxAliMid.TabIndex = 18;
            this.cboxAliMid.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // cboxAliAd
            // 
            this.cboxAliAd.Enabled = false;
            this.cboxAliAd.FormattingEnabled = true;
            this.cboxAliAd.Location = new System.Drawing.Point(119, 181);
            this.cboxAliAd.Name = "cboxAliAd";
            this.cboxAliAd.Size = new System.Drawing.Size(130, 20);
            this.cboxAliAd.TabIndex = 19;
            this.cboxAliAd.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // cboxAliSup
            // 
            this.cboxAliSup.Enabled = false;
            this.cboxAliSup.FormattingEnabled = true;
            this.cboxAliSup.Location = new System.Drawing.Point(119, 212);
            this.cboxAliSup.Name = "cboxAliSup";
            this.cboxAliSup.Size = new System.Drawing.Size(130, 20);
            this.cboxAliSup.TabIndex = 20;
            this.cboxAliSup.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // cboxEnSup
            // 
            this.cboxEnSup.Enabled = false;
            this.cboxEnSup.FormattingEnabled = true;
            this.cboxEnSup.Location = new System.Drawing.Point(119, 437);
            this.cboxEnSup.Name = "cboxEnSup";
            this.cboxEnSup.Size = new System.Drawing.Size(130, 20);
            this.cboxEnSup.TabIndex = 25;
            this.cboxEnSup.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // cboxEnAd
            // 
            this.cboxEnAd.Enabled = false;
            this.cboxEnAd.FormattingEnabled = true;
            this.cboxEnAd.Location = new System.Drawing.Point(119, 406);
            this.cboxEnAd.Name = "cboxEnAd";
            this.cboxEnAd.Size = new System.Drawing.Size(130, 20);
            this.cboxEnAd.TabIndex = 24;
            this.cboxEnAd.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // cboxEnMid
            // 
            this.cboxEnMid.Enabled = false;
            this.cboxEnMid.FormattingEnabled = true;
            this.cboxEnMid.Location = new System.Drawing.Point(119, 376);
            this.cboxEnMid.Name = "cboxEnMid";
            this.cboxEnMid.Size = new System.Drawing.Size(130, 20);
            this.cboxEnMid.TabIndex = 23;
            this.cboxEnMid.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // cboxEnJungle
            // 
            this.cboxEnJungle.Enabled = false;
            this.cboxEnJungle.FormattingEnabled = true;
            this.cboxEnJungle.Location = new System.Drawing.Point(119, 345);
            this.cboxEnJungle.Name = "cboxEnJungle";
            this.cboxEnJungle.Size = new System.Drawing.Size(130, 20);
            this.cboxEnJungle.TabIndex = 22;
            this.cboxEnJungle.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // cboxEnTop
            // 
            this.cboxEnTop.Enabled = false;
            this.cboxEnTop.FormattingEnabled = true;
            this.cboxEnTop.Location = new System.Drawing.Point(119, 315);
            this.cboxEnTop.Name = "cboxEnTop";
            this.cboxEnTop.Size = new System.Drawing.Size(130, 20);
            this.cboxEnTop.TabIndex = 21;
            this.cboxEnTop.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "날짜";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "게임번호";
            // 
            // cboxGameNumber
            // 
            this.cboxGameNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGameNumber.FormattingEnabled = true;
            this.cboxGameNumber.Location = new System.Drawing.Point(359, 27);
            this.cboxGameNumber.Name = "cboxGameNumber";
            this.cboxGameNumber.Size = new System.Drawing.Size(121, 20);
            this.cboxGameNumber.TabIndex = 28;
            this.cboxGameNumber.SelectionChangeCommitted += new System.EventHandler(this.cboxGameNumber_SelectionChangeCommitted);
            this.cboxGameNumber.TextChanged += new System.EventHandler(this.cboxGameNumber_TextChanged);
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(502, 25);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(75, 23);
            this.btnAddGame.TabIndex = 29;
            this.btnAddGame.Text = "새게임";
            this.btnAddGame.UseVisualStyleBackColor = true;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("굴림", 20F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(301, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1235, 181);
            this.dataGridView1.TabIndex = 30;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("굴림", 20F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(301, 300);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1235, 181);
            this.dataGridView2.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(296, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 27);
            this.label3.TabIndex = 32;
            this.label3.Text = "탑 라인전";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(269, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 27);
            this.label4.TabIndex = 33;
            this.label4.Text = "정글 라인전";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(269, 574);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 27);
            this.label5.TabIndex = 33;
            this.label5.Text = "미드 라인전";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(269, 606);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 27);
            this.label6.TabIndex = 33;
            this.label6.Text = "원딜 라인전";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(269, 638);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 27);
            this.label7.TabIndex = 33;
            this.label7.Text = "서폿 라인전";
            // 
            // labTopLane
            // 
            this.labTopLane.AutoSize = true;
            this.labTopLane.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labTopLane.Location = new System.Drawing.Point(444, 510);
            this.labTopLane.Name = "labTopLane";
            this.labTopLane.Size = new System.Drawing.Size(85, 27);
            this.labTopLane.TabIndex = 32;
            this.labTopLane.Text = "00.00";
            // 
            // labJungleLane
            // 
            this.labJungleLane.AutoSize = true;
            this.labJungleLane.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labJungleLane.Location = new System.Drawing.Point(444, 542);
            this.labJungleLane.Name = "labJungleLane";
            this.labJungleLane.Size = new System.Drawing.Size(85, 27);
            this.labJungleLane.TabIndex = 33;
            this.labJungleLane.Text = "00.00";
            // 
            // labMidLane
            // 
            this.labMidLane.AutoSize = true;
            this.labMidLane.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labMidLane.Location = new System.Drawing.Point(444, 574);
            this.labMidLane.Name = "labMidLane";
            this.labMidLane.Size = new System.Drawing.Size(85, 27);
            this.labMidLane.TabIndex = 33;
            this.labMidLane.Text = "00.00";
            // 
            // labAdLane
            // 
            this.labAdLane.AutoSize = true;
            this.labAdLane.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labAdLane.Location = new System.Drawing.Point(444, 606);
            this.labAdLane.Name = "labAdLane";
            this.labAdLane.Size = new System.Drawing.Size(85, 27);
            this.labAdLane.TabIndex = 33;
            this.labAdLane.Text = "00.00";
            // 
            // labSupLane
            // 
            this.labSupLane.AutoSize = true;
            this.labSupLane.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labSupLane.Location = new System.Drawing.Point(444, 638);
            this.labSupLane.Name = "labSupLane";
            this.labSupLane.Size = new System.Drawing.Size(85, 27);
            this.labSupLane.TabIndex = 33;
            this.labSupLane.Text = "00.00";
            // 
            // labTrend1
            // 
            this.labTrend1.AutoSize = true;
            this.labTrend1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labTrend1.Location = new System.Drawing.Point(760, 510);
            this.labTrend1.Name = "labTrend1";
            this.labTrend1.Size = new System.Drawing.Size(85, 27);
            this.labTrend1.TabIndex = 34;
            this.labTrend1.Text = "00.00";
            // 
            // labTrend2
            // 
            this.labTrend2.AutoSize = true;
            this.labTrend2.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labTrend2.Location = new System.Drawing.Point(898, 510);
            this.labTrend2.Name = "labTrend2";
            this.labTrend2.Size = new System.Drawing.Size(85, 27);
            this.labTrend2.TabIndex = 35;
            this.labTrend2.Text = "00.00";
            // 
            // labTrend3
            // 
            this.labTrend3.AutoSize = true;
            this.labTrend3.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labTrend3.Location = new System.Drawing.Point(1051, 510);
            this.labTrend3.Name = "labTrend3";
            this.labTrend3.Size = new System.Drawing.Size(85, 27);
            this.labTrend3.TabIndex = 35;
            this.labTrend3.Text = "00.00";
            // 
            // labTrend4
            // 
            this.labTrend4.AutoSize = true;
            this.labTrend4.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labTrend4.Location = new System.Drawing.Point(1198, 510);
            this.labTrend4.Name = "labTrend4";
            this.labTrend4.Size = new System.Drawing.Size(85, 27);
            this.labTrend4.TabIndex = 35;
            this.labTrend4.Text = "00.00";
            // 
            // labTrend5
            // 
            this.labTrend5.AutoSize = true;
            this.labTrend5.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labTrend5.Location = new System.Drawing.Point(1343, 510);
            this.labTrend5.Name = "labTrend5";
            this.labTrend5.Size = new System.Drawing.Size(85, 27);
            this.labTrend5.TabIndex = 35;
            this.labTrend5.Text = "00.00";
            // 
            // tboxComment
            // 
            this.tboxComment.Enabled = false;
            this.tboxComment.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxComment.Location = new System.Drawing.Point(38, 684);
            this.tboxComment.Multiline = true;
            this.tboxComment.Name = "tboxComment";
            this.tboxComment.Size = new System.Drawing.Size(1498, 165);
            this.tboxComment.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "게임 저장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tboxComment);
            this.Controls.Add(this.labTrend5);
            this.Controls.Add(this.labTrend4);
            this.Controls.Add(this.labTrend3);
            this.Controls.Add(this.labTrend2);
            this.Controls.Add(this.labTrend1);
            this.Controls.Add(this.labSupLane);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labAdLane);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labMidLane);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labJungleLane);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labTopLane);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.cboxGameNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cboxEnSup);
            this.Controls.Add(this.cboxEnAd);
            this.Controls.Add(this.cboxEnMid);
            this.Controls.Add(this.cboxEnJungle);
            this.Controls.Add(this.cboxEnTop);
            this.Controls.Add(this.cboxAliSup);
            this.Controls.Add(this.cboxAliAd);
            this.Controls.Add(this.cboxAliMid);
            this.Controls.Add(this.cboxAliJungle);
            this.Controls.Add(this.cboxAliTop);
            this.Controls.Add(this.labAnSup);
            this.Controls.Add(this.labEnAd);
            this.Controls.Add(this.labEnMid);
            this.Controls.Add(this.labEnJungle);
            this.Controls.Add(this.labEnTop);
            this.Controls.Add(this.labAliSup);
            this.Controls.Add(this.labAliAd);
            this.Controls.Add(this.labAliMid);
            this.Controls.Add(this.labAliJungle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labAliTop);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Label labAliTop;
        private System.Windows.Forms.Label labAliJungle;
        private System.Windows.Forms.Label labAliMid;
        private System.Windows.Forms.Label labAliAd;
        private System.Windows.Forms.Label labAliSup;
        private System.Windows.Forms.Label labAnSup;
        private System.Windows.Forms.Label labEnAd;
        private System.Windows.Forms.Label labEnMid;
        private System.Windows.Forms.Label labEnJungle;
        private System.Windows.Forms.Label labEnTop;
        private System.Windows.Forms.ComboBox cboxAliTop;
        private System.Windows.Forms.ComboBox cboxAliJungle;
        private System.Windows.Forms.ComboBox cboxAliMid;
        private System.Windows.Forms.ComboBox cboxAliAd;
        private System.Windows.Forms.ComboBox cboxAliSup;
        private System.Windows.Forms.ComboBox cboxEnSup;
        private System.Windows.Forms.ComboBox cboxEnAd;
        private System.Windows.Forms.ComboBox cboxEnMid;
        private System.Windows.Forms.ComboBox cboxEnJungle;
        private System.Windows.Forms.ComboBox cboxEnTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxGameNumber;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labTopLane;
        private System.Windows.Forms.Label labJungleLane;
        private System.Windows.Forms.Label labMidLane;
        private System.Windows.Forms.Label labAdLane;
        private System.Windows.Forms.Label labSupLane;
        private System.Windows.Forms.Label labTrend1;
        private System.Windows.Forms.Label labTrend2;
        private System.Windows.Forms.Label labTrend3;
        private System.Windows.Forms.Label labTrend4;
        private System.Windows.Forms.Label labTrend5;
        private System.Windows.Forms.TextBox tboxComment;
        private System.Windows.Forms.Button button1;
    }
}

