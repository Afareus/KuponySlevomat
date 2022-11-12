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

namespace KuponySlevomat.Business {
    class TicketController {

        public DatabaseQueries databaseQueries;
        public List<Ticket> Tickets { get; set; }

        Dictionary<string, Ticket> SavedTickets;
        public List<Ticket> DuplicatedTicketsOnly { get; set; }
        public List<Ticket> NewTicketsOnly { get; set; }

        public TicketController(string path) {
            Tickets = new List<Ticket>();
            databaseQueries = new DatabaseQueries(path);
            SavedTickets = databaseQueries.GetAllTickets();

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
            if (int.Parse(ticketToAdd.Value) <= 5000 && int.Parse(ticketToAdd.Validity) > 20) {        
                Tickets.Add(ticketToAdd);
                return true;
            } else {
                return false;
            }
        }

        internal int SentAddedTicketToSave() {
            if (ContainTicketsDuplicate()) 
                return 0;
            
            if (databaseQueries.SaveTickets(Tickets.ToArray()) ) {
                return 1;
            } else {
                return -1;
            }
        }

        internal bool ContainTicketsDuplicate()
        {
            bool containDuplicite = false;

            DuplicatedTicketsOnly = new List<Ticket>();
            NewTicketsOnly = new List<Ticket>();

            foreach (Ticket tic in Tickets)
            {
                if (SavedTickets.ContainsKey(tic.Ean))
                {
                    DuplicatedTicketsOnly.Add(tic);
                    containDuplicite = true;
                }
                else
                {
                    NewTicketsOnly.Add(tic);
                }
            }

            if (containDuplicite)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal List<Ticket> GetDuplicatedTicketToSave()
        {
            return DuplicatedTicketsOnly;
        }

        internal List<Ticket> GetNewTicketToSaveOnly()
        {
            return NewTicketsOnly;
        }

    }
}
