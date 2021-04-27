using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.IO;
using System.Globalization;
using SQLiteLoader;

namespace ZiFaktura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cusDesign();
        }

        private void cusDesign()
        {
            panelBillSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelBillSubMenu.Visible == true)
            {
                panelBillSubMenu.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void hideusercontrol(UserControl ucontrol) 
        {
            if (ucontrol.Visible == true)
            {
                ucontrol.Visible = false;
            }
        }

        private void buttonBill_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBillSubMenu);
            panelMainview.Controls.Clear();
            panelMainview.Controls.Add(new MainMenu());
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            panelMainview.Controls.Clear();
            panelMainview.Controls.Add(new settings());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelMainview.Controls.Clear();
            panelMainview.Controls.Add(new BillBase());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelMainview.Controls.Clear();
            panelMainview.Controls.Add(new AddBill());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelMainview.Controls.Clear();
            panelMainview.Controls.Add(new importdata());
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "plik csv (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    using (var writer = new StreamWriter(myStream))
                    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    {
                        csv.WriteRecords(Sqlader.getQuery());
                    }
                    MessageBox.Show("Plik został utworzony");
                    myStream.Close();
                }
            }




            
        }
    }
}
