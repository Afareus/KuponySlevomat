using KuponySlevomat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuponySlevomat.TicketsDecoders {
    class EdenredDecoder {
        public Ticket DecodeEdenredTicket(string ean) {
            Ticket decodedTicket = new Ticket();
            decodedTicket.Ean = ean;
            decodedTicket.Company = "Edenred";
            decodedTicket.Type = DecodeType(ean);
            decodedTicket.Value = DecodeValue(ean);
            decodedTicket.Validity = DedoceValidity(ean);
            decodedTicket.Added = DateTime.Now;

            return decodedTicket;
        }

        private string DedoceValidity(string ean) {
            return ean.Substring(2, 2);
        }

        private string DecodeValue(string ean) {
            return ean.Substring(13, 6);
        }

        private string DecodeType(string ean) {
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
