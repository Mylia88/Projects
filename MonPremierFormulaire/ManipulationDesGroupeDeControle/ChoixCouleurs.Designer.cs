namespace ManipulationDesGroupeDeControle
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.casse = new System.Windows.Forms.CheckBox();
            this.couleurDesCaracteres = new System.Windows.Forms.CheckBox();
            this.couleurDuFond = new System.Windows.Forms.CheckBox();
            this.Fond = new System.Windows.Forms.GroupBox();
            this.FRouge = new System.Windows.Forms.RadioButton();
            this.FVert = new System.Windows.Forms.RadioButton();
            this.FBleu = new System.Windows.Forms.RadioButton();
            this.Caractere = new System.Windows.Forms.GroupBox();
            this.CNoir = new System.Windows.Forms.RadioButton();
            this.CRouge = new System.Windows.Forms.RadioButton();
            this.CBlanc = new System.Windows.Forms.RadioButton();
            this.ChoixCasse = new System.Windows.Forms.GroupBox();
            this.CMini = new System.Windows.Forms.RadioButton();
            this.CMaj = new System.Windows.Forms.RadioButton();
            this.Copie = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Fond.SuspendLayout();
            this.Caractere.SuspendLayout();
            this.ChoixCasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 39);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(303, 20);
            this.TextBox.TabIndex = 0;
            this.TextBox.TextChanged += new System.EventHandler(this.Saisie);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tapez votre texte";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.casse);
            this.groupBox1.Controls.Add(this.couleurDesCaracteres);
            this.groupBox1.Controls.Add(this.couleurDuFond);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(385, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 91);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix";
            // 
            // casse
            // 
            this.casse.AutoSize = true;
            this.casse.Location = new System.Drawing.Point(11, 66);
            this.casse.Name = "casse";
            this.casse.Size = new System.Drawing.Size(55, 17);
            this.casse.TabIndex = 2;
            this.casse.Text = "Casse";
            this.casse.UseVisualStyleBackColor = true;
            this.casse.CheckedChanged += new System.EventHandler(this.Casse);
            // 
            // couleurDesCaracteres
            // 
            this.couleurDesCaracteres.AutoSize = true;
            this.couleurDesCaracteres.Location = new System.Drawing.Point(11, 43);
            this.couleurDesCaracteres.Name = "couleurDesCaracteres";
            this.couleurDesCaracteres.Size = new System.Drawing.Size(135, 17);
            this.couleurDesCaracteres.TabIndex = 1;
            this.couleurDesCaracteres.Text = "Couleur des caractères";
            this.couleurDesCaracteres.UseVisualStyleBackColor = true;
            this.couleurDesCaracteres.CheckedChanged += new System.EventHandler(this.CouleurCaractere);
            // 
            // couleurDuFond
            // 
            this.couleurDuFond.AutoSize = true;
            this.couleurDuFond.Location = new System.Drawing.Point(11, 20);
            this.couleurDuFond.Name = "couleurDuFond";
            this.couleurDuFond.Size = new System.Drawing.Size(101, 17);
            this.couleurDuFond.TabIndex = 0;
            this.couleurDuFond.Text = "Couleur du fond";
            this.couleurDuFond.UseVisualStyleBackColor = true;
            this.couleurDuFond.CheckedChanged += new System.EventHandler(this.CouleurFond);
            // 
            // Fond
            // 
            this.Fond.Controls.Add(this.FRouge);
            this.Fond.Controls.Add(this.FVert);
            this.Fond.Controls.Add(this.FBleu);
            this.Fond.Enabled = false;
            this.Fond.Location = new System.Drawing.Point(12, 156);
            this.Fond.Name = "Fond";
            this.Fond.Size = new System.Drawing.Size(99, 88);
            this.Fond.TabIndex = 3;
            this.Fond.TabStop = false;
            this.Fond.Text = "Fond";
            // 
            // FRouge
            // 
            this.FRouge.AutoSize = true;
            this.FRouge.Location = new System.Drawing.Point(0, 19);
            this.FRouge.Name = "FRouge";
            this.FRouge.Size = new System.Drawing.Size(57, 17);
            this.FRouge.TabIndex = 7;
            this.FRouge.TabStop = true;
            this.FRouge.Text = "Rouge";
            this.FRouge.UseVisualStyleBackColor = true;
            this.FRouge.CheckedChanged += new System.EventHandler(this.ChoixFond);
            // 
            // FVert
            // 
            this.FVert.AutoSize = true;
            this.FVert.Location = new System.Drawing.Point(0, 42);
            this.FVert.Name = "FVert";
            this.FVert.Size = new System.Drawing.Size(44, 17);
            this.FVert.TabIndex = 8;
            this.FVert.TabStop = true;
            this.FVert.Text = "Vert";
            this.FVert.UseVisualStyleBackColor = true;
            this.FVert.CheckedChanged += new System.EventHandler(this.ChoixFond);
            // 
            // FBleu
            // 
            this.FBleu.AutoSize = true;
            this.FBleu.Location = new System.Drawing.Point(0, 65);
            this.FBleu.Name = "FBleu";
            this.FBleu.Size = new System.Drawing.Size(46, 17);
            this.FBleu.TabIndex = 9;
            this.FBleu.TabStop = true;
            this.FBleu.Text = "Bleu";
            this.FBleu.UseVisualStyleBackColor = true;
            this.FBleu.CheckedChanged += new System.EventHandler(this.ChoixFond);
            // 
            // Caractere
            // 
            this.Caractere.Controls.Add(this.CNoir);
            this.Caractere.Controls.Add(this.CRouge);
            this.Caractere.Controls.Add(this.CBlanc);
            this.Caractere.Enabled = false;
            this.Caractere.Location = new System.Drawing.Point(117, 156);
            this.Caractere.Name = "Caractere";
            this.Caractere.Size = new System.Drawing.Size(95, 88);
            this.Caractere.TabIndex = 4;
            this.Caractere.TabStop = false;
            this.Caractere.Text = "Caractère";
            // 
            // CNoir
            // 
            this.CNoir.AutoSize = true;
            this.CNoir.Location = new System.Drawing.Point(4, 65);
            this.CNoir.Name = "CNoir";
            this.CNoir.Size = new System.Drawing.Size(44, 17);
            this.CNoir.TabIndex = 12;
            this.CNoir.TabStop = true;
            this.CNoir.Text = "Noir";
            this.CNoir.UseVisualStyleBackColor = true;
            this.CNoir.CheckedChanged += new System.EventHandler(this.ChoixCaractere);
            // 
            // CRouge
            // 
            this.CRouge.AutoSize = true;
            this.CRouge.Location = new System.Drawing.Point(4, 19);
            this.CRouge.Name = "CRouge";
            this.CRouge.Size = new System.Drawing.Size(57, 17);
            this.CRouge.TabIndex = 10;
            this.CRouge.TabStop = true;
            this.CRouge.Text = "Rouge";
            this.CRouge.UseVisualStyleBackColor = true;
            this.CRouge.CheckedChanged += new System.EventHandler(this.ChoixCaractere);
            // 
            // CBlanc
            // 
            this.CBlanc.AutoSize = true;
            this.CBlanc.Location = new System.Drawing.Point(4, 42);
            this.CBlanc.Name = "CBlanc";
            this.CBlanc.Size = new System.Drawing.Size(52, 17);
            this.CBlanc.TabIndex = 11;
            this.CBlanc.TabStop = true;
            this.CBlanc.Text = "Blanc";
            this.CBlanc.UseVisualStyleBackColor = true;
            this.CBlanc.CheckedChanged += new System.EventHandler(this.ChoixCaractere);
            // 
            // ChoixCasse
            // 
            this.ChoixCasse.Controls.Add(this.CMini);
            this.ChoixCasse.Controls.Add(this.CMaj);
            this.ChoixCasse.Enabled = false;
            this.ChoixCasse.Location = new System.Drawing.Point(218, 184);
            this.ChoixCasse.Name = "ChoixCasse";
            this.ChoixCasse.Size = new System.Drawing.Size(93, 60);
            this.ChoixCasse.TabIndex = 5;
            this.ChoixCasse.TabStop = false;
            this.ChoixCasse.Text = "Casse";
            // 
            // CMini
            // 
            this.CMini.AutoSize = true;
            this.CMini.Location = new System.Drawing.Point(2, 14);
            this.CMini.Name = "CMini";
            this.CMini.Size = new System.Drawing.Size(73, 17);
            this.CMini.TabIndex = 13;
            this.CMini.TabStop = true;
            this.CMini.Text = "Minuscule";
            this.CMini.UseVisualStyleBackColor = true;
            this.CMini.CheckedChanged += new System.EventHandler(this.LeChoixCasse);
            // 
            // CMaj
            // 
            this.CMaj.AutoSize = true;
            this.CMaj.Location = new System.Drawing.Point(2, 37);
            this.CMaj.Name = "CMaj";
            this.CMaj.Size = new System.Drawing.Size(73, 17);
            this.CMaj.TabIndex = 14;
            this.CMaj.TabStop = true;
            this.CMaj.Text = "Majuscule";
            this.CMaj.UseVisualStyleBackColor = true;
            this.CMaj.CheckedChanged += new System.EventHandler(this.LeChoixCasse);
            // 
            // Copie
            // 
            this.Copie.AutoSize = true;
            this.Copie.BackColor = System.Drawing.Color.Transparent;
            this.Copie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copie.Location = new System.Drawing.Point(12, 83);
            this.Copie.Name = "Copie";
            this.Copie.Size = new System.Drawing.Size(68, 25);
            this.Copie.TabIndex = 6;
            this.Copie.Text = "Copie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 354);
            this.Controls.Add(this.Copie);
            this.Controls.Add(this.ChoixCasse);
            this.Controls.Add(this.Caractere);
            this.Controls.Add(this.Fond);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox);
            this.Name = "Form1";
            this.Text = "CheckBox et RadioButton";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Fond.ResumeLayout(false);
            this.Fond.PerformLayout();
            this.Caractere.ResumeLayout(false);
            this.Caractere.PerformLayout();
            this.ChoixCasse.ResumeLayout(false);
            this.ChoixCasse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Copie;
        private System.Windows.Forms.RadioButton FRouge;
        private System.Windows.Forms.RadioButton FVert;
        private System.Windows.Forms.RadioButton FBleu;
        private System.Windows.Forms.RadioButton CNoir;
        private System.Windows.Forms.RadioButton CRouge;
        private System.Windows.Forms.RadioButton CBlanc;
        private System.Windows.Forms.RadioButton CMini;
        private System.Windows.Forms.RadioButton CMaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox casse;
        private System.Windows.Forms.CheckBox couleurDesCaracteres;
        private System.Windows.Forms.CheckBox couleurDuFond;
        private System.Windows.Forms.GroupBox Fond;
        private System.Windows.Forms.GroupBox Caractere;
        private System.Windows.Forms.GroupBox ChoixCasse;
    }
}

