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
    public partial class IDConnexion : Form
    {
        public IDConnexion()
        {
            InitializeComponent();
        }

        private void seConnecter(object sender, EventArgs e)
        {
            
            if (MotDePasse.Text != IDUtilisateur.Text)
            {
                errorProvider1.SetError(MotDePasse, "Le mot de passe n'est pas identique à votre identifiant.");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void Quitter(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }



        private void SaisieMDP(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(MotDePasse,string.Empty);
            if (MotDePasse.Text == null)
            {                
                errorProvider1.SetError(MotDePasse, "Vous n'avez pas saisi votre mot de passe.");
                e.Cancel = true;
            }
            if (MotDePasse.Text.Length <5)
            {
                errorProvider1.SetError(MotDePasse, "Le mot de passe doit contenir au moins 5 caractères.");
                e.Cancel = true;
            }
            
        }

        private void SaisieID(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(IDUtilisateur, string.Empty);
            if (IDUtilisateur.Text == null)
            {
                errorProvider1.SetError(IDUtilisateur, "Vous n'avez pas saisi votre identifiant.");
                e.Cancel = true;
            }
            if (IDUtilisateur.Text.Length < 5)
            {
                errorProvider1.SetError(IDUtilisateur, "L'identifiant doit contenir 5 caractères.");
                e.Cancel = true;
            }
            else if (!char.IsLetter(IDUtilisateur.Text[0]))
            {
                errorProvider1.SetError(IDUtilisateur, "La première lettre de votre identifiant doit être une lettre.");
                e.Cancel = true;
            }
            for (int i = 0; i < IDUtilisateur.Text.Length; i++)
            {
                if (!char.IsLetterOrDigit(IDUtilisateur.Text[i]))
                {
                    errorProvider1.SetError(IDUtilisateur, "L'identifiant ne doit contenir que des caractères alphanumériques.");
                    e.Cancel = true;
                }
            }
            



        }
    }
}
