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

namespace Harjoitus_17
{
    public partial class MuistioForm : Form
    {
        private OpenFileDialog OpenFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;
        public MuistioForm()
        {
            InitializeComponent();
        }
        private void UusiTiedosto()
        {
            try
            {
                if (!string.IsNullOrEmpty(TeksitiTB.Text))
                {
                    MessageBox.Show("Sinun pitää tallentaa ensin!");
                }
                else
                {
                    TeksitiTB.Text = string.Empty;
                    Text = "Nimetön";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }
        private void TallennaTiedosto()
        {
            try
            {
                if (!string.IsNullOrEmpty(TeksitiTB.Text))
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Teksti tiedosto (*.txt) | *.txt | RTF-tiedosto (*.RTF) | *.RTF";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, TeksitiTB.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }
        private void AvaaTiedosto()
        {
            try
            {
                OpenFileDialog = new OpenFileDialog();

                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TeksitiTB.Text = File.ReadAllText(OpenFileDialog.FileName);
                    Text = OpenFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("virhe avattaessa tiedostoa!");
            }
        }

        

        private void MuistioForm_Load(object sender, EventArgs e)
        {
            fontDialog = new FontDialog();
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UusiTiedosto();
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvaaTiedosto();
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TallennaTiedosto();
        }

        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TeksitiTB.Text))
                {
                    TallennaTiedosto();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }

        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(fontDialog.ShowDialog() == DialogResult.OK)
                {
                    TeksitiTB.Font = fontDialog.Font;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }
        
    }
}
