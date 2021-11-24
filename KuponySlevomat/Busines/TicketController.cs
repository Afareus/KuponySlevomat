using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KuponySlevomat.Model;
using KuponySlevomat.Queries;
using KuponySlevomat.TicketsDecoders;

namespace KuponySlevomat.Busines {
    class TicketController {

        public DatabaseQueries databaseQueries;
        public List<Ticket> Tickets { get; set; }

        public TicketController(string path) {
            Tickets = new List<Ticket>();
            databaseQueries = new DatabaseQueries(path);
        }

        internal bool AddSodexoTicketToList(string ean) {
            Ticket ticketToAdd = new SodexoDecoder().DecodeSodexoTicket(ean);
            
            if (int.Parse(ticketToAdd.Validity) > 20 && int.Parse(ticketToAdd.Value) <= 5000 && ticketToAdd.Type != "NEZNÁMÝ TYP") {    // podmínka pro uložení 
                Tickets.Add(ticketToAdd);
                return true;
            } else {
                return false;
            }
        }

        internal bool AddUpTicketToList(string ean) {
            Ticket ticketToAdd = new UpDecoder().DecodeUpTicket(ean);
            if (int.Parse(ticketToAdd.Validity) > 20 && int.Parse(ticketToAdd.Value) <= 5000 && ticketToAdd.Type != "NEZNÁMÝ TYP") {    // podmínka pro uložení 
                Tickets.Add(ticketToAdd);
                return true;
            } else {
                return false;
            }
        }

        internal bool AddEdenredTicketToList(string ean) {
            Ticket ticketToAdd = new EdenredDecoder().DecodeEdenredTicket(ean);
            if (int.Parse(ticketToAdd.Value) <= 5000 && ticketToAdd.Type != "NEZNÁMÝ TYP") {    // podmínka pro uložení 
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
