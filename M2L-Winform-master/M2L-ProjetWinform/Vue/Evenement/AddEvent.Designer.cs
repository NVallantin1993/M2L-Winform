namespace M2L_ProjetWinform
{
    partial class AddEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEvent));
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.mc_dateDebut = new System.Windows.Forms.MonthCalendar();
            this.mc_dateFin = new System.Windows.Forms.MonthCalendar();
            this.bdwinformDataSet1 = new M2L_ProjetWinform.bdwinformDataSet();
            this.cb_club = new System.Windows.Forms.ComboBox();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CloseWindow = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdwinformDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(207, 144);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(100, 20);
            this.tb_nom.TabIndex = 0;
            // 
            // mc_dateDebut
            // 
            this.mc_dateDebut.Location = new System.Drawing.Point(207, 203);
            this.mc_dateDebut.Name = "mc_dateDebut";
            this.mc_dateDebut.TabIndex = 1;
            // 
            // mc_dateFin
            // 
            this.mc_dateFin.Location = new System.Drawing.Point(795, 203);
            this.mc_dateFin.Name = "mc_dateFin";
            this.mc_dateFin.TabIndex = 2;
            // 
            // bdwinformDataSet1
            // 
            this.bdwinformDataSet1.DataSetName = "bdwinformDataSet";
            this.bdwinformDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_club
            // 
            this.cb_club.FormattingEnabled = true;
            this.cb_club.Location = new System.Drawing.Point(487, 144);
            this.cb_club.Name = "cb_club";
            this.cb_club.Size = new System.Drawing.Size(121, 21);
            this.cb_club.TabIndex = 3;
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(854, 145);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(100, 20);
            this.tb_type.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom de l\'event :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Club organisateur :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(727, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type d\'evenement :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(718, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date de fin :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date de debut";
            // 
            // CloseWindow
            // 
            this.CloseWindow.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseWindow.Image = ((System.Drawing.Image)(resources.GetObject("CloseWindow.Image")));
            this.CloseWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseWindow.Location = new System.Drawing.Point(665, 387);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(152, 45);
            this.CloseWindow.TabIndex = 27;
            this.CloseWindow.Text = "&Fermer";
            this.CloseWindow.UseVisualStyleBackColor = false;
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.Image = ((System.Drawing.Image)(resources.GetObject("bt_add.Image")));
            this.bt_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_add.Location = new System.Drawing.Point(344, 387);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(152, 45);
            this.bt_add.TabIndex = 26;
            this.bt_add.Text = "&Créer l\'evenement";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 475);
            this.Controls.Add(this.CloseWindow);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_type);
            this.Controls.Add(this.cb_club);
            this.Controls.Add(this.mc_dateFin);
            this.Controls.Add(this.mc_dateDebut);
            this.Controls.Add(this.tb_nom);
            this.Name = "AddEvent";
            this.Text = "AddEvent";
            this.Load += new System.EventHandler(this.AddEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdwinformDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.MonthCalendar mc_dateDebut;
        private System.Windows.Forms.MonthCalendar mc_dateFin;
        private bdwinformDataSet bdwinformDataSet1;
        private System.Windows.Forms.ComboBox cb_club;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CloseWindow;
        private System.Windows.Forms.Button bt_add;
    }
}