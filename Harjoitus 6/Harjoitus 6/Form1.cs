using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_6
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void tarkistaBT_Click(object sender, EventArgs e)
        {
            if(kayttajaTB.Text == "jesse" && salasanaTB.Text == "Jesse123")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;

            }
            else
            {
                VirheViestiLB.Text = "Käyttäjätunnus tai salasana on virheellinen!";
                VirheViestiLB.Visible = true;
            }
        }

        private void salasanaTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
