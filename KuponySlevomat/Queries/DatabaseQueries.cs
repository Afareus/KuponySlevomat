using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuponySlevomat.Queries {
    class DatabaseQueries {

        public string Path { get; set; }

        public DatabaseQueries(string path) {
            Path = path;
        }

        public bool CreateNewDB(string NewPath) {
            string createQuery = @"CREATE TABLE IF NOT EXISTS
                                [Tickets] (
                                [EAN] NVARCHAR(32) NOT NULL PRIMARY KEY,
                                [Company] NVARCHAR(32),
                                [Type] NVARCHAR(32), 
                                [Value] INTEGER,
                                [Validity] BYTE
                                )";
            // [Date] DEFAULT DATE('now'),

            using (SqliteConnection conn = new SqliteConnection("data source =" + NewPath)) {
                SqliteCommand cmd = new SqliteCommand(createQuery, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            return true;
        }


    }
}
