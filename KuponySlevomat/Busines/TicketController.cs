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

        internal void AddSodexoTicketToList(string ean) {
            Tickets.Add(new SodexoDecoder().DecodeSodexoTicket(ean));
        }

        internal void AddUpTicketToList(string ean) {
            Tickets.Add(new UpDecoder().DecodeUpTicket(ean));
        }

        internal void AddEdenredTicketToList(string ean) {
            Tickets.Add(new EdenredDecoder().DecodeEdenredTicket(ean));
        }
    }
}
