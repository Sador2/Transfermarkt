using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MySQL_Test
{
    public partial class FrmProzedurEingabe : Form
    {
        public FrmProzedurEingabe()
        {
            InitializeComponent();
        }

        // Eigenschaften
        public string SpielerName
        {
            get { return tbxSpielerName.Text; }
        }

        public string Überschrieft
        {
            get { return lblÜberschrieft.Text; }
            set { lblÜberschrieft.Text = value; }
        }

        public string Zwei
        {
            get { return tbxZwei.Text; }
        }

        public DateTime Drei
        {
            get
            {
                if (string.IsNullOrWhiteSpace(tbxDrei.Text))
                {
                    return DateTime.Now; // Aktuelles Datum und Uhrzeit
                }
                else
                {
                    DateTime parsedDate;
                    if (DateTime.TryParse(tbxDrei.Text, out parsedDate))
                    {
                        return parsedDate;
                    }
                    else
                    {
                        throw new FormatException("Ungültiges Datum.");
                    }
                }
            }
        }

        public int TorAnzahl
        {
            get
            {
                if (Zwei.Contains("-"))
                {
                    throw new Exception("Anzahl darf nicht negativ sein.");
                }
                try
                {
                    return Convert.ToInt16(Zwei);
                }
                catch (Exception)
                {
                    throw new Exception("Nur Zahlen, keine anderen Zeichen.");
                }
            }
        }

        // Methoden
        public void DesigneUebersicht()
        {
            // Label unsichtbar machen
            lblSpielerName.Visible = false;
            lblZwei.Visible = false;
            lblDrei.Visible = false;

            // Textboxen unsichtbar machen
            tbxSpielerName.Visible = false;
            tbxZwei.Visible = false;
            tbxDrei.Visible = false;

            switch (Überschrieft)
            {
                case "Spieler Infomartion:":
                    // Benennen
                    lblSpielerName.Text = "Spieler Name:";

                    // Sichtbare Felder
                    lblSpielerName.Visible = true;
                    tbxSpielerName.Visible = true;

                    // Koordination
                    lblÜberschrieft.Location = new Point(12, 9);
                    lblSpielerName.Location = new Point(28, 58);
                    tbxSpielerName.Location = new Point(114, 55);
                    btnAbbruch.Location = new Point(56, 99);
                    btnBestätigen.Location = new Point(137, 99);

                    this.Width = 305;
                    this.Height = 177;
                    break;

                case "Spieler kriegt neue Auszeichnung:":
                    // Benennen
                    lblSpielerName.Text = "Spieler Name:";
                    lblZwei.Text = "Auszeichnung:";
                    lblDrei.Text = "Datum";

                    // Sichtbare Felder
                    lblSpielerName.Visible = true;
                    lblZwei.Visible = true;
                    lblDrei.Visible = true;
                    tbxSpielerName.Visible = true;
                    tbxZwei.Visible = true;
                    tbxDrei.Visible = true;

                    // Koordination
                    lblÜberschrieft.Location = new Point(12, 18);
                    lblSpielerName.Location = new Point(71, 63);
                    lblZwei.Location = new Point(154, 63);
                    lblDrei.Location = new Point(245, 63);
                    tbxSpielerName.Location = new Point(71, 81);
                    tbxZwei.Location = new Point(158, 81);
                    tbxDrei.Location = new Point(245, 81);
                    btnAbbruch.Location = new Point(123, 119);
                    btnBestätigen.Location = new Point(204, 119);

                    this.Width = 458;
                    this.Height = 207;
                    break;

                case "Verein kriegt neue Auszeichnung:":
                    // Benennen
                    lblSpielerName.Text = "Verein Name:";
                    lblZwei.Text = "Auszeichnung:";
                    lblDrei.Text = "Datum";

                    // Sichtbare Felder
                    lblSpielerName.Visible = true;
                    lblZwei.Visible = true;
                    lblDrei.Visible = true;
                    tbxSpielerName.Visible = true;
                    tbxZwei.Visible = true;
                    tbxDrei.Visible = true;

                    // Koordination
                    lblÜberschrieft.Location = new Point(12, 18);
                    lblSpielerName.Location = new Point(71, 63);
                    lblZwei.Location = new Point(154, 63);
                    lblDrei.Location = new Point(245, 63);
                    tbxSpielerName.Location = new Point(71, 81);
                    tbxZwei.Location = new Point(158, 81);
                    tbxDrei.Location = new Point(245, 81);
                    btnAbbruch.Location = new Point(123, 119);
                    btnBestätigen.Location = new Point(204, 119);

                    this.Width = 458;
                    this.Height = 207;
                    break;

                case "Hinzu oder änder von vohandene Verein und Werbepartner:":
                    // Benennen
                    lblSpielerName.Text = "Verein:";
                    lblZwei.Text = "Werbepartner:";

                    // Sichtbare Felder
                    lblSpielerName.Visible = true;
                    lblZwei.Visible = true;
                    tbxSpielerName.Visible = true;
                    tbxZwei.Visible = true;

                    // Koordination
                    lblÜberschrieft.Location = new Point(12, 21);
                    lblSpielerName.Location = new Point(235, 67);
                    lblZwei.Location = new Point(235, 96);
                    tbxSpielerName.Location = new Point(326, 64);
                    tbxZwei.Location = new Point(326, 93);
                    btnAbbruch.Location = new Point(240, 133);
                    btnBestätigen.Location = new Point(332, 133);

                    this.Width = 752;
                    this.Height = 207;
                    break;

                case "Eingeben von weiteren Spieler Tore:":
                    // Benennen
                    lblSpielerName.Text = "Spieler Name:";
                    lblZwei.Text = "Anzahl weiterer Tore:";

                    // Sichtbare Felder
                    lblSpielerName.Visible = true;
                    lblZwei.Visible = true;
                    tbxSpielerName.Visible = true;
                    tbxZwei.Visible = true;

                    // Koordination
                    lblÜberschrieft.Location = new Point(12, 9);
                    lblSpielerName.Location = new Point(93, 47);
                    lblZwei.Location = new Point(93, 79);
                    tbxSpielerName.Location = new Point(215, 47);
                    tbxZwei.Location = new Point(215, 76);
                    btnAbbruch.Location = new Point(98, 115);
                    btnBestätigen.Location = new Point(215, 115);

                    this.Width = 479;
                    this.Height = 189;
                    break;

                default:
                    break;
            }
        }

        private void FrmProzedurEingabe_Load(object sender, EventArgs e)
        {
            DesigneUebersicht();
        }

        private void btnBestätigen_Click(object sender, EventArgs e)
        {
            btnBestätigen.DialogResult = DialogResult.None; // Standardmäßig nicht schließen

            bool alleFelderAusgefüllt = true;

            switch (Überschrieft)
            {
                case "Spieler Infomartion:":
                    if (string.IsNullOrWhiteSpace(tbxSpielerName.Text))
                    {
                        MessageBox.Show("Spielername darf nicht leer sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        alleFelderAusgefüllt = false;
                    }
                    break;

                case "Spieler kriegt neue Auszeichnung:":
                    if (string.IsNullOrWhiteSpace(tbxSpielerName.Text) ||
                        string.IsNullOrWhiteSpace(tbxZwei.Text) ||
                        string.IsNullOrWhiteSpace(tbxDrei.Text))
                    {
                        MessageBox.Show("Alle Felder müssen ausgefüllt sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        alleFelderAusgefüllt = false;
                    }
                    break;

                case "Verein kriegt neue Auszeichnung:":
                    if (string.IsNullOrWhiteSpace(tbxSpielerName.Text) ||
                        string.IsNullOrWhiteSpace(tbxZwei.Text) ||
                        string.IsNullOrWhiteSpace(tbxDrei.Text))
                    {
                        MessageBox.Show("Alle Felder müssen ausgefüllt sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        alleFelderAusgefüllt = false;
                    }
                    break;

                case "Hinzu oder änder von vohandene Verein und Werbepartner:":
                    if (string.IsNullOrWhiteSpace(tbxSpielerName.Text) ||
                        string.IsNullOrWhiteSpace(tbxZwei.Text))
                    {
                        MessageBox.Show("Alle Felder müssen ausgefüllt sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        alleFelderAusgefüllt = false;
                    }
                    break;

                case "Eingeben von weiteren Spieler Tore:":
                    if (string.IsNullOrWhiteSpace(tbxSpielerName.Text) ||
                        string.IsNullOrWhiteSpace(tbxZwei.Text))
                    {
                        MessageBox.Show("Alle Felder müssen ausgefüllt sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        alleFelderAusgefüllt = false;
                    }
                    break;

                default:
                    alleFelderAusgefüllt = false;
                    break;
            }

            if (alleFelderAusgefüllt)
            {
                btnBestätigen.DialogResult = DialogResult.OK;
            }
        }
    }
}
