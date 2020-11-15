using LOL_Assistant;
using Serilog;
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

            // Log 초기화
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("log/log-.txt", outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            // Database 초기화
            SQLite db = SQLite.Instance;
            db.Path = "LOLASSISTANT.DB";
            db.Open();
            db.Write("CREATE TABLE IF NOT EXISTS GameInfo (ID string PRIMARY KEY, Date datetime, Number int, Comment string, Save bool)");
            db.Write("CREATE TABLE IF NOT EXISTS GameRepository (ID string, Team string, Position string, Champ string, LineRate real, Trend1 real, Trend2 real, Trend3 real, Trend4 real, Trend5 real)");
            db.Write("CREATE TABLE IF NOT EXISTS MyInfo (IsMain bool, Position string, Champ string)");

            Application.Run(new Form1());
        }
    }
}
