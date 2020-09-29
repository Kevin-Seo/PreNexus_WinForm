﻿using LoL_Assistant.Properties;
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
        bool loop = true;
        int nowGameNumber = 0;
        string nowGameID = "";
        bool nowGameSaved = false;

        string lastAliTop = "";
        string lastAliJungle = "";
        string lastAliMid = "";
        string lastAliAd = "";
        string lastAliSup = "";
        string lastEnTop = "";
        string lastEnJungle = "";
        string lastEnMid = "";
        string lastEnAd = "";
        string lastEnSup = "";

        public Form1()
        {
            InitializeComponent();

            PlaySounds();

            LoadChamps();
            LoadGameInfo();
        }

        async public void PlaySounds()
        {
            SoundPlayer simpleSound = null;
            bool obs = false;

            while (true)
            {
                obs = false;

                if (loop)
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
                            }

                            if (p.ProcessName.IndexOf("obs64") >= 0)
                            {
                                obs = true;
                                labRecord.Text = "OBS ON";
                                labRecord.ForeColor = Color.Lime;
                            }
                        }

                        if (!obs)
                        {
                            labRecord.Text = "OBS OFF";
                            labRecord.ForeColor = Color.Red;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                await Task.Delay(10000);
            }
        }

        public void LoadGameInfo(int number = 0)
        {
            // Step 1.
            cboxGameNumber.Items.Clear();
            cboxAliTop.Text = "";
            cboxAliJungle.Text = "";
            cboxAliMid.Text = "";
            cboxAliAd.Text = "";
            cboxAliSup.Text = "";
            cboxEnTop.Text = "";
            cboxEnJungle.Text = "";
            cboxEnMid.Text = "";
            cboxEnAd.Text = "";
            cboxEnSup.Text = "";
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            nowGameSaved = false;
            tboxComment.Text = "";
            tboxVsChamp.Text = "";
            tboxVs1.Text = "";
            tboxVs2.Text = "";
            tboxVs3.Text = "";

            SQLite db = SQLite.Instance;
            DataTable dt = db.ReadTable($"SELECT * FROM GameInfo WHERE Date in ('{dateTimePicker1.Value.ToString("yyyy-MM-dd")}') ORDER BY Number ASC");

            if (dt.Rows.Count == 0)
            {
                nowGameID = "";
                nowGameNumber = 0;
                cboxGameNumber.Text = "";
                return;
            }

            foreach (DataRow dr in dt.Rows)
            {
                cboxGameNumber.Items.Add(dr["Number"]);
            }

            
            nowGameNumber = number != 0 ? number : (int)dt.Rows[dt.Rows.Count - 1]["Number"];
            nowGameID = number != 0 ? (string)dt.Rows[number-1]["ID"] : (string)dt.Rows[dt.Rows.Count - 1]["ID"];
            cboxGameNumber.Text = nowGameNumber.ToString();

            nowGameSaved = number != 0 ? (bool)dt.Rows[number - 1]["Save"] : (bool)dt.Rows[dt.Rows.Count - 1]["Save"];

            // Step 2.
            dt = db.ReadTable($"SELECT * FROM GameRepository WHERE ID in ('{nowGameID}')");
            if (dt.Rows.Count == 0)
            {
                cboxAliTop.Text = "";
                cboxAliJungle.Text = "";
                cboxAliMid.Text = "";
                cboxAliAd.Text = "";
                cboxAliSup.Text = "";
                cboxEnTop.Text = "";
                cboxEnJungle.Text = "";
                cboxEnMid.Text = "";
                cboxEnAd.Text = "";
                cboxEnSup.Text = "";
                return;
            }

            foreach (DataRow dr in dt.Rows)
            {
                string team = (string)dr["Team"];
                string pos = (string)dr["Position"];
                string champ = (string)dr["Champ"];

                if (team == "Ali")
                {
                    if (pos == "Top")
                    {
                        cboxAliTop.Text = champ;
                    }
                    else if (pos == "Jungle")
                    {
                        cboxAliJungle.Text = champ;
                    }
                    else if (pos == "Mid")
                    {
                        cboxAliMid.Text = champ;
                    }
                    else if (pos == "Ad")
                    {
                        cboxAliAd.Text = champ;
                    }
                    else if (pos == "Sup")
                    {
                        cboxAliSup.Text = champ;
                    }
                }
                else if (team == "En")
                {
                    if (pos == "Top")
                    {
                        cboxEnTop.Text = champ;
                    }
                    else if (pos == "Jungle")
                    {
                        cboxEnJungle.Text = champ;
                    }
                    else if (pos == "Mid")
                    {
                        cboxEnMid.Text = champ;
                    }
                    else if (pos == "Ad")
                    {
                        cboxEnAd.Text = champ;
                    }
                    else if (pos == "Sup")
                    {
                        cboxEnSup.Text = champ;
                    }
                }
                else
                {
                    throw new Exception("Unknown Error...");
                }
            }

            // Step 3.
            dt = db.ReadTable($"SELECT Comment, Save FROM GameInfo WHERE ID in ('{nowGameID}')");
            tboxComment.Text = (string)dt.Rows[0]["Comment"];
        }

        public void LoadChamps()
        {
            SQLite db = SQLite.Instance;

            DataTable dt = db.ReadTable($"SELECT * FROM Champs ORDER BY EnName");
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cboxAliTop.Items.Add((string)dr["KorName"]);
                    cboxAliJungle.Items.Add((string)dr["KorName"]);
                    cboxAliMid.Items.Add((string)dr["KorName"]);
                    cboxAliAd.Items.Add((string)dr["KorName"]);
                    cboxAliSup.Items.Add((string)dr["KorName"]);

                    cboxEnTop.Items.Add((string)dr["KorName"]);
                    cboxEnJungle.Items.Add((string)dr["KorName"]);
                    cboxEnMid.Items.Add((string)dr["KorName"]);
                    cboxEnAd.Items.Add((string)dr["KorName"]);
                    cboxEnSup.Items.Add((string)dr["KorName"]);
                }
            }

            dt = db.ReadTable($"SELECT * FROM MyInfo WHERE IsMain=true");
            if (dt.Rows.Count > 0)
            {
                cboxMainPos.Text = (string)dt.Rows[0]["Position"];
                tboxMainPos.Text = (string)dt.Rows[0]["Champ"];
            }

            dt = db.ReadTable($"SELECT * FROM MyInfo WHERE IsMain=false");
            if (dt.Rows.Count > 0)
            {
                cboxSubPos.Text = (string)dt.Rows[0]["Position"];
                tboxSubPos.Text = (string)dt.Rows[0]["Champ"];
            }
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

            Regex r = new Regex("{\"y\":(?'ONE'[0-9]*\\.?[0-9]*).*{\"y\":(?'TWO'[0-9]*\\.?[0-9]*).*{\"y\":(?'THREE'[0-9]*\\.?[0-9]*).*{\"y\":(?'FOUR'[0-9]*\\.?[0-9]*).*{\"y\":(?'FIVE'[0-9]*\\.?[0-9]*).*");
            Match m = r.Match(resSplit[2]);

            string one = "0";
            string two = "0";
            string three = "0";
            string four = "0";
            string five = "0";

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

        public void SetTrend(string team, string pos, string champ, List<string> trend)
        {
            SQLite db = SQLite.Instance;
            db.Write($"DELETE FROM GameRepository WHERE ID in ('{nowGameID}') AND Team in ('{team}') AND Position in ('{pos}')");
            db.Write($"INSERT INTO GameRepository (ID, Team, Position, Champ, Trend1, Trend2, Trend3, Trend4, Trend5) VALUES ('{nowGameID}', '{team}', '{pos}', '{champ}', {trend[0]}, {trend[1]}, {trend[2]}, {trend[3]}, {trend[4]})");
        }

        public List<string> GetLineRate(string pos, string AliOpID, string EnOpID)
        {
            List<string> ret = new List<string>();

            var apiUrl = $"http://www.op.gg/champion/ajax/statistics/counterChampion/championId={AliOpID}&targetChampionId={EnOpID}&position={pos}";
            Document doc = GetResponse(apiUrl);

            string tmpTr = "";

            foreach (var tr in doc.Select("tr"))
            {
                if (pos != "jungle")
                {
                    if (tr.Children.Text.IndexOf("Lane Kill Rate") >= 0 || tr.Children.Text.IndexOf("라인킬 확률") >= 0)
                    {
                        tmpTr = tr.Children.Text;
                        break;
                    }
                }
                else // == jungle
                {
                    if (tr.Children.Text.IndexOf("Kill Participation") >= 0 || tr.Children.Text.IndexOf("킬관여율") >= 0)
                    {
                        tmpTr = tr.Children.Text;
                        break;
                    }
                }
                
            }

            Regex r = new Regex(@"(?'ALI'[0-9]*\.?[0-9]*)\%{1} .* (?'EN'[0-9]*\.?[0-9]*)\%{1}");
            Match m = r.Match(tmpTr);

            string ali = "0";
            string en = "0";

            if (m.Success)
            {
                string[] groupNames = r.GetGroupNames();

                foreach (var name in groupNames)
                {
                    if (name == "ALI")
                        ali = m.Groups[name].Value;
                    else if (name == "EN")
                        en = m.Groups[name].Value;
                }
            }

            ret.Add(ali);
            ret.Add(en);

            return ret;
        }

        public List<string> GetWinRate(string pos, string AliOpID, string EnOpID)
        {
            List<string> ret = new List<string>();

            var apiUrl = $"http://www.op.gg/champion/ajax/statistics/counterChampion/championId={AliOpID}&targetChampionId={EnOpID}&position={pos}";
            Document doc = GetResponse(apiUrl);

            string tmpTr = "";

            foreach (var tr in doc.Select("tr"))
            {
                if (tr.Children.Text.IndexOf("Win Ratio") >= 0 || tr.Children.Text.IndexOf("승률") >= 0)
                {
                    tmpTr = tr.Children.Text;
                    break;
                }
            }

            Regex r = new Regex(@"(?'ALI'[0-9]*\.?[0-9]*)\%{1} .* (?'EN'[0-9]*\.?[0-9]*)\%{1}");
            Match m = r.Match(tmpTr);

            string ali = "0";
            string en = "0";

            if (m.Success)
            {
                string[] groupNames = r.GetGroupNames();

                foreach (var name in groupNames)
                {
                    if (name == "ALI")
                        ali = m.Groups[name].Value;
                    else if (name == "EN")
                        en = m.Groups[name].Value;
                }
            }

            ret.Add(ali);
            ret.Add(en);

            return ret;
        }

        public void SetLineRate(string pos, List<string> rate)
        {
            SQLite db = SQLite.Instance;
            db.Write($"UPDATE GameRepository SET LineRate='{rate[0]}' WHERE ID in ('{nowGameID}') AND Team in ('Ali') AND Position in ('{pos}')");
            db.Write($"UPDATE GameRepository SET LineRate='{rate[1]}' WHERE ID in ('{nowGameID}') AND Team in ('En') AND Position in ('{pos}')");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            loop = true;
            labStatus.Text = "실행중";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            loop = false;
            labStatus.Text = "정지됨";
        }

        async private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            ComboBox cbox = (ComboBox)sender;

            bool isAliTopChanged = false;
            bool isAliJungleChanged = false;
            bool isAliMidChanged = false;
            bool isAliAdChanged = false;
            bool isAliSupChanged = false;
            bool isEnTopChanged = false;
            bool isEnJungleChanged = false;
            bool isEnMidChanged = false;
            bool isEnAdChanged = false;
            bool isEnSupChanged = false;

            if (!cbox.Items.Contains(cbox.Text)) return;

            if (cboxAliTop.Text != lastAliTop)
            {
                isAliTopChanged = true;
                lastAliTop = cboxAliTop.Text;
            }
            if (cboxAliJungle.Text != lastAliJungle)
            {
                isAliJungleChanged = true;
                lastAliJungle = cboxAliJungle.Text;
            }
            if (cboxAliMid.Text != lastAliMid)
            {
                isAliMidChanged = true;
                lastAliMid = cboxAliMid.Text;
            }
            if (cboxAliAd.Text != lastAliAd)
            {
                isAliAdChanged = true;
                lastAliAd = cboxAliAd.Text;
            }
            if (cboxAliSup.Text != lastAliSup)
            {
                isAliSupChanged = true;
                lastAliSup = cboxAliSup.Text;
            }
            if (cboxEnTop.Text != lastEnTop)
            {
                isEnTopChanged = true;
                lastEnTop = cboxEnTop.Text;
            }
            if (cboxEnJungle.Text != lastEnJungle)
            {
                isEnJungleChanged = true;
                lastEnJungle = cboxEnJungle.Text;
            }
            if (cboxEnMid.Text != lastEnMid)
            {
                isEnMidChanged = true;
                lastEnMid = cboxEnMid.Text;
            }
            if (cboxEnAd.Text != lastEnAd)
            {
                isEnAdChanged = true;
                lastEnAd = cboxEnAd.Text;
            }
            if (cboxEnSup.Text != lastEnSup)
            {
                isEnSupChanged = true;
                lastEnSup = cboxEnSup.Text;
            }

            string cboxtext = cbox.Text;

            await Task.Run(() =>
            {
                if (nowGameSaved) return;

                if (cbox.Name.IndexOf("Ali") >= 0)
                {
                    if (cbox.Name.IndexOf("Top") >= 0 && isAliTopChanged)
                    {
                        SQLite db = SQLite.Instance;
                        DataTable dt = db.ReadTable($"SELECT EnName FROM Champs WHERE KorName in ('{cboxtext}')");
                        string engName = (string)dt.Rows[0]["EnName"];

                        List<string> trend = GetTrend(engName, "top");
                        SetTrend("Ali", "Top", cboxtext, trend);
                    }
                    else if (cbox.Name.IndexOf("Jungle") >= 0 && isAliJungleChanged)
                    {
                        SQLite db = SQLite.Instance;
                        DataTable dt = db.ReadTable($"SELECT EnName FROM Champs WHERE KorName in ('{cboxtext}')");
                        string engName = (string)dt.Rows[0]["EnName"];

                        List<string> trend = GetTrend(engName, "jungle");
                        SetTrend("Ali", "Jungle", cboxtext, trend);
                    }
                    else if (cbox.Name.IndexOf("Mid") >= 0 && isAliMidChanged)
                    {
                        SQLite db = SQLite.Instance;
                        DataTable dt = db.ReadTable($"SELECT EnName FROM Champs WHERE KorName in ('{cboxtext}')");
                        string engName = (string)dt.Rows[0]["EnName"];

                        List<string> trend = GetTrend(engName, "mid");
                        SetTrend("Ali", "Mid", cboxtext, trend);
                    }
                    else if (cbox.Name.IndexOf("Ad") >= 0 && isAliAdChanged)
                    {
                        SQLite db = SQLite.Instance;
                        DataTable dt = db.ReadTable($"SELECT EnName FROM Champs WHERE KorName in ('{cboxtext}')");
                        string engName = (string)dt.Rows[0]["EnName"];

                        List<string> trend = GetTrend(engName, "bot");
                        SetTrend("Ali", "Ad", cboxtext, trend);
                    }
                    else if (cbox.Name.IndexOf("Sup") >= 0 && isAliSupChanged)
                    {
                        SQLite db = SQLite.Instance;
                        DataTable dt = db.ReadTable($"SELECT EnName FROM Champs WHERE KorName in ('{cboxtext}')");
                        string engName = (string)dt.Rows[0]["EnName"];

                        List<string> trend = GetTrend(engName, "support");
                        SetTrend("Ali", "Sup", cboxtext, trend);
                    }
                }
                else if (cbox.Name.IndexOf("En") >= 0)
                {
                    if (cbox.Name.IndexOf("Top") >= 0 && isEnTopChanged)
                    {
                        SQLite db = SQLite.Instance;
                        DataTable dt = db.ReadTable($"SELECT EnName FROM Champs WHERE KorName in ('{cboxtext}')");
                        string engName = (string)dt.Rows[0]["EnName"];

                        List<string> trend = GetTrend(engName, "top");
                        SetTrend("En", "Top", cboxtext, trend);
                    }
                    else if (cbox.Name.IndexOf("Jungle") >= 0 && isEnJungleChanged)
                    {
                        SQLite db = SQLite.Instance;
                        DataTable dt = db.ReadTable($"SELECT EnName FROM Champs WHERE KorName in ('{cboxtext}')");
                        string engName = (string)dt.Rows[0]["EnName"];

                        List<string> trend = GetTrend(engName, "jungle");
                        SetTrend("En", "Jungle", cboxtext, trend);
                    }
                    else if (cbox.Name.IndexOf("Mid") >= 0 && isEnMidChanged)
                    {
                        SQLite db = SQLite.Instance;
                        DataTable dt = db.ReadTable($"SELECT EnName FROM Champs WHERE KorName in ('{cboxtext}')");
                        string engName = (string)dt.Rows[0]["EnName"];

                        List<string> trend = GetTrend(engName, "mid");
                        SetTrend("En", "Mid", cboxtext, trend);
                    }
                    else if (cbox.Name.IndexOf("Ad") >= 0 && isEnAdChanged)
                    {
                        SQLite db = SQLite.Instance;
                        DataTable dt = db.ReadTable($"SELECT EnName FROM Champs WHERE KorName in ('{cboxtext}')");
                        string engName = (string)dt.Rows[0]["EnName"];

                        List<string> trend = GetTrend(engName, "bot");
                        SetTrend("En", "Ad", cboxtext, trend);
                    }
                    else if (cbox.Name.IndexOf("Sup") >= 0 && isEnSupChanged)
                    {
                        SQLite db = SQLite.Instance;
                        DataTable dt = db.ReadTable($"SELECT EnName FROM Champs WHERE KorName in ('{cboxtext}')");
                        string engName = (string)dt.Rows[0]["EnName"];

                        List<string> trend = GetTrend(engName, "support");
                        SetTrend("En", "Sup", cboxtext, trend);
                    }
                }
                else
                {
                    throw new Exception("Unknown Exception...");
                }
            });

            string cboxAliTopText = cboxAliTop.Text;
            string cboxAliJungleText = cboxAliJungle.Text;
            string cboxAliMidText = cboxAliMid.Text;
            string cboxAliAdText = cboxAliAd.Text;
            string cboxAliSupText = cboxAliSup.Text;
            string cboxEnTopText = cboxEnTop.Text;
            string cboxEnJungleText = cboxEnJungle.Text;
            string cboxEnMidText = cboxEnMid.Text;
            string cboxEnAdText = cboxEnAd.Text;
            string cboxEnSupText = cboxEnSup.Text;

            await Task.Run(() =>
            {
                if (nowGameSaved) return;

                if ((isAliTopChanged || isEnTopChanged) && cboxAliTopText != "" && cboxEnTopText != "")
                {
                    SQLite db = SQLite.Instance;
                    DataTable dt;
                    dt = db.ReadTable($"SELECT OpggID FROM Champs WHERE KorName in ('{cboxAliTopText}')");
                    string AliOpID = (string)dt.Rows[0]["OpggID"];
                    dt = db.ReadTable($"SELECT OpggID FROM Champs WHERE KorName in ('{cboxEnTopText}')");
                    string EnOpID = (string)dt.Rows[0]["OpggID"];

                    List<string> lineRate = GetLineRate("top", AliOpID, EnOpID);
                    SetLineRate("Top", lineRate);
                }
                else if ((isAliJungleChanged || isEnJungleChanged) && cboxAliJungleText != "" && cboxEnJungleText != "")
                {
                    SQLite db = SQLite.Instance;
                    DataTable dt;
                    dt = db.ReadTable($"SELECT OpggID FROM Champs WHERE KorName in ('{cboxAliJungleText}')");
                    string AliOpID = (string)dt.Rows[0]["OpggID"];
                    dt = db.ReadTable($"SELECT OpggID FROM Champs WHERE KorName in ('{cboxEnJungleText}')");
                    string EnOpID = (string)dt.Rows[0]["OpggID"];

                    List<string> lineRate = GetLineRate("jungle", AliOpID, EnOpID);
                    SetLineRate("Jungle", lineRate);
                }
                else if ((isAliMidChanged || isEnMidChanged) && cboxAliMidText != "" && cboxEnMidText != "")
                {
                    SQLite db = SQLite.Instance;
                    DataTable dt;
                    dt = db.ReadTable($"SELECT OpggID FROM Champs WHERE KorName in ('{cboxAliMidText}')");
                    string AliOpID = (string)dt.Rows[0]["OpggID"];
                    dt = db.ReadTable($"SELECT OpggID FROM Champs WHERE KorName in ('{cboxEnMidText}')");
                    string EnOpID = (string)dt.Rows[0]["OpggID"];

                    List<string> lineRate = GetLineRate("mid", AliOpID, EnOpID);
                    SetLineRate("Mid", lineRate);
                }
                else if ((isAliAdChanged || isEnAdChanged) && cboxAliAdText != "" && cboxEnAdText != "")
                {
                    SQLite db = SQLite.Instance;
                    DataTable dt;
                    dt = db.ReadTable($"SELECT OpggID FROM Champs WHERE KorName in ('{cboxAliAdText}')");
                    string AliOpID = (string)dt.Rows[0]["OpggID"];
                    dt = db.ReadTable($"SELECT OpggID FROM Champs WHERE KorName in ('{cboxEnAdText}')");
                    string EnOpID = (string)dt.Rows[0]["OpggID"];

                    List<string> lineRate = GetLineRate("adc", AliOpID, EnOpID);
                    SetLineRate("Ad", lineRate);
                }
                else if ((isAliSupChanged || isEnSupChanged) && cboxAliSupText != "" && cboxEnSupText != "")
                {
                    SQLite db = SQLite.Instance;
                    DataTable dt;
                    dt = db.ReadTable($"SELECT OpggID FROM Champs WHERE KorName in ('{cboxAliSupText}')");
                    string AliOpID = (string)dt.Rows[0]["OpggID"];
                    dt = db.ReadTable($"SELECT OpggID FROM Champs WHERE KorName in ('{cboxEnSupText}')");
                    string EnOpID = (string)dt.Rows[0]["OpggID"];

                    List<string> lineRate = GetLineRate("support", AliOpID, EnOpID);
                    SetLineRate("Sup", lineRate);
                }
            });

            LoadDataGridView();

            RecommendChamp();
        }

        async public void RecommendChamp()
        {
            List<VsChamp> listVsChamp = new List<VsChamp>();
            List<Task> listTask = new List<Task>();

            if (rbtnAliTop.Checked)
            {
                if (cboxEnTop.Text == "") return;
                string cboxEnTopText = cboxEnTop.Text;
                tboxVsChamp.Text = cboxEnTop.Text;

                string champlist = "";
                if (cboxMainPos.Text == "탑")
                    champlist = tboxMainPos.Text;
                else if (cboxSubPos.Text == "탑")
                    champlist = tboxSubPos.Text;

                if (champlist.Length == 0) return;

                string[] champs = champlist.Split('\n', '\r',' ', ',');

                foreach (string champ in champs)
                {
                    if (champ == "") continue;
                    if (champ == cboxEnTop.Text) continue;

                    listTask.Add(Task.Run(() =>
                    {
                        SQLite db = SQLite.Instance;
                        DataTable dt;
                        dt = db.ReadTable($"SELECT OpggID FROM Champs WHERE KorName in ('{champ}')");
                        string AliOpID = (string)dt.Rows[0]["OpggID"];
                        dt = db.ReadTable($"SELECT OpggID FROM Champs WHERE KorName in ('{cboxEnTopText}')");
                        string EnOpID = (string)dt.Rows[0]["OpggID"];

                        List<string> lineRate = GetLineRate("top", AliOpID, EnOpID);
                        List<string> winRate = GetWinRate("top", AliOpID, EnOpID);
                        listVsChamp.Add(new VsChamp(champ, double.Parse(lineRate[0]), double.Parse(winRate[0])));
                    }));
                }
            }
            else if (rbtnAliJungle.Checked)
            {
                if (cboxEnJungle.Text == "") return;
                string cboxEnJungleText = cboxEnJungle.Text;
                tboxVsChamp.Text = cboxEnJungle.Text;

                string champlist = "";
                if (cboxMainPos.Text == "정글")
                    champlist = tboxMainPos.Text;
                else if (cboxSubPos.Text == "정글")
                    champlist = tboxSubPos.Text;

                if (champlist.Length == 0) return;

                string[] champs = champlist.Split('\n', '\r', ' ', ',');

                foreach (string champ in champs)
                {
                    if (champ == "") continue;
                    if (champ == cboxEnJungle.Text) continue;

                    listTask.Add(Task.Run(() =>
                    {
                        SQLite db = SQLite.Instance;
                        DataTable dt;
                        dt = db.ReadTable($"SELECT OpggID FROM Champs WHERE KorName in ('{champ}')");
                        string AliOpID = (string)dt.Rows[0]["OpggID"];
                        dt = db.ReadTable($"SELECT OpggID FROM Champs WHERE KorName in ('{cboxEnJungleText}')");
                        string EnOpID = (string)dt.Rows[0]["OpggID"];

                        List<string> lineRate = GetLineRate("jungle", AliOpID, EnOpID);
                        List<string> winRate = GetWinRate("jungle", AliOpID, EnOpID);
                        listVsChamp.Add(new VsChamp(champ, double.Parse(lineRate[0]), double.Parse(winRate[0])));
                    }));
                }
            }
            else if (rbtnAliMid.Checked)
            {
                if (cboxEnMid.Text == "") return;
                string cboxEnMidText = cboxEnMid.Text;
                tboxVsChamp.Text = cboxEnMid.Text;

                string champlist = "";
                if (cboxMainPos.Text == "미드")
                    champlist = tboxMainPos.Text;
                else if (cboxSubPos.Text == "미드")
                    champlist = tboxSubPos.Text;

                if (champlist.Length == 0) return;

                string[] champs = champlist.Split('\n', '\r', ' ', ',');

                foreach (string champ in champs)
                {
                    if (champ == "") continue;
                    if (champ == cboxEnMid.Text) continue;

                    listTask.Add(Task.Run(() =>
                    {
                        SQLite db = SQLite.Instance;
                        DataTable dt;
                        dt = db.ReadTable($"SELECT OpggID FROM Champs WHERE KorName in ('{champ}')");
                        string AliOpID = (string)dt.Rows[0]["OpggID"];
                        dt = db.ReadTable($"SELECT OpggID FROM Champs WHERE KorName in ('{cboxEnMidText}')");
                        string EnOpID = (string)dt.Rows[0]["OpggID"];

                        List<string> lineRate = GetLineRate("mid", AliOpID, EnOpID);
                        List<string> winRate = GetWinRate("mid", AliOpID, EnOpID);
                        listVsChamp.Add(new VsChamp(champ, double.Parse(lineRate[0]), double.Parse(winRate[0])));
                    }));
                }
            }
            else if (rbtnAliAd.Checked)
            {
                if (cboxEnAd.Text == "") return;
                string cboxEnAdText = cboxEnAd.Text;
                tboxVsChamp.Text = cboxEnAd.Text;

                string champlist = "";
                if (cboxMainPos.Text == "원딜")
                    champlist = tboxMainPos.Text;
                else if (cboxSubPos.Text == "원딜")
                    champlist = tboxSubPos.Text;

                if (champlist.Length == 0) return;

                string[] champs = champlist.Split('\n', '\r', ' ', ',');

                foreach (string champ in champs)
                {
                    if (champ == "") continue;
                    if (champ == cboxEnAd.Text) continue;

                    listTask.Add(Task.Run(() =>
                    {
                        SQLite db = SQLite.Instance;
                        DataTable dt;
                        dt = db.ReadTable($"SELECT OpggID FROM Champs WHERE KorName in ('{champ}')");
                        string AliOpID = (string)dt.Rows[0]["OpggID"];
                        dt = db.ReadTable($"SELECT OpggID FROM Champs WHERE KorName in ('{cboxEnAdText}')");
                        string EnOpID = (string)dt.Rows[0]["OpggID"];

                        List<string> lineRate = GetLineRate("adc", AliOpID, EnOpID);
                        List<string> winRate = GetWinRate("adc", AliOpID, EnOpID);
                        listVsChamp.Add(new VsChamp(champ, double.Parse(lineRate[0]), double.Parse(winRate[0])));
                    }));
                }
            }
            else if (rbtnAliSup.Checked)
            {
                if (cboxEnSup.Text == "") return;
                string cboxEnSupText = cboxEnSup.Text;
                tboxVsChamp.Text = cboxEnSup.Text;

                string champlist = "";
                if (cboxMainPos.Text == "서폿")
                    champlist = tboxMainPos.Text;
                else if (cboxSubPos.Text == "서폿")
                    champlist = tboxSubPos.Text;

                if (champlist.Length == 0) return;

                string[] champs = champlist.Split('\n', '\r', ' ', ',');

                foreach (string champ in champs)
                {
                    if (champ == "") continue;
                    if (champ == cboxEnSup.Text) continue;

                    listTask.Add(Task.Run(() =>
                    {
                        SQLite db = SQLite.Instance;
                        DataTable dt;
                        dt = db.ReadTable($"SELECT OpggID FROM Champs WHERE KorName in ('{champ}')");
                        string AliOpID = (string)dt.Rows[0]["OpggID"];
                        dt = db.ReadTable($"SELECT OpggID FROM Champs WHERE KorName in ('{cboxEnSupText}')");
                        string EnOpID = (string)dt.Rows[0]["OpggID"];

                        List<string> lineRate = GetLineRate("support", AliOpID, EnOpID);
                        List<string> winRate = GetWinRate("support", AliOpID, EnOpID);
                        listVsChamp.Add(new VsChamp(champ, double.Parse(lineRate[0]), double.Parse(winRate[0])));
                    }));
                }
            }

            await Task.WhenAll(listTask.ToArray());

            listVsChamp.Sort(delegate (VsChamp x, VsChamp y)
            {
                if (x.vsAvg > y.vsAvg) return -1;
                else return 1;
            });

            if (tboxVsChamp.Text != "")
            {
                for (int i = 0; i < listVsChamp.Count; i++)
                {
                    if (i == 3) break;

                    if (i == 0)
                    {
                        tboxVs1.Text = $"{listVsChamp[i].champ} : 라인전우위[ {listVsChamp[i].vsLane} ] / 게임승률[ {listVsChamp[i].vsGame} ] / 평균[ {listVsChamp[i].vsAvg} ]";
                    }
                    else if (i == 1)
                    {
                        tboxVs2.Text = $"{listVsChamp[i].champ} : 라인전우위[ {listVsChamp[i].vsLane} ] / 게임승률[ {listVsChamp[i].vsGame} ] / 평균[ {listVsChamp[i].vsAvg} ]";
                    }
                    else if (i == 2)
                    {
                        tboxVs3.Text = $"{listVsChamp[i].champ} : 라인전우위[ {listVsChamp[i].vsLane} ] / 게임승률[ {listVsChamp[i].vsGame} ] / 평균[ {listVsChamp[i].vsAvg} ]";
                    }
                }
            }
        }

        public void LoadDataGridView()
        {
            // Ali
            SQLite db = SQLite.Instance;
            DataTable dtAli = db.ReadTable($@"SELECT Position as 포지션, Champ as 챔피언, LineRate as 라인전우위, Trend1 as '0-25', Trend2 as '25-30', Trend3 as '30-35', Trend4 as '35-40', Trend5 as '40+' FROM GameRepository WHERE ID in ('{nowGameID}') AND Team in ('Ali')
              ORDER BY CASE WHEN Position in ('Top') THEN '1'
                WHEN Position in ('Jungle') THEN '2'
                WHEN Position in ('Mid') THEN '3'
                WHEN Position in ('Ad') THEN '4'
                WHEN Position in ('Sup') THEN '5'
                END");
            dataGridView1.DataSource = dtAli;
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // En
            DataTable dtEn = db.ReadTable($@"SELECT Position as 포지션, Champ as 챔피언, LineRate as 라인전우위, Trend1 as '0-25', Trend2 as '25-30', Trend3 as '30-35', Trend4 as '35-40', Trend5 as '40+' FROM GameRepository WHERE ID in ('{nowGameID}') AND Team in ('En')
              ORDER BY CASE WHEN Position in ('Top') THEN '1'
                WHEN Position in ('Jungle') THEN '2'
                WHEN Position in ('Mid') THEN '3'
                WHEN Position in ('Ad') THEN '4'
                WHEN Position in ('Sup') THEN '5'
                END");
            dataGridView2.DataSource = dtEn;
            foreach (DataGridViewColumn c in dataGridView2.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            ProcessValue();
        }

        public void ProcessValue()
        {
            try
            {
                double aliTopLane = double.Parse(dataGridView1.Rows[0].Cells["라인전우위"].Value.ToString());
                double aliJungleLane = double.Parse(dataGridView1.Rows[1].Cells["라인전우위"].Value.ToString());
                double aliMidLane = double.Parse(dataGridView1.Rows[2].Cells["라인전우위"].Value.ToString());
                double aliAdLane = double.Parse(dataGridView1.Rows[3].Cells["라인전우위"].Value.ToString());
                double aliSupLane = double.Parse(dataGridView1.Rows[4].Cells["라인전우위"].Value.ToString());

                double EnTopLane = double.Parse(dataGridView2.Rows[0].Cells["라인전우위"].Value.ToString());
                double EnJungleLane = double.Parse(dataGridView2.Rows[1].Cells["라인전우위"].Value.ToString());
                double EnMidLane = double.Parse(dataGridView2.Rows[2].Cells["라인전우위"].Value.ToString());
                double EnAdLane = double.Parse(dataGridView2.Rows[3].Cells["라인전우위"].Value.ToString());
                double EnSupLane = double.Parse(dataGridView2.Rows[4].Cells["라인전우위"].Value.ToString());

                labTopLane.Text = string.Format("{0:0.##}", (aliTopLane - EnTopLane));
                labJungleLane.Text = string.Format("{0:0.##}", (aliJungleLane - EnJungleLane));
                labMidLane.Text = string.Format("{0:0.##}", (aliMidLane - EnMidLane));
                labAdLane.Text = string.Format("{0:0.##}", (aliAdLane - EnAdLane));
                labSupLane.Text = string.Format("{0:0.##}", (aliSupLane - EnSupLane));
                
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.ToString());
            }

            try
            {
                double aliSum1 = 0;
                double aliSum2 = 0;
                double aliSum3 = 0;
                double aliSum4 = 0;
                double aliSum5 = 0;

                double enSum1 = 0;
                double enSum2 = 0;
                double enSum3 = 0;
                double enSum4 = 0;
                double enSum5 = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    aliSum1 += double.Parse(row.Cells["0-25"].Value.ToString());
                    aliSum2 += double.Parse(row.Cells["25-30"].Value.ToString());
                    aliSum3 += double.Parse(row.Cells["30-35"].Value.ToString());
                    aliSum4 += double.Parse(row.Cells["35-40"].Value.ToString());
                    aliSum5 += double.Parse(row.Cells["40+"].Value.ToString());
                }

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    enSum1 += double.Parse(row.Cells["0-25"].Value.ToString());
                    enSum2 += double.Parse(row.Cells["25-30"].Value.ToString());
                    enSum3 += double.Parse(row.Cells["30-35"].Value.ToString());
                    enSum4 += double.Parse(row.Cells["35-40"].Value.ToString());
                    enSum5 += double.Parse(row.Cells["40+"].Value.ToString());
                }

                labTrend1.Text = string.Format("{0:0.##}", (aliSum1 - enSum1) / 5);
                labTrend2.Text = string.Format("{0:0.##}", (aliSum2 - enSum2) / 5);
                labTrend3.Text = string.Format("{0:0.##}", (aliSum3 - enSum3) / 5);
                labTrend4.Text = string.Format("{0:0.##}", (aliSum4 - enSum4) / 5);
                labTrend5.Text = string.Format("{0:0.##}", (aliSum5 - enSum5) / 5);
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.ToString());
            }
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            SQLite db = SQLite.Instance;
            DataTable dt = db.ReadTable($"SELECT Number FROM (SELECT ROW_NUMBER() OVER (ORDER BY Number DESC) rownum, * FROM GameInfo WHERE Date in ('{dateTimePicker1.Value.ToString("yyyy-MM-dd")}')) t WHERE t.rownum <= 1");

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
            db.Write($"INSERT INTO GameInfo (ID, Date, Number, Comment, Save) VALUES ('{id}', '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}', {nowGameNumber}, '', false)");

            LoadGameInfo();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadGameInfo();

            if (cboxGameNumber.Text != "" && nowGameSaved == false)
            {
                cboxAliTop.Enabled = true;
                cboxAliJungle.Enabled = true;
                cboxAliMid.Enabled = true;
                cboxAliAd.Enabled = true;
                cboxAliSup.Enabled = true;

                cboxEnTop.Enabled = true;
                cboxEnJungle.Enabled = true;
                cboxEnMid.Enabled = true;
                cboxEnAd.Enabled = true;
                cboxEnSup.Enabled = true;
            }
            else
            {
                cboxAliTop.Enabled = false;
                cboxAliJungle.Enabled = false;
                cboxAliMid.Enabled = false;
                cboxAliAd.Enabled = false;
                cboxAliSup.Enabled = false;

                cboxEnTop.Enabled = false;
                cboxEnJungle.Enabled = false;
                cboxEnMid.Enabled = false;
                cboxEnAd.Enabled = false;
                cboxEnSup.Enabled = false;
            }
        }

        private void cboxGameNumber_TextChanged(object sender, EventArgs e)
        {
            if (cboxGameNumber.Text != "" && nowGameSaved == false)
            {
                cboxAliTop.Enabled = true;
                cboxAliJungle.Enabled = true;
                cboxAliMid.Enabled = true;
                cboxAliAd.Enabled = true;
                cboxAliSup.Enabled = true;

                cboxEnTop.Enabled = true;
                cboxEnJungle.Enabled = true;
                cboxEnMid.Enabled = true;
                cboxEnAd.Enabled = true;
                cboxEnSup.Enabled = true;
            }
            else
            {
                cboxAliTop.Enabled = false;
                cboxAliJungle.Enabled = false;
                cboxAliMid.Enabled = false;
                cboxAliAd.Enabled = false;
                cboxAliSup.Enabled = false;

                cboxEnTop.Enabled = false;
                cboxEnJungle.Enabled = false;
                cboxEnMid.Enabled = false;
                cboxEnAd.Enabled = false;
                cboxEnSup.Enabled = false;
            }
        }

        private void cboxGameNumber_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadGameInfo(int.Parse(cboxGameNumber.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLite db = SQLite.Instance;
            db.Write($"UPDATE GameInfo SET Comment='{tboxComment.Text}', Save=true WHERE ID in ('{nowGameID}')");

            cboxAliTop.Enabled = false;
            cboxAliJungle.Enabled = false;
            cboxAliMid.Enabled = false;
            cboxAliAd.Enabled = false;
            cboxAliSup.Enabled = false;

            cboxEnTop.Enabled = false;
            cboxEnJungle.Enabled = false;
            cboxEnMid.Enabled = false;
            cboxEnAd.Enabled = false;
            cboxEnSup.Enabled = false;
        }

        private void btnMainSubPos_Click(object sender, EventArgs e)
        {
            SQLite db = SQLite.Instance;
            db.Write($"DELETE FROM MyInfo");
            db.Write($"INSERT INTO MyInfo (IsMain, Position, Champ) VALUES (true, '{cboxMainPos.Text}', '{tboxMainPos.Text}')");
            db.Write($"INSERT INTO MyInfo (IsMain, Position, Champ) VALUES (false, '{cboxSubPos.Text}', '{tboxSubPos.Text}')");
        }
    }

    class VsChamp
    {
        public VsChamp(string chp, double lane, double game)
        {
            champ = chp;
            vsLane = lane;
            vsGame = game;
            vsAvg = (lane + game) / 2;
        }

        public string champ = "";
        public double vsLane = 0;
        public double vsGame = 0;
        public double vsAvg = 0;
    }
}