namespace M2L_ProjetWinform
{
    partial class Frm_acceuil
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.clubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parSpecialitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adherentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parClubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreDadherentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evenementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermezToutesLesFenetresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clubToolStripMenuItem,
            this.adherentToolStripMenuItem,
            this.evenementToolStripMenuItem,
            this.fermezToutesLesFenetresToolStripMenuItem,
            this.statistiqueToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1193, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // clubToolStripMenuItem
            // 
            this.clubToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeToolStripMenuItem1,
            this.ajouterToolStripMenuItem1});
            this.clubToolStripMenuItem.Name = "clubToolStripMenuItem";
            this.clubToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.clubToolStripMenuItem.Text = "Club";
            // 
            // listeToolStripMenuItem1
            // 
            this.listeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parSpecialitéToolStripMenuItem});
            this.listeToolStripMenuItem1.Name = "listeToolStripMenuItem1";
            this.listeToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.listeToolStripMenuItem1.Text = "Liste";
            this.listeToolStripMenuItem1.Click += new System.EventHandler(this.listeToolStripMenuItem1_Click);
            // 
            // parSpecialitéToolStripMenuItem
            // 
            this.parSpecialitéToolStripMenuItem.Name = "parSpecialitéToolStripMenuItem";
            this.parSpecialitéToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.parSpecialitéToolStripMenuItem.Text = "Par Specialité";
            this.parSpecialitéToolStripMenuItem.Click += new System.EventHandler(this.parSpecialitéToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajouterToolStripMenuItem1_Click);
            // 
            // adherentToolStripMenuItem
            // 
            this.adherentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeToolStripMenuItem,
            this.ajouterToolStripMenuItem,
            this.nombreDadherentToolStripMenuItem});
            this.adherentToolStripMenuItem.Name = "adherentToolStripMenuItem";
            this.adherentToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.adherentToolStripMenuItem.Text = "Adherent";
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parClubToolStripMenuItem});
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.listeToolStripMenuItem.Text = "Liste";
            this.listeToolStripMenuItem.Click += new System.EventHandler(this.listeToolStripMenuItem_Click);
            // 
            // parClubToolStripMenuItem
            // 
            this.parClubToolStripMenuItem.Name = "parClubToolStripMenuItem";
            this.parClubToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.parClubToolStripMenuItem.Text = "Par Club";
            this.parClubToolStripMenuItem.Click += new System.EventHandler(this.parClubToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // nombreDadherentToolStripMenuItem
            // 
            this.nombreDadherentToolStripMenuItem.Name = "nombreDadherentToolStripMenuItem";
            this.nombreDadherentToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.nombreDadherentToolStripMenuItem.Text = "Nombre d\'adherent";
            this.nombreDadherentToolStripMenuItem.Click += new System.EventHandler(this.nombreDadherentToolStripMenuItem_Click);
            // 
            // evenementToolStripMenuItem
            // 
            this.evenementToolStripMenuItem.Name = "evenementToolStripMenuItem";
            this.evenementToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.evenementToolStripMenuItem.Text = "Evenement";
            // 
            // fermezToutesLesFenetresToolStripMenuItem
            // 
            this.fermezToutesLesFenetresToolStripMenuItem.Name = "fermezToutesLesFenetresToolStripMenuItem";
            this.fermezToutesLesFenetresToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
            this.fermezToutesLesFenetresToolStripMenuItem.Text = "Fermez Toutes les fenetres";
            this.fermezToutesLesFenetresToolStripMenuItem.Click += new System.EventHandler(this.fermezToutesLesFenetresToolStripMenuItem_Click);
            // 
            // statistiqueToolStripMenuItem
            // 
            this.statistiqueToolStripMenuItem.Name = "statistiqueToolStripMenuItem";
            this.statistiqueToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.statistiqueToolStripMenuItem.Text = "Statistique";
            this.statistiqueToolStripMenuItem.Click += new System.EventHandler(this.statistiqueToolStripMenuItem_Click);
            // 
            // Frm_acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1193, 551);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "Frm_acceuil";
            this.Text = "Acceuil";
            this.Load += new System.EventHandler(this.Frm_acceuil_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem clubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adherentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evenementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parClubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parSpecialitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nombreDadherentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermezToutesLesFenetresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiqueToolStripMenuItem;
    }
}

