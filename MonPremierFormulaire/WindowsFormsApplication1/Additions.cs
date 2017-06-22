using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace WindowsFormsApplication1
{
    public partial class Additions : Form
    {
        public Additions()
        {
            InitializeComponent();
        }

       int somme;

        public void Chiffres(object sender, EventArgs e)
        { 
            Button Bouton = sender as Button;
            int valeur = int.Parse(Bouton.Text);
            textBox1.Text = textBox1.Text + Bouton.Text + "+";
            //textBox1.Text += Bouton.Text + "+";
            somme += valeur;
            

        }
      
        public void Vider(object sender, EventArgs e)
        {
            textBox1.Clear();
            somme = 0;
        }

        public void clk_Somme(object sender, EventArgs e)
        {
            textBox1.Text += "=" + somme + "+";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MessageFermeture(object sender, FormClosingEventArgs e)
        {
            Debug.WriteLine("Fin de l'application additionneur.");
        }
    }
}
