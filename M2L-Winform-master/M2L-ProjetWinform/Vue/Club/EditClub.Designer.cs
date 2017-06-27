namespace M2L_ProjetWinform
{
    partial class EditClub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditClub));
            this.Edit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbSite = new System.Windows.Forms.TextBox();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.tbSpecilite = new System.Windows.Forms.TextBox();
            this.gb_contact = new System.Windows.Forms.GroupBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CloseWindow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_contact.SuspendLayout();
            this.SuspendLayout();
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit.Location = new System.Drawing.Point(179, 453);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(152, 45);
            this.Edit.TabIndex = 27;
            this.Edit.Text = "&Valider";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbNom);
            this.groupBox1.Controls.Add(this.tbSite);
            this.groupBox1.Controls.Add(this.tbTelephone);
            this.groupBox1.Controls.Add(this.tbSpecilite);
            this.groupBox1.Location = new System.Drawing.Point(44, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 288);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Renseignement Généraux";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Telephone :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Spécialité/Acitvité :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Site internet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nom";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(224, 45);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(289, 20);
            this.tbNom.TabIndex = 4;
            // 
            // tbSite
            // 
            this.tbSite.Location = new System.Drawing.Point(224, 88);
            this.tbSite.Name = "tbSite";
            this.tbSite.Size = new System.Drawing.Size(289, 20);
            this.tbSite.TabIndex = 5;
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(224, 218);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(289, 20);
            this.tbTelephone.TabIndex = 7;
            // 
            // tbSpecilite
            // 
            this.tbSpecilite.Location = new System.Drawing.Point(224, 156);
            this.tbSpecilite.Name = "tbSpecilite";
            this.tbSpecilite.Size = new System.Drawing.Size(289, 20);
            this.tbSpecilite.TabIndex = 6;
            // 
            // gb_contact
            // 
            this.gb_contact.Controls.Add(this.tbMail);
            this.gb_contact.Controls.Add(this.label4);
            this.gb_contact.Location = new System.Drawing.Point(682, 102);
            this.gb_contact.Name = "gb_contact";
            this.gb_contact.Size = new System.Drawing.Size(471, 288);
            this.gb_contact.TabIndex = 25;
            this.gb_contact.TabStop = false;
            this.gb_contact.Text = "Contact";
            this.gb_contact.Enter += new System.EventHandler(this.gb_contact_Enter);
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(161, 135);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(264, 20);
            this.tbMail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-Mail :";
            // 
            // CloseWindow
            // 
            this.CloseWindow.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseWindow.Image = ((System.Drawing.Image)(resources.GetObject("CloseWindow.Image")));
            this.CloseWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseWindow.Location = new System.Drawing.Point(748, 463);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(152, 45);
            this.CloseWindow.TabIndex = 29;
            this.CloseWindow.Text = "&Fermer";
            this.CloseWindow.UseVisualStyleBackColor = false;
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            // 
            // EditClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 591);
            this.Controls.Add(this.CloseWindow);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_contact);
            this.Name = "EditClub";
            this.Text = "EditClub";
            this.Load += new System.EventHandler(this.EditClub_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_contact.ResumeLayout(false);
            this.gb_contact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbSite;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.TextBox tbSpecilite;
        private System.Windows.Forms.GroupBox gb_contact;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CloseWindow;
    }
}