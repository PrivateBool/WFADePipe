namespace WFADePipe
{
    partial class FormIntreface
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
            this.buttonBrasser = new System.Windows.Forms.Button();
            this.labelTypeDeDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelValeurDe
            // 
            this.labelValeurDe.AutoSize = true;
            this.labelValeurDe.Location = new System.Drawing.Point(228, 100);
            this.labelValeurDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValeurDe.Name = "labelValeurDe";
            this.labelValeurDe.Size = new System.Drawing.Size(112, 13);
            this.labelValeurDe.TabIndex = 0;
            this.labelValeurDe.Text = "Résultat de la brasse :";
            // 
            // textBoxValeurDe
            // 
            this.textBoxValeurDe.Location = new System.Drawing.Point(338, 95);
            this.textBoxValeurDe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxValeurDe.Name = "textBoxValeurDe";
            this.textBoxValeurDe.Size = new System.Drawing.Size(76, 20);
            this.textBoxValeurDe.TabIndex = 1;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(338, 126);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(76, 20);
            this.textBoxTotal.TabIndex = 3;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(228, 131);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(37, 13);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "Total :";
            // 
            // buttonBrasser
            // 
            this.buttonBrasser.Location = new System.Drawing.Point(291, 157);
            this.buttonBrasser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBrasser.Name = "buttonBrasser";
            this.buttonBrasser.Size = new System.Drawing.Size(110, 19);
            this.buttonBrasser.TabIndex = 4;
            this.buttonBrasser.Text = "Brasser";
            this.buttonBrasser.UseVisualStyleBackColor = true;
            this.buttonBrasser.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTypeDeDe
            // 
            this.labelTypeDeDe.AutoSize = true;
            this.labelTypeDeDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeDeDe.Location = new System.Drawing.Point(209, 41);
            this.labelTypeDeDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTypeDeDe.Name = "labelTypeDeDe";
            this.labelTypeDeDe.Size = new System.Drawing.Size(288, 36);
            this.labelTypeDeDe.TabIndex = 5;
            this.labelTypeDeDe.Text = "Type de dé brasser";
            // 
            // FormIntreface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTypeDeDe);
            this.Controls.Add(this.buttonBrasser);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textBoxValeurDe);
            this.Controls.Add(this.labelValeurDe);
            this.Name = "FormIntreface";
            this.Text = "Jeu de dé";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValeurDe;
        private System.Windows.Forms.TextBox textBoxValeurDe;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonBrasser;
        private System.Windows.Forms.Label labelTypeDeDe;
    }
}

