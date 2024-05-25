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
    public partial class FrmNeueSpieler : Form
    {
        public FrmNeueSpieler()
        {
            InitializeComponent();
        }

        private void FrmNeueSpieler_Load(object sender, EventArgs e)
        {

        }

        public string SpielerName
        {
            get { return tbxVorname.Text + " " + tbxNachname.Text; }
        }

        public DateTime Geburtsdatum
        {
            get 
            {
                try
                {
                    return Convert.ToDateTime(tbxGeburtsdatum.Text);
                }
                catch (Exception)
                {
                    throw new Exception("Geburtsdatum muss Jahr-Monat-Tag");
                }
            }
            set { tbxGeburtsdatum.Text = value.ToString(); }
        }

        public int NationID
        {
            get 
            { 

                return 1; 
            
            }
            set { value = 1; }
        }
    }
}
