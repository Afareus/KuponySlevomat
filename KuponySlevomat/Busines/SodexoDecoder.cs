using KuponySlevomat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuponySlevomat.Busines {
    class SodexoDecoder {

        public Ticket DecodedSodexoTicket(string ean) {

            Ticket decodedTicket = new Ticket();
            decodedTicket.Ean = ean;
            decodedTicket.Company = "Sodexo";
            decodedTicket.Type = DecodeSodexoType(ean);
            decodedTicket.Value = DecodeSodexoValue(ean);
            decodedTicket.Validity = DedoceSodexoValidity(ean);
            decodedTicket.Added = DateTime.Now;

            return decodedTicket;
        }

        private int DedoceSodexoValidity(string ean) {
            if (ean.Substring(0, 2) == "30") {
                return Int32.Parse(ean.Substring(2, 2)) + 2;
            } else {
                return Int32.Parse(ean.Substring(2, 2));
            }
        }

        private int DecodeSodexoValue(string ean) {
            return Int32.Parse(ean.Substring(4, 6)) / 100;
        }

        private string DecodeSodexoType(string ean) {
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

                default: return "NEZNÁMÝ PASS";

            }
        }

    }
}
