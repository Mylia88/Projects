using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At3Exo2
{
    public partial class FormExos2 : Form
    {
        public FormExos2()
        {
            InitializeComponent();
        }

        private void Entrer(object sender, EventArgs e)
        {
            IDConnexion connexion = new IDConnexion();
            DialogResult resultat = connexion.ShowDialog();


            switch (resultat)
            {
                case DialogResult.OK:
                    Reponse.Text = "Vous êtes connecté.";
                    break;
                case DialogResult.Cancel:
                    Reponse.Text = "Action annulée.";
                    break;       
                default:
                    Reponse.Text = "Erreur commande.";
                    break;
            }
        }
    }
}

         

