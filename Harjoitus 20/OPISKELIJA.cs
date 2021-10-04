using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Harjoitus_20
{
    class OPISKELIJA
    {
        YHDISTA yhteys = new YHDISTA();

        public bool lisaaOpiskelija(string enimi, string snimi, string puh, string email, int onro)
        {
            MySqlCommand komento = new MySqlCommand();
            string lisayskysely = "INSERT INTO yhteystiedot " + "(etunimi, sukunimi, puhelin, sahkoposti, opiskelijanumero) " + "VALUES (@enm, @snm, @puh, @eml, @ono); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@ono", MySqlDbType.VarChar).Value = onro;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }



        public DataTable haeOpiskelijat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT Oid, etunimi, sukunimi, puhelin, sahkoposti, opiskelijanumero FROM yhteystiedot", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        public bool muokkaaOpiskelijaa(int Oid, string enimi, string snimi, string puh, string email, int onro)
        {
            MySqlCommand komento = new MySqlCommand();
            string paivityskysely = "UPDATE `yhteystiedot` SET `etunimi`=@enm, " + "`sukunimi`=@snm,`puhelin`=@puh,`sahkoposti`= @eml,`opiskelijanumero`=@ono" + " WHERE Oid = @oid";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@ono", MySqlDbType.VarChar).Value = onro;
            komento.Parameters.Add("@oid", MySqlDbType.VarChar).Value = Oid;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }


        public bool poistaOpiskelijat(string ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            string poistakysely = "DELETE FROM yhteystiedot WHERE Oid = @oid";
            komento.CommandText = poistakysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@oid", MySqlDbType.UInt32).Value = ktunnus;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
    }
}
