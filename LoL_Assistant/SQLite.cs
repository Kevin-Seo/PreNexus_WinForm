using System;
using System.Data;
using System.Data.SQLite;

namespace LOL_Assistant
{
    public sealed class SQLite
    {
        // class SQLite
        // - SQLite Database 접근 모듈 클래스 (싱글톤)
        //
        // <구현 필요 목록>
        // 1. 생성자
        //
        // 2. 멤버변수
        // _instance    : SQLite       - 싱글톤 SQLite 인스턴스
        // _path        : string            - DB 파일 경로
        // _conn        : SQLiteConnection  - SQLite 연결 객체
        //
        // 3. 멤버함수
        // void Open()                              - SQLiteConnection Open용 함수
        // DataSet Read(string statement)           - 데이터 읽기용 함수. DataSet 리턴.
        // DataTable ReadTable(string statement)    - 데이터 읽기용 함수. DataTable 리턴.
        // void Write(string statement)             - INSERT, UPDATE, DELETE 용 함수
        //
        // 4. 중복호출부 함수화
        // bool Valid()     - Conn NULL 체크



        // 1. 생성자
        private SQLite()
        {
            // Do Nothing
        }

        // 2. 멤버변수
        // _instance    : SQLite       - 싱글톤 SQLite 인스턴스
        private static readonly Lazy<SQLite> _instance = new Lazy<SQLite>(() => new SQLite());
        public static SQLite Instance
        {
            get { return _instance.Value; }
        }

        // _path        : string            - DB 파일 경로
        private string _path;
        public string Path
        {
            get { return _path; }
            set { _path = $@"Data Source={Environment.CurrentDirectory}\{value}"; }
        }

        // _conn        : SQLiteConnection  - SQLite 연결 객체
        private SQLiteConnection _conn;
        public SQLiteConnection Conn
        {
            get { return _conn; }
            set { _conn = value; }
        }

        // 3. 멤버함수
        // void Open()                              - SQLiteConnection Open용 함수
        public void Open()
        {
            _conn = new SQLiteConnection(_path);
            _conn.Open();
        }

        // DataSet Read(string statement)           - 데이터 읽기용 함수. DataSet 리턴.
        public DataSet Read(string statement)
        {
            if (!Valid()) throw new Exception("SQLiteConnection 객체가 설정되지 않았습니다.");

            DataSet ds = new DataSet();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(statement, _conn);
            adapter.Fill(ds);

            return ds;
        }

        // DataTable ReadTable(string statement)    - 데이터 읽기용 함수. DataTable 리턴.
        public DataTable ReadTable(string statement)
        {
            if (!Valid()) throw new Exception("SQLiteConnection 객체가 설정되지 않았습니다.");

            DataSet ds = new DataSet();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(statement, _conn);
            adapter.Fill(ds);

            return ds.Tables[0];
        }

        // void Write(string statement)             - INSERT, UPDATE, DELETE 용 쓰기함수
        public void Write(string statement)
        {
            if (!Valid()) throw new Exception("SQLiteConnection 객체가 설정되지 않았습니다.");

            SQLiteCommand cmd = new SQLiteCommand(statement, _conn);
            cmd.ExecuteNonQuery();
        }

        // 4. 중복호출부 함수화
        // bool Valid()  - Conn NULL 체크
        public bool Valid()
        {
            if (_conn == null) return false;
            else return true;
        }
    }
}
