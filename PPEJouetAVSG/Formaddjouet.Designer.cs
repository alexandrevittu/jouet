namespace PPEJouetAVSG
{
    partial class Formaddjouet
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
            this.lblnomjouet = new System.Windows.Forms.Label();
            this.lblcat = new System.Windows.Forms.Label();
            this.lblprix = new System.Windows.Forms.Label();
            this.txtnomjouet = new System.Windows.Forms.TextBox();
            this.txtprix = new System.Windows.Forms.TextBox();
            this.btnajouterjouet = new System.Windows.Forms.Button();
            this.cbcat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbtrancheage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter un jouet";
            // 
            // lblnomjouet
            // 
            this.lblnomjouet.AutoSize = true;
            this.lblnomjouet.Location = new System.Drawing.Point(31, 80);
            this.lblnomjouet.Name = "lblnomjouet";
            this.lblnomjouet.Size = new System.Drawing.Size(76, 13);
            this.lblnomjouet.TabIndex = 1;
            this.lblnomjouet.Text = "Nom du jouet :";
            // 
            // lblcat
            // 
            this.lblcat.AutoSize = true;
            this.lblcat.Location = new System.Drawing.Point(31, 218);
            this.lblcat.Name = "lblcat";
            this.lblcat.Size = new System.Drawing.Size(58, 13);
            this.lblcat.TabIndex = 4;
            this.lblcat.Text = "Categorie :";
            // 
            // lblprix
            // 
            this.lblprix.AutoSize = true;
            this.lblprix.Location = new System.Drawing.Point(31, 266);
            this.lblprix.Name = "lblprix";
            this.lblprix.Size = new System.Drawing.Size(29, 13);
            this.lblprix.TabIndex = 5;
            this.lblprix.Text = "prix :";
            // 
            // txtnomjouet
            // 
            this.txtnomjouet.Location = new System.Drawing.Point(113, 77);
            this.txtnomjouet.Name = "txtnomjouet";
            this.txtnomjouet.Size = new System.Drawing.Size(137, 20);
            this.txtnomjouet.TabIndex = 6;
            // 
            // txtprix
            // 
            this.txtprix.Location = new System.Drawing.Point(113, 266);
            this.txtprix.Name = "txtprix";
            this.txtprix.Size = new System.Drawing.Size(137, 20);
            this.txtprix.TabIndex = 10;
            // 
            // btnajouterjouet
            // 
            this.btnajouterjouet.Location = new System.Drawing.Point(274, 343);
            this.btnajouterjouet.Name = "btnajouterjouet";
            this.btnajouterjouet.Size = new System.Drawing.Size(174, 53);
            this.btnajouterjouet.TabIndex = 11;
            this.btnajouterjouet.Text = "ajouter";
            this.btnajouterjouet.UseVisualStyleBackColor = true;
            this.btnajouterjouet.Click += new System.EventHandler(this.btnajouterjouet_Click);
            // 
            // cbcat
            // 
            this.cbcat.FormattingEnabled = true;
            this.cbcat.Location = new System.Drawing.Point(113, 218);
            this.cbcat.Name = "cbcat";
            this.cbcat.Size = new System.Drawing.Size(137, 21);
            this.cbcat.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tranche age :";
            // 
            // cbtrancheage
            // 
            this.cbtrancheage.FormattingEnabled = true;
            this.cbtrancheage.Location = new System.Drawing.Point(113, 120);
            this.cbtrancheage.Name = "cbtrancheage";
            this.cbtrancheage.Size = new System.Drawing.Size(137, 21);
            this.cbtrancheage.TabIndex = 15;
            // 
            // Formaddjouet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 457);
            this.Controls.Add(this.cbtrancheage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbcat);
            this.Controls.Add(this.btnajouterjouet);
            this.Controls.Add(this.txtprix);
            this.Controls.Add(this.txtnomjouet);
            this.Controls.Add(this.lblprix);
            this.Controls.Add(this.lblcat);
            this.Controls.Add(this.lblnomjouet);
            this.Controls.Add(this.label1);
            this.Name = "Formaddjouet";
            this.Text = "Formaddjouet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnomjouet;
        private System.Windows.Forms.Label lblcat;
        private System.Windows.Forms.Label lblprix;
        private System.Windows.Forms.TextBox txtnomjouet;
        private System.Windows.Forms.TextBox txtprix;
        private System.Windows.Forms.Button btnajouterjouet;
        private System.Windows.Forms.ComboBox cbcat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbtrancheage;
    }
}