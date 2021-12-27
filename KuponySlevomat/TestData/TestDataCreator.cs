using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuponySlevomat.Model;

namespace KuponySlevomat.TestData {
    class TestDataCreator {

        public static List<Ticket> CreateTestTickets() {
            List<Ticket> tickets = new List<Ticket>();
            Ticket ticket = new Ticket();

            for (int i = 0; i < 100000; i++) {
                ticket.Ean = "15210011247620000500020523500903";
                ticket.Company = "Edenred";
                ticket.Type = "Bla bla bla";
                ticket.Value = "1000";
                ticket.Validity = "22";
                ticket.Added = DateTime.Now.ToString("yyyy-MM-dd");

                tickets.Add(ticket);
            }
            return tickets;
        }

    } 
}
