using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Harjoitus_15
{
    public partial class sekunttiForm : Form
    {
        private Stopwatch sekunttikello;
        public sekunttiForm()
        {
            InitializeComponent();
        }
        private void KaynnistaBT_Click(object sender, EventArgs e)
        {
            sekunttikello.Start();
        }

        private void LopetaBT_Click(object sender, EventArgs e)
        {
            sekunttikello.Stop();
        }

        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            sekunttikello.Reset();
        }

        private void sekunttiForm_Load(object sender, EventArgs e)
        {
            sekunttikello = new Stopwatch();
        }

        private void AikaTM_Tick(object sender, EventArgs e)
        {
            AikaLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", sekunttikello.Elapsed);
        }
    }
}
