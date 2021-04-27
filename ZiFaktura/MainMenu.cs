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
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
            labelNameview.Paint += new PaintEventHandler(this.labelNameview_Paint);
            Getinfo();
            
        }

        private void labelNameview_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, labelNameview.DisplayRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        public void Getinfo()
        {
            List<string> bills = Sqlader.getColumn("Brutto");
            List<float> fbills = new List<float>();
            float x;
            foreach (string item in bills)
            {
                if (float.TryParse(item, out _))
                {
                    fbills.Add(float.Parse(item));
                };
            }
            List<string> netto = Sqlader.getColumn("Netto");
            List<float> fnetto = new List<float>();
            foreach (string item in netto)
            {
                if (float.TryParse(item, out _))
                {
                    fnetto.Add(float.Parse(item));
                };
            }

            label2.Text = bills.Count.ToString();

            label6.Text = (fbills.Sum() / fbills.Count).ToString();

            label8.Text = (fbills.Sum() - fnetto.Sum()).ToString();
            
        }

        
    }
}
