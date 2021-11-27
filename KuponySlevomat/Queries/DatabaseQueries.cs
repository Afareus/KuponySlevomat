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
                                [Id] INTEGER PRIMARY KEY AUTOINCREMENT,
                                [EAN] NVARCHAR(32) NOT NULL,
                                [Company] NVARCHAR(32),
                                [Type] NVARCHAR(32), 
                                [Value] NVARCHAR(8),
                                [Validity] NVARCHAR(4),
                                [Date] DATE
                                )";

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
                        Ticket ticket = new Ticket((string)reader["EAN"], (string)reader["Company"], (string)reader["Type"], (string)reader["Value"], (string)reader["Validity"], (string)reader["Date"]);
                        tickets.Add(ticket);
                    }
                }
                conn.Close();
            }
            return tickets.ToArray();
        }

        internal bool SaveTickets(Ticket[] ticketsToSave) {
            using (SqliteConnection conn = new SqliteConnection("data source =" + Path)) {
                foreach (Ticket tic in ticketsToSave) {
                    string saveTicketQuery = "INSERT INTO Tickets(EAN,Company,Type,Value,Validity,Date) VALUES ('" + tic.Ean + "','" + tic.Company + "','" + tic.Type + "','" + tic.Value + "','" + tic.Validity + "','" + tic.Added + "')";
                    SqliteCommand cmd = new SqliteCommand(saveTicketQuery, conn);
                    conn.Open();
                    try {
                        cmd.ExecuteNonQuery();
                    } catch (SqliteException) {
                        return false;
                    } finally {
                        conn.Close();
                    }
                    conn.Close();
                }
            }
            return true;
        }
    }
}
