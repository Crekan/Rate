using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rate
{
    public partial class Rate : Form
    {
        public Rate()
        {
            InitializeComponent();
            total.Controls[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double startcount = Convert.ToDouble(numstartcount.Value);
            double rate = Convert.ToDouble(numpercent.Value);
            int years = Convert.ToInt32(numyears.Value);

            rate = rate / 100;
            int periods = 0;

            if (comboprocess.SelectedIndex == 0)
            {
                double dayRate = rate / 365;
                periods = years * 365;
                startcount = startcount * Math.Pow((1 + dayRate), periods);
                total.Text = Convert.ToString(Math.Round(startcount, 2));

            }
            else if (comboprocess.SelectedIndex == 1)
            {
                double monthRate = rate / 12;
                periods = years * 12;
                startcount = startcount * Math.Pow((1 + monthRate), periods);
                total.Text = Convert.ToString(Math.Round(startcount, 2));
            }
            else if (comboprocess.SelectedIndex == 2)
            {
                double quarterRate = rate / 4;
                periods = years * 4;
                startcount = startcount * Math.Pow((1 + quarterRate), periods);
                total.Text = Convert.ToString(Math.Round(startcount, 2));
            }
            else if (comboprocess.SelectedIndex == 3)
            {
                double halfyearRate = rate / 2;
                periods = years * 2;
                startcount = startcount * Math.Pow((1 + halfyearRate), periods);
                total.Text = Convert.ToString(Math.Round(startcount, 2));
            }
            else if (comboprocess.SelectedIndex == 4)
            {
                double yearRate = rate;
                periods = years;
                startcount = startcount * Math.Pow((1 + yearRate), periods);
                total.Text = Convert.ToString(Math.Round(startcount, 2));
            }
            else
            {
                comboprocess.Text = "Процесс не выбран";
            }
        }
    }
}
