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

            for (int i = 0; i < 100000; i++) {
                Ticket ticket = new Ticket();
                ticket.Ean = "15210011247620000500020523554455";
                ticket.Company = "Edenred";
                ticket.Type = TicketsData.TicketsTypes.EdenredTypes[i % 9];
                int val = (int)(Math.Round((Double)((i % 5000) / 500),2)*500) + 500;
                ticket.Value = val.ToString();
                ticket.Validity = "22";
                ticket.Added = DateTime.Now.ToString("yyyy-MM-dd");

                tickets.Add(ticket);
            }
            return tickets;
        }

    } 
}
