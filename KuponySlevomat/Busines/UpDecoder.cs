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
            //decodedTicket.Type = DecodeUpType(ean);
            //decodedTicket.Value = DecodeUpValue(ean);
            //decodedTicket.Validity = DedoceUpValidity(ean);
            decodedTicket.Added = DateTime.Now;

            return decodedTicket;
        }










    }
}
