namespace PPEJouetAVSG
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
            this.titre1 = new System.Windows.Forms.Label();
            this.textBoxidentifiant = new System.Windows.Forms.TextBox();
            this.labelidentifiant = new System.Windows.Forms.Label();
            this.textBoxMDP = new System.Windows.Forms.TextBox();
            this.labelMDP = new System.Windows.Forms.Label();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titre1
            // 
            this.titre1.AutoSize = true;
            this.titre1.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre1.ForeColor = System.Drawing.Color.Red;
            this.titre1.Location = new System.Drawing.Point(424, 74);
            this.titre1.Name = "titre1";
            this.titre1.Size = new System.Drawing.Size(70, 17);
            this.titre1.TabIndex = 0;
            this.titre1.Text = "Connexion";
            // 
            // textBoxidentifiant
            // 
            this.textBoxidentifiant.Location = new System.Drawing.Point(406, 198);
            this.textBoxidentifiant.Name = "textBoxidentifiant";
            this.textBoxidentifiant.Size = new System.Drawing.Size(190, 20);
            this.textBoxidentifiant.TabIndex = 1;
            // 
            // labelidentifiant
            // 
            this.labelidentifiant.AutoSize = true;
            this.labelidentifiant.Location = new System.Drawing.Point(311, 198);
            this.labelidentifiant.Name = "labelidentifiant";
            this.labelidentifiant.Size = new System.Drawing.Size(59, 13);
            this.labelidentifiant.TabIndex = 2;
            this.labelidentifiant.Text = "Identifiant :";
            // 
            // textBoxMDP
            // 
            this.textBoxMDP.Location = new System.Drawing.Point(406, 254);
            this.textBoxMDP.Name = "textBoxMDP";
            this.textBoxMDP.PasswordChar = '♪';
            this.textBoxMDP.Size = new System.Drawing.Size(190, 20);
            this.textBoxMDP.TabIndex = 3;
            // 
            // labelMDP
            // 
            this.labelMDP.AutoSize = true;
            this.labelMDP.Location = new System.Drawing.Point(311, 257);
            this.labelMDP.Name = "labelMDP";
            this.labelMDP.Size = new System.Drawing.Size(77, 13);
            this.labelMDP.TabIndex = 4;
            this.labelMDP.Text = "Mot de passe :";
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(374, 357);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(222, 60);
            this.buttonConnexion.TabIndex = 5;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.labelMDP);
            this.Controls.Add(this.textBoxMDP);
            this.Controls.Add(this.labelidentifiant);
            this.Controls.Add(this.textBoxidentifiant);
            this.Controls.Add(this.titre1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titre1;
        private System.Windows.Forms.TextBox textBoxidentifiant;
        private System.Windows.Forms.Label labelidentifiant;
        private System.Windows.Forms.TextBox textBoxMDP;
        private System.Windows.Forms.Label labelMDP;
        private System.Windows.Forms.Button buttonConnexion;
    }
}

