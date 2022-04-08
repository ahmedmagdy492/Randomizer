using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randomizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandomizer_Click(object sender, EventArgs e)
        {
            RandomCompare randomCompare = new RandomCompare();
            randomCompare.WindowState = FormWindowState.Maximized;
            randomCompare.ShowDialog();
        }

        private void BtnMyThings_Click(object sender, EventArgs e)
        {
            MyThings myThings = new MyThings();
            myThings.WindowState = FormWindowState.Maximized;
            myThings.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                btnRandomizer.PerformClick();
            }
            else if (e.KeyCode == Keys.F2)
            {
                BtnMyThings.PerformClick();
            }
            else if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}
