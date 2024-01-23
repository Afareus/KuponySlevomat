using KuponySlevomat.Model;
using System;
using KuponySlevomat.TicketsData;

namespace KuponySlevomat.TicketsDecoders {
    class SodexoDecoder : ITicketDecoder {

        private string ean;
        private string date;

        public Ticket DecodeTicket(string ean, string date) {
            this.ean = ean;
            this.date = date;

            Ticket decodedTicket = new Ticket();
            decodedTicket.Ean = ean;
            decodedTicket.Company = "Pluxee/Sodexo";
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
                case "10": return TicketsTypes.SodexoTypes[0];
                case "30": return TicketsTypes.SodexoTypes[1];
                case "70": return TicketsTypes.SodexoTypes[2];
                case "71": return TicketsTypes.SodexoTypes[3];
                case "73": return TicketsTypes.SodexoTypes[4];
                case "75": return TicketsTypes.SodexoTypes[5];
                case "79": return TicketsTypes.SodexoTypes[6];
                case "81": return TicketsTypes.SodexoTypes[7];
                case "82": return TicketsTypes.SodexoTypes[8];
                case "83": return TicketsTypes.SodexoTypes[9];

                default: return "NEZNÁMÝ TYP";

            }
        }
    }
}
