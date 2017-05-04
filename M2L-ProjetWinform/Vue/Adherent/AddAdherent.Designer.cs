namespace M2L_ProjetWinform
{
    partial class AddAdherent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdherent));
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.gb_Sexe = new System.Windows.Forms.GroupBox();
            this.gb_adress = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.tb_cp = new System.Windows.Forms.TextBox();
            this.tb_rue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mc_naissance = new System.Windows.Forms.MonthCalendar();
            this.Add_Adherent = new System.Windows.Forms.Button();
            this.CloseWindow = new System.Windows.Forms.Button();
            this.gb_Sexe.SuspendLayout();
            this.gb_adress.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(94, 28);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(100, 20);
            this.tb_nom.TabIndex = 1;
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(94, 82);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(100, 20);
            this.tb_prenom.TabIndex = 2;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(6, 55);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(61, 17);
            this.rb_male.TabIndex = 3;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Homme";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(6, 28);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(59, 17);
            this.rb_female.TabIndex = 4;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Femme";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // gb_Sexe
            // 
            this.gb_Sexe.Controls.Add(this.rb_female);
            this.gb_Sexe.Controls.Add(this.rb_male);
            this.gb_Sexe.Location = new System.Drawing.Point(251, 141);
            this.gb_Sexe.Name = "gb_Sexe";
            this.gb_Sexe.Size = new System.Drawing.Size(80, 83);
            this.gb_Sexe.TabIndex = 5;
            this.gb_Sexe.TabStop = false;
            this.gb_Sexe.Text = "Sexe";
            // 
            // gb_adress
            // 
            this.gb_adress.Controls.Add(this.label6);
            this.gb_adress.Controls.Add(this.label5);
            this.gb_adress.Controls.Add(this.label4);
            this.gb_adress.Controls.Add(this.tb_ville);
            this.gb_adress.Controls.Add(this.tb_cp);
            this.gb_adress.Controls.Add(this.tb_rue);
            this.gb_adress.Location = new System.Drawing.Point(616, 64);
            this.gb_adress.Name = "gb_adress";
            this.gb_adress.Size = new System.Drawing.Size(307, 315);
            this.gb_adress.TabIndex = 7;
            this.gb_adress.TabStop = false;
            this.gb_adress.Text = "Information Complémentaire :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ville :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Code Postal :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Numero et nom de la rue :";
            // 
            // tb_ville
            // 
            this.tb_ville.Location = new System.Drawing.Point(180, 141);
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.Size = new System.Drawing.Size(100, 20);
            this.tb_ville.TabIndex = 2;
            // 
            // tb_cp
            // 
            this.tb_cp.Location = new System.Drawing.Point(180, 78);
            this.tb_cp.Name = "tb_cp";
            this.tb_cp.Size = new System.Drawing.Size(100, 20);
            this.tb_cp.TabIndex = 1;
            // 
            // tb_rue
            // 
            this.tb_rue.Location = new System.Drawing.Point(180, 27);
            this.tb_rue.Name = "tb_rue";
            this.tb_rue.Size = new System.Drawing.Size(100, 20);
            this.tb_rue.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mc_naissance);
            this.groupBox1.Controls.Add(this.gb_Sexe);
            this.groupBox1.Controls.Add(this.tb_prenom);
            this.groupBox1.Controls.Add(this.tb_nom);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 315);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information general";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date de naissance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prenom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom :";
            // 
            // mc_naissance
            // 
            this.mc_naissance.Location = new System.Drawing.Point(12, 141);
            this.mc_naissance.Name = "mc_naissance";
            this.mc_naissance.TabIndex = 3;
            // 
            // Add_Adherent
            // 
            this.Add_Adherent.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Add_Adherent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Adherent.Image = ((System.Drawing.Image)(resources.GetObject("Add_Adherent.Image")));
            this.Add_Adherent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_Adherent.Location = new System.Drawing.Point(403, 205);
            this.Add_Adherent.Name = "Add_Adherent";
            this.Add_Adherent.Size = new System.Drawing.Size(152, 45);
            this.Add_Adherent.TabIndex = 23;
            this.Add_Adherent.Text = "&Ajouter l\'adhérent";
            this.Add_Adherent.UseVisualStyleBackColor = false;
            this.Add_Adherent.Click += new System.EventHandler(this.Add_Adherent_Click_1);
            // 
            // CloseWindow
            // 
            this.CloseWindow.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseWindow.Image = ((System.Drawing.Image)(resources.GetObject("CloseWindow.Image")));
            this.CloseWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseWindow.Location = new System.Drawing.Point(403, 292);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(152, 45);
            this.CloseWindow.TabIndex = 24;
            this.CloseWindow.Text = "&Fermer";
            this.CloseWindow.UseVisualStyleBackColor = false;
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            // 
            // AddAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 516);
            this.Controls.Add(this.CloseWindow);
            this.Controls.Add(this.Add_Adherent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_adress);
            this.Name = "AddAdherent";
            this.Text = "AddAdherent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddAdherent_Load);
            this.gb_Sexe.ResumeLayout(false);
            this.gb_Sexe.PerformLayout();
            this.gb_adress.ResumeLayout(false);
            this.gb_adress.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.GroupBox gb_Sexe;
        private System.Windows.Forms.GroupBox gb_adress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ville;
        private System.Windows.Forms.TextBox tb_cp;
        private System.Windows.Forms.TextBox tb_rue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mc_naissance;
        private System.Windows.Forms.Button Add_Adherent;
        private System.Windows.Forms.Button CloseWindow;
    }
}