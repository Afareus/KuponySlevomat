using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuponySlevomat.Model {
    class Ticket {

        public string Ean { get; set; }
        public string Company { get; set; }
        public string Type { get; set; }
        public int Value { get; set; }
        public int Validity { get; set; }
        public DateTime Added { get; set; }


    }
}
