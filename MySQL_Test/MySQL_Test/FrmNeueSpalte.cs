using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_Test
{
    public partial class FrmNeueSpalte : Form
    {
        public FrmNeueSpalte()
        {
            InitializeComponent();
        }

        //Eigenschaft
        public string Uberschrieft
        {
            get { return lblUeberschrieft.Text; }
            set { lblUeberschrieft.Text = value; }
        }

        public string Eins
        {
            get { return tbxEins.Text; }
            set { tbxEins.Text = value; }
        }
        public string Zwei
        {
            get { return tbxZwei.Text; }
            set { tbxZwei.Text = value; }
        }
        public string Drei
        {
            get { return tbxDrei.Text; }
            set { tbxDrei.Text = value; }
        }
        public string Vier
        {
            get { return tbxVier.Text; }
            set { tbxVier.Text = value; }
        }
        public string Fünf
        {
            get { return tbxFünf.Text; }
            set { tbxFünf.Text = value; }
        }

        //Methode
        public void DesigneUebersicht()
        {
            FrmHauptForm frmHauptForm = new FrmHauptForm();

            //Anzeigen
            lblEins.Visible = false;
            lblZwei.Visible = false;
            lblDrei.Visible = false;
            lblVier.Visible = false;

            tbxEins.Visible = false;
            tbxZwei.Visible = false;
            tbxDrei.Visible = false;
            tbxVier.Visible = false;

            switch (Uberschrieft)
            {
                case "Spieler":
                    //Anzeigen
                    lblEins.Visible = true;
                    lblZwei.Visible = true;
                    lblDrei.Visible = true;

                    tbxEins.Visible = true;
                    tbxZwei.Visible = true;
                    tbxDrei.Visible = true;

                    lblEins.Text = "Name";
                    lblZwei.Text = "Geburtsdatum";
                    lblDrei.Text = "NationID";

                    //Koordinaten
                    lblUeberschrieft.Location = new Point(140, 20);
                    lblEins.Location = new Point(24, 55);
                    lblZwei.Location = new Point(130, 55);
                    lblDrei.Location = new Point(236, 55);

                    tbxEins.Location = new Point(24, 73);
                    tbxZwei.Location = new Point(130, 73);
                    tbxDrei.Location = new Point(236, 73);

                    btnAbbruch.Location = new Point(94, 105);
                    btnBestätigen.Location = new Point(175, 105);

                    this.Width = 373;
                    this.Height = 192;
                    break;

                case "Verein":
                    //Anzeigen
                    lblEins.Visible = true;
                    lblZwei.Visible = true;

                    tbxEins.Visible = true;
                    tbxZwei.Visible = true;

                    lblEins.Text = "Name";
                    lblZwei.Text = "WerbepartnerID";

                    //Koordinaten
                    lblUeberschrieft.Location = new Point(75, 9);
                    lblEins.Location = new Point(12, 47);
                    lblZwei.Location = new Point(118, 47);

                    tbxEins.Location = new Point(12, 65);
                    tbxZwei.Location = new Point(118, 65);

                    btnAbbruch.Location = new Point(37, 94);
                    btnBestätigen.Location = new Point(118, 94);

                    this.Width = 266;
                    this.Height = 184;
                    break;

                case "Trainer":
                    //Anzeigen
                    lblEins.Visible = true;
                    lblZwei.Visible = true;

                    tbxEins.Visible = true;
                    tbxZwei.Visible = true;

                    lblEins.Text = "Name";
                    lblZwei.Text = "VereinID";

                    //Koordinaten
                    lblUeberschrieft.Location = new Point(75, 9);
                    lblEins.Location = new Point(12, 47);
                    lblZwei.Location = new Point(118, 47);

                    tbxEins.Location = new Point(12, 65);
                    tbxZwei.Location = new Point(118, 65);

                    btnAbbruch.Location = new Point(37, 94);
                    btnBestätigen.Location = new Point(118, 94);

                    this.Width = 266;
                    this.Height = 184;
                    break;

                case "Vertrag":
                    //Anzeigen
                    lblEins.Visible = true;
                    lblZwei.Visible = true;
                    lblDrei.Visible = true;
                    lblVier.Visible = true;
                    lblFünf.Visible = true;

                    tbxEins.Visible = true;
                    tbxZwei.Visible = true;
                    tbxDrei.Visible = true;
                    tbxVier.Visible = true;
                    tbxFünf.Visible = true;

                    lblEins.Text = "SpielerID";
                    lblZwei.Text = "VereinID";
                    lblDrei.Text = "Startdatum";
                    lblVier.Text = "Enddatum";
                    lblFünf.Text = "Gehalt";

                    //Koordinaten
                    lblUeberschrieft.Location = new Point(59, 9);
                    lblEins.Location = new Point(10, 51);
                    lblZwei.Location = new Point(10, 80);
                    lblDrei.Location = new Point(10, 109);
                    lblVier.Location = new Point(10, 138);
                    lblFünf.Location = new Point(10, 167);

                    tbxEins.Location = new Point(100, 48);
                    tbxZwei.Location = new Point(100, 77);
                    tbxDrei.Location = new Point(100, 106);
                    tbxVier.Location = new Point(100, 135);
                    tbxFünf.Location = new Point(100, 164);

                    btnAbbruch.Location = new Point(29, 194);
                    btnBestätigen.Location = new Point(110, 194);

                    this.Width = 222;
                    this.Height = 268;
                    break;

                case "Werbepartner":
                    //Anzeigen
                    lblEins.Visible = true;

                    tbxEins.Visible = true;

                    lblEins.Text = "Name";

                    //Koordinaten
                    lblUeberschrieft.Location = new Point(31, 9);
                    lblEins.Location = new Point(30, 56);

                    tbxEins.Location = new Point(75, 53);

                    btnAbbruch.Location = new Point(31, 91);
                    btnBestätigen.Location = new Point(112, 91);

                    this.Width = 236;
                    this.Height = 170;
                    break;

                case "Wettbewerb":
                    //Anzeigen
                    lblEins.Visible = true;
                    lblZwei.Visible = true;

                    tbxEins.Visible = true;
                    tbxZwei.Visible = true;

                    lblEins.Text = "Name";
                    lblZwei.Text = "Jahr";

                    //Koordinaten
                    lblUeberschrieft.Location = new Point(75, 9);
                    lblEins.Location = new Point(12, 47);
                    lblZwei.Location = new Point(118, 47);

                    tbxEins.Location = new Point(12, 65);
                    tbxZwei.Location = new Point(118, 65);

                    btnAbbruch.Location = new Point(37, 94);
                    btnBestätigen.Location = new Point(118, 94);

                    this.Width = 266;
                    this.Height = 184;
                    break;

                case "Statistik":
                    // //////////////////////////////////////////////
                    break;

                case "Auszeichnung":
                    // /////////////////////////////////////////////
                    break;

                case "Nation":
                    //Anzeigen
                    lblEins.Visible = true;

                    tbxEins.Visible = true;

                    lblEins.Text = "Name";

                    //Koordinaten
                    lblUeberschrieft.Location = new Point(31, 9);
                    lblEins.Location = new Point(30, 56);

                    tbxEins.Location = new Point(75, 53);

                    btnAbbruch.Location = new Point(31, 91);
                    btnBestätigen.Location = new Point(112, 91);

                    this.Width = 236;
                    break;
                default:
                    break;
            }
        }

        private void FrmNeueSpalte_Load(object sender, EventArgs e)
        {
            DesigneUebersicht();
        }

        

    }
}
