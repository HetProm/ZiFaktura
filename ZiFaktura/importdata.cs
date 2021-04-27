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
using CsvHelper;
using System.IO;
using System.Globalization;

namespace ZiFaktura
{
    public partial class importdata : UserControl
    {
        public importdata()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                label1.Text = ofd.FileName;
                using (var read = new StreamReader(ofd.SafeFileName))
                using(var csv = new CsvReader(read, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<getBiilmodel>().ToList();
                    foreach (getBiilmodel item in records)
                    {
                        Sqlader.SaveBillv2(item);
                    }
                }
                MessageBox.Show("Import udany.");
            }

        }
    }
}
