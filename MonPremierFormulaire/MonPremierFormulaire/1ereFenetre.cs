using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonPremierFormulaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ClickRecopier(object sender, EventArgs e)
        {
            Copie.Text = Saisie.Text;
            Saisie.Clear();
            Saisie.Focus();
        }

        private void ClickEffacer(object sender, EventArgs e)
        {
            Saisie.Clear();
        }

        private void ClickQuitter(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
