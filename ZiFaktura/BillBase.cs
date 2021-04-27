using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLiteLoader;

namespace ZiFaktura
{
    public partial class BillBase : UserControl
    {
        
        public BillBase()
        {
            InitializeComponent();
            Createallbill();
            
        }

        public void Createallbill()
        {
            //////////////////
            ///Get data from database by query getBillmodel
            //////////////////
            /* 
            paneldateparrent.Controls.Clear();
            List<getBiilmodel> x = Sqlader.getQuery();
            foreach (getBiilmodel item in x)
            {
                CreateOnebill(item.Dokument, item.Brutto.ToString().Insert(item.Brutto.ToString().Length-2,","), item.Data_wystawienia);
            }
            */
            paneldateparrent.Controls.Clear();
            List<string> name = Sqlader.getColumn("Dokument");
            List<string> price = Sqlader.getColumn("Brutto");
            List<string> dateW = Sqlader.getColumn("Data_wystawienia");
            List<string> dateS = Sqlader.getColumn("Data_sprzedazy");
            List<string> netto = Sqlader.getColumn("Netto");
            List<string> nip = Sqlader.getColumn("NIP");
            List<string> vat = Sqlader.getColumn("Vat");
            List<string> addres = Sqlader.getColumn("Adres");
            List<string> country = Sqlader.getColumn("Kraj");
            List<string> paymethond = Sqlader.getColumn("Sposob_platnosci");
            List<string> postcode = Sqlader.getColumn("Kod_pocztowy");
            List<string> fname = Sqlader.getColumn("Imie");
            List<string> lname = Sqlader.getColumn("Nazwisko");
            List<string> city = Sqlader.getColumn("Miasto");



            for (int i = 0; i < name.Count; i++)
            {
                CreateOnebilltest(name[i], price[i], dateW[i],dateS[i],netto[i],fname[i],lname[i],nip[i],addres[i],postcode[i],city[i],vat[i],country[i],paymethond[i]);
            }

        }
        public void CreateOnebill(string document, string price, string date) 
        {
            //create main panel of the one element
            Panel mainoneview = new Panel();
            mainoneview.Dock = DockStyle.Top;
            mainoneview.Size = new Size(paneldateparrent.Width, 60);
            mainoneview.Parent = paneldateparrent;
            mainoneview.Font = new Font("Microsoft YaHei UI", 12);
            

            // label with date of issue
            Label datee = new Label();
            datee.Parent = mainoneview;
            datee.Size = new Size(labelname.Width, labelname.Height);
            datee.Text = date;
            datee.Dock = DockStyle.Left;
            datee.Font = new Font("Microsoft YaHei UI", 12);
            datee.BorderStyle = BorderStyle.FixedSingle;
            // label with price
            Label cost = new Label();
            cost.Parent = mainoneview;
            cost.Size = new Size(labelname.Width, labelname.Height);
            cost.Text = price.ToString();
            cost.Dock = DockStyle.Left;
            cost.Font = new Font("Microsoft YaHei UI", 12);
            cost.BorderStyle = BorderStyle.FixedSingle;

            // create label with name of bill in mainoneview
            Label name = new Label();
            name.Parent = mainoneview;
            name.Text = document;
            name.Dock = DockStyle.Left;
            name.Size = new Size(labelname.Width, labelname.Height);
            name.Font = new Font("Microsoft YaHei UI", 12);
            name.BorderStyle = BorderStyle.FixedSingle;


            foreach (Control item in mainoneview.Controls)
            {
                item.MouseHover += (s, e) => { mainoneview.BackColor = Color.Red; };
                item.MouseLeave += (s, e) => { mainoneview.BackColor = Color.White; };
            }



        }
        public void CreateOnebilltest(string document, string price, string date,string datesale,string netto, string fname, string lname, string nip, string addres, string postc, string city, string vat, string country, string pmethod)
        {
            //create main panel of the one element
            Panel mainoneview = new Panel();
            mainoneview.Dock = DockStyle.Top;
            mainoneview.Size = new Size(paneldateparrent.Width, 60);
            mainoneview.Parent = paneldateparrent;
            mainoneview.Font = new Font("Microsoft YaHei UI", 12);


            // label with date of issue
            Label datee = new Label();
            datee.Parent = mainoneview;
            datee.Size = new Size(labelname.Width, labelname.Height);
            datee.Text = date;
            datee.Dock = DockStyle.Left;
            datee.Font = new Font("Microsoft YaHei UI", 12);
            datee.BorderStyle = BorderStyle.FixedSingle;
            // label with price
            Label cost = new Label();
            cost.Parent = mainoneview;
            cost.Size = new Size(labelname.Width, labelname.Height);
            cost.Text = price.ToString();
            cost.Dock = DockStyle.Left;
            cost.Font = new Font("Microsoft YaHei UI", 12);
            cost.BorderStyle = BorderStyle.FixedSingle;

            // create label with name of bill in mainoneview
            Label name = new Label();
            name.Parent = mainoneview;
            name.Text = document;
            name.Dock = DockStyle.Left;
            name.Size = new Size(labelname.Width, labelname.Height);
            name.Font = new Font("Microsoft YaHei UI", 12);
            name.BorderStyle = BorderStyle.FixedSingle;


            foreach (Control item in mainoneview.Controls)
            {
                item.MouseClick += (s, e) => {
                    clsfield();
                    labelDokument.Text = document;
                    labelImie.Text = fname;
                    labelkodp.Text = postc;
                    labelKraj.Text = country;
                    labelMiasto.Text = city;
                    labelnazwisko.Text = lname;
                    labelnip.Text = nip;
                    labelsplatnosci.Text = pmethod;
                    labelvat.Text = vat;
                    labelDataW.Text = date;
                    labeldatasprzeday.Text = datesale;
                    labelCBrutto.Text = price;
                    labelCNetto.Text = netto;
                    labeladres.Text = addres;
                
                };
                item.MouseHover += (s, e) => { mainoneview.BackColor = Color.FromArgb(211, 224, 234); };
                item.MouseLeave += (s, e) => { mainoneview.BackColor = Color.White; };
            }

            void clsfield()
            {
                labelDokument.Text = "";
                labelImie.Text = "";
                labelkodp.Text = "";
                labelKraj.Text = "";
                labelMiasto.Text = "";
                labelnazwisko.Text = "";
                labelnip.Text = "";
                labelsplatnosci.Text = "";
                labelvat.Text = "";
                labelDataW.Text = "";
                labeldatasprzeday.Text = "";
                labelCBrutto.Text = "";
                labelCNetto.Text = "";
                labeladres.Text = "";
            }



        }




        private void Mainoneview_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void restbuttonclick()
        {
            buttonname.Text = "Nazwa";
            buttondatesort.Text = "Data";
            buttonsortprice.Text = "Cena";
        }
        int nameclick = 0;
        int dataclick = 0;
        int priceclick = 0;
        private void buttonname_Click(object sender, EventArgs e)
        {

            restbuttonclick();
            if (nameclick == 0)
            {
                paneldateparrent.Controls.Clear();
                List<string> name = Sqlader.getColumnSort("Dokument","Dokument");
                List<string> price = Sqlader.getColumnSort("Brutto", "Dokument");
                List<string> dateW = Sqlader.getColumnSort("Data_wystawienia", "Dokument");
                List<string> dateS = Sqlader.getColumnSort("Data_sprzedazy", "Dokument");
                List<string> netto = Sqlader.getColumnSort("Netto", "Dokument");
                List<string> nip = Sqlader.getColumnSort("NIP", "Dokument");
                List<string> vat = Sqlader.getColumnSort("Vat", "Dokument");
                List<string> addres = Sqlader.getColumnSort("Adres", "Dokument");
                List<string> country = Sqlader.getColumnSort("Kraj", "Dokument");
                List<string> paymethond = Sqlader.getColumnSort("Sposob_platnosci", "Dokument");
                List<string> postcode = Sqlader.getColumnSort("Kod_pocztowy", "Dokument");
                List<string> fname = Sqlader.getColumnSort("Imie", "Dokument");
                List<string> lname = Sqlader.getColumnSort("Nazwisko", "Dokument");
                List<string> city = Sqlader.getColumnSort("Miasto", "Dokument");
                buttonname.Text = "Nazwa ^";
                for (int i = 0; i < name.Count; i++)
                {
                    CreateOnebilltest(name[i], price[i], dateW[i], dateS[i], netto[i], fname[i], lname[i], nip[i], addres[i], postcode[i], city[i], vat[i], country[i], paymethond[i]);
                }
                nameclick++;
            }
            else
            {
                paneldateparrent.Controls.Clear();
                List<string> name = Sqlader.getColumnSort("Dokument", "Dokument","DESC");
                List<string> price = Sqlader.getColumnSort("Brutto", "Dokument", "DESC");
                List<string> dateW = Sqlader.getColumnSort("Data_wystawienia", "Dokument", "DESC");
                List<string> dateS = Sqlader.getColumnSort("Data_sprzedazy", "Dokument", "DESC");
                List<string> netto = Sqlader.getColumnSort("Netto", "Dokument", "DESC");
                List<string> nip = Sqlader.getColumnSort("NIP", "Dokument", "DESC");
                List<string> vat = Sqlader.getColumnSort("Vat", "Dokument", "DESC");
                List<string> addres = Sqlader.getColumnSort("Adres", "Dokument", "DESC");
                List<string> country = Sqlader.getColumnSort("Kraj", "Dokument", "DESC");
                List<string> paymethond = Sqlader.getColumnSort("Sposob_platnosci", "Dokument", "DESC");
                List<string> postcode = Sqlader.getColumnSort("Kod_pocztowy", "Dokument", "DESC");
                List<string> fname = Sqlader.getColumnSort("Imie", "Dokument", "DESC");
                List<string> lname = Sqlader.getColumnSort("Nazwisko", "Dokument", "DESC");
                List<string> city = Sqlader.getColumnSort("Miasto", "Dokument", "DESC");
                buttonname.Text = "Nazwa ˅";
                for (int i = 0; i < name.Count; i++)
                {
                    CreateOnebilltest(name[i], price[i], dateW[i], dateS[i], netto[i], fname[i], lname[i], nip[i], addres[i], postcode[i], city[i], vat[i], country[i], paymethond[i]);
                }
                nameclick = 0;
            }
            
        }

        private void buttondatesort_Click(object sender, EventArgs e)
        {
            restbuttonclick();
            if (dataclick == 0)
            {
                paneldateparrent.Controls.Clear();
                List<string> name = Sqlader.getColumnSort("Dokument", "Data_wystawienia");
                List<string> price = Sqlader.getColumnSort("Brutto", "Data_wystawienia");
                List<string> dateW = Sqlader.getColumnSort("Data_wystawienia", "Data_wystawienia");
                List<string> dateS = Sqlader.getColumnSort("Data_sprzedazy", "Data_wystawienia");
                List<string> netto = Sqlader.getColumnSort("Netto", "Data_wystawienia");
                List<string> nip = Sqlader.getColumnSort("NIP", "Data_wystawienia");
                List<string> vat = Sqlader.getColumnSort("Vat", "Data_wystawienia");
                List<string> addres = Sqlader.getColumnSort("Adres", "Data_wystawienia");
                List<string> country = Sqlader.getColumnSort("Kraj", "Data_wystawienia");
                List<string> paymethond = Sqlader.getColumnSort("Sposob_platnosci", "Data_wystawienia");
                List<string> postcode = Sqlader.getColumnSort("Kod_pocztowy", "Data_wystawienia");
                List<string> fname = Sqlader.getColumnSort("Imie", "Data_wystawienia");
                List<string> lname = Sqlader.getColumnSort("Nazwisko", "Data_wystawienia");
                List<string> city = Sqlader.getColumnSort("Miasto", "Data_wystawienia");
                buttondatesort.Text = "Data ^";
                for (int i = 0; i < name.Count; i++)
                {
                    CreateOnebilltest(name[i], price[i], dateW[i], dateS[i], netto[i], fname[i], lname[i], nip[i], addres[i], postcode[i], city[i], vat[i], country[i], paymethond[i]);

                }
                dataclick++;
            }
            else
            {
                paneldateparrent.Controls.Clear();
                List<string> name = Sqlader.getColumnSort("Dokument", "Data_wystawienia", "DESC");
                List<string> price = Sqlader.getColumnSort("Brutto", "Data_wystawienia", "DESC");
                List<string> dateW = Sqlader.getColumnSort("Data_wystawienia", "Data_wystawienia", "DESC");
                List<string> dateS = Sqlader.getColumnSort("Data_sprzedazy", "Data_wystawienia", "DESC");
                List<string> netto = Sqlader.getColumnSort("Netto", "Data_wystawienia", "DESC");
                List<string> nip = Sqlader.getColumnSort("NIP", "Data_wystawienia", "DESC");
                List<string> vat = Sqlader.getColumnSort("Vat", "Data_wystawienia", "DESC");
                List<string> addres = Sqlader.getColumnSort("Adres", "Data_wystawienia", "DESC");
                List<string> country = Sqlader.getColumnSort("Kraj", "Data_wystawienia", "DESC");
                List<string> paymethond = Sqlader.getColumnSort("Sposob_platnosci", "Data_wystawienia", "DESC");
                List<string> postcode = Sqlader.getColumnSort("Kod_pocztowy", "Data_wystawienia", "DESC");
                List<string> fname = Sqlader.getColumnSort("Imie", "Data_wystawienia", "DESC");
                List<string> lname = Sqlader.getColumnSort("Nazwisko", "Data_wystawienia", "DESC");
                List<string> city = Sqlader.getColumnSort("Miasto", "Data_wystawienia", "DESC");
                buttondatesort.Text = "Data ˅";
                for (int i = 0; i < name.Count; i++)
                {
                    CreateOnebilltest(name[i], price[i], dateW[i], dateS[i], netto[i], fname[i], lname[i], nip[i], addres[i], postcode[i], city[i], vat[i], country[i], paymethond[i]);
                }
                dataclick = 0;
            }
        }

        private void buttonsortprice_Click(object sender, EventArgs e)
        {
            restbuttonclick();
            if (priceclick == 0)
            {
                paneldateparrent.Controls.Clear();
                List<string> name = Sqlader.getColumnSort("Dokument", "Brutto");
                List<string> price = Sqlader.getColumnSort("Brutto", "Brutto");
                List<string> dateW = Sqlader.getColumnSort("Data_wystawienia", "Brutto");
                List<string> dateS = Sqlader.getColumnSort("Data_sprzedazy", "Brutto");
                List<string> netto = Sqlader.getColumnSort("Netto", "Brutto");
                List<string> nip = Sqlader.getColumnSort("NIP", "Brutto");
                List<string> vat = Sqlader.getColumnSort("Vat", "Brutto");
                List<string> addres = Sqlader.getColumnSort("Adres", "Brutto");
                List<string> country = Sqlader.getColumnSort("Kraj", "Brutto");
                List<string> paymethond = Sqlader.getColumnSort("Sposob_platnosci", "Brutto");
                List<string> postcode = Sqlader.getColumnSort("Kod_pocztowy", "Brutto");
                List<string> fname = Sqlader.getColumnSort("Imie", "Brutto");
                List<string> lname = Sqlader.getColumnSort("Nazwisko", "Brutto");
                List<string> city = Sqlader.getColumnSort("Miasto", "Brutto");
                buttonsortprice.Text = "Cena ^";
                for (int i = 0; i < name.Count; i++)
                {
                    CreateOnebilltest(name[i], price[i], dateW[i], dateS[i], netto[i], fname[i], lname[i], nip[i], addres[i], postcode[i], city[i], vat[i], country[i], paymethond[i]);
                }
                priceclick++;
            }
            else
            {
                paneldateparrent.Controls.Clear();
                List<string> name = Sqlader.getColumnSort("Dokument", "Brutto", "DESC");
                List<string> price = Sqlader.getColumnSort("Brutto", "Brutto", "DESC");
                List<string> dateW = Sqlader.getColumnSort("Data_wystawienia", "Brutto", "DESC");
                List<string> dateS = Sqlader.getColumnSort("Data_sprzedazy", "Brutto", "DESC");
                List<string> netto = Sqlader.getColumnSort("Netto", "Brutto", "DESC");
                List<string> nip = Sqlader.getColumnSort("NIP", "Brutto", "DESC");
                List<string> vat = Sqlader.getColumnSort("Vat", "Brutto", "DESC");
                List<string> addres = Sqlader.getColumnSort("Adres", "Brutto", "DESC");
                List<string> country = Sqlader.getColumnSort("Kraj", "Brutto", "DESC");
                List<string> paymethond = Sqlader.getColumnSort("Sposob_platnosci", "Brutto", "DESC");
                List<string> postcode = Sqlader.getColumnSort("Kod_pocztowy", "Brutto", "DESC");
                List<string> fname = Sqlader.getColumnSort("Imie", "Brutto", "DESC");
                List<string> lname = Sqlader.getColumnSort("Nazwisko", "Brutto", "DESC");
                List<string> city = Sqlader.getColumnSort("Miasto", "Brutto", "DESC");
                buttonsortprice.Text = "Cena ˅";
                for (int i = 0; i < name.Count; i++)
                {
                    CreateOnebilltest(name[i], price[i], dateW[i], dateS[i], netto[i], fname[i], lname[i], nip[i], addres[i], postcode[i], city[i], vat[i], country[i], paymethond[i]);
                }
                priceclick = 0;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            restbuttonclick();
            paneldateparrent.Controls.Clear();
            
            
            List<string> name = Sqlader.getValue("Dokument", "Dokument", textBoxSearchBill.Text);
            List<string> price = Sqlader.getValue("Brutto", "Dokument", textBoxSearchBill.Text);
            List<string> dateW = Sqlader.getValue("Data_wystawienia", "Dokument", textBoxSearchBill.Text);
            List<string> dateS = Sqlader.getValue("Data_sprzedazy", "Dokument", textBoxSearchBill.Text);
            List<string> netto = Sqlader.getValue("Netto", "Dokument", textBoxSearchBill.Text);
            List<string> nip = Sqlader.getValue("NIP", "Dokument", textBoxSearchBill.Text);
            List<string> vat = Sqlader.getValue("Vat", "Dokument", textBoxSearchBill.Text);
            List<string> addres = Sqlader.getValue("Adres", "Dokument", textBoxSearchBill.Text);
            List<string> country = Sqlader.getValue("Kraj", "Dokument", textBoxSearchBill.Text);
            List<string> paymethond = Sqlader.getValue("Sposob_platnosci", "Dokument", textBoxSearchBill.Text);
            List<string> postcode = Sqlader.getValue("Kod_pocztowy", "Dokument", textBoxSearchBill.Text);
            List<string> fname = Sqlader.getValue("Imie", "Dokument", textBoxSearchBill.Text);
            List<string> lname = Sqlader.getValue("Nazwisko", "Dokument", textBoxSearchBill.Text);
            List<string> city = Sqlader.getValue("Miasto", "Dokument", textBoxSearchBill.Text);
            for (int i = 0; i < name.Count; i++)
            {
                CreateOnebilltest(name[i], price[i], dateW[i], dateS[i], netto[i], fname[i], lname[i], nip[i], addres[i], postcode[i], city[i], vat[i], country[i], paymethond[i]);
            }
            textBoxSearchBill.Text = "";
        }

        
    }
}
