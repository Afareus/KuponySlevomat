using KuponySlevomat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuponySlevomat.TicketsDecoders {
    class SodexoDecoder {

        public Ticket DecodeSodexoTicket(string ean, string date) {
            Ticket decodedTicket = new Ticket();
            decodedTicket.Ean = ean;
            decodedTicket.Company = "Sodexo";
            decodedTicket.Type = DecodeType(ean);
            decodedTicket.Value = DecodeValue(ean);
            decodedTicket.Validity = DedoceValidity(ean);
            decodedTicket.Added = date;

            return decodedTicket;
        }

        private string DedoceValidity(string ean) {
            if (ean.Substring(0, 2) == "30") {
                return (Int32.Parse(ean.Substring(2, 2)) + 2).ToString();
            } else {
                return ean.Substring(2, 2);
            }
        }

        private string DecodeValue(string ean) {
            return (Int32.Parse(ean.Substring(4, 6)) / 100).ToString();
        }

        private string DecodeType(string ean) {
            string eanPartofType = ean.Substring(0, 2);

            switch (eanPartofType) {
                case "10": return "Gastro Pass";
                case "30": return "Dárkový Pas";
                case "70": return "Holiday Pas";
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
