using LoL_Assistant.Properties;
using LOL_Assistant;
using Newtonsoft.Json.Linq;
using NSoup;
using NSoup.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoL_Assistant
{
    public partial class Form1 : Form
    {
        bool loop = false;
        int nowGameNumber = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public Document GetResponse(string apiUrl)
        {
            Document doc = null;
            string strHttp = "";

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
                request.Method = "GET";
                request.ContentType = "text/html; charset=UTF-8";
                // 커스텀 헤더가 필요한 경우(인증 토큰 등)
                // request.Headers.Add("custom-api-param", "value");

                var httpResponse = (HttpWebResponse)request.GetResponse();

                // HttpStatusCode의 판단이 필요한 경우
                if (httpResponse.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("API호출에 실패");
                }

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    strHttp = streamReader.ReadToEnd();
                }

                doc = NSoupClient.Parse(strHttp);
            }
            catch (WebException wex)
            {
                Console.WriteLine(wex);
            }

            return doc;
        }

        public List<string> GetTrend(string champName, string position)
        {
            List<string> ret = new List<string>();

            var apiUrl = $"http://www.op.gg/champion/{champName}/statistics/{position}/trend";
            Document doc = GetResponse(apiUrl);

            string[] resSplit = null;

            foreach (var script in doc.Select("script"))
            {
                if (script.Data.IndexOf("Trend-Detail-GameLengthWinRateGraph") >= 0)
                {
                    resSplit = script.Data.Split('[');
                    Console.WriteLine(resSplit[2]);

                    break;
                }
            }

            Regex r = new Regex("{\"y\":(?'ONE'[0-9]*\\.[0-9]*).*{\"y\":(?'TWO'[0-9]*\\.[0-9]*).*{\"y\":(?'THREE'[0-9]*\\.[0-9]*).*{\"y\":(?'FOUR'[0-9]*\\.[0-9]*).*{\"y\":(?'FIVE'[0-9]*\\.[0-9]*).*");
            Match m = r.Match(resSplit[2]);

            string one = "";
            string two = "";
            string three = "";
            string four = "";
            string five = "";

            if (m.Success)
            {
                string[] groupNames = r.GetGroupNames();

                foreach (var name in groupNames)
                {
                    if (name == "ONE")
                        one = m.Groups[name].Value;
                    else if (name == "TWO")
                        two = m.Groups[name].Value;
                    else if (name == "THREE")
                        three = m.Groups[name].Value;
                    else if (name == "FOUR")
                        four = m.Groups[name].Value;
                    else if (name == "FIVE")
                        five = m.Groups[name].Value;
                }
            }

            ret.Add(one);
            ret.Add(two);
            ret.Add(three);
            ret.Add(four);
            ret.Add(five);

            return ret;
        }

        async private void btnStart_Click(object sender, EventArgs e)
        {
            loop = true;
            labStatus.Text = "실행중";
            SoundPlayer simpleSound = null;
            
            while (loop)
            {
                try
                {
                    Process[] allProc = Process.GetProcesses();    //시스템의 모든 프로세스 정보 출력
                    
                    foreach (Process p in allProc)
                    {
                        if (p.ProcessName.IndexOf("League of Legends") >= 0)
                        {
                            var rand = new Random();
                            int ranNum = rand.Next(0, 4);

                            if (ranNum == 0)
                                simpleSound = new SoundPlayer(Resources.맵봐맵);
                            else if (ranNum == 1)
                                simpleSound = new SoundPlayer(Resources.미니맵);
                            else if (ranNum == 2)
                                simpleSound = new SoundPlayer(Resources.정글위치확인);
                            else if (ranNum == 3)
                                simpleSound = new SoundPlayer(Resources.췤);
                            simpleSound.Play();
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                await Task.Delay(10000);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            loop = false;
            labStatus.Text = "정지됨";
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            ComboBox cbox = (ComboBox)sender;
            if (cbox.Name.IndexOf("Ali") >= 0)
            {
                if (cbox.Name.IndexOf("Top") >= 0)
                {
                    Console.WriteLine(cbox.Name);
                    List<string> trend = GetTrend(cbox.Text, "top");
                }
                else if (cbox.Name.IndexOf("Jungle") >= 0)
                {
                    Console.WriteLine(cbox.Name);
                    List<string> trend = GetTrend(cbox.Text, "jungle");
                }
                else if (cbox.Name.IndexOf("Mid") >= 0)
                {
                    Console.WriteLine(cbox.Name);
                    List<string> trend = GetTrend(cbox.Text, "mid");
                }
                else if (cbox.Name.IndexOf("Ad") >= 0)
                {
                    Console.WriteLine(cbox.Name);
                    List<string> trend = GetTrend(cbox.Text, "bot");
                }
                else if (cbox.Name.IndexOf("Sup") >= 0)
                {
                    Console.WriteLine(cbox.Name);
                    List<string> trend = GetTrend(cbox.Text, "support");
                }
            }
            else if (cbox.Name.IndexOf("En") >= 0)
            {
                if (cbox.Name.IndexOf("Top") >= 0)
                {
                    Console.WriteLine(cbox.Name);
                }
                else if (cbox.Name.IndexOf("Jungle") >= 0)
                {
                    Console.WriteLine(cbox.Name);
                }
                else if (cbox.Name.IndexOf("Mid") >= 0)
                {
                    Console.WriteLine(cbox.Name);
                }
                else if (cbox.Name.IndexOf("Ad") >= 0)
                {
                    Console.WriteLine(cbox.Name);
                }
                else if (cbox.Name.IndexOf("Sup") >= 0)
                {
                    Console.WriteLine(cbox.Name);
                }
            }
            else
            {
                throw new Exception("Unknown Exception...");
            }
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            SQLite db = SQLite.Instance;
            DataTable dt = db.ReadTable("SELECT Number FROM (SELECT ROW_NUMBER() OVER (ORDER BY Number DESC) rownum, * FROM Games) t WHERE t.rownum <= 1");

            if (dt.Rows.Count == 0)
            {
                nowGameNumber = 1;
            }
            else
            {
                nowGameNumber = (int)dt.Rows[0]["Number"];
                nowGameNumber += 1;
            }

            string id = Guid.NewGuid().ToString();
            db.Write($"INSER INTO GameInfo (ID, Date, Number) VALUES ('{id}', '{dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")}, {nowGameNumber}')");

            cboxGameNumber.Text = nowGameNumber.ToString();
        }
    }
}
