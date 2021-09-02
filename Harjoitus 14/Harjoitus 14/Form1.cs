using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Harjoitus_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = System.IO.File.ReadAllText(@"C:/Users/jesse.mitronen/source/repos/Harjoitus 14/Harjoitus 14/Tehtava14.txt");
            teksti += SyotaTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.mm.yyyy HH:mm") + "\n";
            TextWriter txt = new StreamWriter("C:/Users/jesse.mitronen/source/repos/Harjoitus 14/Harjoitus 14/Tehtava14.txt");
            txt.Write(teksti);
            txt.Close();
            Application.Exit();
        }
    }
}
