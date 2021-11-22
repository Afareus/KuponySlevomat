using KuponySlevomat.Model;
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
                                [Validity] BYTE,
                                [Date] TIMESTAMP DEFAULT CURRENT_TIMESTAMP
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


        internal Ticket[] GetAllTickets() {
            string selectAllQuery = "SELECT * FROM Tickets";
            List<Ticket> tickets = new List<Ticket>();

            using (SqliteConnection conn = new SqliteConnection("data source =" + Path)) {
                SqliteCommand cmd = new SqliteCommand(selectAllQuery, conn);
                conn.Open();
                using (SqliteDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        Ticket ticket = new Ticket((string)reader["EAN"], (string)reader["Company"], (string)reader["Type"], (int)reader["Value"], (int)reader["Validity"], (DateTime)reader["Date"]);
                        tickets.Add(ticket);
                    }
                }
                conn.Close();
            }
            return tickets.ToArray();
        }

        internal bool SaveTickets() {
            throw new NotImplementedException();           // metoda pro přidání poukázek do databáze
        }
    }
}
