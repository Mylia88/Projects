﻿namespace WindowsFormsApplication1
{
    partial class Additions
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(264, 96);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Chiffres);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Chiffres);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(216, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Chiffres);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(270, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 44);
            this.button4.TabIndex = 4;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Chiffres);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(324, 132);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 44);
            this.button5.TabIndex = 5;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Chiffres);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(108, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 44);
            this.button6.TabIndex = 6;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Chiffres);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(162, 182);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(48, 44);
            this.button7.TabIndex = 7;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Chiffres);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(216, 182);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 44);
            this.button8.TabIndex = 8;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Chiffres);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(270, 182);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 44);
            this.button9.TabIndex = 9;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Chiffres);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(324, 182);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(48, 44);
            this.button10.TabIndex = 10;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Chiffres);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(108, 242);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(102, 23);
            this.button11.TabIndex = 11;
            this.button11.Text = "Vider";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Vider);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(270, 242);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(102, 23);
            this.button12.TabIndex = 12;
            this.button12.Text = "Calculer";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.clk_Somme);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 277);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Additionneur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MessageFermeture);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}

