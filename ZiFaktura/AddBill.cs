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
    public partial class AddBill : UserControl
    {
        public AddBill()
        {
            InitializeComponent();
            
        }

        public void Add(BillModel bill)
        {
            Sqlader.SaveBill(bill);
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {

            if (ValidateChildren())
            {
                MessageBox.Show("Faktura został wprowadzona.","Udane");
                BillModel bill = new BillModel();
                
                bill.Document = texboxdocument.Text;
                bill.FirstName = texboxFirstname.Text;
                bill.LastName = textBoxlastname.Text;
                bill.NIP =  int.TryParse(textBoxnip.Text,out _) ? int.Parse(textBoxnip.Text) : 0;
                bill.Address = texboxaddress.Text;
                bill.Postcode = textBoxpostcode.Text;
                bill.City = textBoxcity.Text;
                bill.dateofissue = dateTimePicker1.Text;
                bill.dateofsale = dateTimePicker2.Text;
                bill.Netto = float.Parse(texboxnetto.Text);
                bill.Vat = float.Parse(textBoxvat.Text) / 100;
                bill.Brutto = bill.Netto * bill.Vat + bill.Netto;
                bill.Payment = textboxpay.Text;
                bill.Country = textboxcountry.Text;
                Add(bill);
            }
            else
            {
                MessageBox.Show("Popraw błędy.","Błąd");
            }
            
        }
        
        private void texboxdocument_Validating(object sender, CancelEventArgs e)
        {
            
            if (string.IsNullOrEmpty(texboxdocument.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(texboxdocument, "Podaj nazwę faktury.");
                errorProvider1.SetIconPadding(texboxdocument, -20);



            }
            else
            {
                e.Cancel = false;
            }
        }

        private void texboxFirstname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(texboxFirstname.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(texboxFirstname, "Podaj imię.");
                errorProvider1.SetIconPadding(texboxFirstname, -20);



            }
            else
            {
                e.Cancel = false;
            }
        }

        private void textBoxlastname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxlastname.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxlastname, "Podaj nazwisko.");
                errorProvider1.SetIconPadding(textBoxlastname, -20);



            }
            else
            {
                e.Cancel = false;
            }
        }

        private void textBoxnip_Validating(object sender, CancelEventArgs e)
        {
            // NIP validating
        }

        private void texboxaddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(texboxaddress.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(texboxaddress, "Podaj adres.");
                errorProvider1.SetIconPadding(texboxaddress, -20);



            }
            else
            {
                e.Cancel = false;
            }
        }

        private void textBoxpostcode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxpostcode.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxpostcode, "Podaj kod pocztowy (xx-xxx).");
                errorProvider1.SetIconPadding(textBoxpostcode, -20);



            }
            else
            {
                e.Cancel = false;
            }
        }

        private void textBoxcity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxcity.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxcity, "Podaj miasto.");
                errorProvider1.SetIconPadding(textBoxcity, -20);



            }
            else
            {
                e.Cancel = false;
            }
        }

        

        private void texboxnetto_Validating(object sender, CancelEventArgs e)
        {
            
            if (string.IsNullOrEmpty(texboxnetto.Text) || int.TryParse(texboxnetto.Text, out _) ? false : true)
            {
                e.Cancel = true;
                errorProvider1.SetError(texboxnetto, "Podaj liczbę.");
                errorProvider1.SetIconPadding(texboxnetto, -20);



            }
            else
            {
                e.Cancel = false;
            }
        }

        private void textBoxvat_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxvat.Text) || int.TryParse(textBoxvat.Text, out _) ? false : true)
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxvat, "Podaj liczbę.");
                errorProvider1.SetIconPadding(textBoxvat, -20);



            }
            else
            {
                e.Cancel = false;
            }
        }

        private void textboxpay_Validating(object sender, CancelEventArgs e)
        {
            // texboxpay validating
        }

        private void textboxcountry_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textboxcountry.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textboxcountry, "Podaj kraj.");
                errorProvider1.SetIconPadding(textboxcountry, -20);



            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
