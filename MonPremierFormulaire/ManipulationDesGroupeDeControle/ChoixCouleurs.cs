using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulationDesGroupeDeControle
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Saisie(object sender, EventArgs e)
        {
            Copie.Text = TextBox.Text;
            if (TextBox.TextLength == 0)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
        }

        private void CouleurFond(object sender, EventArgs e)
        {
            if (couleurDuFond.Checked)
            {
                Fond.Enabled = true;
            }
            else
            {
                Fond.Enabled = false;
            }
        }

        
        private void CouleurCaractere(object sender, EventArgs e)
        {
            if (couleurDesCaracteres.Checked)
            {
                Caractere.Enabled = true;
            }
            else
            {
                Caractere.Enabled = false;
            }
        }

        private void Casse(object sender, EventArgs e)
        {
            if (casse.Checked)
            {
                ChoixCasse.Enabled = true;
            }
            else
            {
                ChoixCasse.Enabled = false;
            }
        }


        private void ChoixFond(object sender, EventArgs e)
        {
            if (FRouge.Checked)
            {
                Copie.BackColor = Color.DarkRed;
            }
            if (FVert.Checked)
            {
                Copie.BackColor = Color.DarkSeaGreen;
            }
            if (FBleu.Checked)
            {
                Copie.BackColor = Color.DarkCyan;
            }

        }

        private void ChoixCaractere(object sender, EventArgs e)
        {
            if (CRouge.Checked)
            {
                Copie.ForeColor = Color.DarkRed;
            }
            if (CBlanc.Checked)
            {
                Copie.ForeColor = Color.White;
            }
            if (CNoir.Checked)
            {
                Copie.ForeColor = Color.Black;
            }
        }

        private void LeChoixCasse(object sender, EventArgs e)
        {
            if (CMini.Checked)
            {
                Copie.Text = Copie.Text.ToLower();
            }
            if (CMaj.Checked)
            {
                Copie.Text = Copie.Text.ToUpper();
            }
        }   
    }   

}
