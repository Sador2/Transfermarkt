using System;
using MySql.Data.MySqlClient;
namespace MySQL_Test
{
    public partial class FrmHauptForm : Form
    {
        public FrmHauptForm()
        {
            InitializeComponent();
            InitializeListView();
        }


        private void InitializeListView()
        {
            listView.Columns.Clear();

            listView.View = View.Details;
            listView.FullRowSelect = true;
        }

        private void btnSpieler_Click(object sender, EventArgs e)
        {
            ViewÜberschrieft("Spieler", "SpielerID", "Name", "Geburtsdatum", "NationID");

            // Erstellen einer Instanz von Klasse_Transfermarkt
            Klasse_Transfermarkt klasse_Transfermarkt = new Klasse_Transfermarkt();

            // Verwenden eines using-Blocks, um die Datenbankverbindung zu öffnen
            using (MySqlConnection aconnection = new MySqlConnection(klasse_Transfermarkt.ConnectionString))
            {
                aconnection.Open(); // Verbindung öffnen
                string aquery = "SELECT * FROM spieler"; // SQL-Abfrage, um alle Spieler abzurufen

                using (MySqlCommand acommand = new MySqlCommand(aquery, aconnection))
                {
                    using (MySqlDataReader reader = acommand.ExecuteReader())
                    {
                        listView.Items.Clear(); // Bestehende Elemente in der ListView löschen

                        // Schleife über die Ergebnisse der Abfrage
                        while (reader.Read())
                        {
                            // Erstellen eines ListViewItems für jeden Spieler
                            ListViewItem item = new ListViewItem(reader["SpielerID"].ToString());
                            item.SubItems.Add(reader["Name"].ToString());
                            item.SubItems.Add(reader["Geburtsdatum"].ToString());
                            item.SubItems.Add(reader["NationID"].ToString());

                            // Hinzufügen des ListViewItems zur ListView
                            listView.Items.Add(item);
                        }
                    }
                }
            }
        }
        private void btnAuszeichnung_Click(object sender, EventArgs e)
        {
            ViewÜberschrieft("Auszeichnung", "SpielerID", "VereinID","Name","Jahr");
            // Erstellen einer Instanz von Klasse_Transfermarkt
            Klasse_Transfermarkt klasse_Transfermarkt = new Klasse_Transfermarkt();

            // Verwenden eines using-Blocks, um die Datenbankverbindung zu öffnen
            using (MySqlConnection aconnection = new MySqlConnection(klasse_Transfermarkt.ConnectionString))
            {
                aconnection.Open(); // Verbindung öffnen
                string aquery = "SELECT * FROM auszeichnung"; // SQL-Abfrage, um alle Spieler abzurufen

                using (MySqlCommand acommand = new MySqlCommand(aquery, aconnection))
                {
                    using (MySqlDataReader reader = acommand.ExecuteReader())
                    {
                        listView.Items.Clear(); // Bestehende Elemente in der ListView löschen

                        // Schleife über die Ergebnisse der Abfrage
                        while (reader.Read())
                        {
                            // Erstellen eines ListViewItems für jeden Spieler
                            ListViewItem item = new ListViewItem(reader["SpielerID"].ToString());
                            item.SubItems.Add(reader["VereinID"].ToString());
                            item.SubItems.Add(reader["Name"].ToString());
                            item.SubItems.Add(reader["Jahr"].ToString());

                            // Hinzufügen des ListViewItems zur ListView
                            listView.Items.Add(item);
                        }
                    }
                }
            }
        }
        private void btnStatistik_Click(object sender, EventArgs e)
        {
            ViewÜberschrieft("Statistik", "StatistikID", "SpielerID", "Statistiktyp","Wert");
            // Erstellen einer Instanz von Klasse_Transfermarkt
            Klasse_Transfermarkt klasse_Transfermarkt = new Klasse_Transfermarkt();

            // Verwenden eines using-Blocks, um die Datenbankverbindung zu öffnen
            using (MySqlConnection aconnection = new MySqlConnection(klasse_Transfermarkt.ConnectionString))
            {
                aconnection.Open(); // Verbindung öffnen
                string aquery = "Select * From Statistik"; // SQL-Abfrage, um alle Spieler abzurufen

                using (MySqlCommand acommand = new MySqlCommand(aquery, aconnection))
                {
                    using (MySqlDataReader reader = acommand.ExecuteReader())
                    {
                        listView.Items.Clear(); // Bestehende Elemente in der ListView löschen

                        // Schleife über die Ergebnisse der Abfrage
                        while (reader.Read())
                        {
                            // Erstellen eines ListViewItems für jeden Spieler
                            ListViewItem item = new ListViewItem(reader["StatistikID"].ToString());
                            item.SubItems.Add(reader["SpielerID"].ToString());
                            item.SubItems.Add(reader["Statistiktyp"].ToString());
                            item.SubItems.Add(reader["Wert"].ToString());

                            // Hinzufügen des ListViewItems zur ListView
                            listView.Items.Add(item);
                        }
                    }
                }
            }
        }
        private void btnNation_Click(object sender, EventArgs e)
        {
            ViewÜberschrieft("Nation", "NationID", "Name");
            // Erstellen einer Instanz von Klasse_Transfermarkt
            Klasse_Transfermarkt klasse_Transfermarkt = new Klasse_Transfermarkt();

            // Verwenden eines using-Blocks, um die Datenbankverbindung zu öffnen
            using (MySqlConnection aconnection = new MySqlConnection(klasse_Transfermarkt.ConnectionString))
            {
                aconnection.Open(); // Verbindung öffnen
                string aquery = "Select * From Nation"; // SQL-Abfrage, um alle Spieler abzurufen

                using (MySqlCommand acommand = new MySqlCommand(aquery, aconnection))
                {
                    using (MySqlDataReader reader = acommand.ExecuteReader())
                    {
                        listView.Items.Clear(); // Bestehende Elemente in der ListView löschen

                        // Schleife über die Ergebnisse der Abfrage
                        while (reader.Read())
                        {
                            // Erstellen eines ListViewItems für jeden Spieler
                            ListViewItem item = new ListViewItem(reader["NationID"].ToString());
                            item.SubItems.Add(reader["Name"].ToString());

                            // Hinzufügen des ListViewItems zur ListView
                            listView.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void btnVerein_Click(object sender, EventArgs e)
        {
            ViewÜberschrieft("Verein", "VereinID", "Name", "WerbepartnerID");
            // Erstellen einer Instanz von Klasse_Transfermarkt
            Klasse_Transfermarkt klasse_Transfermarkt = new Klasse_Transfermarkt();

            // Verwenden eines using-Blocks, um die Datenbankverbindung zu öffnen
            using (MySqlConnection aconnection = new MySqlConnection(klasse_Transfermarkt.ConnectionString))
            {
                aconnection.Open(); // Verbindung öffnen
                string aquery = "Select * From Verein"; // SQL-Abfrage, um alle Spieler abzurufen

                using (MySqlCommand acommand = new MySqlCommand(aquery, aconnection))
                {
                    using (MySqlDataReader reader = acommand.ExecuteReader())
                    {
                        listView.Items.Clear(); // Bestehende Elemente in der ListView löschen

                        // Schleife über die Ergebnisse der Abfrage
                        while (reader.Read())
                        {
                            // Erstellen eines ListViewItems für jeden Spieler
                            ListViewItem item = new ListViewItem(reader["VereinID"].ToString());
                            item.SubItems.Add(reader["Name"].ToString());
                            item.SubItems.Add(reader["WerbepartnerID"].ToString());

                            // Hinzufügen des ListViewItems zur ListView
                            listView.Items.Add(item);
                        }
                    }
                }
            }
        }
        private void btnTrainer_Click(object sender, EventArgs e)
        {
            ViewÜberschrieft("Trainer", "TrainerID", "Name", "VereinID");
            // Erstellen einer Instanz von Klasse_Transfermarkt
            Klasse_Transfermarkt klasse_Transfermarkt = new Klasse_Transfermarkt();

            // Verwenden eines using-Blocks, um die Datenbankverbindung zu öffnen
            using (MySqlConnection aconnection = new MySqlConnection(klasse_Transfermarkt.ConnectionString))
            {
                aconnection.Open(); // Verbindung öffnen
                string aquery = "Select * From Trainer"; // SQL-Abfrage, um alle Spieler abzurufen

                using (MySqlCommand acommand = new MySqlCommand(aquery, aconnection))
                {
                    using (MySqlDataReader reader = acommand.ExecuteReader())
                    {
                        listView.Items.Clear(); // Bestehende Elemente in der ListView löschen

                        // Schleife über die Ergebnisse der Abfrage
                        while (reader.Read())
                        {
                            // Erstellen eines ListViewItems für jeden Spieler
                            ListViewItem item = new ListViewItem(reader["TrainerID"].ToString());
                            item.SubItems.Add(reader["Name"].ToString());
                            item.SubItems.Add(reader["VereinID"].ToString());

                            // Hinzufügen des ListViewItems zur ListView
                            listView.Items.Add(item);
                        }
                    }
                }
            }
        }
        private void btnVertrag_Click(object sender, EventArgs e)
        {
            ViewÜberschrieft("Vertrag", "VertragID", "SpielerID", "VereinID", "Startdatum", "Enddatum", "Gehalt") ;
            // Erstellen einer Instanz von Klasse_Transfermarkt
            Klasse_Transfermarkt klasse_Transfermarkt = new Klasse_Transfermarkt();

            // Verwenden eines using-Blocks, um die Datenbankverbindung zu öffnen
            using (MySqlConnection aconnection = new MySqlConnection(klasse_Transfermarkt.ConnectionString))
            {
                aconnection.Open(); // Verbindung öffnen
                string aquery = "Select * From Vertrag"; // SQL-Abfrage, um alle Spieler abzurufen

                using (MySqlCommand acommand = new MySqlCommand(aquery, aconnection))
                {
                    using (MySqlDataReader reader = acommand.ExecuteReader())
                    {
                        listView.Items.Clear(); // Bestehende Elemente in der ListView löschen

                        // Schleife über die Ergebnisse der Abfrage
                        while (reader.Read())
                        {
                            // Erstellen eines ListViewItems für jeden Spieler
                            ListViewItem item = new ListViewItem(reader["VertragID"].ToString());
                            item.SubItems.Add(reader["SpielerID"].ToString());
                            item.SubItems.Add(reader["VereinID"].ToString());
                            item.SubItems.Add(reader["Startdatum"].ToString());
                            item.SubItems.Add(reader["Enddatum"].ToString());
                            item.SubItems.Add(reader["Gehalt"].ToString());

                            // Hinzufügen des ListViewItems zur ListView
                            listView.Items.Add(item);
                        }
                    }
                }
            }
        }
        private void btnWerbepartner_Click(object sender, EventArgs e)
        {
            ViewÜberschrieft("Werbepartner", "WerbepartnerID", "Name");
            // Erstellen einer Instanz von Klasse_Transfermarkt
            Klasse_Transfermarkt klasse_Transfermarkt = new Klasse_Transfermarkt();

            // Verwenden eines using-Blocks, um die Datenbankverbindung zu öffnen
            using (MySqlConnection aconnection = new MySqlConnection(klasse_Transfermarkt.ConnectionString))
            {
                aconnection.Open(); // Verbindung öffnen
                string aquery = "Select * From Werbepartner"; // SQL-Abfrage, um alle Spieler abzurufen

                using (MySqlCommand acommand = new MySqlCommand(aquery, aconnection))
                {
                    using (MySqlDataReader reader = acommand.ExecuteReader())
                    {
                        listView.Items.Clear(); // Bestehende Elemente in der ListView löschen

                        // Schleife über die Ergebnisse der Abfrage
                        while (reader.Read())
                        {
                            // Erstellen eines ListViewItems für jeden Spieler
                            ListViewItem item = new ListViewItem(reader["WerbepartnerID"].ToString());
                            item.SubItems.Add(reader["Name"].ToString());

                            // Hinzufügen des ListViewItems zur ListView
                            listView.Items.Add(item);
                        }
                    }
                }
            }
        }
        private void btnWettbewerb_Click(object sender, EventArgs e)
        {
            ViewÜberschrieft("Werbepartner", "WettbewerbID", "Name", "Jahr");
            // Erstellen einer Instanz von Klasse_Transfermarkt
            Klasse_Transfermarkt klasse_Transfermarkt = new Klasse_Transfermarkt();

            // Verwenden eines using-Blocks, um die Datenbankverbindung zu öffnen
            using (MySqlConnection aconnection = new MySqlConnection(klasse_Transfermarkt.ConnectionString))
            {
                aconnection.Open(); // Verbindung öffnen
                string aquery = "Select * From Wettbewerb"; // SQL-Abfrage, um alle Spieler abzurufen

                using (MySqlCommand acommand = new MySqlCommand(aquery, aconnection))
                {
                    using (MySqlDataReader reader = acommand.ExecuteReader())
                    {
                        listView.Items.Clear(); // Bestehende Elemente in der ListView löschen

                        // Schleife über die Ergebnisse der Abfrage
                        while (reader.Read())
                        {
                            // Erstellen eines ListViewItems für jeden Spieler
                            ListViewItem item = new ListViewItem(reader["WettbewerbID"].ToString());
                            item.SubItems.Add(reader["Name"].ToString());
                            item.SubItems.Add(reader["Jahr"].ToString());

                            // Hinzufügen des ListViewItems zur ListView
                            listView.Items.Add(item);
                        }
                    }
                }
            }
        }


        /*
        public string ListeAnzeigen()
        {
            // Zuerst löschen wir alle vorhandenen Elemente
            listView.Items.Clear();
            ListViewItem newitem = new ListViewItem();

            // Dann fügen wir jedes Objekt in einem ListViewItem hinzu
            foreach (string transfer in listTransfer)
            {
                newitem.SubItems.Add(" ");
            }
            return listView.ToString();

            for (int i = listTransfer.Count; i <= 0; i--)
            {
                newitem.SubItems.Add(" ");
            }
        }
        */
        public void ViewÜberschrieft(string tabelle, string eins, string zwei, string drei = "", string vier = "", string fünf = "", string sechs = "")
        {
            lblÜberschrieft.Text = $"Tablle Anzeigen von: {tabelle}";
            listView.Columns.Clear();
            listView.Columns.Add(eins, 100, HorizontalAlignment.Left);
            listView.Columns.Add(zwei, 100, HorizontalAlignment.Left);
            listView.Columns.Add(drei, 100, HorizontalAlignment.Left);
            listView.Columns.Add(vier, 100, HorizontalAlignment.Left);
            listView.Columns.Add(fünf, 100, HorizontalAlignment.Left);
            listView.Columns.Add(sechs, 100, HorizontalAlignment.Left);
        }
    }
}