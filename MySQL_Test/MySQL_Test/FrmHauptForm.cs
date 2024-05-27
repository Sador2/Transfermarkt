using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySQL_Test
{
    public partial class FrmHauptForm : Form
    {
        //Attribut
        public string AktuelleTabelle;
        //Eigenschaft
        private int SelectedRowID
        {
            get
            {
                int selectedRowID = -1; // Standardwert, wenn keine Zeile ausgewählt ist

                // Überprüfen, ob eine Zeile ausgewählt ist
                if (listView.SelectedItems.Count > 0)
                {
                    // Den Wert der ersten Spalte (z. B. die SpaltenID) auslesen
                    string idString = listView.SelectedItems[0].SubItems[0].Text;

                    // Versuchen, die ID in eine Ganzzahl umzuwandeln
                    int.TryParse(idString, out selectedRowID);
                }
                return selectedRowID;
            }
        }

        public FrmHauptForm()
        {
            AktuelleTabelle = "";
            InitializeComponent();
            InitializierenListView();
        }

        private void InitializierenListView()
        {
            listView.Columns.Clear();
            listView.View = View.Details;
            listView.FullRowSelect = true;
        }

        private void TabelleAnzeige(string query, params string[] columnNames)
        {
            Klasse_Transfermarkt klasse_Transfermarkt = new Klasse_Transfermarkt();

            using (MySqlConnection aconnection = new MySqlConnection(klasse_Transfermarkt.ConnectionString))
            {
                aconnection.Open();
                using (MySqlCommand acommand = new MySqlCommand(query, aconnection))
                {
                    using (MySqlDataReader reader = acommand.ExecuteReader())
                    {
                        listView.Items.Clear();
                        listView.Columns.Clear();

                        foreach (string columnName in columnNames)
                        {
                            listView.Columns.Add(columnName, 100, HorizontalAlignment.Left);
                        }

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader[columnNames[0]].ToString());
                            for (int i = 1; i < columnNames.Length; i++)
                            {
                                item.SubItems.Add(reader[columnNames[i]].ToString());
                            }
                            listView.Items.Add(item);
                        }
                    }
                }
            }
        }

        public void ViewÜberschrieft(string tabelle)
        {
            lblÜberschrieft.Text = $"Tabelle anzeigen von: {tabelle}";
            AktuelleTabelle = tabelle;
        }

        private void btnSpieler_Click(object sender, EventArgs e)
        {
            ViewÜberschrieft("Spieler");
            string query = "SELECT Spieler.SpielerID, Spieler.Name, Spieler.Geburtsdatum, Spieler.NationID FROM Spieler";
            TabelleAnzeige(query,"SpielerID", "Name", "Geburtsdatum", "NationID");
        }

        private void btnAuszeichnung_Click(object sender, EventArgs e)
        {
            ViewÜberschrieft("Auszeichnung");
            string query = "SELECT Auszeichnung.SpielerID, Auszeichnung.VereinID, Auszeichnung.Name, Auszeichnung.Jahr FROM Auszeichnung";
            TabelleAnzeige(query, "SpielerID", "VereinID", "Name", "Jahr");
        }

        private void btnStatistik_Click(object sender, EventArgs e)
        {
            ViewÜberschrieft("Statistik");
            string query = "SELECT Statistik.StatistikID, Statistik.SpielerID, Statistik.Statistiktyp, Statistik.Wert FROM Statistik";
            TabelleAnzeige(query, "StatistikID", "SpielerID", "Statistiktyp", "Wert");
        }

        private void btnNation_Click(object sender, EventArgs e)
        {
            ViewÜberschrieft("Nation");
            string query = "SELECT Nation.NationID, Nation.Name FROM Nation";
            TabelleAnzeige(query, "NationID", "Name");
        }

        private void btnVerein_Click(object sender, EventArgs e)
        {
            ViewÜberschrieft("Verein");
            string query = "SELECT Verein.VereinID, Verein.Name, Verein.WerbepartnerID FROM Verein";
            TabelleAnzeige(query, "VereinID", "Name", "WerbepartnerID");
        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {
            ViewÜberschrieft("Trainer");
            string query = "SELECT Trainer.TrainerID, Trainer.Name, Trainer.VereinID FROM Trainer";
            TabelleAnzeige(query, "TrainerID", "Name", "VereinID");
        }

        private void btnVertrag_Click(object sender, EventArgs e)
        {
            ViewÜberschrieft("Vertrag");
            string query = "SELECT Vertrag.VertragID, Vertrag.SpielerID, Vertrag.VereinID, Vertrag.Startdatum, Vertrag.Enddatum, Vertrag.Gehalt FROM Vertrag";
            TabelleAnzeige(query, "VertragID", "SpielerID", "VereinID", "Startdatum", "Enddatum", "Gehalt");
        }

        private void btnWerbepartner_Click(object sender, EventArgs e)
        {
            ViewÜberschrieft("Werbepartner");
            string query = "SELECT Werbepartner.WerbepartnerID, Werbepartner.Name FROM Werbepartner";
            TabelleAnzeige(query, "WerbepartnerID", "Name");
        }

        private void btnWettbewerb_Click(object sender, EventArgs e)
        {
            ViewÜberschrieft("Wettbewerb");
            string query = "SELECT Wettbewerb.WettbewerbID, Wettbewerb.Name, Wettbewerb.Jahr FROM Wettbewerb";
            TabelleAnzeige(query, "WettbewerbID", "Name", "Jahr");
        }

        private void btnSpalteHinzufügen_Click(object sender, EventArgs e)
        {
            if (AktuelleTabelle == "")
            {
                throw new Exception("Welche Tabelle?");
            }
            else
            {
                FrmNeueSpalte frmNeueSpalte = new FrmNeueSpalte();
                if (frmNeueSpalte.DialogResult == DialogResult.OK)
                {
                    switch (AktuelleTabelle)
                    {
                        case "Spieler":

                            break;

                        case "Auszeichnung":

                            break;

                        case "Statistik":

                            break;

                        case "Nation":

                            break;

                        case "Verein":

                            break;

                        case "Trainer":

                            break;

                        case "Vertrag":

                            break;

                        case "Werbepartner":

                            break;

                        case "Wettbewerb":

                            break;
                    }
                }
            }
        }

        private void btnSpalteLoeschen_Click(object sender, EventArgs e)
        {
            // Überprüfen, ob eine Zeile ausgewählt ist
            if (listView.SelectedItems.Count > 0)
            {
                // Die ausgewählten Zeilen löschen
                foreach (ListViewItem selectedItem in listView.SelectedItems)
                {
                    // Den Wert der ersten Spalte (z. B. die SpielerID) auslesen
                    string id = selectedItem.SubItems[0].Text;

                    // Bestätigen, ob der Benutzer die Zeile wirklich löschen möchte
                    DialogResult result = MessageBox.Show("Möchten Sie die ausgewählte Zeile wirklich löschen?", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Erstellen Sie eine Instanz von Klasse_Transfermarkt
                        Klasse_Transfermarkt klasse_Transfermarkt = new Klasse_Transfermarkt();

                        // Den Tabellennamen übergeben
                        string tableName = AktuelleTabelle; // Setzen Sie den Namen Ihrer Tabelle hier ein
                        string spalteName = AktuelleTabelle; // Setzen Sie den Namen Ihrer Tabelle hier ein
                        int idZahl = SelectedRowID;

                        if (AktuelleTabelle == "Auszeichnung")
                        { spalteName = "Spieler"; }

                        // Überprüfen Sie die Gültigkeit des Tabellennamens
                        if (!string.IsNullOrEmpty(tableName))
                        {
                            // Verbinden Sie sich mit der Datenbank und führen Sie den Löschbefehl aus
                            using (MySqlConnection connection = new MySqlConnection(klasse_Transfermarkt.ConnectionString))
                            {
                                try
                                {
                                    connection.Open();
                                    string deleteQuery = $"DELETE FROM {tableName} WHERE {spalteName}ID = {idZahl}"; // Ändern Sie dies entsprechend Ihrer Tabellenstruktur

                                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                                    {
                                        command.Parameters.AddWithValue("@id", id);
                                        command.ExecuteNonQuery();
                                    }

                                    // Die Zeile aus der ListView entfernen
                                    listView.Items.Remove(selectedItem);

                                    // Benachrichtigen Sie den Benutzer über das erfolgreiche Löschen
                                    MessageBox.Show("Die Zeile wurde erfolgreich gelöscht.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    // Fehlerbehandlung für Datenbankfehler
                                    MessageBox.Show("Ein Fehler ist beim Löschen der Zeile aufgetreten: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ungültiger Tabellenname.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie zuerst eine Zeile zum Löschen aus.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmHauptForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Überprüfen, ob der Benutzer das Formular wirklich schließen möchte
            DialogResult result = MessageBox.Show("Möchten Sie das Formular wirklich schließen?", "Formular schließen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Wenn der Benutzer Nein wählt, die Schließung des Formulars abbrechen
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnSpierInfo_Click(object sender, EventArgs e)
        {
            FrmProzedurEingabe frmProzedurEingabe = new FrmProzedurEingabe();
            ViewÜberschrieft("Spieler Info");

            if (frmProzedurEingabe.ShowDialog() == DialogResult.OK)
            {
                Klasse_Transfermarkt flasse_Transfermarkt = new Klasse_Transfermarkt();                
                string query = $"CALL SpielerInformationen('{frmProzedurEingabe.SpielerName}')";

                // Verbindung zur Datenbank herstellen und die gespeicherte Prozedur ausführen
                using (MySqlConnection connection = new MySqlConnection(flasse_Transfermarkt.ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    listView.Items.Clear();
                                    listView.Columns.Clear();

                                    // Spalten hinzufügen
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        listView.Columns.Add(reader.GetName(i), 100, HorizontalAlignment.Left);
                                    }

                                    // Daten anzeigen
                                    while (reader.Read())
                                    {
                                        ListViewItem item = new ListViewItem(reader.GetString(0)); // Annahme: Erste Spalte enthält Spielername
                                        for (int i = 1; i < reader.FieldCount; i++)
                                        {
                                            // Wert aus der Datenbank lesen und entsprechend seines Typs abrufen
                                            object value = reader.GetValue(i);
                                            string formattedValue = value is DBNull ? "" : value.ToString();
                                            item.SubItems.Add(formattedValue);
                                        }
                                        listView.Items.Add(item);
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Es wurden keine Spielerinformationen gefunden.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


    }
}
