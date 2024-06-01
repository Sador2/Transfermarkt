using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using static System.Net.Mime.MediaTypeNames;

namespace MySQL_Test
{
    public partial class FrmHauptForm : Form
    {
        //Attribut
        public string AktuelleTabelle;
        //Eigenschaft
        public static string BenutzerZustand = "Gast";
        private int SelectedRowID
        {
            get
            {
                int selectedRowID = -1; // Standardwert, wenn keine Zeile ausgew�hlt ist

                // �berpr�fen, ob eine Zeile ausgew�hlt ist
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
            AktuelleTabelle = "";;
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

        public void View�berschrieft(string tabelle)
        {
            lbl�berschrieft.Text = $"Tabelle anzeigen von: {tabelle}";
            AktuelleTabelle = tabelle;
        }

        private void btnSpieler_Click(object sender, EventArgs e)
        {
            View�berschrieft("Spieler");
            string query = "SELECT Spieler.SpielerID, Spieler.Name, Spieler.Geburtsdatum, Spieler.NationID FROM Spieler";
            TabelleAnzeige(query,"SpielerID", "Name", "Geburtsdatum", "NationID");
        }

        private void btnAuszeichnung_Click(object sender, EventArgs e)
        {
            View�berschrieft("Auszeichnung");
            string query = "SELECT Auszeichnung.SpielerID, Auszeichnung.VereinID, Auszeichnung.Name, Auszeichnung.Jahr FROM Auszeichnung";
            TabelleAnzeige(query, "SpielerID", "VereinID", "Name", "Jahr");
        }

        private void btnStatistik_Click(object sender, EventArgs e)
        {
            View�berschrieft("Statistik");
            string query = "SELECT Statistik.StatistikID, Statistik.SpielerID, Statistik.Statistiktyp, Statistik.Wert FROM Statistik";
            TabelleAnzeige(query, "StatistikID", "SpielerID", "Statistiktyp", "Wert");
        }

        private void btnNation_Click(object sender, EventArgs e)
        {
            View�berschrieft("Nation");
            string query = "SELECT Nation.NationID, Nation.Name FROM Nation";
            TabelleAnzeige(query, "NationID", "Name");
        }

        private void btnVerein_Click(object sender, EventArgs e)
        {
            View�berschrieft("Verein");
            string query = "SELECT Verein.VereinID, Verein.Name, Verein.WerbepartnerID FROM Verein";
            TabelleAnzeige(query, "VereinID", "Name", "WerbepartnerID");
        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {
            View�berschrieft("Trainer");
            string query = "SELECT Trainer.TrainerID, Trainer.Name, Trainer.VereinID FROM Trainer";
            TabelleAnzeige(query, "TrainerID", "Name", "VereinID");
        }

        private void btnVertrag_Click(object sender, EventArgs e)
        {
            View�berschrieft("Vertrag");
            string query = "SELECT Vertrag.VertragID, Vertrag.SpielerID, Vertrag.VereinID, Vertrag.Startdatum, Vertrag.Enddatum, Vertrag.Gehalt FROM Vertrag";
            TabelleAnzeige(query, "VertragID", "SpielerID", "VereinID", "Startdatum", "Enddatum", "Gehalt");
        }

        private void btnWerbepartner_Click(object sender, EventArgs e)
        {
            View�berschrieft("Werbepartner");
            string query = "SELECT Werbepartner.WerbepartnerID, Werbepartner.Name FROM Werbepartner";
            TabelleAnzeige(query, "WerbepartnerID", "Name");
        }

        private void btnWettbewerb_Click(object sender, EventArgs e)
        {
            View�berschrieft("Wettbewerb");
            string query = "SELECT Wettbewerb.WettbewerbID, Wettbewerb.Name, Wettbewerb.Jahr FROM Wettbewerb";
            TabelleAnzeige(query, "WettbewerbID", "Name", "Jahr");
        }

        private void btnwettbewerb_verein_Click(object sender, EventArgs e)
        {
            View�berschrieft("Wettbewerb und Verein");
            string query = "SELECT * FROM wettbewerb_verein;";
            TabelleAnzeige(query, "WettbewerbID", "VereinID");
        }

        private void btnSpalteHinzuf�gen_Click(object sender, EventArgs e)
        {
            FrmNeueSpalte frmNeueSpalte = new FrmNeueSpalte();
            if (AktuelleTabelle == "")
            {
                MessageBox.Show("W�hle erstmal eine Tabelle", "Welche Tabelle?");
            }
            else if (frmNeueSpalte.Uberschrieft == "Statistik" || frmNeueSpalte.Uberschrieft == "Auszeichnung")
            {
                MessageBox.Show("Du auch eine Prozedur verwenden", "Prozedur Benutzen", MessageBoxButtons.OKCancel);
            }
            else
            {
                frmNeueSpalte.Uberschrieft = AktuelleTabelle;
                if (frmNeueSpalte.ShowDialog() == DialogResult.OK)
                {
                    string query = "";
                    switch (AktuelleTabelle)
                    {
                        case "Spieler":
                            query = $"INSERT INTO {AktuelleTabelle} (Name, Geburtsdatum, NationID) VALUES ('{frmNeueSpalte.Eins}',' {frmNeueSpalte.Zwei}', {frmNeueSpalte.Drei})";
                            break;
                        case "Verein":
                            query = $"INSERT INTO {AktuelleTabelle} (Name, WerbepartnerID) VALUES ('{frmNeueSpalte.Eins}',' {frmNeueSpalte.Zwei}')";
                            break;

                        case "Trainer":
                            query = $"INSERT INTO {AktuelleTabelle} (Name, VereinID) VALUES ('{frmNeueSpalte.Eins}',' {frmNeueSpalte.Zwei}')";
                            break;

                        case "Vertrag":
                            query = $"INSERT INTO {AktuelleTabelle} (SpielerID, VereinID, Startdatum,Enddatum,Gehalt) VALUES ('{frmNeueSpalte.Eins}',' {frmNeueSpalte.Zwei}', {frmNeueSpalte.Drei},'{frmNeueSpalte.Vier}','{frmNeueSpalte.F�nf}',)";
                            break;

                        case "Werbepartner":
                            query = $"INSERT INTO {AktuelleTabelle} (Name) VALUES ('{frmNeueSpalte.Eins}')";
                            break;

                        case "Wettbewerb":
                            query = $"INSERT INTO {AktuelleTabelle} (Name, Jahr) VALUES ('{frmNeueSpalte.Eins}',' {frmNeueSpalte.Zwei}')";
                            break;

                        case "Nation":
                            query = $"INSERT INTO {AktuelleTabelle} (Name) VALUES ('{frmNeueSpalte.Eins}')";
                            break; 

                        default:
                            MessageBox.Show("In dieser Tabelle kannst du nicht Hinzuf�gen", "Falsche Tabelle",MessageBoxButtons.OKCancel);
                            query = "Fehler";
                            break;
                    }

                    Klasse_Transfermarkt klasse_Transfermarkt = new Klasse_Transfermarkt();
                    // Verbindung zur Datenbank �ffnen und sicherstellen, dass sie ordnungsgem�� geschlossen wird
                    using (MySqlConnection connection = new MySqlConnection(klasse_Transfermarkt.ConnectionString))
                    {
                        connection.Open(); // Verbindung �ffnen
                                           // SQL-Abfrage zum Einf�gen eines neuen Spielers
                                           // SQL-Befehl vorbereiten
                        int AnzahlDatens�tzen = Regex.Matches(query, ",").Count / 2 + 1;
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            switch (AktuelleTabelle)
                            {
                                case "Spieler":
                                    command.Parameters.AddWithValue("@name", frmNeueSpalte.Eins);
                                    command.Parameters.AddWithValue("@birthDate", frmNeueSpalte.Zwei);
                                    command.Parameters.AddWithValue("@nationId", frmNeueSpalte.Drei);
                                    break;
                                case "Verein":
                                    command.Parameters.AddWithValue("@name", frmNeueSpalte.Eins);
                                    command.Parameters.AddWithValue("@werbepartnerID", frmNeueSpalte.Zwei);
                                    break;

                                case "Trainer":
                                    command.Parameters.AddWithValue("@name", frmNeueSpalte.Eins);
                                    command.Parameters.AddWithValue("@vereinid", frmNeueSpalte.Zwei);
                                    break;

                                case "Vertrag":
                                    // ///////////////////////////////////////////////////////////////////////////////////
                                    break;

                                case "Werbepartner":
                                    command.Parameters.AddWithValue("@name", frmNeueSpalte.Eins);
                                    break;

                                case "Wettbewerb":
                                    command.Parameters.AddWithValue("@name", frmNeueSpalte.Eins);
                                    command.Parameters.AddWithValue("@jahr", frmNeueSpalte.Zwei);
                                    break;

                                default:
                                    query = "Fehler";
                                    break;
                            }
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                }
            }
        }
        private void btnSpalteLoeschen_Click(object sender, EventArgs e)
        {
            // �berpr�fen, ob eine Zeile ausgew�hlt ist
            if (listView.SelectedItems.Count > 0)
            {
                // Die ausgew�hlten Zeilen l�schen
                foreach (ListViewItem selectedItem in listView.SelectedItems)
                {
                    // Den Wert der ersten Spalte (z. B. die SpielerID) auslesen
                    string id = selectedItem.SubItems[0].Text;
                    
                    // Best�tigen, ob der Benutzer die Zeile wirklich l�schen m�chte
                    DialogResult result = MessageBox.Show("M�chten Sie die ausgew�hlte Zeile wirklich l�schen?", "Best�tigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Erstellen Sie eine Instanz von Klasse_Transfermarkt
                        Klasse_Transfermarkt klasse_Transfermarkt = new Klasse_Transfermarkt();

                        // Den Tabellennamen �bergeben
                        string tableName = AktuelleTabelle; // Setzen Sie den Namen Ihrer Tabelle hier ein
                        string spalteName = AktuelleTabelle; // Setzen Sie den Namen Ihrer Tabelle hier ein
                        int idZahl = int.Parse(id);

                        if (AktuelleTabelle == "Auszeichnung")
                        {
                            // Die VereinID auslesen (angenommen, sie ist im zweiten SubItem gespeichert)
                            string vereinId = selectedItem.SubItems[1].Text;
                            spalteName = "Spieler";
                        }

                        // �berpr�fen Sie die G�ltigkeit des Tabellennamens
                        if (!string.IsNullOrEmpty(tableName))
                        {
                            // Verbinden Sie sich mit der Datenbank und f�hren Sie den L�schbefehl aus
                            using (MySqlConnection connection = new MySqlConnection(klasse_Transfermarkt.ConnectionString))
                            {
                                try
                                {
                                    string deleteQuery = $"DELETE FROM {tableName} WHERE {spalteName}ID = @id"; // �ndern Sie dies entsprechend Ihrer Tabellenstruktur
                                    connection.Open();
                                    if (tableName == "Auszeichnung")
                                    {
                                        deleteQuery = $"DELETE FROM {tableName} WHERE SpielerID = @id AND VereinID = @vereinId";
                                    }

                                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                                    {
                                        command.Parameters.AddWithValue("@id", idZahl);
                                        if (tableName == "Auszeichnung")
                                        {
                                            int vereinIdZahl = int.Parse(selectedItem.SubItems[1].Text);
                                            command.Parameters.AddWithValue("@vereinId", vereinIdZahl);
                                        }
                                        command.ExecuteNonQuery();
                                    }

                                    // Die Zeile aus der ListView entfernen
                                    listView.Items.Remove(selectedItem);

                                    // Benachrichtigen Sie den Benutzer �ber das erfolgreiche L�schen
                                    MessageBox.Show("Die Zeile wurde erfolgreich gel�scht.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    // Fehlerbehandlung f�r Datenbankfehler
                                    MessageBox.Show("Ein Fehler ist beim L�schen der Zeile aufgetreten: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ung�ltiger Tabellenname.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Bitte w�hlen Sie zuerst eine Zeile zum L�schen aus.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmHauptForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // �berpr�fen, ob der Benutzer das Formular wirklich schlie�en m�chte
            DialogResult result = MessageBox.Show("M�chten Sie das Formular wirklich schlie�en?", "Formular schlie�en", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Wenn der Benutzer Nein w�hlt, die Schlie�ung des Formulars abbrechen
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public void ProzedurEingabe(string query)
        {
            FrmProzedurEingabe frmProzedurEingabe = new FrmProzedurEingabe();
            Klasse_Transfermarkt flasse_Transfermarkt = new Klasse_Transfermarkt();

            // Verbindung zur Datenbank herstellen und die gespeicherte Prozedur ausf�hren
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

                                // Spalten hinzuf�gen
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    listView.Columns.Add(reader.GetName(i), 100, HorizontalAlignment.Left);
                                }

                                // Daten anzeigen
                                while (reader.Read())
                                {
                                    ListViewItem item = new ListViewItem(reader.GetString(0)); // Annahme: Erste Spalte enth�lt Spielername
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

        public void ProzedurEingabeOhneView(string procedur, string spielerName, string zweiteEingabe = "", DateTime? dritteEingabe = null)
        {
            FrmProzedurEingabe frmProzedurEingabe = new FrmProzedurEingabe();
            Klasse_Transfermarkt klasse_Transfermarkt = new Klasse_Transfermarkt();

            // Verbindung zur Datenbank herstellen und die gespeicherte Prozedur ausf�hren
            using (MySqlConnection connection = new MySqlConnection(klasse_Transfermarkt.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(procedur, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parameter hinzuf�gen
                        switch (procedur)
                        {
                            case "SpielerToreErhoehen":
                                command.Parameters.AddWithValue("@p_SpielerName", spielerName);
                                command.Parameters.AddWithValue("@p_AnzahlTore", Convert.ToInt32(zweiteEingabe));
                                break;

                            case "Hinzu_�nd_Verein_Werbepartner":
                                command.Parameters.AddWithValue("@p_VereinName", spielerName);
                                command.Parameters.AddWithValue("@p_WerbepartnerName", zweiteEingabe);
                                break;

                            case "V_NeueAuszeichnungHinzufuegen":
                                command.Parameters.AddWithValue("@verein_name", spielerName);
                                command.Parameters.AddWithValue("@neue_auszeichnung_name", zweiteEingabe);
                                command.Parameters.AddWithValue("@auszeichnung_datum", dritteEingabe);
                                break;

                            case "NeueAuszeichnungHinzufuegen":
                                command.Parameters.AddWithValue("@spieler_name", spielerName);
                                command.Parameters.AddWithValue("@neue_auszeichnung_name", zweiteEingabe);
                                command.Parameters.AddWithValue("@auszeichnung_datum", dritteEingabe);
                                break;

                            default:
                                MessageBox.Show($"Prozedur f�r: {procedur} konnte nicht gefunden werden", "Prozedur Fehler!");
                                break;
                        }

                        // Prozedur ausf�hren
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Die Auszeichnung wurde erfolgreich hinzugef�gt.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Es wurden keine �nderungen vorgenommen.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        //Prozedur Button
        private void btnSpierInfo_Click(object sender, EventArgs e)
        {
            FrmProzedurEingabe frmProzedurEingabe = new FrmProzedurEingabe();
            frmProzedurEingabe.�berschrieft = "Spieler Infomartion:";

            if (frmProzedurEingabe.ShowDialog() == DialogResult.OK)
            {
                string query = $"CALL SpielerInformationen('{frmProzedurEingabe.SpielerName}')";
                ProzedurEingabe(query);
                View�berschrieft("Spieler Info:");
            }
        }
        private void btnSpNeueAuszeichnung_Click(object sender, EventArgs e)
        {
            FrmProzedurEingabe frmProzedurEingabe = new FrmProzedurEingabe();
            frmProzedurEingabe.�berschrieft = "Spieler kriegt neue Auszeichnung:";

            if (frmProzedurEingabe.ShowDialog() == DialogResult.OK)
            {

                ProzedurEingabeOhneView("NeueAuszeichnungHinzufuegen", frmProzedurEingabe.Name, frmProzedurEingabe.Zwei, frmProzedurEingabe.Drei);
            }
        }

        private void btnVNeueAuszeichnung_Click(object sender, EventArgs e)
        {
            FrmProzedurEingabe frmProzedurEingabe = new FrmProzedurEingabe();
            frmProzedurEingabe.�berschrieft = "Verein kriegt neue Auszeichnung:";

            if (frmProzedurEingabe.ShowDialog() == DialogResult.OK)
            {

                ProzedurEingabeOhneView("V_NeueAuszeichnungHinzufuegen", frmProzedurEingabe.Name, frmProzedurEingabe.Zwei, frmProzedurEingabe.Drei);
            }
        }

        private void btnWerbePartnerHinzuf�gen_Click(object sender, EventArgs e)
        {
            FrmProzedurEingabe frmProzedurEingabe = new FrmProzedurEingabe();
            frmProzedurEingabe.�berschrieft = "Hinzu oder �nder von vohandene Verein und Werbepartner:";

            if (frmProzedurEingabe.ShowDialog() == DialogResult.OK)
            {

                ProzedurEingabeOhneView("Hinzu_�nd_Verein_Werbepartner", frmProzedurEingabe.Name, frmProzedurEingabe.Zwei);
            }
        }

        private void btnSpielerToreErhoehen_Click(object sender, EventArgs e)
        {
            FrmProzedurEingabe frmProzedurEingabe = new FrmProzedurEingabe();
            frmProzedurEingabe.�berschrieft = "Eingeben von weiteren Spieler Tore:";
            
            if (frmProzedurEingabe.ShowDialog() == DialogResult.OK)
            {

                ProzedurEingabeOhneView("SpielerToreErhoehen", frmProzedurEingabe.Name, frmProzedurEingabe.TorAnzahl.ToString());
            }
        }

        private void btnAnmelden_Click(object sender, EventArgs e)
        {
            FrmAnmelden frmAnmelden = new FrmAnmelden();

            if (btnAnmelden.Text == "Anmelden")
            {
                if (frmAnmelden.ShowDialog() == DialogResult.OK)
                {
                    BenutzerZustand = frmAnmelden.Benutzer;
                    AktuelleZuStand();
                }
            }
            else
            {
                AktuelleZuStand();
            }
        }

        private void FrmHauptForm_Load(object sender, EventArgs e)
        {
            AktuelleZuStand();
        }

        public void AktuelleZuStand()
        {
            //Aktueller Benutzer
            lblBenutzer.Text = $"Benutzer Zustand: {BenutzerZustand}";

            //Berechtigung des Benutzers
            if (btnAnmelden.Text == "Abmelden")
            {
                lblProzedurVerwenden.Visible = false;

                btnSpalteHinzuf�gen.Visible = false;
                btnSpalteLoeschen.Visible = false;

                btnAnmelden.Text = "Anmelden";
                btnSpierInfo.Visible = false;
                btnSpNeueAuszeichnung.Visible = false;
                btnVNeueAuszeichnung.Visible = false;
                btnWerbePartnerHinzuf�gen.Visible = false;
                btnSpielerToreErhoehen.Visible = false;
            }
            else
            {
                lblBenutzer.Text = $"Benutzer Zustand: Gast";

                lblProzedurVerwenden.Visible = true;

                btnAnmelden.Text = "Abmelden";
                btnSpalteHinzuf�gen.Visible = true;
                btnSpalteLoeschen.Visible = true;

                btnSpierInfo.Visible = true;
                btnSpNeueAuszeichnung.Visible = true;
                btnVNeueAuszeichnung.Visible = true;
                btnWerbePartnerHinzuf�gen.Visible = true;
                btnSpielerToreErhoehen.Visible = true;
            }
        }
    }
}
