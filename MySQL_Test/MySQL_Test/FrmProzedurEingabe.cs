using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MySQL_Test
{
    public partial class FrmProzedurEingabe : Form
    {
        public FrmProzedurEingabe()
        {
            InitializeComponent();
        }
        public string SpielerName
        {
            get { return tbxSpielerName.Text; }
            set { tbxSpielerName.Text = value; }
        }
    }
}
