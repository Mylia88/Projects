using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_3MiseEnOeuvreDialogueModal
{
    public partial class FormExo1 : Form
    {
        public FormExo1()
        {
            InitializeComponent();
        }

        private void AppelModal(object sender, EventArgs e)
        {

            FrmDialogueModal dialogueModal = new FrmDialogueModal();
            DialogResult resultat = dialogueModal.ShowDialog();

            switch(resultat)
            {
                case DialogResult.OK:
                    textBox1.Text = "OK";
                    break;
                case DialogResult.Cancel:
                    textBox1.Text = "Abandon";
                    break;
                default:
                    textBox1.Text = "WTF";
                    break;
            }
        }
    }
}
