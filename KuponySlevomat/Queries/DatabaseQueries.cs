using KuponySlevomat.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuponySlevomat.Queries {
    class DatabaseQueries {                         

        public string Path { get; set; }

        public DatabaseQueries(string path) {
            Path = path;
        }

        public DatabaseQueries() {
        }

        // TODO: kód od otevření komunikace do zavření by mohl být v TRY bloku - incident na SQLite Error 14: "Unable to open database file" - zatím jednou u uživatele

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


        internal Dictionary<string,Ticket> GetAllTickets() {
            string selectAllQuery = "SELECT * FROM Tickets";
            Dictionary<string, Ticket> tickets = new Dictionary<string, Ticket>();

            using (SqliteConnection conn = new SqliteConnection("data source =" + Path)) {
                SqliteCommand cmd = new SqliteCommand(selectAllQuery, conn);
                conn.Open();
                using (SqliteDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        Ticket ticket = new Ticket((string)reader["EAN"], (string)reader["Company"], (string)reader["Type"], (string)reader["Value"], (string)reader["Validity"], (string)reader["Date"]);
                        tickets.Add(ticket.Ean, ticket);
                    }
                }
                conn.Close();
            }
            return tickets;
        }


        internal bool SaveTickets(Ticket[] ticketsToSave) {
            using (SqliteConnection conn = new SqliteConnection("data source =" + Path)) {
                conn.Open();
                using (var transaction = conn.BeginTransaction()) {
                    var command = conn.CreateCommand();
                    command.CommandText = @"INSERT INTO Tickets(EAN,Company,Type,Value,Validity,Date) VALUES ($ean, $company, $type, $value, $validity, $added)";

                    var parameter1 = command.CreateParameter();
                    parameter1.ParameterName = "$ean";
                    command.Parameters.Add(parameter1);

                    var parameter2 = command.CreateParameter();
                    parameter2.ParameterName = "$company";
                    command.Parameters.Add(parameter2);

                    var parameter3 = command.CreateParameter();
                    parameter3.ParameterName = "$type";
                    command.Parameters.Add(parameter3);

                    var parameter4 = command.CreateParameter();
                    parameter4.ParameterName = "$value";
                    command.Parameters.Add(parameter4);

                    var parameter5 = command.CreateParameter();
                    parameter5.ParameterName = "$validity";
                    command.Parameters.Add(parameter5);

                    var parameter6 = command.CreateParameter();
                    parameter6.ParameterName = "$added";
                    command.Parameters.Add(parameter6);

                    foreach (Ticket tic in ticketsToSave) {
                        parameter1.Value = tic.Ean;
                        parameter2.Value = tic.Company;
                        parameter3.Value = tic.Type;
                        parameter4.Value = tic.Value;
                        parameter5.Value = tic.Validity;
                        parameter6.Value = tic.Added;

                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
                conn.Close();
            }
            return true;
        }



        internal Ticket[] GetTickets(int selectedCompany, DateTimePicker dateTimePickerFrom, DateTimePicker dateTimePickerTo) {
            string dateFrom = dateTimePickerFrom.Value.ToString("yyyy-MM-dd");
            string dateTo = dateTimePickerTo.Value.ToString("yyyy-MM-dd");

            string selectAllQuery;

            if (selectedCompany == 1) {
                selectAllQuery = "SELECT * FROM Tickets WHERE Date BETWEEN '" + dateFrom + "' AND '" + dateTo + "' AND Company = 'Sodexo'";
            } else if (selectedCompany == 2) {
                selectAllQuery = "SELECT * FROM Tickets WHERE Date BETWEEN '" + dateFrom + "' AND '" + dateTo + "' AND Company = 'Up'";
            } else if (selectedCompany == 3) {
                selectAllQuery = "SELECT * FROM Tickets WHERE Date BETWEEN '" + dateFrom + "' AND '" + dateTo + "' AND Company = 'Edenred'";
            } else if (selectedCompany == 4) {
                selectAllQuery = "SELECT * FROM Tickets WHERE Date BETWEEN '" + dateFrom + "' AND '" + dateTo + "' AND Company = 'Moje Stravenka'";
            } else {
                selectAllQuery = "SELECT * FROM Tickets WHERE Date BETWEEN '" + dateFrom + "' AND '" + dateTo + "'";
            }


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


        // Funkce IsDbReadAble funguje jen pro databázi kde už něco je... jak to napsat všeobecnějí???
        internal bool IsDbReadAble(string pathToDb)
        {
            try
            {
                using (SqliteConnection conn = new SqliteConnection("data source =" + pathToDb))
                {
                    SqliteCommand cmd = new SqliteCommand("SELECT * FROM Tickets WHERE Tickets.Id = 1", conn);
                    conn.Open();
                    using (SqliteDataReader reader = cmd.ExecuteReader()) {}
                    conn.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
