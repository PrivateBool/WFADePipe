namespace WFADePipe
{
    partial class FormDe
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
            this.labelValeurDe = new System.Windows.Forms.Label();
            this.textBoxValeurDe = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelValeurDe
            // 
            this.labelValeurDe.AutoSize = true;
            this.labelValeurDe.Location = new System.Drawing.Point(304, 123);
            this.labelValeurDe.Name = "labelValeurDe";
            this.labelValeurDe.Size = new System.Drawing.Size(140, 16);
            this.labelValeurDe.TabIndex = 0;
            this.labelValeurDe.Text = "Résultat de la brasse :";
            // 
            // textBoxValeurDe
            // 
            this.textBoxValeurDe.Location = new System.Drawing.Point(450, 117);
            this.textBoxValeurDe.Name = "textBoxValeurDe";
            this.textBoxValeurDe.Size = new System.Drawing.Size(100, 22);
            this.textBoxValeurDe.TabIndex = 1;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(450, 155);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 22);
            this.textBoxTotal.TabIndex = 3;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(304, 161);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(44, 16);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "Total :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textBoxValeurDe);
            this.Controls.Add(this.labelValeurDe);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDe";
            this.Text = "Jeu de dé";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValeurDe;
        private System.Windows.Forms.TextBox textBoxValeurDe;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button button1;
    }
}

