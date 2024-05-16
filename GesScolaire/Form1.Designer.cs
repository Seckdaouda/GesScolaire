namespace GesScolaire
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveclasse = new System.Windows.Forms.Button();
            this.dataGridViewClasse = new System.Windows.Forms.DataGridView();
            this.comboSpecialite = new System.Windows.Forms.ComboBox();
            this.comboNiveau = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewEtudiant = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimeAnneescolaire = new System.Windows.Forms.DateTimePicker();
            this.textcredit = new System.Windows.Forms.TextBox();
            this.textnom = new System.Windows.Forms.TextBox();
            this.textprenom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelmontant = new System.Windows.Forms.Label();
            this.textMontant = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboClasse = new System.Windows.Forms.ComboBox();
            this.textRechercher = new System.Windows.Forms.TextBox();
            this.recherche = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.textIdEtudiant = new System.Windows.Forms.TextBox();
            this.effacher = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.rechercheClasse = new System.Windows.Forms.Button();
            this.textclasse = new System.Windows.Forms.TextBox();
            this.modifierclasse = new System.Windows.Forms.Button();
            this.supprimerclasse = new System.Windows.Forms.Button();
            this.effacherclasse = new System.Windows.Forms.Button();
            this.textidclasse = new System.Windows.Forms.TextBox();
            this.supprimer = new System.Windows.Forms.Button();
            this.retourlisteclasse = new System.Windows.Forms.Button();
            this.retourlisteetudiant = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClasse)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.retourlisteclasse);
            this.panel1.Controls.Add(this.textidclasse);
            this.panel1.Controls.Add(this.effacherclasse);
            this.panel1.Controls.Add(this.supprimerclasse);
            this.panel1.Controls.Add(this.modifierclasse);
            this.panel1.Controls.Add(this.textclasse);
            this.panel1.Controls.Add(this.rechercheClasse);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.saveclasse);
            this.panel1.Controls.Add(this.dataGridViewClasse);
            this.panel1.Controls.Add(this.comboSpecialite);
            this.panel1.Controls.Add(this.comboNiveau);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 537);
            this.panel1.TabIndex = 0;
            // 
            // saveclasse
            // 
            this.saveclasse.BackColor = System.Drawing.Color.Blue;
            this.saveclasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveclasse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveclasse.Location = new System.Drawing.Point(48, 203);
            this.saveclasse.Name = "saveclasse";
            this.saveclasse.Size = new System.Drawing.Size(153, 38);
            this.saveclasse.TabIndex = 6;
            this.saveclasse.Text = "Enregistrer";
            this.saveclasse.UseVisualStyleBackColor = false;
            this.saveclasse.Click += new System.EventHandler(this.saveclasse_Click);
            // 
            // dataGridViewClasse
            // 
            this.dataGridViewClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClasse.Location = new System.Drawing.Point(24, 291);
            this.dataGridViewClasse.Name = "dataGridViewClasse";
            this.dataGridViewClasse.RowHeadersWidth = 62;
            this.dataGridViewClasse.RowTemplate.Height = 28;
            this.dataGridViewClasse.Size = new System.Drawing.Size(481, 232);
            this.dataGridViewClasse.TabIndex = 5;
            this.dataGridViewClasse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClasse_CellClick);
            // 
            // comboSpecialite
            // 
            this.comboSpecialite.FormattingEnabled = true;
            this.comboSpecialite.Items.AddRange(new object[] {
            "IAGE",
            "FC",
            "GL",
            "BAFA",
            "RI"});
            this.comboSpecialite.Location = new System.Drawing.Point(223, 111);
            this.comboSpecialite.Name = "comboSpecialite";
            this.comboSpecialite.Size = new System.Drawing.Size(163, 28);
            this.comboSpecialite.TabIndex = 4;
            // 
            // comboNiveau
            // 
            this.comboNiveau.FormattingEnabled = true;
            this.comboNiveau.Items.AddRange(new object[] {
            "L1",
            "L2",
            "L3",
            "M1",
            "M2"});
            this.comboNiveau.Location = new System.Drawing.Point(223, 60);
            this.comboNiveau.Name = "comboNiveau";
            this.comboNiveau.Size = new System.Drawing.Size(163, 28);
            this.comboNiveau.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Spécialité";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Niveau";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.retourlisteetudiant);
            this.panel2.Controls.Add(this.supprimer);
            this.panel2.Controls.Add(this.effacher);
            this.panel2.Controls.Add(this.textIdEtudiant);
            this.panel2.Controls.Add(this.modifier);
            this.panel2.Controls.Add(this.recherche);
            this.panel2.Controls.Add(this.textRechercher);
            this.panel2.Controls.Add(this.comboClasse);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textMontant);
            this.panel2.Controls.Add(this.labelmontant);
            this.panel2.Controls.Add(this.dataGridViewEtudiant);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dateTimeAnneescolaire);
            this.panel2.Controls.Add(this.textcredit);
            this.panel2.Controls.Add(this.textnom);
            this.panel2.Controls.Add(this.textprenom);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(533, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 537);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewEtudiant
            // 
            this.dataGridViewEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEtudiant.Location = new System.Drawing.Point(15, 291);
            this.dataGridViewEtudiant.Name = "dataGridViewEtudiant";
            this.dataGridViewEtudiant.RowHeadersWidth = 62;
            this.dataGridViewEtudiant.RowTemplate.Height = 28;
            this.dataGridViewEtudiant.Size = new System.Drawing.Size(702, 232);
            this.dataGridViewEtudiant.TabIndex = 11;
            this.dataGridViewEtudiant.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEtudiant_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(15, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimeAnneescolaire
            // 
            this.dateTimeAnneescolaire.Location = new System.Drawing.Point(517, 51);
            this.dateTimeAnneescolaire.Name = "dateTimeAnneescolaire";
            this.dateTimeAnneescolaire.Size = new System.Drawing.Size(200, 30);
            this.dateTimeAnneescolaire.TabIndex = 9;
            // 
            // textcredit
            // 
            this.textcredit.Location = new System.Drawing.Point(127, 129);
            this.textcredit.Name = "textcredit";
            this.textcredit.Size = new System.Drawing.Size(183, 30);
            this.textcredit.TabIndex = 8;
            // 
            // textnom
            // 
            this.textnom.Location = new System.Drawing.Point(127, 93);
            this.textnom.Name = "textnom";
            this.textnom.Size = new System.Drawing.Size(183, 30);
            this.textnom.TabIndex = 7;
            // 
            // textprenom
            // 
            this.textprenom.Location = new System.Drawing.Point(127, 54);
            this.textprenom.Name = "textprenom";
            this.textprenom.Size = new System.Drawing.Size(183, 30);
            this.textprenom.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(333, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 27);
            this.label8.TabIndex = 5;
            this.label8.Text = "Année scolaire";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 27);
            this.label7.TabIndex = 4;
            this.label7.Text = "Crédit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 27);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nom";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 27);
            this.label5.TabIndex = 2;
            this.label5.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(239, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Formulaire Etudiant";
            // 
            // labelmontant
            // 
            this.labelmontant.AutoSize = true;
            this.labelmontant.BackColor = System.Drawing.Color.White;
            this.labelmontant.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelmontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmontant.Location = new System.Drawing.Point(333, 96);
            this.labelmontant.Name = "labelmontant";
            this.labelmontant.Size = new System.Drawing.Size(155, 27);
            this.labelmontant.TabIndex = 12;
            this.labelmontant.Text = "Montant Verse";
            // 
            // textMontant
            // 
            this.textMontant.Location = new System.Drawing.Point(517, 90);
            this.textMontant.Name = "textMontant";
            this.textMontant.Size = new System.Drawing.Size(200, 30);
            this.textMontant.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(333, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 27);
            this.label9.TabIndex = 14;
            this.label9.Text = "Classe";
            // 
            // comboClasse
            // 
            this.comboClasse.FormattingEnabled = true;
            this.comboClasse.Location = new System.Drawing.Point(517, 129);
            this.comboClasse.Name = "comboClasse";
            this.comboClasse.Size = new System.Drawing.Size(200, 33);
            this.comboClasse.TabIndex = 15;
            this.comboClasse.SelectedIndexChanged += new System.EventHandler(this.comboClasse_SelectedIndexChanged);
            // 
            // textRechercher
            // 
            this.textRechercher.Location = new System.Drawing.Point(174, 191);
            this.textRechercher.Name = "textRechercher";
            this.textRechercher.Size = new System.Drawing.Size(153, 30);
            this.textRechercher.TabIndex = 16;
            // 
            // recherche
            // 
            this.recherche.BackColor = System.Drawing.Color.SpringGreen;
            this.recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recherche.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recherche.Location = new System.Drawing.Point(15, 187);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(153, 38);
            this.recherche.TabIndex = 17;
            this.recherche.Text = "Recherche";
            this.recherche.UseVisualStyleBackColor = false;
            this.recherche.Click += new System.EventHandler(this.recherche_Click);
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modifier.Location = new System.Drawing.Point(174, 247);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(153, 38);
            this.modifier.TabIndex = 18;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = false;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // textIdEtudiant
            // 
            this.textIdEtudiant.Location = new System.Drawing.Point(15, 11);
            this.textIdEtudiant.Name = "textIdEtudiant";
            this.textIdEtudiant.ReadOnly = true;
            this.textIdEtudiant.Size = new System.Drawing.Size(88, 30);
            this.textIdEtudiant.TabIndex = 19;
            // 
            // effacher
            // 
            this.effacher.BackColor = System.Drawing.Color.DodgerBlue;
            this.effacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.effacher.Location = new System.Drawing.Point(517, 247);
            this.effacher.Name = "effacher";
            this.effacher.Size = new System.Drawing.Size(153, 38);
            this.effacher.TabIndex = 21;
            this.effacher.Text = "Effacher";
            this.effacher.UseVisualStyleBackColor = false;
            this.effacher.Click += new System.EventHandler(this.effacher_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Blue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(140, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Formulaire Classe";
            // 
            // rechercheClasse
            // 
            this.rechercheClasse.BackColor = System.Drawing.Color.SpringGreen;
            this.rechercheClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercheClasse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rechercheClasse.Location = new System.Drawing.Point(48, 150);
            this.rechercheClasse.Name = "rechercheClasse";
            this.rechercheClasse.Size = new System.Drawing.Size(153, 38);
            this.rechercheClasse.TabIndex = 18;
            this.rechercheClasse.Text = "Recherche";
            this.rechercheClasse.UseVisualStyleBackColor = false;
            this.rechercheClasse.Click += new System.EventHandler(this.rechercheClasse_Click);
            // 
            // textclasse
            // 
            this.textclasse.Location = new System.Drawing.Point(223, 150);
            this.textclasse.Name = "textclasse";
            this.textclasse.Size = new System.Drawing.Size(153, 26);
            this.textclasse.TabIndex = 19;
            // 
            // modifierclasse
            // 
            this.modifierclasse.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.modifierclasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierclasse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modifierclasse.Location = new System.Drawing.Point(48, 247);
            this.modifierclasse.Name = "modifierclasse";
            this.modifierclasse.Size = new System.Drawing.Size(153, 38);
            this.modifierclasse.TabIndex = 20;
            this.modifierclasse.Text = "Modifier";
            this.modifierclasse.UseVisualStyleBackColor = false;
            this.modifierclasse.Click += new System.EventHandler(this.modifierclasse_Click);
            // 
            // supprimerclasse
            // 
            this.supprimerclasse.BackColor = System.Drawing.Color.Red;
            this.supprimerclasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimerclasse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.supprimerclasse.Location = new System.Drawing.Point(292, 247);
            this.supprimerclasse.Name = "supprimerclasse";
            this.supprimerclasse.Size = new System.Drawing.Size(153, 38);
            this.supprimerclasse.TabIndex = 21;
            this.supprimerclasse.Text = "Supprimer";
            this.supprimerclasse.UseVisualStyleBackColor = false;
            this.supprimerclasse.Click += new System.EventHandler(this.supprimerclasse_Click);
            // 
            // effacherclasse
            // 
            this.effacherclasse.BackColor = System.Drawing.Color.DodgerBlue;
            this.effacherclasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effacherclasse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.effacherclasse.Location = new System.Drawing.Point(292, 203);
            this.effacherclasse.Name = "effacherclasse";
            this.effacherclasse.Size = new System.Drawing.Size(153, 38);
            this.effacherclasse.TabIndex = 22;
            this.effacherclasse.Text = "Effacher";
            this.effacherclasse.UseVisualStyleBackColor = false;
            this.effacherclasse.Click += new System.EventHandler(this.effacherclasse_Click);
            // 
            // textidclasse
            // 
            this.textidclasse.Location = new System.Drawing.Point(417, 15);
            this.textidclasse.Name = "textidclasse";
            this.textidclasse.ReadOnly = true;
            this.textidclasse.Size = new System.Drawing.Size(88, 26);
            this.textidclasse.TabIndex = 23;
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.Color.Red;
            this.supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.supprimer.Location = new System.Drawing.Point(358, 247);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(153, 38);
            this.supprimer.TabIndex = 22;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = false;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // retourlisteclasse
            // 
            this.retourlisteclasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.retourlisteclasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retourlisteclasse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.retourlisteclasse.Location = new System.Drawing.Point(402, 150);
            this.retourlisteclasse.Name = "retourlisteclasse";
            this.retourlisteclasse.Size = new System.Drawing.Size(89, 38);
            this.retourlisteclasse.TabIndex = 24;
            this.retourlisteclasse.Text = "Retour";
            this.retourlisteclasse.UseVisualStyleBackColor = false;
            this.retourlisteclasse.Click += new System.EventHandler(this.retourlisteclasse_Click);
            // 
            // retourlisteetudiant
            // 
            this.retourlisteetudiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.retourlisteetudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retourlisteetudiant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.retourlisteetudiant.Location = new System.Drawing.Point(349, 191);
            this.retourlisteetudiant.Name = "retourlisteetudiant";
            this.retourlisteetudiant.Size = new System.Drawing.Size(102, 38);
            this.retourlisteetudiant.TabIndex = 25;
            this.retourlisteetudiant.Text = "Retour";
            this.retourlisteetudiant.UseVisualStyleBackColor = false;
            this.retourlisteetudiant.Click += new System.EventHandler(this.retourlisteetudiant_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClasse)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtudiant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewClasse;
        private System.Windows.Forms.ComboBox comboSpecialite;
        private System.Windows.Forms.ComboBox comboNiveau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textprenom;
        private System.Windows.Forms.Button saveclasse;
        private System.Windows.Forms.DateTimePicker dateTimeAnneescolaire;
        private System.Windows.Forms.TextBox textcredit;
        private System.Windows.Forms.TextBox textnom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewEtudiant;
        private System.Windows.Forms.TextBox textMontant;
        private System.Windows.Forms.Label labelmontant;
        private System.Windows.Forms.ComboBox comboClasse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button recherche;
        private System.Windows.Forms.TextBox textRechercher;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.TextBox textIdEtudiant;
        private System.Windows.Forms.Button effacher;
        private System.Windows.Forms.TextBox textclasse;
        private System.Windows.Forms.Button rechercheClasse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textidclasse;
        private System.Windows.Forms.Button effacherclasse;
        private System.Windows.Forms.Button supprimerclasse;
        private System.Windows.Forms.Button modifierclasse;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button retourlisteclasse;
        private System.Windows.Forms.Button retourlisteetudiant;
    }
}

