namespace PPEJouetAVSG
{
    partial class FormJouetCategorie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewjouetcategorie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewjouetcategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewjouetcategorie
            // 
            this.dataGridViewjouetcategorie.AllowUserToAddRows = false;
            this.dataGridViewjouetcategorie.AllowUserToDeleteRows = false;
            this.dataGridViewjouetcategorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewjouetcategorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewjouetcategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewjouetcategorie.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewjouetcategorie.Name = "dataGridViewjouetcategorie";
            this.dataGridViewjouetcategorie.ReadOnly = true;
            this.dataGridViewjouetcategorie.RowHeadersVisible = false;
            this.dataGridViewjouetcategorie.Size = new System.Drawing.Size(872, 530);
            this.dataGridViewjouetcategorie.TabIndex = 0;
            // 
            // FormJouetCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 530);
            this.Controls.Add(this.dataGridViewjouetcategorie);
            this.Name = "FormJouetCategorie";
            this.Text = "FormJouetCategorie";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewjouetcategorie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewjouetcategorie;
    }
}