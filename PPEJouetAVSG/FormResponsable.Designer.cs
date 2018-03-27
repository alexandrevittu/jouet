namespace PPEJouetAVSG
{
    partial class FormResponsable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.editjouet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editjouet
            // 
            this.editjouet.Location = new System.Drawing.Point(429, 170);
            this.editjouet.Name = "editjouet";
            this.editjouet.Size = new System.Drawing.Size(118, 56);
            this.editjouet.TabIndex = 0;
            this.editjouet.Text = "ajouter jouet";
            this.editjouet.UseVisualStyleBackColor = true;
            this.editjouet.Click += new System.EventHandler(this.editjouet_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Nombre de jouet par categorie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "recapitulatif des commandes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormResponsable
            // 
            this.ClientSize = new System.Drawing.Size(847, 554);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.editjouet);
            this.Name = "FormResponsable";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btneditlist;
        private System.Windows.Forms.Button btnrecap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnaddemploye;
        private System.Windows.Forms.Button editjouet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}