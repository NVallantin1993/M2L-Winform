namespace M2L_ProjetWinform
{
    partial class ListeAdherentClub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeAdherentClub));
            this.cb_club = new System.Windows.Forms.ComboBox();
            this.lvAdherent = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sexe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_recherche = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_club
            // 
            this.cb_club.FormattingEnabled = true;
            this.cb_club.Location = new System.Drawing.Point(130, 35);
            this.cb_club.Name = "cb_club";
            this.cb_club.Size = new System.Drawing.Size(234, 21);
            this.cb_club.TabIndex = 0;
            // 
            // lvAdherent
            // 
            this.lvAdherent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Prenom,
            this.Sexe,
            this.Adresse,
            this.Age});
            this.lvAdherent.Location = new System.Drawing.Point(12, 98);
            this.lvAdherent.Name = "lvAdherent";
            this.lvAdherent.Size = new System.Drawing.Size(866, 324);
            this.lvAdherent.TabIndex = 1;
            this.lvAdherent.UseCompatibleStateImageBehavior = false;
            this.lvAdherent.View = System.Windows.Forms.View.Details;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.Text = "Prénom";
            // 
            // Sexe
            // 
            this.Sexe.Text = "Sexe";
            // 
            // Adresse
            // 
            this.Adresse.Text = "Adresse";
            // 
            // Age
            // 
            this.Age.Text = "Age";
            // 
            // btn_recherche
            // 
            this.btn_recherche.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recherche.Image = ((System.Drawing.Image)(resources.GetObject("btn_recherche.Image")));
            this.btn_recherche.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_recherche.Location = new System.Drawing.Point(469, 22);
            this.btn_recherche.Name = "btn_recherche";
            this.btn_recherche.Size = new System.Drawing.Size(152, 45);
            this.btn_recherche.TabIndex = 26;
            this.btn_recherche.Text = "&Rechercher";
            this.btn_recherche.UseVisualStyleBackColor = false;
            this.btn_recherche.Click += new System.EventHandler(this.btn_recherche_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Club :";
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Image = ((System.Drawing.Image)(resources.GetObject("btnFermer.Image")));
            this.btnFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFermer.Location = new System.Drawing.Point(683, 22);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(152, 45);
            this.btnFermer.TabIndex = 28;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // ListeAdherentClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 521);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_recherche);
            this.Controls.Add(this.lvAdherent);
            this.Controls.Add(this.cb_club);
            this.Name = "ListeAdherentClub";
            this.Text = "*";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListeAdherentClub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_club;
        private System.Windows.Forms.ListView lvAdherent;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Prenom;
        private System.Windows.Forms.ColumnHeader Sexe;
        private System.Windows.Forms.ColumnHeader Adresse;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.Button btn_recherche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFermer;
    }
}