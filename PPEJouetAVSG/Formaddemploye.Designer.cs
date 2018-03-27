namespace PPEJouetAVSG
{
    partial class Formaddemploye
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxNom = new System.Windows.Forms.TextBox();
            this.txtboxPrenom = new System.Windows.Forms.TextBox();
            this.txtboxmdp = new System.Windows.Forms.TextBox();
            this.txtboxcp = new System.Windows.Forms.TextBox();
            this.txtboxAdresse = new System.Windows.Forms.TextBox();
            this.txtboxNumtel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mot de passe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Code postal :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero de telephone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adresse :";
            // 
            // txtboxNom
            // 
            this.txtboxNom.Location = new System.Drawing.Point(78, 58);
            this.txtboxNom.Name = "txtboxNom";
            this.txtboxNom.Size = new System.Drawing.Size(100, 20);
            this.txtboxNom.TabIndex = 6;
            // 
            // txtboxPrenom
            // 
            this.txtboxPrenom.Location = new System.Drawing.Point(92, 98);
            this.txtboxPrenom.Name = "txtboxPrenom";
            this.txtboxPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtboxPrenom.TabIndex = 7;
            // 
            // txtboxmdp
            // 
            this.txtboxmdp.Location = new System.Drawing.Point(119, 131);
            this.txtboxmdp.Name = "txtboxmdp";
            this.txtboxmdp.Size = new System.Drawing.Size(100, 20);
            this.txtboxmdp.TabIndex = 8;
            // 
            // txtboxcp
            // 
            this.txtboxcp.Location = new System.Drawing.Point(111, 164);
            this.txtboxcp.Name = "txtboxcp";
            this.txtboxcp.Size = new System.Drawing.Size(100, 20);
            this.txtboxcp.TabIndex = 9;
            // 
            // txtboxAdresse
            // 
            this.txtboxAdresse.Location = new System.Drawing.Point(94, 203);
            this.txtboxAdresse.Name = "txtboxAdresse";
            this.txtboxAdresse.Size = new System.Drawing.Size(100, 20);
            this.txtboxAdresse.TabIndex = 10;
            // 
            // txtboxNumtel
            // 
            this.txtboxNumtel.Location = new System.Drawing.Point(158, 240);
            this.txtboxNumtel.Name = "txtboxNumtel";
            this.txtboxNumtel.Size = new System.Drawing.Size(100, 20);
            this.txtboxNumtel.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Formaddemploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 538);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtboxNumtel);
            this.Controls.Add(this.txtboxAdresse);
            this.Controls.Add(this.txtboxcp);
            this.Controls.Add(this.txtboxmdp);
            this.Controls.Add(this.txtboxPrenom);
            this.Controls.Add(this.txtboxNom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formaddemploye";
            this.Text = "Formaddemploye";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxNom;
        private System.Windows.Forms.TextBox txtboxPrenom;
        private System.Windows.Forms.TextBox txtboxmdp;
        private System.Windows.Forms.TextBox txtboxcp;
        private System.Windows.Forms.TextBox txtboxAdresse;
        private System.Windows.Forms.TextBox txtboxNumtel;
        private System.Windows.Forms.Button button1;
    }
}