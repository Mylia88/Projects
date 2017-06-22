using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JouerAvecCaractèresChaîne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Clk_Resultat(object sender, EventArgs e)
        {
            if (char.IsLetter(Saisie.Text[(int)Posit.Value]))
            {
                Resultat.Text = "Lettre";
            }
            if (char.IsDigit(Saisie.Text[(int)Posit.Value]))
            {
                Resultat.Text = "Nombre";
            }
            if (!char.IsLetterOrDigit(Saisie.Text[(int)Posit.Value]))
            {
               Resultat.Text = "Autre";
            }
        }

        private void NbrCaract(object sender, EventArgs e)
        {
             Posit.Maximum = Saisie.TextLength - 1;
        }
    }
}
