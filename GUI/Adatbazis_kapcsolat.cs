using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace GUI
{
    class Adatbazis_kapcsolat
    {
        MySqlCommand sqlparancs = null;
        MySqlConnection adatbazis_kapcsolodas = null;

        public Adatbazis_kapcsolat()
        {
            MySqlConnectionStringBuilder adatbazis_kapcsolat_felepitese = new MySqlConnectionStringBuilder();

            adatbazis_kapcsolat_felepitese.Server = "localhost";
            adatbazis_kapcsolat_felepitese.UserID = "root";
            adatbazis_kapcsolat_felepitese.Password = "";
            adatbazis_kapcsolat_felepitese.Database = "munkasok";
            adatbazis_kapcsolodas = new MySqlConnection(adatbazis_kapcsolat_felepitese.ConnectionString);

            try
            {
                adatbazis_kapcsolat_nyitasa();
                sqlparancs = adatbazis_kapcsolodas.CreateCommand();
                adatbazis_kapcsolat_zarasa();

            }
            catch (MySqlException adatbazis_kivitel_kezeles)
            {
                MessageBox.Show(adatbazis_kivitel_kezeles.Message);
                Environment.Exit(0);
             
            }
        }

        internal List<Dolgozo> getAllDolgozo()
        {
            List<Dolgozo> dolgozos = new List<Dolgozo>();
            sqlparancs.CommandText = "SELECT * FROM dolgozok";
            adatbazis_kapcsolat_nyitasa();
            using (MySqlDataReader adatbazis_olvasas = sqlparancs.ExecuteReader())
            {

            }

            return dolgozos;
        }

        private void adatbazis_kapcsolat_zarasa()
        {
            if (adatbazis_kapcsolodas.State == System.Data.ConnectionState.Open)
            {
                adatbazis_kapcsolodas.Close();
            }
        }

        private void adatbazis_kapcsolat_nyitasa()
        {
            if (adatbazis_kapcsolodas.State== System.Data.ConnectionState.Open)
            {
                adatbazis_kapcsolodas.Open();
            }
        }
    }
}
