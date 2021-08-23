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
            VastausLB.Text = "";

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
            if (Vastaus < 18.5)
            {
                VastausLB.Text = "painoindeksisi on: " + Vastaus;
                VastausLB.ForeColor = Color.Aqua;
                KuvausLB.Text = "Alipaino";
                KuvausLB.ForeColor = Color.Aqua;
                KuvausLB.Visible = true;
                VastausLB.Visible = true;
            }
            else if(Vastaus < 25)
            {
                VastausLB.Text = "painoindeksisi on: " + Vastaus;
                VastausLB.ForeColor = Color.Green;
                KuvausLB.Text = "Normaalipaino";
                KuvausLB.ForeColor = Color.Green;
                KuvausLB.Visible = true;
                VastausLB.Visible = true;
            }
            else if(Vastaus < 40)
            {
                VastausLB.Text = "painoindeksisi on: " + Vastaus;
                VastausLB.ForeColor = Color.Gold;
                KuvausLB.Text = "Ylipaino";
                KuvausLB.ForeColor = Color.Gold;
                KuvausLB.Visible = true;
                VastausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = "painoindeksisi on: " + Vastaus;
                VastausLB.ForeColor = Color.Red;
                KuvausLB.Text = "Huomattava ylipaino";
                KuvausLB.ForeColor = Color.Red;
                KuvausLB.Visible = true;
                VastausLB.Visible = true;

            }
           

        }
    }
}
