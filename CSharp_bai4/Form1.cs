using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txttqd_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length>0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.errorProvider1.SetError(ctr,"Phải nhập số ");
                btvndtoeur.Enabled = false;
                btvndtousd.Enabled = false;
                bteurtovnd.Enabled = false;
                btusdtovnd.Enabled = false;
            }
            else
            {
                this.errorProvider1.Clear();
                bteurtovnd.Enabled = true;
                btusdtovnd.Enabled = true;
                btvndtoeur.Enabled= true;
                btvndtousd.Enabled= true;
            }    
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void txtkq_TextChanged(object sender, EventArgs e)
        {

        }

        private void btvndtousd_Click(object sender, EventArgs e)
        {
            double sotien = Convert.ToDouble(txtkq.Text);
            txtkq.Text = Math.Round(sotien*17861,2).ToString();
        }
    }
}
