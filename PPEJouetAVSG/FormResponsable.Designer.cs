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
            this.label1 = new System.Windows.Forms.Label();
            this.btneditlist = new System.Windows.Forms.Button();
            this.btnrecap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Responsable du CE";
            // 
            // btneditlist
            // 
            this.btneditlist.Location = new System.Drawing.Point(283, 111);
            this.btneditlist.Name = "btneditlist";
            this.btneditlist.Size = new System.Drawing.Size(171, 48);
            this.btneditlist.TabIndex = 1;
            this.btneditlist.Text = "editer liste jouets";
            this.btneditlist.UseVisualStyleBackColor = true;
            this.btneditlist.Click += new System.EventHandler(this.btneditlist_Click);
            // 
            // btnrecap
            // 
            this.btnrecap.Location = new System.Drawing.Point(283, 211);
            this.btnrecap.Name = "btnrecap";
            this.btnrecap.Size = new System.Drawing.Size(171, 48);
            this.btnrecap.TabIndex = 2;
            this.btnrecap.Text = "Recapitulatif des commandes";
            this.btnrecap.UseVisualStyleBackColor = true;
            this.btnrecap.Click += new System.EventHandler(this.btnrecap_Click);
            // 
            // FormResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 474);
            this.Controls.Add(this.btnrecap);
            this.Controls.Add(this.btneditlist);
            this.Controls.Add(this.label1);
            this.Name = "FormResponsable";
            this.Text = "FormResponsable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btneditlist;
        private System.Windows.Forms.Button btnrecap;
    }
}