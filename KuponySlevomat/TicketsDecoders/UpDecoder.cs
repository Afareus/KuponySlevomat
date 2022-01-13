﻿using KuponySlevomat.Model;
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
            decodedTicket.Added = date;
            decodedTicket.Validity = DecodeValidity();
            decodedTicket.Value = DecodeValue();
            decodedTicket.Type = DecodeType();

            return decodedTicket;
        }

        private string DecodeValidity() {
            return string.Empty;
        }

        private string DecodeValue() {
            return int.Parse(ean.Substring(12, 5)).ToString();
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
