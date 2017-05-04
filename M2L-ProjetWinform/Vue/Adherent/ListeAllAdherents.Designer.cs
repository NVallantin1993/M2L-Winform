namespace M2L_ProjetWinform
{
    partial class ListeAllAdherents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeAllAdherents));
            this.lvListAdhe = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFermer = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvListAdhe
            // 
            this.lvListAdhe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvListAdhe.Location = new System.Drawing.Point(12, 12);
            this.lvListAdhe.Name = "lvListAdhe";
            this.lvListAdhe.Size = new System.Drawing.Size(1121, 432);
            this.lvListAdhe.TabIndex = 0;
            this.lvListAdhe.UseCompatibleStateImageBehavior = false;
            this.lvListAdhe.View = System.Windows.Forms.View.Details;
            this.lvListAdhe.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvAdher_ColumnClick);
            this.lvListAdhe.SelectedIndexChanged += new System.EventHandler(this.lvListAdhe_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prenom";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sexe";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "date de naissance";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Rue adresse";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Code postal";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ville";
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Image = ((System.Drawing.Image)(resources.GetObject("btnFermer.Image")));
            this.btnFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFermer.Location = new System.Drawing.Point(480, 450);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(152, 45);
            this.btnFermer.TabIndex = 29;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit.Image = ((System.Drawing.Image)(resources.GetObject("bt_edit.Image")));
            this.bt_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_edit.Location = new System.Drawing.Point(137, 450);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(152, 45);
            this.bt_edit.TabIndex = 35;
            this.bt_edit.Text = "&Editer";
            this.bt_edit.UseVisualStyleBackColor = false;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(791, 450);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(152, 45);
            this.btn_Delete.TabIndex = 36;
            this.btn_Delete.Text = "&Supprimer";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // ListeAllAdherents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 547);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lvListAdhe);
            this.Name = "ListeAllAdherents";
            this.Text = "Liste de tout les adhérents";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListeAllAdherents_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvListAdhe;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button btn_Delete;
    }
}