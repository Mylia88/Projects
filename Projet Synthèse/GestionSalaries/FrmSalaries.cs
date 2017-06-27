using GestionSalaraies;
using SalariesDll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilitaires;

namespace GestionSalaraies
{
    public partial class cbSalaries : Form
    {
        Salaries Salaries;
        Salarie Salarie;
        
        
        enum Contextes
        {
            Initial = 0,
            Consultation = 1,
            ModificationInitiale = 2,
            ModificationAnnuler = 3,
            ModificationValider = 4,
            AjoutInitial = 5,
            AjoutValider = 6

        }
        public cbSalaries()
        {
            InitializeComponent();
        }

        void GestionnaireContextes(Contextes contexte)
        {
            switch (contexte)
            {
                case Contextes.Initial:
                    cbSalarié.Enabled = (cbSalarié.Items.Count > 0);
                    btnNouveauS.Enabled = true;
                    gbDetailSalarié.Visible = false;
                    break;
                case Contextes.Consultation:
                    btnNouveauS.Enabled = true;
                    gbDetailSalarié.Visible = true;
                    pnlBoutons.Enabled = true;
                    btnModifier.Enabled = true;
                    btnAnnuler.Enabled = false;
                    btnValider.Enabled = false;
                    txtMatricule.ReadOnly = true;
                    txtNomS.ReadOnly = true;
                    txtPrenomS.ReadOnly = true;
                    chkCompteBloque.Enabled = false;
                    
                    break;
                case Contextes.ModificationInitiale:
                    break;
                case Contextes.ModificationAnnuler:
                    break;
                case Contextes.ModificationValider:
                    break;
                case Contextes.AjoutInitial:
                    break;
                case Contextes.AjoutValider:
                    break;
                default:
                    break;
            }
        }

        private void FrmSalaries_Load(object sender, EventArgs e)
        {
            ChargerSalaries();
            GestionnaireContextes(Contextes.Initial);
        }

        private void ChargerSalaries()
        {

        }
    }
}
