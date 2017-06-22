using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeDamier
{
    public partial class FenetreDamier : Form
    {
        public FenetreDamier()
        {
            InitializeComponent();

            int nbrBouton = 20;

            for (int i = 0; i < nbrBouton; i++)
            {
                for (int j = 0; j < nbrBouton; j++)
                {
                    Button Case = new Button();
                    Case.Size = new System.Drawing.Size(50, 50);
                    Case.Left = i * 50;
                    Case.Top = j * 50;
                    this.Controls.Add(Case);
                    if ((i+j)%2 == 0)
                    {
                        Case.BackColor = Color.AntiqueWhite;
                    }
                    if ((i+j)%2== 1)
                    {
                        Case.BackColor = Color.Black;
                    }
                }
            }
            


            
        }
        
    }
}
