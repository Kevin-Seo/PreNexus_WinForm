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
            this.labStatus.Text = "정지됨";
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
            this.cboxAliTop.FormattingEnabled = true;
            this.cboxAliTop.Items.AddRange(new object[] {
            "아트록스",
            "아리",
            "아칼리",
            "알리스타",
            "아무무",
            "애니비아",
            "애니",
            "아펠리오스",
            "애쉬",
            "아우렐리온솔",
            "아지르",
            "바드",
            "블리츠크랭크",
            "브랜드",
            "브라움",
            "케이틀린",
            "카밀",
            "카시오페아",
            "초카스",
            "코르키",
            "다리우스",
            "다이애나",
            "문도박사",
            "드레이븐",
            "에코",
            "엘리스",
            "이블린",
            "이즈리얼",
            "피들스틱",
            "피오라",
            "피즈",
            "갈리오",
            "갱플랭크",
            "가렌",
            "나르",
            "그라가스",
            "그레이브즈",
            "헤카림",
            "하이머딩거",
            "일라오이",
            "이렐리아",
            "아이번",
            "잔나",
            "자르반4세",
            "잭스",
            "제이스",
            "진",
            "징크스",
            "카이사",
            "칼리스타",
            "카르마",
            "카서스",
            "카사딘",
            "카타리나",
            "케일",
            "케인",
            "케넨",
            "카직스",
            "킨드레드",
            "클레드",
            "코그모",
            "르블랑",
            "리신",
            "레오나",
            "릴리아",
            "리산드라",
            "루시안",
            "룰루",
            "럭스",
            "말파이트",
            "말자하",
            "마오카이",
            "마스터이",
            "미스포츈",
            "모데카이저",
            "모르가나",
            "나미",
            "나서스",
            "노틸러스",
            "니코",
            "니달리",
            "녹턴",
            "누누와월럼프",
            "올라프",
            "오리아나",
            "오른",
            "판테온",
            "뽀삐",
            "파이크",
            "키아나",
            "퀸",
            "라칸",
            "람머스",
            "렉사이",
            "레넥톤",
            "렝가",
            "리븐",
            "럼블",
            "라이즈",
            "사미라",
            "세주아니",
            "세나",
            "세트",
            "샤코",
            "쉔",
            "쉬바나",
            "신지드",
            "사이온",
            "시비르",
            "스카너",
            "소나",
            "소라카",
            "스웨인",
            "사일러스",
            "신드라",
            "탐켄치",
            "탈리야",
            "탈론",
            "타릭",
            "티모",
            "쓰레쉬",
            "트리스타나",
            "트런들",
            "트린다미어",
            "트위스티드페이트",
            "트위치",
            "우디르",
            "우르곳",
            "바루스",
            "베인",
            "베이가",
            "벨코즈",
            "바이",
            "빅토르",
            "블라디미르",
            "볼리베어",
            "워윅",
            "오공",
            "자야",
            "제라스",
            "신짜오",
            "야스오",
            "요네",
            "요릭",
            "유미",
            "자크",
            "제드",
            "직스",
            "질리언",
            "조이",
            "자이라"});
            this.cboxAliTop.Location = new System.Drawing.Point(119, 90);
            this.cboxAliTop.Name = "cboxAliTop";
            this.cboxAliTop.Size = new System.Drawing.Size(130, 20);
            this.cboxAliTop.TabIndex = 16;
            this.cboxAliTop.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // cboxAliJungle
            // 
            this.cboxAliJungle.FormattingEnabled = true;
            this.cboxAliJungle.Items.AddRange(new object[] {
            "아트록스",
            "아리",
            "아칼리",
            "알리스타",
            "아무무",
            "애니비아",
            "애니",
            "아펠리오스",
            "애쉬",
            "아우렐리온솔",
            "아지르",
            "바드",
            "블리츠크랭크",
            "브랜드",
            "브라움",
            "케이틀린",
            "카밀",
            "카시오페아",
            "초카스",
            "코르키",
            "다리우스",
            "다이애나",
            "문도박사",
            "드레이븐",
            "에코",
            "엘리스",
            "이블린",
            "이즈리얼",
            "피들스틱",
            "피오라",
            "피즈",
            "갈리오",
            "갱플랭크",
            "가렌",
            "나르",
            "그라가스",
            "그레이브즈",
            "헤카림",
            "하이머딩거",
            "일라오이",
            "이렐리아",
            "아이번",
            "잔나",
            "자르반4세",
            "잭스",
            "제이스",
            "진",
            "징크스",
            "카이사",
            "칼리스타",
            "카르마",
            "카서스",
            "카사딘",
            "카타리나",
            "케일",
            "케인",
            "케넨",
            "카직스",
            "킨드레드",
            "클레드",
            "코그모",
            "르블랑",
            "리신",
            "레오나",
            "릴리아",
            "리산드라",
            "루시안",
            "룰루",
            "럭스",
            "말파이트",
            "말자하",
            "마오카이",
            "마스터이",
            "미스포츈",
            "모데카이저",
            "모르가나",
            "나미",
            "나서스",
            "노틸러스",
            "니코",
            "니달리",
            "녹턴",
            "누누와월럼프",
            "올라프",
            "오리아나",
            "오른",
            "판테온",
            "뽀삐",
            "파이크",
            "키아나",
            "퀸",
            "라칸",
            "람머스",
            "렉사이",
            "레넥톤",
            "렝가",
            "리븐",
            "럼블",
            "라이즈",
            "사미라",
            "세주아니",
            "세나",
            "세트",
            "샤코",
            "쉔",
            "쉬바나",
            "신지드",
            "사이온",
            "시비르",
            "스카너",
            "소나",
            "소라카",
            "스웨인",
            "사일러스",
            "신드라",
            "탐켄치",
            "탈리야",
            "탈론",
            "타릭",
            "티모",
            "쓰레쉬",
            "트리스타나",
            "트런들",
            "트린다미어",
            "트위스티드페이트",
            "트위치",
            "우디르",
            "우르곳",
            "바루스",
            "베인",
            "베이가",
            "벨코즈",
            "바이",
            "빅토르",
            "블라디미르",
            "볼리베어",
            "워윅",
            "오공",
            "자야",
            "제라스",
            "신짜오",
            "야스오",
            "요네",
            "요릭",
            "유미",
            "자크",
            "제드",
            "직스",
            "질리언",
            "조이",
            "자이라"});
            this.cboxAliJungle.Location = new System.Drawing.Point(119, 120);
            this.cboxAliJungle.Name = "cboxAliJungle";
            this.cboxAliJungle.Size = new System.Drawing.Size(130, 20);
            this.cboxAliJungle.TabIndex = 17;
            this.cboxAliJungle.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // cboxAliMid
            // 
            this.cboxAliMid.FormattingEnabled = true;
            this.cboxAliMid.Items.AddRange(new object[] {
            "아트록스",
            "아리",
            "아칼리",
            "알리스타",
            "아무무",
            "애니비아",
            "애니",
            "아펠리오스",
            "애쉬",
            "아우렐리온솔",
            "아지르",
            "바드",
            "블리츠크랭크",
            "브랜드",
            "브라움",
            "케이틀린",
            "카밀",
            "카시오페아",
            "초카스",
            "코르키",
            "다리우스",
            "다이애나",
            "문도박사",
            "드레이븐",
            "에코",
            "엘리스",
            "이블린",
            "이즈리얼",
            "피들스틱",
            "피오라",
            "피즈",
            "갈리오",
            "갱플랭크",
            "가렌",
            "나르",
            "그라가스",
            "그레이브즈",
            "헤카림",
            "하이머딩거",
            "일라오이",
            "이렐리아",
            "아이번",
            "잔나",
            "자르반4세",
            "잭스",
            "제이스",
            "진",
            "징크스",
            "카이사",
            "칼리스타",
            "카르마",
            "카서스",
            "카사딘",
            "카타리나",
            "케일",
            "케인",
            "케넨",
            "카직스",
            "킨드레드",
            "클레드",
            "코그모",
            "르블랑",
            "리신",
            "레오나",
            "릴리아",
            "리산드라",
            "루시안",
            "룰루",
            "럭스",
            "말파이트",
            "말자하",
            "마오카이",
            "마스터이",
            "미스포츈",
            "모데카이저",
            "모르가나",
            "나미",
            "나서스",
            "노틸러스",
            "니코",
            "니달리",
            "녹턴",
            "누누와월럼프",
            "올라프",
            "오리아나",
            "오른",
            "판테온",
            "뽀삐",
            "파이크",
            "키아나",
            "퀸",
            "라칸",
            "람머스",
            "렉사이",
            "레넥톤",
            "렝가",
            "리븐",
            "럼블",
            "라이즈",
            "사미라",
            "세주아니",
            "세나",
            "세트",
            "샤코",
            "쉔",
            "쉬바나",
            "신지드",
            "사이온",
            "시비르",
            "스카너",
            "소나",
            "소라카",
            "스웨인",
            "사일러스",
            "신드라",
            "탐켄치",
            "탈리야",
            "탈론",
            "타릭",
            "티모",
            "쓰레쉬",
            "트리스타나",
            "트런들",
            "트린다미어",
            "트위스티드페이트",
            "트위치",
            "우디르",
            "우르곳",
            "바루스",
            "베인",
            "베이가",
            "벨코즈",
            "바이",
            "빅토르",
            "블라디미르",
            "볼리베어",
            "워윅",
            "오공",
            "자야",
            "제라스",
            "신짜오",
            "야스오",
            "요네",
            "요릭",
            "유미",
            "자크",
            "제드",
            "직스",
            "질리언",
            "조이",
            "자이라"});
            this.cboxAliMid.Location = new System.Drawing.Point(119, 151);
            this.cboxAliMid.Name = "cboxAliMid";
            this.cboxAliMid.Size = new System.Drawing.Size(130, 20);
            this.cboxAliMid.TabIndex = 18;
            this.cboxAliMid.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // cboxAliAd
            // 
            this.cboxAliAd.FormattingEnabled = true;
            this.cboxAliAd.Items.AddRange(new object[] {
            "아트록스",
            "아리",
            "아칼리",
            "알리스타",
            "아무무",
            "애니비아",
            "애니",
            "아펠리오스",
            "애쉬",
            "아우렐리온솔",
            "아지르",
            "바드",
            "블리츠크랭크",
            "브랜드",
            "브라움",
            "케이틀린",
            "카밀",
            "카시오페아",
            "초카스",
            "코르키",
            "다리우스",
            "다이애나",
            "문도박사",
            "드레이븐",
            "에코",
            "엘리스",
            "이블린",
            "이즈리얼",
            "피들스틱",
            "피오라",
            "피즈",
            "갈리오",
            "갱플랭크",
            "가렌",
            "나르",
            "그라가스",
            "그레이브즈",
            "헤카림",
            "하이머딩거",
            "일라오이",
            "이렐리아",
            "아이번",
            "잔나",
            "자르반4세",
            "잭스",
            "제이스",
            "진",
            "징크스",
            "카이사",
            "칼리스타",
            "카르마",
            "카서스",
            "카사딘",
            "카타리나",
            "케일",
            "케인",
            "케넨",
            "카직스",
            "킨드레드",
            "클레드",
            "코그모",
            "르블랑",
            "리신",
            "레오나",
            "릴리아",
            "리산드라",
            "루시안",
            "룰루",
            "럭스",
            "말파이트",
            "말자하",
            "마오카이",
            "마스터이",
            "미스포츈",
            "모데카이저",
            "모르가나",
            "나미",
            "나서스",
            "노틸러스",
            "니코",
            "니달리",
            "녹턴",
            "누누와월럼프",
            "올라프",
            "오리아나",
            "오른",
            "판테온",
            "뽀삐",
            "파이크",
            "키아나",
            "퀸",
            "라칸",
            "람머스",
            "렉사이",
            "레넥톤",
            "렝가",
            "리븐",
            "럼블",
            "라이즈",
            "사미라",
            "세주아니",
            "세나",
            "세트",
            "샤코",
            "쉔",
            "쉬바나",
            "신지드",
            "사이온",
            "시비르",
            "스카너",
            "소나",
            "소라카",
            "스웨인",
            "사일러스",
            "신드라",
            "탐켄치",
            "탈리야",
            "탈론",
            "타릭",
            "티모",
            "쓰레쉬",
            "트리스타나",
            "트런들",
            "트린다미어",
            "트위스티드페이트",
            "트위치",
            "우디르",
            "우르곳",
            "바루스",
            "베인",
            "베이가",
            "벨코즈",
            "바이",
            "빅토르",
            "블라디미르",
            "볼리베어",
            "워윅",
            "오공",
            "자야",
            "제라스",
            "신짜오",
            "야스오",
            "요네",
            "요릭",
            "유미",
            "자크",
            "제드",
            "직스",
            "질리언",
            "조이",
            "자이라"});
            this.cboxAliAd.Location = new System.Drawing.Point(119, 181);
            this.cboxAliAd.Name = "cboxAliAd";
            this.cboxAliAd.Size = new System.Drawing.Size(130, 20);
            this.cboxAliAd.TabIndex = 19;
            this.cboxAliAd.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // cboxAliSup
            // 
            this.cboxAliSup.FormattingEnabled = true;
            this.cboxAliSup.Items.AddRange(new object[] {
            "아트록스",
            "아리",
            "아칼리",
            "알리스타",
            "아무무",
            "애니비아",
            "애니",
            "아펠리오스",
            "애쉬",
            "아우렐리온솔",
            "아지르",
            "바드",
            "블리츠크랭크",
            "브랜드",
            "브라움",
            "케이틀린",
            "카밀",
            "카시오페아",
            "초카스",
            "코르키",
            "다리우스",
            "다이애나",
            "문도박사",
            "드레이븐",
            "에코",
            "엘리스",
            "이블린",
            "이즈리얼",
            "피들스틱",
            "피오라",
            "피즈",
            "갈리오",
            "갱플랭크",
            "가렌",
            "나르",
            "그라가스",
            "그레이브즈",
            "헤카림",
            "하이머딩거",
            "일라오이",
            "이렐리아",
            "아이번",
            "잔나",
            "자르반4세",
            "잭스",
            "제이스",
            "진",
            "징크스",
            "카이사",
            "칼리스타",
            "카르마",
            "카서스",
            "카사딘",
            "카타리나",
            "케일",
            "케인",
            "케넨",
            "카직스",
            "킨드레드",
            "클레드",
            "코그모",
            "르블랑",
            "리신",
            "레오나",
            "릴리아",
            "리산드라",
            "루시안",
            "룰루",
            "럭스",
            "말파이트",
            "말자하",
            "마오카이",
            "마스터이",
            "미스포츈",
            "모데카이저",
            "모르가나",
            "나미",
            "나서스",
            "노틸러스",
            "니코",
            "니달리",
            "녹턴",
            "누누와월럼프",
            "올라프",
            "오리아나",
            "오른",
            "판테온",
            "뽀삐",
            "파이크",
            "키아나",
            "퀸",
            "라칸",
            "람머스",
            "렉사이",
            "레넥톤",
            "렝가",
            "리븐",
            "럼블",
            "라이즈",
            "사미라",
            "세주아니",
            "세나",
            "세트",
            "샤코",
            "쉔",
            "쉬바나",
            "신지드",
            "사이온",
            "시비르",
            "스카너",
            "소나",
            "소라카",
            "스웨인",
            "사일러스",
            "신드라",
            "탐켄치",
            "탈리야",
            "탈론",
            "타릭",
            "티모",
            "쓰레쉬",
            "트리스타나",
            "트런들",
            "트린다미어",
            "트위스티드페이트",
            "트위치",
            "우디르",
            "우르곳",
            "바루스",
            "베인",
            "베이가",
            "벨코즈",
            "바이",
            "빅토르",
            "블라디미르",
            "볼리베어",
            "워윅",
            "오공",
            "자야",
            "제라스",
            "신짜오",
            "야스오",
            "요네",
            "요릭",
            "유미",
            "자크",
            "제드",
            "직스",
            "질리언",
            "조이",
            "자이라"});
            this.cboxAliSup.Location = new System.Drawing.Point(119, 212);
            this.cboxAliSup.Name = "cboxAliSup";
            this.cboxAliSup.Size = new System.Drawing.Size(130, 20);
            this.cboxAliSup.TabIndex = 20;
            this.cboxAliSup.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // cboxEnSup
            // 
            this.cboxEnSup.FormattingEnabled = true;
            this.cboxEnSup.Items.AddRange(new object[] {
            "아트록스",
            "아리",
            "아칼리",
            "알리스타",
            "아무무",
            "애니비아",
            "애니",
            "아펠리오스",
            "애쉬",
            "아우렐리온솔",
            "아지르",
            "바드",
            "블리츠크랭크",
            "브랜드",
            "브라움",
            "케이틀린",
            "카밀",
            "카시오페아",
            "초카스",
            "코르키",
            "다리우스",
            "다이애나",
            "문도박사",
            "드레이븐",
            "에코",
            "엘리스",
            "이블린",
            "이즈리얼",
            "피들스틱",
            "피오라",
            "피즈",
            "갈리오",
            "갱플랭크",
            "가렌",
            "나르",
            "그라가스",
            "그레이브즈",
            "헤카림",
            "하이머딩거",
            "일라오이",
            "이렐리아",
            "아이번",
            "잔나",
            "자르반4세",
            "잭스",
            "제이스",
            "진",
            "징크스",
            "카이사",
            "칼리스타",
            "카르마",
            "카서스",
            "카사딘",
            "카타리나",
            "케일",
            "케인",
            "케넨",
            "카직스",
            "킨드레드",
            "클레드",
            "코그모",
            "르블랑",
            "리신",
            "레오나",
            "릴리아",
            "리산드라",
            "루시안",
            "룰루",
            "럭스",
            "말파이트",
            "말자하",
            "마오카이",
            "마스터이",
            "미스포츈",
            "모데카이저",
            "모르가나",
            "나미",
            "나서스",
            "노틸러스",
            "니코",
            "니달리",
            "녹턴",
            "누누와월럼프",
            "올라프",
            "오리아나",
            "오른",
            "판테온",
            "뽀삐",
            "파이크",
            "키아나",
            "퀸",
            "라칸",
            "람머스",
            "렉사이",
            "레넥톤",
            "렝가",
            "리븐",
            "럼블",
            "라이즈",
            "사미라",
            "세주아니",
            "세나",
            "세트",
            "샤코",
            "쉔",
            "쉬바나",
            "신지드",
            "사이온",
            "시비르",
            "스카너",
            "소나",
            "소라카",
            "스웨인",
            "사일러스",
            "신드라",
            "탐켄치",
            "탈리야",
            "탈론",
            "타릭",
            "티모",
            "쓰레쉬",
            "트리스타나",
            "트런들",
            "트린다미어",
            "트위스티드페이트",
            "트위치",
            "우디르",
            "우르곳",
            "바루스",
            "베인",
            "베이가",
            "벨코즈",
            "바이",
            "빅토르",
            "블라디미르",
            "볼리베어",
            "워윅",
            "오공",
            "자야",
            "제라스",
            "신짜오",
            "야스오",
            "요네",
            "요릭",
            "유미",
            "자크",
            "제드",
            "직스",
            "질리언",
            "조이",
            "자이라"});
            this.cboxEnSup.Location = new System.Drawing.Point(119, 437);
            this.cboxEnSup.Name = "cboxEnSup";
            this.cboxEnSup.Size = new System.Drawing.Size(130, 20);
            this.cboxEnSup.TabIndex = 25;
            this.cboxEnSup.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // cboxEnAd
            // 
            this.cboxEnAd.FormattingEnabled = true;
            this.cboxEnAd.Items.AddRange(new object[] {
            "아트록스",
            "아리",
            "아칼리",
            "알리스타",
            "아무무",
            "애니비아",
            "애니",
            "아펠리오스",
            "애쉬",
            "아우렐리온솔",
            "아지르",
            "바드",
            "블리츠크랭크",
            "브랜드",
            "브라움",
            "케이틀린",
            "카밀",
            "카시오페아",
            "초카스",
            "코르키",
            "다리우스",
            "다이애나",
            "문도박사",
            "드레이븐",
            "에코",
            "엘리스",
            "이블린",
            "이즈리얼",
            "피들스틱",
            "피오라",
            "피즈",
            "갈리오",
            "갱플랭크",
            "가렌",
            "나르",
            "그라가스",
            "그레이브즈",
            "헤카림",
            "하이머딩거",
            "일라오이",
            "이렐리아",
            "아이번",
            "잔나",
            "자르반4세",
            "잭스",
            "제이스",
            "진",
            "징크스",
            "카이사",
            "칼리스타",
            "카르마",
            "카서스",
            "카사딘",
            "카타리나",
            "케일",
            "케인",
            "케넨",
            "카직스",
            "킨드레드",
            "클레드",
            "코그모",
            "르블랑",
            "리신",
            "레오나",
            "릴리아",
            "리산드라",
            "루시안",
            "룰루",
            "럭스",
            "말파이트",
            "말자하",
            "마오카이",
            "마스터이",
            "미스포츈",
            "모데카이저",
            "모르가나",
            "나미",
            "나서스",
            "노틸러스",
            "니코",
            "니달리",
            "녹턴",
            "누누와월럼프",
            "올라프",
            "오리아나",
            "오른",
            "판테온",
            "뽀삐",
            "파이크",
            "키아나",
            "퀸",
            "라칸",
            "람머스",
            "렉사이",
            "레넥톤",
            "렝가",
            "리븐",
            "럼블",
            "라이즈",
            "사미라",
            "세주아니",
            "세나",
            "세트",
            "샤코",
            "쉔",
            "쉬바나",
            "신지드",
            "사이온",
            "시비르",
            "스카너",
            "소나",
            "소라카",
            "스웨인",
            "사일러스",
            "신드라",
            "탐켄치",
            "탈리야",
            "탈론",
            "타릭",
            "티모",
            "쓰레쉬",
            "트리스타나",
            "트런들",
            "트린다미어",
            "트위스티드페이트",
            "트위치",
            "우디르",
            "우르곳",
            "바루스",
            "베인",
            "베이가",
            "벨코즈",
            "바이",
            "빅토르",
            "블라디미르",
            "볼리베어",
            "워윅",
            "오공",
            "자야",
            "제라스",
            "신짜오",
            "야스오",
            "요네",
            "요릭",
            "유미",
            "자크",
            "제드",
            "직스",
            "질리언",
            "조이",
            "자이라"});
            this.cboxEnAd.Location = new System.Drawing.Point(119, 406);
            this.cboxEnAd.Name = "cboxEnAd";
            this.cboxEnAd.Size = new System.Drawing.Size(130, 20);
            this.cboxEnAd.TabIndex = 24;
            this.cboxEnAd.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // cboxEnMid
            // 
            this.cboxEnMid.FormattingEnabled = true;
            this.cboxEnMid.Items.AddRange(new object[] {
            "아트록스",
            "아리",
            "아칼리",
            "알리스타",
            "아무무",
            "애니비아",
            "애니",
            "아펠리오스",
            "애쉬",
            "아우렐리온솔",
            "아지르",
            "바드",
            "블리츠크랭크",
            "브랜드",
            "브라움",
            "케이틀린",
            "카밀",
            "카시오페아",
            "초카스",
            "코르키",
            "다리우스",
            "다이애나",
            "문도박사",
            "드레이븐",
            "에코",
            "엘리스",
            "이블린",
            "이즈리얼",
            "피들스틱",
            "피오라",
            "피즈",
            "갈리오",
            "갱플랭크",
            "가렌",
            "나르",
            "그라가스",
            "그레이브즈",
            "헤카림",
            "하이머딩거",
            "일라오이",
            "이렐리아",
            "아이번",
            "잔나",
            "자르반4세",
            "잭스",
            "제이스",
            "진",
            "징크스",
            "카이사",
            "칼리스타",
            "카르마",
            "카서스",
            "카사딘",
            "카타리나",
            "케일",
            "케인",
            "케넨",
            "카직스",
            "킨드레드",
            "클레드",
            "코그모",
            "르블랑",
            "리신",
            "레오나",
            "릴리아",
            "리산드라",
            "루시안",
            "룰루",
            "럭스",
            "말파이트",
            "말자하",
            "마오카이",
            "마스터이",
            "미스포츈",
            "모데카이저",
            "모르가나",
            "나미",
            "나서스",
            "노틸러스",
            "니코",
            "니달리",
            "녹턴",
            "누누와월럼프",
            "올라프",
            "오리아나",
            "오른",
            "판테온",
            "뽀삐",
            "파이크",
            "키아나",
            "퀸",
            "라칸",
            "람머스",
            "렉사이",
            "레넥톤",
            "렝가",
            "리븐",
            "럼블",
            "라이즈",
            "사미라",
            "세주아니",
            "세나",
            "세트",
            "샤코",
            "쉔",
            "쉬바나",
            "신지드",
            "사이온",
            "시비르",
            "스카너",
            "소나",
            "소라카",
            "스웨인",
            "사일러스",
            "신드라",
            "탐켄치",
            "탈리야",
            "탈론",
            "타릭",
            "티모",
            "쓰레쉬",
            "트리스타나",
            "트런들",
            "트린다미어",
            "트위스티드페이트",
            "트위치",
            "우디르",
            "우르곳",
            "바루스",
            "베인",
            "베이가",
            "벨코즈",
            "바이",
            "빅토르",
            "블라디미르",
            "볼리베어",
            "워윅",
            "오공",
            "자야",
            "제라스",
            "신짜오",
            "야스오",
            "요네",
            "요릭",
            "유미",
            "자크",
            "제드",
            "직스",
            "질리언",
            "조이",
            "자이라"});
            this.cboxEnMid.Location = new System.Drawing.Point(119, 376);
            this.cboxEnMid.Name = "cboxEnMid";
            this.cboxEnMid.Size = new System.Drawing.Size(130, 20);
            this.cboxEnMid.TabIndex = 23;
            this.cboxEnMid.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // cboxEnJungle
            // 
            this.cboxEnJungle.FormattingEnabled = true;
            this.cboxEnJungle.Items.AddRange(new object[] {
            "아트록스",
            "아리",
            "아칼리",
            "알리스타",
            "아무무",
            "애니비아",
            "애니",
            "아펠리오스",
            "애쉬",
            "아우렐리온솔",
            "아지르",
            "바드",
            "블리츠크랭크",
            "브랜드",
            "브라움",
            "케이틀린",
            "카밀",
            "카시오페아",
            "초카스",
            "코르키",
            "다리우스",
            "다이애나",
            "문도박사",
            "드레이븐",
            "에코",
            "엘리스",
            "이블린",
            "이즈리얼",
            "피들스틱",
            "피오라",
            "피즈",
            "갈리오",
            "갱플랭크",
            "가렌",
            "나르",
            "그라가스",
            "그레이브즈",
            "헤카림",
            "하이머딩거",
            "일라오이",
            "이렐리아",
            "아이번",
            "잔나",
            "자르반4세",
            "잭스",
            "제이스",
            "진",
            "징크스",
            "카이사",
            "칼리스타",
            "카르마",
            "카서스",
            "카사딘",
            "카타리나",
            "케일",
            "케인",
            "케넨",
            "카직스",
            "킨드레드",
            "클레드",
            "코그모",
            "르블랑",
            "리신",
            "레오나",
            "릴리아",
            "리산드라",
            "루시안",
            "룰루",
            "럭스",
            "말파이트",
            "말자하",
            "마오카이",
            "마스터이",
            "미스포츈",
            "모데카이저",
            "모르가나",
            "나미",
            "나서스",
            "노틸러스",
            "니코",
            "니달리",
            "녹턴",
            "누누와월럼프",
            "올라프",
            "오리아나",
            "오른",
            "판테온",
            "뽀삐",
            "파이크",
            "키아나",
            "퀸",
            "라칸",
            "람머스",
            "렉사이",
            "레넥톤",
            "렝가",
            "리븐",
            "럼블",
            "라이즈",
            "사미라",
            "세주아니",
            "세나",
            "세트",
            "샤코",
            "쉔",
            "쉬바나",
            "신지드",
            "사이온",
            "시비르",
            "스카너",
            "소나",
            "소라카",
            "스웨인",
            "사일러스",
            "신드라",
            "탐켄치",
            "탈리야",
            "탈론",
            "타릭",
            "티모",
            "쓰레쉬",
            "트리스타나",
            "트런들",
            "트린다미어",
            "트위스티드페이트",
            "트위치",
            "우디르",
            "우르곳",
            "바루스",
            "베인",
            "베이가",
            "벨코즈",
            "바이",
            "빅토르",
            "블라디미르",
            "볼리베어",
            "워윅",
            "오공",
            "자야",
            "제라스",
            "신짜오",
            "야스오",
            "요네",
            "요릭",
            "유미",
            "자크",
            "제드",
            "직스",
            "질리언",
            "조이",
            "자이라"});
            this.cboxEnJungle.Location = new System.Drawing.Point(119, 345);
            this.cboxEnJungle.Name = "cboxEnJungle";
            this.cboxEnJungle.Size = new System.Drawing.Size(130, 20);
            this.cboxEnJungle.TabIndex = 22;
            this.cboxEnJungle.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // cboxEnTop
            // 
            this.cboxEnTop.FormattingEnabled = true;
            this.cboxEnTop.Items.AddRange(new object[] {
            "아트록스",
            "아리",
            "아칼리",
            "알리스타",
            "아무무",
            "애니비아",
            "애니",
            "아펠리오스",
            "애쉬",
            "아우렐리온솔",
            "아지르",
            "바드",
            "블리츠크랭크",
            "브랜드",
            "브라움",
            "케이틀린",
            "카밀",
            "카시오페아",
            "초카스",
            "코르키",
            "다리우스",
            "다이애나",
            "문도박사",
            "드레이븐",
            "에코",
            "엘리스",
            "이블린",
            "이즈리얼",
            "피들스틱",
            "피오라",
            "피즈",
            "갈리오",
            "갱플랭크",
            "가렌",
            "나르",
            "그라가스",
            "그레이브즈",
            "헤카림",
            "하이머딩거",
            "일라오이",
            "이렐리아",
            "아이번",
            "잔나",
            "자르반4세",
            "잭스",
            "제이스",
            "진",
            "징크스",
            "카이사",
            "칼리스타",
            "카르마",
            "카서스",
            "카사딘",
            "카타리나",
            "케일",
            "케인",
            "케넨",
            "카직스",
            "킨드레드",
            "클레드",
            "코그모",
            "르블랑",
            "리신",
            "레오나",
            "릴리아",
            "리산드라",
            "루시안",
            "룰루",
            "럭스",
            "말파이트",
            "말자하",
            "마오카이",
            "마스터이",
            "미스포츈",
            "모데카이저",
            "모르가나",
            "나미",
            "나서스",
            "노틸러스",
            "니코",
            "니달리",
            "녹턴",
            "누누와월럼프",
            "올라프",
            "오리아나",
            "오른",
            "판테온",
            "뽀삐",
            "파이크",
            "키아나",
            "퀸",
            "라칸",
            "람머스",
            "렉사이",
            "레넥톤",
            "렝가",
            "리븐",
            "럼블",
            "라이즈",
            "사미라",
            "세주아니",
            "세나",
            "세트",
            "샤코",
            "쉔",
            "쉬바나",
            "신지드",
            "사이온",
            "시비르",
            "스카너",
            "소나",
            "소라카",
            "스웨인",
            "사일러스",
            "신드라",
            "탐켄치",
            "탈리야",
            "탈론",
            "타릭",
            "티모",
            "쓰레쉬",
            "트리스타나",
            "트런들",
            "트린다미어",
            "트위스티드페이트",
            "트위치",
            "우디르",
            "우르곳",
            "바루스",
            "베인",
            "베이가",
            "벨코즈",
            "바이",
            "빅토르",
            "블라디미르",
            "볼리베어",
            "워윅",
            "오공",
            "자야",
            "제라스",
            "신짜오",
            "야스오",
            "요네",
            "요릭",
            "유미",
            "자크",
            "제드",
            "직스",
            "질리언",
            "조이",
            "자이라"});
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
            this.cboxGameNumber.FormattingEnabled = true;
            this.cboxGameNumber.Location = new System.Drawing.Point(359, 27);
            this.cboxGameNumber.Name = "cboxGameNumber";
            this.cboxGameNumber.Size = new System.Drawing.Size(121, 20);
            this.cboxGameNumber.TabIndex = 28;
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(301, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1173, 181);
            this.dataGridView1.TabIndex = 30;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(301, 300);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1173, 181);
            this.dataGridView2.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
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
    }
}

