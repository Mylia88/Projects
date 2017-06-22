using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JouerChaineCaracteres
{
    public partial class Form1 : Form
    {
        int pos1;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Action1(object sender, EventArgs e)
        {
            Resultat.Text = Saisie.Text.Replace(Portion1.Text, Portion2.Text);
        }

        private void Action2(object sender, EventArgs e)
        {

        }

        private void Action3(object sender, EventArgs e)
        {

        }

        private void Compte(object sender, EventArgs e)
        {
            while (Saisie.Text.IndexOf(Portion1.Text, pos1) != -1)
            {
                pos1 = Saisie.Text.IndexOf(Portion1.Text);
                int pos2 = Saisie.Text.IndexOf(Portion1.Text, pos1 + 1);
            }
        }

        private void Jouer(object sender, EventArgs e)
        {
          
        }
    }
}
