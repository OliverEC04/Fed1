using static System.Net.Mime.MediaTypeNames;

using namespace;

class Debtordatabase
{

    static void InitializeDatabase()
    {
        SQLiteConnection.Createfile(@"..\..\files\DebtorDB.mdf);

         Connection.Open();


         string CreateDebtorTableQuery = @"



           CREATE TABLE IF NOT EXISTS Debtor(
               DebtorID INT PRIMARY KEY AUTOINCREMENT,
               Debtor_Name TEXT NOT NULL
          ); ";


        string CreateDebtTableQuery = @"
            CREATE TABLE IF NOT EXISTS Debt (
                DebtID INT PRIMARY KEY AUTOINCREMENT,
                Debt_Amount INT
           );";


        string CreateDebtHistoryTableQuery = @"
            CREATE TABLE IF NOT EXISTS Debt_History "(
                Debt_HistoryID INT PRIMARY KEY AUTOINCREMENT,
                Date_day INT,
                Date_month INT,
                Date_year INT
           ); ";


    static void InsertData(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO Debtor
               (Col1, Col2, Col3, Col4) VALUES('Greg', 'Oliver', 'Sebastian', 'Morten'); ";
         sqlite_cmd.ExecuteNonQuery()";

         sqlite_cmd.CommandText = "INSERT INTO Debt
            (Col1, Col2, Col3, Col4) VALUES(69, 21, 555, 7000); '";
         sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = "INSERT INTO Debt_History
               (Col1, Col2, Col3, Col4) VALUES(21, 02, 2024); ";
         sqlite_cmd.ExecuteNonQuery();


            InsertData(sqlite_conn);
            ReadData(sqlite_conn);
        };

    };

};