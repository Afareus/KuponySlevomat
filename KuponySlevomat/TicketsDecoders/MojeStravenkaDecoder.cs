﻿using KuponySlevomat.Model;
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
            return ean.Substring(2, 2);          // asi hotovo
        }

        private string DecodeValue() {
            return Int32.Parse(ean.Substring(7, 5)).ToString();      // asi hotovo
        }

        private string DecodeType() {       // nemá typy
            return string.Empty;
        }
    }
}
