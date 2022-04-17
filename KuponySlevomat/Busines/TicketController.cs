using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KuponySlevomat.Model;
using KuponySlevomat.Queries;
using KuponySlevomat.TicketsDecoders;
using KuponySlevomat.TestData;

namespace KuponySlevomat.Busines {
    class TicketController {

        public DatabaseQueries databaseQueries;
        public List<Ticket> Tickets { get; set; }

        public TicketController(string path) {
            Tickets = new List<Ticket>();
            databaseQueries = new DatabaseQueries(path);

            //Tickets = TestDataCreator.CreateTestTickets();                   // TESTOVACÍ DATA - zobrazí se po načtení první poukázky
        }

        internal bool AddSodexoTicketToList(string ean, string date) {
            Ticket ticketToAdd = new SodexoDecoder().DecodeTicket(ean, date);
            if (int.Parse(ticketToAdd.Validity) > 20 && int.Parse(ticketToAdd.Value) <= 5000 && ticketToAdd.Type != "NEZNÁMÝ TYP") {
                Tickets.Add(ticketToAdd);
                return true;
            } else {
                return false;
            }
        }

        internal bool AddUpTicketToList(string ean, string date) {
            Ticket ticketToAdd = new UpDecoder().DecodeTicket(ean, date);
            if (int.Parse(ticketToAdd.Value) <= 5000 && ticketToAdd.Type != "NEZNÁMÝ TYP") {
                Tickets.Add(ticketToAdd);
                return true;
            } else {
                return false;
            }
        }

        internal bool AddEdenredTicketToList(string ean, string date) {
            Ticket ticketToAdd = new EdenredDecoder().DecodeTicket(ean, date);
            if (int.Parse(ticketToAdd.Value) <= 5000 && ticketToAdd.Type != "NEZNÁMÝ TYP") {
                Tickets.Add(ticketToAdd);
                return true;
            } else {
                return false;
            }
        }

        internal bool AddMojeStravenkaTicketToList(string ean, string date) {
            Ticket ticketToAdd = new MojeStravenkaDecoder().DecodeTicket(ean, date);
            if (int.Parse(ticketToAdd.Value) <= 5000 && int.Parse(ticketToAdd.Validity) > 20) {        // zkontrolovat
                Tickets.Add(ticketToAdd);
                return true;
            } else {
                return false;
            }
        }

        internal Ticket[] ReturnAllAddedTickets() {
            return Tickets.ToArray();
        }

        internal bool SentAddedTicketToSave() {
            if (databaseQueries.SaveTickets(ReturnAllAddedTickets())) {
                return true;
            } else {
                return false;
            }
        }


        //internal string SummaryInfo(Ticket[] loadedTickets) {
        //    string summaryInfoText = "";
        //    int totalValue = 0;
        //    Dictionary<int, int> summarySodexo = new Dictionary<int, int>();
        //    Dictionary<int, int> summaryUp = new Dictionary<int, int>();
        //    Dictionary<int, int> summaryEdenred = new Dictionary<int, int>();
        //    Dictionary<int, int> summaryMojeStravenka = new Dictionary<int, int>();

        //    foreach (Ticket tic in loadedTickets) {
        //        if (tic.Company == "Sodexo") {
        //            if (!summarySodexo.ContainsKey(int.Parse(tic.Value))) {
        //                summarySodexo.Add(int.Parse(tic.Value), 1);
        //            } else {
        //                summarySodexo[int.Parse(tic.Value)] += 1;
        //            }
        //        }
        //        if (tic.Company == "Up") {
        //            if (!summaryUp.ContainsKey(int.Parse(tic.Value))) {
        //                summaryUp.Add(int.Parse(tic.Value), 1);
        //            } else {
        //                summaryUp[int.Parse(tic.Value)] += 1;
        //            }
        //        }
        //        if (tic.Company == "Edenred") {
        //            if (!summaryEdenred.ContainsKey(int.Parse(tic.Value))) {
        //                summaryEdenred.Add(int.Parse(tic.Value), 1);
        //            } else {
        //                summaryEdenred[int.Parse(tic.Value)] += 1;
        //            }
        //        }
        //        if (tic.Company == "MojeStravenka") {
        //            if (!summaryMojeStravenka.ContainsKey(int.Parse(tic.Value))) {
        //                summaryMojeStravenka.Add(int.Parse(tic.Value), 1);
        //            } else {
        //                summaryMojeStravenka[int.Parse(tic.Value)] += 1;
        //            }
        //        }
        //        totalValue += int.Parse(tic.Value);
        //    }

        //    if (summarySodexo.Count > 0) {
        //        summaryInfoText = " Sodexo: " + Environment.NewLine + Environment.NewLine;

        //        int countSum = 0;
        //        int valueSum = 0;

        //        foreach (var item in summarySodexo) {
        //            int key = item.Key;
        //            int value = item.Value;
        //            countSum += value;
        //            valueSum += (value * key);
        //            summaryInfoText += string.Format("\t\t\t {0,7} \t {1,8} \t {2,11}", key, value, key * value) + Environment.NewLine;

        //        }
        //        summaryInfoText += "----------------------------------------------------------------------------------" + Environment.NewLine;
        //        summaryInfoText += string.Format("\t\t\t {0,7} \t {1,8} \t {2,11}", "Celkem", countSum, valueSum) + Environment.NewLine;
        //        summaryInfoText += "__________________________________________________________________________________" + Environment.NewLine + Environment.NewLine + Environment.NewLine;
        //    }

        //    if (summaryUp.Count > 0) {
        //        summaryInfoText += " Up: " + Environment.NewLine + Environment.NewLine;

        //        int countSum = 0;
        //        int valueSum = 0;

        //        foreach (var item in summaryUp) {
        //            int key = item.Key;
        //            int value = item.Value;
        //            countSum += value;
        //            valueSum += (value * key);
        //            summaryInfoText += string.Format("\t\t\t {0,7} \t {1,8} \t {2,11}", key, value, key * value) + Environment.NewLine;
        //        }
        //        summaryInfoText += "----------------------------------------------------------------------------------" + Environment.NewLine;
        //        summaryInfoText += string.Format("\t\t\t {0,7} \t {1,8} \t {2,11}", "Celkem", countSum, valueSum) + Environment.NewLine;
        //        summaryInfoText += "__________________________________________________________________________________" + Environment.NewLine + Environment.NewLine + Environment.NewLine;
        //    }

        //    if (summaryEdenred.Count > 0) {
        //        summaryInfoText += " Edenred: " + Environment.NewLine + Environment.NewLine;

        //        int countSum = 0;
        //        int valueSum = 0;

        //        foreach (var item in summaryEdenred) {
        //            int key = item.Key;
        //            int value = item.Value;
        //            countSum += value;
        //            valueSum += (value * key);
        //            summaryInfoText += string.Format("\t\t\t {0,7} \t {1,8} \t {2,11}", key, value, key * value) + Environment.NewLine;
        //        }
        //        summaryInfoText += "----------------------------------------------------------------------------------" + Environment.NewLine;
        //        summaryInfoText += string.Format("\t\t\t {0,7} \t {1,8} \t {2,11}", "Celkem", countSum, valueSum) + Environment.NewLine;
        //        summaryInfoText += "__________________________________________________________________________________" + Environment.NewLine + Environment.NewLine + Environment.NewLine;
        //    }

        //    if (summaryMojeStravenka.Count > 0) {
        //        summaryInfoText +=  " Moje Stravenka: " + Environment.NewLine + Environment.NewLine;

        //        int countSum = 0;
        //        int valueSum = 0;

        //        foreach (var item in summaryMojeStravenka) {
        //            int key = item.Key;
        //            int value = item.Value;
        //            countSum += value;
        //            valueSum += (value * key);
        //            summaryInfoText += string.Format("\t\t\t {0,7} \t {1,8} \t {2,11}", key, value, key * value) + Environment.NewLine;
        //        }
        //        summaryInfoText += "----------------------------------------------------------------------------------" + Environment.NewLine;
        //        summaryInfoText += string.Format("\t\t\t {0,7} \t {1,8} \t {2,11}", "Celkem", countSum, valueSum) + Environment.NewLine;
        //        summaryInfoText += "__________________________________________________________________________________" + Environment.NewLine;
        //    }

        //    summaryInfoText += Environment.NewLine + Environment.NewLine;
        //    summaryInfoText += "\t     Celkem " + loadedTickets.Count() + " kusů v celkové hodnotě " + totalValue + " Kč.";

        //    return summaryInfoText;
        //}
    }
}
