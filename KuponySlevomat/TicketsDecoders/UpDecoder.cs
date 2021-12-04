using KuponySlevomat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuponySlevomat.TicketsDecoders {
    class UpDecoder {

        public Ticket DecodeUpTicket(string ean, string date) {
            Ticket decodedTicket = new Ticket();
            decodedTicket.Ean = ean;
            decodedTicket.Company = "Up";
            decodedTicket.Type = DecodeType(ean);
            decodedTicket.Value = DecodeValue(ean);
            decodedTicket.Validity = DecodeValidity();

            string day = date.Substring(0, 2);
            string month = date.Substring(3, 2);
            string year = date.Substring(6, 4);
            string formatDate = $"{year}-{month}-{day}";
            decodedTicket.Added = formatDate;

            return decodedTicket;
        }

        private string DecodeValue(string ean) {
            return ean.Substring(12, 5);
        }

        private string DecodeValidity() {
            return string.Empty;
        }

        private string DecodeType(string ean) {
            string eanPartofType = ean.Substring(21, 1);
            switch (eanPartofType) {
                case "1": return "Stravenka";
                case "2": return "Cadhoc";
                case "3": return "Dovolená";
                case "4": return "Unišek";
                case "5": return "Unišek +";
                default: return "NEZNÁMÝ TYP";    
            }
        }
    }
}
