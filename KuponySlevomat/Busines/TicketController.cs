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
            
            if (ticketToAdd.Validity > 20 && ticketToAdd.Value <= 5000 && ticketToAdd.Type != "NEZNÁMÝ PASS") {    // podmínka pro uložení 
                Tickets.Add(ticketToAdd);
                return true;
            } else {
                return false;
            }
        }

        internal void AddUpTicketToList(string ean) {
            Tickets.Add(new UpDecoder().DecodeUpTicket(ean));
        }

        internal void AddEdenredTicketToList(string ean) {
            Tickets.Add(new EdenredDecoder().DecodeEdenredTicket(ean));
        }
    }
}
