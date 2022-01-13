using KuponySlevomat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuponySlevomat.TicketsDecoders {
    class MojeStravenkaDecoder : ITicketDecoder {

        private string ean;
        private string date;

        public Ticket DecodeTicket(string ean, string date) {
            this.ean = ean;
            this.date = date;

            Ticket decodedTicket = new Ticket();
            decodedTicket.Ean = ean;
            decodedTicket.Company = "Moje Stravenka";
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
            return Int32.Parse(ean.Substring(15, 5)).ToString();
        }

        private string DecodeType() {       // nemá typy
            return string.Empty;
        }
    }
}
