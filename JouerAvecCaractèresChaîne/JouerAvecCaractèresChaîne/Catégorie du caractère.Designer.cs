namespace JouerAvecCaractèresChaîne
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Saisie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Resultat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Posit = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Posit)).BeginInit();
            this.SuspendLayout();
            // 
            // Saisie
            // 
            this.Saisie.Location = new System.Drawing.Point(130, 34);
            this.Saisie.Name = "Saisie";
            this.Saisie.Size = new System.Drawing.Size(256, 20);
            this.Saisie.TabIndex = 0;
            this.Saisie.TextChanged += new System.EventHandler(this.NbrCaract);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saisissez une chaîne :";
            // 
            // Resultat
            // 
            this.Resultat.Location = new System.Drawing.Point(130, 111);
            this.Resultat.Name = "Resultat";
            this.Resultat.Size = new System.Drawing.Size(127, 20);
            this.Resultat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Position du caractère :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Résultat :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Catégorie du caractère";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Clk_Resultat);
            // 
            // Posit
            // 
            this.Posit.Location = new System.Drawing.Point(130, 72);
            this.Posit.Name = "Posit";
            this.Posit.Size = new System.Drawing.Size(120, 20);
            this.Posit.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 372);
            this.Controls.Add(this.Posit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Resultat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Saisie);
            this.Name = "Form1";
            this.Text = "Catégorie du caractère";
            ((System.ComponentModel.ISupportInitialize)(this.Posit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Saisie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Resultat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown Posit;
    }
}

