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
    }
}
