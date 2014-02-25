using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiceRoller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string sideofdi;

        private void ARL()
        {
            string i = sideofdi+ "-" + lblOut.Text;
            lbRolls.Items.Insert(0,i);

            
            int x = (lbRolls.Items.Count - 1);
                if (x > 7)
                {
                    lbRolls.Items.RemoveAt(8);
                }
        }

        

        private Random rnd = new Random();

        private void btD2_Click(object sender, EventArgs e)
        {
            sideofdi = "D2";
            int d2 = (int)((rnd.NextDouble() * 2) + 1);
            lblOut.Text = d2.ToString();
            ARL();
        }

        private void btD4_Click(object sender, EventArgs e)
        {
            sideofdi = "D4";
            int d4 = (int) ((rnd.NextDouble() * 4)+1);
            lblOut.Text = d4.ToString();
            ARL();
        }
        private void btD6_Click(object sender, EventArgs e)
        {
            sideofdi = "D6";
            int d6= (int)((rnd.NextDouble() * 6) + 1);
            lblOut.Text = d6.ToString();
            ARL();
        }

        private void btD8_Click(object sender, EventArgs e)
        {
            sideofdi = "D8";
            int d8 = (int)((rnd.NextDouble() * 8) + 1);
            lblOut.Text = d8.ToString();
            ARL();
        }

        private void btD10_Click(object sender, EventArgs e)
        {
            sideofdi = "D10";
            int d10 = (int)((rnd.NextDouble() * 10) + 1);
            lblOut.Text = d10.ToString();
            ARL();
        }

        private void btD12_Click(object sender, EventArgs e)
        {
            sideofdi = "D12";
            int d12 = (int)((rnd.NextDouble() * 12) + 1);
            lblOut.Text = d12.ToString();
            ARL();
        }

        private void btD20_Click(object sender, EventArgs e)
        {
            sideofdi = "D20";
            int d20 = (int)((rnd.NextDouble() * 20) + 1);
            lblOut.Text = d20.ToString();
            ARL();
        }


        private void btClear_Click(object sender, EventArgs e)
        {
            lbRolls.Items.Clear();
        }
       
    }
}
