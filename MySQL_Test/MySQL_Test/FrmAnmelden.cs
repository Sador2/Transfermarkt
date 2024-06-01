using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MySQL_Test
{
    public partial class FrmAnmelden : Form
    {
        public FrmAnmelden()
        {
            InitializeComponent();
        }

        // Eigenschaften
        public string Benutzer
        {
            get { return tbxBenutzer.Text; }
        }
        public string Passwort
        {
            get { return tbxPasswort.Text; }
        }

        // Methoden
        bool BenutzerÜberprüfen(string benutzername, string passwort)
        {
            // Benutzer und ihre Passwörter
            Dictionary<string, string> benutzer = new Dictionary<string, string>
            {
                { "Chef", "1234" },
            };

            // Überprüfen, ob der Benutzername in der Liste vorhanden ist
            if (benutzer.ContainsKey(benutzername))
            {
                // Überprüfen, ob das Passwort übereinstimmt
                if (benutzer[benutzername] == passwort)
                {
                    return true; // Benutzer und Passwort sind korrekt
                }
            }
            return false; // Benutzername oder Passwort ist falsch oder der Benutzer existiert nicht
        }

        private void btnAnmelden_Click(object sender, EventArgs e)
        {
            if (BenutzerÜberprüfen(tbxBenutzer.Text, tbxPasswort.Text))
            {
                DialogResult = DialogResult.OK; // Anmeldung erfolgreich, schließe das Formular
            }
            else
            {
                MessageBox.Show("Falscher Benutzername oder Passwort.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
