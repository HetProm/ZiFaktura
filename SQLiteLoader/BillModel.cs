using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteLoader
{
    public class BillModel
    {
        public int Id { get; set; }
        public string Document { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NIP { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string dateofissue { get; set; }
        public string dateofsale { get; set; }
        public float Netto { get; set; }
        public float Vat { get; set; }
        public float Brutto { get; set; }
        public string Payment { get; set; }
        public string Country { get; set; }


    }
}
