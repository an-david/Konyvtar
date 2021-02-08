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
    public partial class kereses : Form
    {
        public kereses()
        {
            InitializeComponent();
        }

        private void kereses_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns[0].Name = "k_azon";
            dataGridView1.Columns[0].HeaderText = "Azonosító";

            dataGridView1.Columns[1].Name = "cim";
            dataGridView1.Columns[1].HeaderText = "Cím";

            dataGridView1.Columns[2].Name = "szerzo";
            dataGridView1.Columns[2].HeaderText = "Szerző";

            dataGridView1.Columns[3].Name = "kiado";
            dataGridView1.Columns[3].HeaderText = "Kiadó";

            dataGridView1.Columns[4].Name = "megj";
            dataGridView1.Columns[4].HeaderText = "Megjelenés";

            dataGridView1.Columns[5].Name = "mufaj";
            dataGridView1.Columns[5].HeaderText = "Műfaj";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cim = tb_konyvcim.Text;

            dataGridView1.Rows.Clear();
            betolt(cim);
        }

        public void betolt(string cim)
        {
            Program.sql.CommandText = "SELECT * FROM konyv WHERE cim = '" + cim + "';";
            using (MySqlDataReader dr = Program.sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    int uj_sor_index = dataGridView1.Rows.Add();

                    DataGridViewRow uj_sor = dataGridView1.Rows[uj_sor_index];
                    uj_sor.Cells["k_azon"].Value = dr.GetInt32("k_azon");
                    uj_sor.Cells["cim"].Value = dr.GetString("cim");
                    uj_sor.Cells["szerzo"].Value = dr.GetString("szerzo");
                    uj_sor.Cells["kiado"].Value = dr.GetString("kiado");
                    uj_sor.Cells["megj"].Value = dr.GetString("megj");
                    uj_sor.Cells["mufaj"].Value = dr.GetString("mufaj");
                }
            }
        }

        private void bt_vissza_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.alapertelmezett.Show();
        }
    }
}
