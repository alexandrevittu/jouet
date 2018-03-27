namespace PPEJouetAVSG
{
    partial class FormRecapitulatif
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
            this.components = new System.ComponentModel.Container();
            this.enfantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slam2018JouetAVSGDataSet = new PPEJouetAVSG.slam2018JouetAVSGDataSet();
            this.enfantTableAdapter = new PPEJouetAVSG.slam2018JouetAVSGDataSetTableAdapters.enfantTableAdapter();
            this.dataGridView1listjouet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.enfantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slam2018JouetAVSGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1listjouet)).BeginInit();
            this.SuspendLayout();
            // 
            // enfantBindingSource
            // 
            this.enfantBindingSource.DataMember = "enfant";
            this.enfantBindingSource.DataSource = this.slam2018JouetAVSGDataSet;
            // 
            // slam2018JouetAVSGDataSet
            // 
            this.slam2018JouetAVSGDataSet.DataSetName = "slam2018JouetAVSGDataSet";
            this.slam2018JouetAVSGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enfantTableAdapter
            // 
            this.enfantTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1listjouet
            // 
            this.dataGridView1listjouet.AllowUserToAddRows = false;
            this.dataGridView1listjouet.AllowUserToDeleteRows = false;
            this.dataGridView1listjouet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1listjouet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1listjouet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1listjouet.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1listjouet.Name = "dataGridView1listjouet";
            this.dataGridView1listjouet.RowHeadersVisible = false;
            this.dataGridView1listjouet.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1listjouet.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1listjouet.Size = new System.Drawing.Size(1133, 634);
            this.dataGridView1listjouet.TabIndex = 0;
            // 
            // FormRecapitulatif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 636);
            this.Controls.Add(this.dataGridView1listjouet);
            this.Name = "FormRecapitulatif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRecapitulatif";
            this.Load += new System.EventHandler(this.FormRecapitulatif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enfantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slam2018JouetAVSGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1listjouet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private slam2018JouetAVSGDataSet slam2018JouetAVSGDataSet;
        private System.Windows.Forms.BindingSource enfantBindingSource;
        private slam2018JouetAVSGDataSetTableAdapters.enfantTableAdapter enfantTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1listjouet;

    }
}