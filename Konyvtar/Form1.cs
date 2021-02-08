using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konyvtar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void könyvFelvételeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.felvetel.Show();
        }

        private void könyvTörléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.torles.Show();
        }

        private void könyvBeszerzésénekBeviteleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.beszerzes.Show();
        }

        private void könyvKereséseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.kereses.Show();
        }

        private void gyüjteményToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.gyujtemeny.Show();
        }
    }
}
