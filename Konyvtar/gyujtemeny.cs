using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Konyvtar
{
    public partial class gyujtemeny : Form
    {
        public gyujtemeny()
        {
            InitializeComponent();
        }

        private void gyujtemeny_Load(object sender, EventArgs e)
        {
            Program.sql.CommandText = "SELECT ar FROM vasarlas";
            using (MySqlDataReader dr = Program.sql.ExecuteReader())
            {
                int brutto = 0;
                int netto = 0;
                while (dr.Read())
                {
                    brutto += Convert.ToInt32(0.25 * dr.GetInt32("ar"));
                    netto += Convert.ToInt32(dr.GetInt32("ar"));
                }
                lb_brutto.Text = "" + (netto + brutto) + " Ft.";
            }
        }

        private void bt_vissza_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.alapertelmezett.Show();
        }
    }
}
