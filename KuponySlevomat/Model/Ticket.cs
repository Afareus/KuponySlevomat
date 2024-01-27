namespace KuponySlevomat.Model {
    public class Ticket {

        public string Ean { get; set; }
        public string Company { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public string Validity { get; set; }
        public string Added { get; set; }


        public Ticket(string ean, string company, string type, string value, string validity, string added) {
            this.Ean = ean;
            this.Company = company;
            this.Type = type;
            this.Value = value;
            this.Validity = validity;
            this.Added = added;
        }

        public Ticket() {
        }

        public override string ToString() {
            string day = Added.Substring(8, 2);
            string month = Added.Substring(5, 2);
            string year = Added.Substring(0, 4);
            string AddedCzFormat = $"{day}.{month}.{year}";

            return string.Format("{0,32} {1,14} {2,21} {3, 15} {4,20}", Ean, Company, Type, int.Parse(Value), AddedCzFormat);
        }
    }
}
