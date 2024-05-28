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

        public string Überschrieft
        {
            get { return lblÜberschrieft.Text; }
            set { lblÜberschrieft.Text = value; }
        }
        public string Zwei
        {
            get { return tbxZwei.Text; }
            set { tbxZwei.Text = value;}
        }
        public DateTime Drei
        {
            get { return Convert.ToDateTime(tbxDrei.Text); }
            set { tbxDrei.Text = value.ToString(); }
        }
    }
}
