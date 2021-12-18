using KuponySlevomat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuponySlevomat.TicketsDecoders {
    class EdenredDecoder: ITicketDecoder {

        private string ean;
        private string date;

        public Ticket DecodeTicket(string ean, string date) {
            this.ean = ean;
            this.date = date;

            Ticket decodedTicket = new Ticket();
            decodedTicket.Ean = ean;
            decodedTicket.Company = "Edenred";
            decodedTicket.Added = date;
            decodedTicket.Validity = DecodeValidity();
            decodedTicket.Value = DecodeValue();
            decodedTicket.Type = DecodeType();

            return decodedTicket;
        }

        private string DecodeValidity() {
            return ean.Substring(2, 2);
        }

        private string DecodeValue() {
            return ean.Substring(13, 6);
        }

        private string DecodeType() {
            if (ean.Length == 32) {
                string eanPartofType = ean.Substring(27, 3);
                switch (eanPartofType) {
                    case "001": return "Ticket Restaurant";
                    case "002": return "Edenred Čistý";
                    case "003": return "Kids";
                    case "004": return "Compliments Dárkový";
                    case "005": return "Sport&Kultura";
                    case "006": return "Holiday";
                    case "007": return "Academica";
                    case "008": return "Medica";
                    case "009": return "Multi";
                    case "010": return "Service";
                    default: return "NEZNÁMÝ TYP";
                }
            }
            else { 
                return "NEZNÁMÝ TYP"; 
            }

        }
    }
}
