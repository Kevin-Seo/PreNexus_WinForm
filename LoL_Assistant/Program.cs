using LOL_Assistant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoL_Assistant
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Database 초기화
            SQLite db = SQLite.Instance;
            db.Path = "LOLASSISTANT.DB";
            db.Open();
            db.Write("CREATE TABLE IF NOT EXISTS GameInfo (ID string PRIMARY KEY, Date datetime, Number int)");
            db.Write("CREATE TABLE IF NOT EXISTS GameRepository (ID string, Team string, Position string, Champ string, LineRate real, Length1 real, Length2 real, Length3 real, Length4 real, Length5 real)");

            Application.Run(new Form1());
        }
    }
}
