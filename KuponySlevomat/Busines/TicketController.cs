using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KuponySlevomat.Model;

namespace KuponySlevomat.Busines {
    class TicketController {

        public List<Ticket> Tickets { get; set; }

        public TicketController() {
            Tickets = new List<Ticket>();
        }

        internal bool AddSodexoTicketToList(string ean) {
            Ticket ticketToAdd = new SodexoDecoder().DecodeSodexoTicket(ean);
            
            if (ticketToAdd.Validity > 20 && ticketToAdd.Value <= 5000 && ticketToAdd.Type != "NEZNÁMÝ TYP") {    // podmínka pro uložení 
                Tickets.Add(ticketToAdd);
                return true;
            } else {
                return false;
            }
        }

        internal bool AddUpTicketToList(string ean) {
            Ticket ticketToAdd = new UpDecoder().DecodeUpTicket(ean);
            if (ticketToAdd.Validity > 20 && ticketToAdd.Value <= 5000 && ticketToAdd.Type != "NEZNÁMÝ TYP") {    // podmínka pro uložení 
                Tickets.Add(ticketToAdd);
                return true;
            } else {
                return false;
            }
        }

        internal bool AddEdenredTicketToList(string ean) {
            Ticket ticketToAdd = new EdenredDecoder().DecodeEdenredTicket(ean);
            if (ticketToAdd.Value <= 5000 && ticketToAdd.Type != "NEZNÁMÝ TYP") {    // podmínka pro uložení 
                Tickets.Add(ticketToAdd);
                return true;
            } else {
                return false;
            }
        }
    }
}
