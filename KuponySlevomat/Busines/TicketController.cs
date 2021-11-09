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
            Tickets.Add(new SodexoDecoder().DecodedSodexoTicket(ean));
        }
    }
}
