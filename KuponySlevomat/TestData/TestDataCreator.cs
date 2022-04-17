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

            for (int i = 50000; i > 0; i--) {
                Ticket ticket = new Ticket();
                ticket.Ean = "15210011247620000500020523554455";
                ticket.Company = "Edenred";
                ticket.Type = TicketsData.TicketsTypes.EdenredTypes[i % 10];
                int val = (int)(Math.Round((Double)((i % 5000) / 500),2)*500) + 500;
                ticket.Value = val.ToString();
                ticket.Validity = "22";
                ticket.Added = DateTime.Now.ToString("yyyy-MM-dd");

                tickets.Add(ticket);
            }

            for (int i = 50000; i > 0; i--) {
                Ticket ticket = new Ticket();
                ticket.Ean = "152100112476200005000205";
                ticket.Company = "Sodexo";
                ticket.Type = TicketsData.TicketsTypes.SodexoTypes[i % 10];
                int val = (int)(Math.Round((Double)((i % 5000) / 500), 2) * 500) + 500;
                ticket.Value = val.ToString();
                ticket.Validity = "22";
                ticket.Added = DateTime.Now.ToString("yyyy-MM-dd");

                tickets.Add(ticket);
            }

            for (int i = 50000; i > 0; i--) {
                Ticket ticket = new Ticket();
                ticket.Ean = "152100112476200005000205";
                ticket.Company = "Up";
                ticket.Type = TicketsData.TicketsTypes.UpTypes[i % 5];
                int val = (int)(Math.Round((Double)((i % 5000) / 500), 2) * 500) + 500;
                ticket.Value = val.ToString();
                ticket.Validity = "22";
                ticket.Added = DateTime.Now.ToString("yyyy-MM-dd");

                tickets.Add(ticket);
            }

            for (int i = 50000; i > 0; i--) {
                Ticket ticket = new Ticket();
                ticket.Ean = "1521001124762000050002";
                ticket.Company = "Moje Stravenka";
                ticket.Type = string.Empty;
                int val = (int)(Math.Round((Double)((i % 5000) / 500), 2) * 500) + 500;
                ticket.Value = val.ToString();
                ticket.Validity = "22";
                ticket.Added = DateTime.Now.ToString("yyyy-MM-dd");

                tickets.Add(ticket);
            }

            return tickets;
        }

    } 
}
