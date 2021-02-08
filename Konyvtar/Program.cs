using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Konyvtar
{
    static class Program
    {

        // Forms.
        public static felvetel felvetel = null;
        public static torles torles = null;
        public static beszerzes beszerzes = null;
        public static kereses kereses = null;
        public static gyujtemeny gyujtemeny = null;
        public static Form1 alapertelmezett = null;

        // Adatbázis kapcsolat.
        public static MySqlConnection conn = null;
        public static MySqlCommand sql = null;

        [STAThread]
        static void Main()
        {
            // Kapcsolat létrehozása.
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "konyves_ab";
            conn = new MySqlConnection(sb.ToString());

            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                //Environment.Exit(0);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            alapertelmezett = new Form1();
            torles = new torles();
            felvetel = new felvetel();
            beszerzes = new beszerzes();
            kereses = new kereses();
            gyujtemeny = new gyujtemeny();
            Application.Run(alapertelmezett);
        }
    }
}
