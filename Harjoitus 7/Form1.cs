using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MuutaBT_Click(object sender, EventArgs e)
        {
            if(CelsiusToRB.Checked == true)
            {
                VastausLB.Text = Convert.ToString((Convert.ToInt16(MaaraTB.Text) + 5 / 9) - 32); 
            }
            if(FahrenheitToRB.Checked == true)
            {
                VastausLB.Text = Convert.ToString((Convert.ToInt16(MaaraTB.Text) + 5 / 9) + 32);
                VastausLB.Visible = true;
            }
            VastausLB.Visible = true;
        }
    }
    
}
