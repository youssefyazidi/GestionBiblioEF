namespace GestionBiblioEF
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
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonfirst = new System.Windows.Forms.Button();
            this.Rechercher = new System.Windows.Forms.GroupBox();
            this.textBoxCodeRechercher = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonNouveau = new System.Windows.Forms.Button();
            this.dateTimePickerInscription = new System.Windows.Forms.DateTimePicker();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rechercher.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(42, 292);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(282, 28);
            this.buttonEnregistrer.TabIndex = 37;
            this.buttonEnregistrer.Text = "Enregistrer vos opérations";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            this.buttonEnregistrer.Click += new System.EventHandler(this.buttonEnregistrer_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(243, 218);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(42, 23);
            this.buttonLast.TabIndex = 36;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(176, 218);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(42, 23);
            this.buttonNext.TabIndex = 35;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(106, 218);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(42, 23);
            this.buttonPrevious.TabIndex = 34;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonfirst
            // 
            this.buttonfirst.Location = new System.Drawing.Point(42, 218);
            this.buttonfirst.Name = "buttonfirst";
            this.buttonfirst.Size = new System.Drawing.Size(42, 23);
            this.buttonfirst.TabIndex = 33;
            this.buttonfirst.Text = "<<";
            this.buttonfirst.UseVisualStyleBackColor = true;
            this.buttonfirst.Click += new System.EventHandler(this.buttonfirst_Click);
            // 
            // Rechercher
            // 
            this.Rechercher.Controls.Add(this.textBoxCodeRechercher);
            this.Rechercher.Controls.Add(this.label5);
            this.Rechercher.Controls.Add(this.buttonRechercher);
            this.Rechercher.Location = new System.Drawing.Point(405, 173);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(325, 107);
            this.Rechercher.TabIndex = 32;
            this.Rechercher.TabStop = false;
            this.Rechercher.Text = "Recherche";
            // 
            // textBoxCodeRechercher
            // 
            this.textBoxCodeRechercher.Location = new System.Drawing.Point(175, 73);
            this.textBoxCodeRechercher.Name = "textBoxCodeRechercher";
            this.textBoxCodeRechercher.Size = new System.Drawing.Size(142, 20);
            this.textBoxCodeRechercher.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Code adherent :";
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(158, 29);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(159, 23);
            this.buttonRechercher.TabIndex = 12;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(421, 297);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(159, 23);
            this.buttonAnnuler.TabIndex = 31;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(421, 124);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(159, 23);
            this.buttonSupprimer.TabIndex = 30;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(421, 64);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(159, 23);
            this.buttonModifier.TabIndex = 29;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonNouveau
            // 
            this.buttonNouveau.Location = new System.Drawing.Point(421, 9);
            this.buttonNouveau.Name = "buttonNouveau";
            this.buttonNouveau.Size = new System.Drawing.Size(159, 23);
            this.buttonNouveau.TabIndex = 28;
            this.buttonNouveau.Text = "Nouveau";
            this.buttonNouveau.UseVisualStyleBackColor = true;
            this.buttonNouveau.Click += new System.EventHandler(this.buttonNouveau_Click);
            // 
            // dateTimePickerInscription
            // 
            this.dateTimePickerInscription.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInscription.Location = new System.Drawing.Point(190, 153);
            this.dateTimePickerInscription.Name = "dateTimePickerInscription";
            this.dateTimePickerInscription.Size = new System.Drawing.Size(162, 20);
            this.dateTimePickerInscription.TabIndex = 27;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(190, 105);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(162, 20);
            this.textBoxAdresse.TabIndex = 26;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(190, 58);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(162, 20);
            this.textBoxNom.TabIndex = 25;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(190, 14);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(162, 20);
            this.textBoxCode.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Date Inscription :  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Adresse  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Code adherent :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 365);
            this.Controls.Add(this.buttonEnregistrer);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonfirst);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonNouveau);
            this.Controls.Add(this.dateTimePickerInscription);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Gestion des adherents";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Rechercher.ResumeLayout(false);
            this.Rechercher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonfirst;
        private System.Windows.Forms.GroupBox Rechercher;
        private System.Windows.Forms.TextBox textBoxCodeRechercher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonNouveau;
        private System.Windows.Forms.DateTimePicker dateTimePickerInscription;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

