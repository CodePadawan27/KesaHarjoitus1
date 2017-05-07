using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KesaHarjoitus1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NumeerinenYA.Value = 100;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NumeerinenYA.Value++;

        }

        private void aNappi1_Click(object sender, EventArgs e)
        {

            if (aValinta1.Checked)
            {
                MessageBox.Show("Teit valinnan!");

            }
        }

        private void aValinta1_CheckedChanged(object sender, EventArgs e)
        {
            

            }

        private void aOsoiteRivi_TextChanged(object sender, EventArgs e)
        {
            try
            {


                aOmaSelain.Url = new Uri(aOsoiteRivi.Text);
            } catch {
            }
        }

        private void NumeerinenYA_ValueChanged(object sender, EventArgs e)
        {
            aEdistymispalkki.Minimum = (int)NumeerinenYA.Minimum;
            aEdistymispalkki.Maximum = (int)NumeerinenYA.Maximum;

            aEdistymispalkki.Value = (int)NumeerinenYA.Value;

        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

