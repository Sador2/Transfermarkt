using System;
using System.Data;
using MySql.Data.MySqlClient;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace MySQL_Test
{
    public class Klasse_Transfermarkt
    {
        //Attribut
        private string connectionString;

        //Eigenschaft
        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        //Konstroktor
        public Klasse_Transfermarkt()
        {
            // Verbindungsinformationen zusammensetzen
            connectionString = $"Server=localhost;Database=transfermarkt;Uid=root; Pwd=12345;";
        }
        public Klasse_Transfermarkt(string server, string database, string user, string password) :this()
        {
            // Verbindungsinformationen zusammensetzen
            ConnectionString = $"Server={server};Database={database};Uid={user};Pwd={password};";
        }

        //Methode
        public void OpenConnection()
        {
            // Verbindung zur Datenbank öffnen
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();
        }

        public void CloseConnection()
        {
            // Verbindung zur Datenbank schließen
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Close();
        }

        //Probe
        public void InsertPlayer(string name, DateTime birthDate, int nationId)
        {
            // Verbindung zur Datenbank öffnen und sicherstellen, dass sie ordnungsgemäß geschlossen wird
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open(); // Verbindung öffnen
                                   // SQL-Abfrage zum Einfügen eines neuen Spielers
                string query = "INSERT INTO Spieler (Name, Geburtsdatum, NationID) VALUES (@name, @birthDate, @nationId)";
                // SQL-Befehl vorbereiten
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Parameter für die SQL-Abfrage festlegen
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@birthDate", birthDate);
                    command.Parameters.AddWithValue("@nationId", nationId);
                    // SQL-Abfrage ausführen, um den neuen Spieler einzufügen
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

    }
}
