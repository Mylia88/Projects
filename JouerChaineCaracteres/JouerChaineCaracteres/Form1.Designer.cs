namespace JouerChaineCaracteres
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
            this.Portion1 = new System.Windows.Forms.TextBox();
            this.Resultat = new System.Windows.Forms.TextBox();
            this.Portion2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Choix1 = new System.Windows.Forms.RadioButton();
            this.Choix2 = new System.Windows.Forms.RadioButton();
            this.Choix3 = new System.Windows.Forms.RadioButton();
            this.Choix4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Saisie
            // 
            this.Saisie.Location = new System.Drawing.Point(191, 56);
            this.Saisie.Name = "Saisie";
            this.Saisie.Size = new System.Drawing.Size(273, 20);
            this.Saisie.TabIndex = 0;
            // 
            // Portion1
            // 
            this.Portion1.Location = new System.Drawing.Point(191, 93);
            this.Portion1.Name = "Portion1";
            this.Portion1.Size = new System.Drawing.Size(273, 20);
            this.Portion1.TabIndex = 1;
            // 
            // Resultat
            // 
            this.Resultat.Location = new System.Drawing.Point(191, 166);
            this.Resultat.Name = "Resultat";
            this.Resultat.ReadOnly = true;
            this.Resultat.Size = new System.Drawing.Size(273, 20);
            this.Resultat.TabIndex = 2;
            // 
            // Portion2
            // 
            this.Portion2.Location = new System.Drawing.Point(191, 130);
            this.Portion2.Name = "Portion2";
            this.Portion2.Size = new System.Drawing.Size(273, 20);
            this.Portion2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Saisissez une chaine : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Portion de chaîne 1 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Portion de remplacement 2 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Résultat :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Choix4);
            this.groupBox1.Controls.Add(this.Choix3);
            this.groupBox1.Controls.Add(this.Choix2);
            this.groupBox1.Controls.Add(this.Choix1);
            this.groupBox1.Location = new System.Drawing.Point(24, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 124);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Faites vottre choix";
            // 
            // Choix1
            // 
            this.Choix1.AutoSize = true;
            this.Choix1.Location = new System.Drawing.Point(6, 19);
            this.Choix1.Name = "Choix1";
            this.Choix1.Size = new System.Drawing.Size(130, 17);
            this.Choix1.TabIndex = 0;
            this.Choix1.TabStop = true;
            this.Choix1.Text = "Nombre occurences 1";
            this.Choix1.UseVisualStyleBackColor = true;
            this.Choix1.Click += new System.EventHandler(this.Compte);
            // 
            // Choix2
            // 
            this.Choix2.AutoSize = true;
            this.Choix2.Location = new System.Drawing.Point(6, 42);
            this.Choix2.Name = "Choix2";
            this.Choix2.Size = new System.Drawing.Size(229, 17);
            this.Choix2.TabIndex = 1;
            this.Choix2.TabStop = true;
            this.Choix2.Text = "Remplacer toutes les occurence de 1 par 2";
            this.Choix2.UseVisualStyleBackColor = true;
            this.Choix2.Click += new System.EventHandler(this.Action1);
            // 
            // Choix3
            // 
            this.Choix3.AutoSize = true;
            this.Choix3.Location = new System.Drawing.Point(6, 65);
            this.Choix3.Name = "Choix3";
            this.Choix3.Size = new System.Drawing.Size(190, 17);
            this.Choix3.TabIndex = 2;
            this.Choix3.TabStop = true;
            this.Choix3.Text = "Remplacer 1ere occurence 1 par 2";
            this.Choix3.UseVisualStyleBackColor = true;
            this.Choix3.Click += new System.EventHandler(this.Action2);
            // 
            // Choix4
            // 
            this.Choix4.AutoSize = true;
            this.Choix4.Location = new System.Drawing.Point(6, 88);
            this.Choix4.Name = "Choix4";
            this.Choix4.Size = new System.Drawing.Size(222, 17);
            this.Choix4.TabIndex = 3;
            this.Choix4.TabStop = true;
            this.Choix4.Text = "Remplacer dernière occurence de 1 par 2";
            this.Choix4.UseVisualStyleBackColor = true;
            this.Choix4.Click += new System.EventHandler(this.Action3);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Jouer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Jouer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Portion2);
            this.Controls.Add(this.Resultat);
            this.Controls.Add(this.Portion1);
            this.Controls.Add(this.Saisie);
            this.Name = "Form1";
            this.Text = "Jouer avec les chaînes de caractères";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Saisie;
        private System.Windows.Forms.TextBox Portion1;
        private System.Windows.Forms.TextBox Resultat;
        private System.Windows.Forms.TextBox Portion2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Choix4;
        private System.Windows.Forms.RadioButton Choix3;
        private System.Windows.Forms.RadioButton Choix2;
        private System.Windows.Forms.RadioButton Choix1;
        private System.Windows.Forms.Button button1;
    }
}

