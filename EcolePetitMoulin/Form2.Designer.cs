namespace EcolePetitMoulin
{
    partial class Form2
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
            this.txBoxRecherche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNoteSommaire = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbValeurFinal = new System.Windows.Forms.Label();
            this.lbValeurTp2 = new System.Windows.Forms.Label();
            this.lbValeurIntra = new System.Windows.Forms.Label();
            this.lbValeurTp1 = new System.Windows.Forms.Label();
            this.lbMoyenneCour = new System.Windows.Forms.Label();
            this.lbMoyenneFinal = new System.Windows.Forms.Label();
            this.lbMoyenneTp2 = new System.Windows.Forms.Label();
            this.lbMoyenneIntra = new System.Windows.Forms.Label();
            this.lbMoyenneTp1 = new System.Windows.Forms.Label();
            this.lbNbrEleve = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.NoID = new System.Windows.Forms.ColumnHeader();
            this.Prenom = new System.Windows.Forms.ColumnHeader();
            this.Nom = new System.Windows.Forms.ColumnHeader();
            this.CodePermanent = new System.Windows.Forms.ColumnHeader();
            this.telephone = new System.Windows.Forms.ColumnHeader();
            this.Sexe = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.numeroCivique = new System.Windows.Forms.ColumnHeader();
            this.Rue = new System.Windows.Forms.ColumnHeader();
            this.Ville = new System.Windows.Forms.ColumnHeader();
            this.codePostal = new System.Windows.Forms.ColumnHeader();
            this.Tp1 = new System.Windows.Forms.ColumnHeader();
            this.Intra = new System.Windows.Forms.ColumnHeader();
            this.Tp2 = new System.Windows.Forms.ColumnHeader();
            this.Final = new System.Windows.Forms.ColumnHeader();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTite = new System.Windows.Forms.Label();
            this.lbEcoleDuPetitMoulin = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txBoxRecherche
            // 
            this.txBoxRecherche.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txBoxRecherche.Location = new System.Drawing.Point(287, 217);
            this.txBoxRecherche.Name = "txBoxRecherche";
            this.txBoxRecherche.Size = new System.Drawing.Size(649, 34);
            this.txBoxRecherche.TabIndex = 1;
            this.txBoxRecherche.TextChanged += new System.EventHandler(this.txBoxRecherche_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(160, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rechercher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(160, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre d\'élève(s)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbNoteSommaire);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbValeurFinal);
            this.groupBox1.Controls.Add(this.lbValeurTp2);
            this.groupBox1.Controls.Add(this.lbValeurIntra);
            this.groupBox1.Controls.Add(this.lbValeurTp1);
            this.groupBox1.Controls.Add(this.lbMoyenneCour);
            this.groupBox1.Controls.Add(this.lbMoyenneFinal);
            this.groupBox1.Controls.Add(this.lbMoyenneTp2);
            this.groupBox1.Controls.Add(this.lbMoyenneIntra);
            this.groupBox1.Controls.Add(this.lbMoyenneTp1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(359, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 125);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moyenne";
            // 
            // lbNoteSommaire
            // 
            this.lbNoteSommaire.AutoSize = true;
            this.lbNoteSommaire.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNoteSommaire.ForeColor = System.Drawing.Color.Coral;
            this.lbNoteSommaire.Location = new System.Drawing.Point(455, 60);
            this.lbNoteSommaire.Name = "lbNoteSommaire";
            this.lbNoteSommaire.Size = new System.Drawing.Size(103, 37);
            this.lbNoteSommaire.TabIndex = 31;
            this.lbNoteSommaire.Text = "100,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(455, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 37);
            this.label3.TabIndex = 30;
            // 
            // lbValeurFinal
            // 
            this.lbValeurFinal.AutoSize = true;
            this.lbValeurFinal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbValeurFinal.ForeColor = System.Drawing.Color.Coral;
            this.lbValeurFinal.Location = new System.Drawing.Point(317, 62);
            this.lbValeurFinal.Name = "lbValeurFinal";
            this.lbValeurFinal.Size = new System.Drawing.Size(98, 37);
            this.lbValeurFinal.TabIndex = 29;
            this.lbValeurFinal.Text = "100,00";
            // 
            // lbValeurTp2
            // 
            this.lbValeurTp2.AutoSize = true;
            this.lbValeurTp2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbValeurTp2.ForeColor = System.Drawing.Color.Coral;
            this.lbValeurTp2.Location = new System.Drawing.Point(218, 63);
            this.lbValeurTp2.Name = "lbValeurTp2";
            this.lbValeurTp2.Size = new System.Drawing.Size(98, 37);
            this.lbValeurTp2.TabIndex = 28;
            this.lbValeurTp2.Text = "100,00";
            // 
            // lbValeurIntra
            // 
            this.lbValeurIntra.AutoSize = true;
            this.lbValeurIntra.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbValeurIntra.ForeColor = System.Drawing.Color.Coral;
            this.lbValeurIntra.Location = new System.Drawing.Point(116, 65);
            this.lbValeurIntra.Name = "lbValeurIntra";
            this.lbValeurIntra.Size = new System.Drawing.Size(98, 37);
            this.lbValeurIntra.TabIndex = 27;
            this.lbValeurIntra.Text = "100,00";
            // 
            // lbValeurTp1
            // 
            this.lbValeurTp1.AutoSize = true;
            this.lbValeurTp1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbValeurTp1.ForeColor = System.Drawing.Color.Coral;
            this.lbValeurTp1.Location = new System.Drawing.Point(22, 64);
            this.lbValeurTp1.Name = "lbValeurTp1";
            this.lbValeurTp1.Size = new System.Drawing.Size(98, 37);
            this.lbValeurTp1.TabIndex = 26;
            this.lbValeurTp1.Text = "100,00";
            this.lbValeurTp1.Click += new System.EventHandler(this.lbValeurTp1_Click);
            // 
            // lbMoyenneCour
            // 
            this.lbMoyenneCour.AutoSize = true;
            this.lbMoyenneCour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMoyenneCour.Location = new System.Drawing.Point(473, 29);
            this.lbMoyenneCour.Name = "lbMoyenneCour";
            this.lbMoyenneCour.Size = new System.Drawing.Size(53, 21);
            this.lbMoyenneCour.TabIndex = 24;
            this.lbMoyenneCour.Text = "Cours";
            // 
            // lbMoyenneFinal
            // 
            this.lbMoyenneFinal.AutoSize = true;
            this.lbMoyenneFinal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMoyenneFinal.Location = new System.Drawing.Point(336, 43);
            this.lbMoyenneFinal.Name = "lbMoyenneFinal";
            this.lbMoyenneFinal.Size = new System.Drawing.Size(43, 21);
            this.lbMoyenneFinal.TabIndex = 23;
            this.lbMoyenneFinal.Text = "Final";
            // 
            // lbMoyenneTp2
            // 
            this.lbMoyenneTp2.AutoSize = true;
            this.lbMoyenneTp2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMoyenneTp2.Location = new System.Drawing.Point(239, 42);
            this.lbMoyenneTp2.Name = "lbMoyenneTp2";
            this.lbMoyenneTp2.Size = new System.Drawing.Size(36, 21);
            this.lbMoyenneTp2.TabIndex = 22;
            this.lbMoyenneTp2.Text = "TP2";
            // 
            // lbMoyenneIntra
            // 
            this.lbMoyenneIntra.AutoSize = true;
            this.lbMoyenneIntra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMoyenneIntra.Location = new System.Drawing.Point(137, 41);
            this.lbMoyenneIntra.Name = "lbMoyenneIntra";
            this.lbMoyenneIntra.Size = new System.Drawing.Size(42, 21);
            this.lbMoyenneIntra.TabIndex = 21;
            this.lbMoyenneIntra.Text = "Intra";
            // 
            // lbMoyenneTp1
            // 
            this.lbMoyenneTp1.AutoSize = true;
            this.lbMoyenneTp1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMoyenneTp1.Location = new System.Drawing.Point(42, 43);
            this.lbMoyenneTp1.Name = "lbMoyenneTp1";
            this.lbMoyenneTp1.Size = new System.Drawing.Size(36, 21);
            this.lbMoyenneTp1.TabIndex = 20;
            this.lbMoyenneTp1.Text = "TP1";
            // 
            // lbNbrEleve
            // 
            this.lbNbrEleve.AutoSize = true;
            this.lbNbrEleve.Font = new System.Drawing.Font("Segoe UI", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNbrEleve.ForeColor = System.Drawing.Color.Coral;
            this.lbNbrEleve.Location = new System.Drawing.Point(182, 264);
            this.lbNbrEleve.Name = "lbNbrEleve";
            this.lbNbrEleve.Size = new System.Drawing.Size(0, 116);
            this.lbNbrEleve.TabIndex = 25;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NoID,
            this.Prenom,
            this.Nom,
            this.CodePermanent,
            this.telephone,
            this.Sexe,
            this.Date,
            this.numeroCivique,
            this.Rue,
            this.Ville,
            this.codePostal,
            this.Tp1,
            this.Intra,
            this.Tp2,
            this.Final});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(10, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1111, 197);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // NoID
            // 
            this.NoID.Text = "NoID";
            // 
            // Prenom
            // 
            this.Prenom.Text = "Prenom";
            this.Prenom.Width = 80;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 80;
            // 
            // CodePermanent
            // 
            this.CodePermanent.Text = "Code Permanent";
            this.CodePermanent.Width = 110;
            // 
            // telephone
            // 
            this.telephone.Text = "telephone";
            this.telephone.Width = 100;
            // 
            // Sexe
            // 
            this.Sexe.Text = "Sexe";
            this.Sexe.Width = 40;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 100;
            // 
            // numeroCivique
            // 
            this.numeroCivique.Text = "No civique";
            this.numeroCivique.Width = 80;
            // 
            // Rue
            // 
            this.Rue.Text = "Rue";
            this.Rue.Width = 120;
            // 
            // Ville
            // 
            this.Ville.Text = "Ville";
            this.Ville.Width = 100;
            // 
            // codePostal
            // 
            this.codePostal.Text = "Code Postal";
            this.codePostal.Width = 80;
            // 
            // Tp1
            // 
            this.Tp1.Text = "TP1";
            this.Tp1.Width = 40;
            // 
            // Intra
            // 
            this.Intra.Text = "Intra";
            this.Intra.Width = 40;
            // 
            // Tp2
            // 
            this.Tp2.Text = "TP2";
            this.Tp2.Width = 40;
            // 
            // Final
            // 
            this.Final.Text = "Final";
            this.Final.Width = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EcolePetitMoulin.Properties.Resources.SeekPng_com_illustration_png_3562377;
            this.pictureBox1.Location = new System.Drawing.Point(954, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(6, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 45);
            this.label4.TabIndex = 31;
            this.label4.Text = "MOULIN";
            // 
            // lbTite
            // 
            this.lbTite.AutoSize = true;
            this.lbTite.BackColor = System.Drawing.Color.Transparent;
            this.lbTite.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTite.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTite.Location = new System.Drawing.Point(25, 271);
            this.lbTite.Name = "lbTite";
            this.lbTite.Size = new System.Drawing.Size(118, 37);
            this.lbTite.TabIndex = 30;
            this.lbTite.Text = "du Petit";
            // 
            // lbEcoleDuPetitMoulin
            // 
            this.lbEcoleDuPetitMoulin.AutoSize = true;
            this.lbEcoleDuPetitMoulin.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEcoleDuPetitMoulin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbEcoleDuPetitMoulin.Location = new System.Drawing.Point(50, 245);
            this.lbEcoleDuPetitMoulin.Name = "lbEcoleDuPetitMoulin";
            this.lbEcoleDuPetitMoulin.Size = new System.Drawing.Size(68, 31);
            this.lbEcoleDuPetitMoulin.TabIndex = 29;
            this.lbEcoleDuPetitMoulin.Text = "École";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1133, 394);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTite);
            this.Controls.Add(this.lbEcoleDuPetitMoulin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txBoxRecherche);
            this.Controls.Add(this.lbNbrEleve);
            this.Name = "Form2";
            this.Text = "Zone de Recherche";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txBoxRecherche;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label lbValeurTp1;
        private Label lbMoyenneCour;
        private Label lbMoyenneFinal;
        private Label lbMoyenneTp2;
        private Label lbMoyenneIntra;
        private Label lbMoyenneTp1;
        private Label lbNbrEleve;
        private Label label3;
        private Label lbValeurFinal;
        private Label lbValeurTp2;
        private Label lbValeurIntra;
        private ListView listView1;
        private ColumnHeader telephone;
        private ColumnHeader Prenom;
        private ColumnHeader Nom;
        private ColumnHeader Sexe;
        private ColumnHeader Date;
        private ColumnHeader numeroCivique;
        private ColumnHeader Rue;
        private ColumnHeader Ville;
        private ColumnHeader codePostal;
        private ColumnHeader CodePermanent;
        private ColumnHeader Tp1;
        private ColumnHeader Intra;
        private ColumnHeader Tp2;
        private ColumnHeader Final;
        private ColumnHeader NoID;
        private Label lbNoteSommaire;
        private PictureBox pictureBox1;
        private Label label4;
        private Label lbTite;
        private Label lbEcoleDuPetitMoulin;
    }
}