using KuponySlevomat.Model;
using System;

namespace KuponySlevomat.TicketsDecoders {
    class SodexoDecoder : ITicketDecoder {

        private string ean;
        private string date;

        public Ticket DecodeTicket(string ean, string date) {
            this.ean = ean;
            this.date = date;

            Ticket decodedTicket = new Ticket();
            decodedTicket.Ean = ean;
            decodedTicket.Company = "Sodexo";
            decodedTicket.Added = date;
            decodedTicket.Validity = DecodeValidity();
            decodedTicket.Value = DecodeValue();
            decodedTicket.Type = DecodeType();

            return decodedTicket;
        }

        private string DecodeValidity() {
            if (ean.Substring(0, 2) == "30") {
                return (Int32.Parse(ean.Substring(2, 2)) + 2).ToString();
            } else {
                return ean.Substring(2, 2);
            }
        }

        private string DecodeValue() {
            return (Int32.Parse(ean.Substring(4, 6)) / 100).ToString();
        }

        private string DecodeType() {
            string eanPartofType = ean.Substring(0, 2);

            switch (eanPartofType) {
                case "10": return "Gastro Pass";
                case "30": return "Dárkový Pass";
                case "70": return "Holiday Pass";
                case "71": return "Relax Pass";
                case "73": return "Vital Pass";
                case "75": return "Flexi Pass";
                case "79": return "Asistence";
                case "81": return "Fokus Pass";
                case "82": return "Flexi Pass Individual";
                case "83": return "Bonus Pass";

                default: return "NEZNÁMÝ TYP";

            }
        }
    }
}
