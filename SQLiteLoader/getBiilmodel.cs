using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteLoader
{
    public class getBiilmodel
    {
        public int id { get; set; }
        public string Dokument { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int NIP { get; set; }
        public string Adres { get; set; }
        public string Kod_pocztowy { get; set; }
        public string Miasto { get; set; }
        public string Data_wystawienia { get; set; }
        public string Data_sprzedazy { get; set; }
        public float Netto { get; set; }
        private float vat;
        public float Vat { get { return vat / 100; } set { vat = value; } }
        private double brutto;
        public double Brutto { get { return Netto*Vat+Netto; } set { brutto = value; } }
        public string Sposob_platonosci { get; set; }
        public string Kraj { get; set; }
    }
}
