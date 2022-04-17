using KuponySlevomat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuponySlevomat.TicketsData;

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
                    case "001": return TicketsTypes.EdenredTypes[0];
                    case "002": return TicketsTypes.EdenredTypes[1];
                    case "003": return TicketsTypes.EdenredTypes[2];
                    case "004": return TicketsTypes.EdenredTypes[3];
                    case "005": return TicketsTypes.EdenredTypes[4];
                    case "006": return TicketsTypes.EdenredTypes[5];
                    case "007": return TicketsTypes.EdenredTypes[6];
                    case "008": return TicketsTypes.EdenredTypes[7];
                    case "009": return TicketsTypes.EdenredTypes[8];
                    case "010": return TicketsTypes.EdenredTypes[9];
                    default: return "NEZNÁMÝ TYP";
                }
            }
            else { 
                return "NEZNÁMÝ TYP"; 
            }

        }
    }
}
