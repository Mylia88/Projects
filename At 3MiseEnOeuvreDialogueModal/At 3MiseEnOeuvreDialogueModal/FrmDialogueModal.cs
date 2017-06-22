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
    public partial class FrmDialogueModal : Form
    {
        public FrmDialogueModal()
        {
            InitializeComponent();
        }

        private void ok(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Abandon(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Autre(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
        }
    }
}
