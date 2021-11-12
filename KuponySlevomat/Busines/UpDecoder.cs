using KuponySlevomat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuponySlevomat.Busines {
    class UpDecoder {

        public Ticket DecodeUpTicket(string ean) {

            Ticket decodedTicket = new Ticket();
            decodedTicket.Ean = ean;
            decodedTicket.Company = "Up";
            decodedTicket.Type = DecodeType(ean);
            decodedTicket.Value = DecodeValue(ean);
            decodedTicket.Validity = 11;
            decodedTicket.Added = DateTime.Now;

            return decodedTicket;
        }

        private int DecodeValue(string ean) {
            return Int32.Parse(ean.Substring(12, 5));
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
