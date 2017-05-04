namespace M2L_ProjetWinform
{
    partial class Statistics
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
            this.bdwinformDataSet = new M2L_ProjetWinform.bdwinformDataSet();
            this.adherentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adherentTableAdapter = new M2L_ProjetWinform.bdwinformDataSetTableAdapters.adherentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdwinformDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bdwinformDataSet
            // 
            this.bdwinformDataSet.DataSetName = "bdwinformDataSet";
            this.bdwinformDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adherentBindingSource
            // 
            this.adherentBindingSource.DataMember = "adherent";
            this.adherentBindingSource.DataSource = this.bdwinformDataSet;
            // 
            // adherentTableAdapter
            // 
            this.adherentTableAdapter.ClearBeforeFill = true;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 617);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdwinformDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private bdwinformDataSet bdwinformDataSet;
        private System.Windows.Forms.BindingSource adherentBindingSource;
        private bdwinformDataSetTableAdapters.adherentTableAdapter adherentTableAdapter;
    }
}