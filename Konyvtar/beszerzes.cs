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
    public partial class beszerzes : Form
    {
        public beszerzes()
        {
            InitializeComponent();
        }

        private void beszerzes_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns[0].Name = "szam";
            dataGridView1.Columns[0].HeaderText = "Szám";

            dataGridView1.Columns[1].Name = "azon";
            dataGridView1.Columns[1].HeaderText = "Azonosító";

            dataGridView1.Columns[2].Name = "datum";
            dataGridView1.Columns[2].HeaderText = "Dátum";

            dataGridView1.Columns[3].Name = "ar";
            dataGridView1.Columns[3].HeaderText = "Ár";

            betolt();
    }

    public void betolt()
    {
        Program.sql.CommandText = "SELECT * FROM vasarlas;";
        using (MySqlDataReader dr = Program.sql.ExecuteReader())
        {
            while (dr.Read())
            {
                int uj_sor_index = dataGridView1.Rows.Add();

                DataGridViewRow uj_sor = dataGridView1.Rows[uj_sor_index];
                uj_sor.Cells["szam"].Value = dr.GetInt32("szam");
                uj_sor.Cells["azon"].Value = dr.GetInt32("azon");
                uj_sor.Cells["datum"].Value = dr.GetMySqlDateTime("datum");
                uj_sor.Cells["ar"].Value = dr.GetString("ar");
            }
        }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(konyv_id.Value);
            string ar = tb_konyvara.Text;
            string beszerzesi_ido = dateTimePicker1.Value.ToString("yyyy-MM-dd-h-mm-ss");
            
            Program.sql.CommandText = "INSERT INTO vasarlas (azon, ar, datum) " +
                "VALUES  (" + id + ", '" + ar + "', '" + beszerzesi_ido + "');";

            Program.sql.ExecuteNonQuery();

            dataGridView1.Rows.Clear();
            betolt();
        }

        private void bt_vissza_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.alapertelmezett.Show();
        }
    }
}
