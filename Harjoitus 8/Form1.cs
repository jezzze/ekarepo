using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PoistuBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
            PituusTB.Text = "";
            PainoTB.Text = "";
            VastausTB.Text = "";

            KgRB.Checked = false;
            LbRB.Checked = false;
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double Paino = Convert.ToDouble(PainoTB.Text);
            double Pituus = Convert.ToDouble(PituusTB.Text);
            double Vastaus = 0.0;

            if (KgRB.Checked)
            {
                Vastaus = Paino / (Pituus * Pituus);
            }
            else
                if (LbRB.Checked)
            {
                Paino = Paino / 2.205;
                Vastaus = Paino / (Pituus * Pituus);
            }
            VastausTB.Text = "Sinun BMI on: " + Vastaus.ToString("#.#");

        }
    }
}
