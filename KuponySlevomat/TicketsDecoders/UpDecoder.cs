using KuponySlevomat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuponySlevomat.TicketsDecoders {
    class UpDecoder : ITicketDecoder {

        private string ean;
        private string date;

        public Ticket DecodeTicket(string ean, string date) {
            this.ean = ean;
            this.date = date;

            Ticket decodedTicket = new Ticket();
            decodedTicket.Ean = ean;
            decodedTicket.Company = "Up";
            decodedTicket.Added = FormateDate();
            decodedTicket.Validity = DecodeValidity();
            decodedTicket.Value = DecodeValue();
            decodedTicket.Type = DecodeType();

            return decodedTicket;
        }

        private string FormateDate() {
            string day = date.Substring(0, 2);
            string month = date.Substring(3, 2);
            string year = date.Substring(6, 4);
            string formatedDate = $"{year}-{month}-{day}";
            return formatedDate;
        }

        private string DecodeValidity() {
            return string.Empty;
        }

        private string DecodeValue() {
            return ean.Substring(12, 5);
        }

        private string DecodeType() {
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
