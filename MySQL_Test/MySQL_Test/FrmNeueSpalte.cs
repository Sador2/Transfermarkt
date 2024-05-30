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
    }
}
