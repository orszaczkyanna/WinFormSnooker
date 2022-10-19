using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormSnooker
{
    class Adatbazis
    {
        MySqlConnection connection = null;
        MySqlCommand cmd = null;

        //Konstruktor
        public Adatbazis(string server = "localhost", string userID = "root", string password = "", string database = "snooker")
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = server;
            sb.UserID = userID;
            sb.Password = password;
            sb.Database = database;
            connection = new MySqlConnection(sb.ConnectionString);
            try
            {
                connection.Open();
                cmd = connection.CreateCommand();
                connection.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\nA kapcsolat felépítése sikertelen.\nA program leáll.");
                Environment.Exit(0);
            }

        }


        //Az összes versenyzőt tartalmazó lista
        public List<Versenyzo> osszesVersenyzo()
        {
            List<Versenyzo> osszes = new List<Versenyzo>();
            cmd.CommandText = "SELECT `Id`,`Helyezes`,`Nev`,`Orszag`,`Nyeremeny` FROM `snooker`;";
            try
            {
                connection.Open();
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Versenyzo uj = new Versenyzo(
                            dr.GetUInt64("Id"), 
                            dr.GetInt32("Helyezes"), 
                            dr.GetString("Nev"), 
                            dr.GetString("Orszag"), 
                            dr.GetInt32("Nyeremeny")
                        );
                        osszes.Add(uj);
                    }
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return osszes;

        }


        //Meglévő versenyző adatainak módosítása
        public void versenyzoUpdate(Versenyzo versenyzo)
        {
            try
            {
                connection.Open();
                cmd.Parameters.Clear();

                cmd.CommandText = "UPDATE `snooker` SET `Helyezes`= @helyezes,`Nev`= @nev,`Orszag`= @orszag,`Nyeremeny`= @nyeremeny WHERE `Id`= @id;";
                cmd.Parameters.AddWithValue("@helyezes", versenyzo.Helyezes);
                cmd.Parameters.AddWithValue("@nev", versenyzo.Nev);
                cmd.Parameters.AddWithValue("@orszag", versenyzo.Orszag);
                cmd.Parameters.AddWithValue("@nyeremeny", versenyzo.Nyeremeny);
                cmd.Parameters.AddWithValue("@id", versenyzo.Id);
                
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }       


        //Versenyző törlése
        public void versenyzoDelete(string id)
        {
            try
            {
                connection.Open();
                cmd.Parameters.Clear();
                cmd.CommandText = "DELETE FROM `snooker` WHERE `Id` = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                connection.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Új versenyző hozzáadása
        public void versenyzoInsert(Versenyzo versenyzo)
        {
            try
            {
                connection.Open();
                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO `snooker`(`Id`, `Helyezes`, `Nev`, `Orszag`, `Nyeremeny`) VALUES (@Id, @Helyezes, @Nev, @Orszag, @Nyeremeny);";
                cmd.Parameters.AddWithValue("@Id", versenyzo.Id);
                cmd.Parameters.AddWithValue("@Helyezes", versenyzo.Helyezes);
                cmd.Parameters.AddWithValue("@Nev", versenyzo.Nev);
                cmd.Parameters.AddWithValue("@Orszag", versenyzo.Orszag);
                cmd.Parameters.AddWithValue("@Nyeremeny", versenyzo.Nyeremeny);

                cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
