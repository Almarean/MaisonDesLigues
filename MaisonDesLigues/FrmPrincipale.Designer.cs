﻿namespace MaisonDesLigues
{
    partial class FrmPrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipale));
            this.TabInscription = new System.Windows.Forms.TabPage();
            this.GrpBenevole = new System.Windows.Forms.GroupBox();
            this.BtnEnregistreBenevole = new System.Windows.Forms.Button();
            this.PanelDispoBenevole = new System.Windows.Forms.Panel();
            this.TxtLicenceBenevole = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDateNaissance = new System.Windows.Forms.MaskedTextBox();
            this.CmdQuitter = new System.Windows.Forms.Button();
            this.GrpTypeParticipant = new System.Windows.Forms.GroupBox();
            this.RadLicencie = new System.Windows.Forms.RadioButton();
            this.RadBenevole = new System.Windows.Forms.RadioButton();
            this.RadIntervenant = new System.Windows.Forms.RadioButton();
            this.GrpIdentite = new System.Windows.Forms.GroupBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtCp = new System.Windows.Forms.MaskedTextBox();
            this.TxtVille = new System.Windows.Forms.TextBox();
            this.TxtAdr2 = new System.Windows.Forms.TextBox();
            this.TxtAdr1 = new System.Windows.Forms.TextBox();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PicAffiche = new System.Windows.Forms.PictureBox();
            this.GrpIntervenant = new System.Windows.Forms.GroupBox();
            this.BtnEnregistrerIntervenant = new System.Windows.Forms.Button();
            this.GrpNuiteIntervenant = new System.Windows.Forms.GroupBox();
            this.PanNuiteIntervenant = new System.Windows.Forms.Panel();
            this.RdbNuiteIntervenantNon = new System.Windows.Forms.RadioButton();
            this.RdbNuiteIntervenantOui = new System.Windows.Forms.RadioButton();
            this.PanFonctionIntervenant = new System.Windows.Forms.Panel();
            this.CmbAtelierIntervenant = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TabPrincipal = new System.Windows.Forms.TabControl();
            this.TabInscription.SuspendLayout();
            this.GrpBenevole.SuspendLayout();
            this.GrpTypeParticipant.SuspendLayout();
            this.GrpIdentite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAffiche)).BeginInit();
            this.GrpIntervenant.SuspendLayout();
            this.GrpNuiteIntervenant.SuspendLayout();
            this.TabPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabInscription
            // 
            this.TabInscription.Controls.Add(this.GrpBenevole);
            this.TabInscription.Controls.Add(this.CmdQuitter);
            this.TabInscription.Controls.Add(this.GrpTypeParticipant);
            this.TabInscription.Controls.Add(this.GrpIdentite);
            this.TabInscription.Controls.Add(this.PicAffiche);
            this.TabInscription.Controls.Add(this.GrpIntervenant);
            this.TabInscription.Location = new System.Drawing.Point(4, 25);
            this.TabInscription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabInscription.Name = "TabInscription";
            this.TabInscription.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabInscription.Size = new System.Drawing.Size(1277, 716);
            this.TabInscription.TabIndex = 0;
            this.TabInscription.Text = "Inscription";
            this.TabInscription.UseVisualStyleBackColor = true;
            // 
            // GrpBenevole
            // 
            this.GrpBenevole.Controls.Add(this.BtnEnregistreBenevole);
            this.GrpBenevole.Controls.Add(this.PanelDispoBenevole);
            this.GrpBenevole.Controls.Add(this.TxtLicenceBenevole);
            this.GrpBenevole.Controls.Add(this.label9);
            this.GrpBenevole.Controls.Add(this.label8);
            this.GrpBenevole.Controls.Add(this.TxtDateNaissance);
            this.GrpBenevole.Location = new System.Drawing.Point(809, 28);
            this.GrpBenevole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrpBenevole.Name = "GrpBenevole";
            this.GrpBenevole.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrpBenevole.Size = new System.Drawing.Size(752, 214);
            this.GrpBenevole.TabIndex = 23;
            this.GrpBenevole.TabStop = false;
            this.GrpBenevole.Text = "Disponibilités Bénévole";
            this.GrpBenevole.Visible = false;
            // 
            // BtnEnregistreBenevole
            // 
            this.BtnEnregistreBenevole.Enabled = false;
            this.BtnEnregistreBenevole.Location = new System.Drawing.Point(428, 176);
            this.BtnEnregistreBenevole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEnregistreBenevole.Name = "BtnEnregistreBenevole";
            this.BtnEnregistreBenevole.Size = new System.Drawing.Size(177, 31);
            this.BtnEnregistreBenevole.TabIndex = 1;
            this.BtnEnregistreBenevole.Text = "Enregistrer";
            this.BtnEnregistreBenevole.UseVisualStyleBackColor = true;
            this.BtnEnregistreBenevole.Click += new System.EventHandler(this.BtnEnregistreBenevole_Click);
            // 
            // PanelDispoBenevole
            // 
            this.PanelDispoBenevole.Location = new System.Drawing.Point(37, 103);
            this.PanelDispoBenevole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelDispoBenevole.Name = "PanelDispoBenevole";
            this.PanelDispoBenevole.Size = new System.Drawing.Size(335, 103);
            this.PanelDispoBenevole.TabIndex = 21;
            // 
            // TxtLicenceBenevole
            // 
            this.TxtLicenceBenevole.Location = new System.Drawing.Point(181, 71);
            this.TxtLicenceBenevole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtLicenceBenevole.Mask = "000000000000";
            this.TxtLicenceBenevole.Name = "TxtLicenceBenevole";
            this.TxtLicenceBenevole.Size = new System.Drawing.Size(195, 22);
            this.TxtLicenceBenevole.TabIndex = 19;
            this.TxtLicenceBenevole.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ChkDateBenevole_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Date de naissance : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Numéro de licence : ";
            // 
            // TxtDateNaissance
            // 
            this.TxtDateNaissance.Location = new System.Drawing.Point(181, 39);
            this.TxtDateNaissance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDateNaissance.Mask = "00/00/0000";
            this.TxtDateNaissance.Name = "TxtDateNaissance";
            this.TxtDateNaissance.Size = new System.Drawing.Size(195, 22);
            this.TxtDateNaissance.TabIndex = 2;
            this.TxtDateNaissance.Text = "15081985";
            this.TxtDateNaissance.ValidatingType = typeof(System.DateTime);
            this.TxtDateNaissance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ChkDateBenevole_CheckedChanged);
            // 
            // CmdQuitter
            // 
            this.CmdQuitter.Location = new System.Drawing.Point(657, 222);
            this.CmdQuitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdQuitter.Name = "CmdQuitter";
            this.CmdQuitter.Size = new System.Drawing.Size(192, 44);
            this.CmdQuitter.TabIndex = 22;
            this.CmdQuitter.Text = "Quitter";
            this.CmdQuitter.UseVisualStyleBackColor = true;
            this.CmdQuitter.Click += new System.EventHandler(this.CmdQuitter_Click);
            // 
            // GrpTypeParticipant
            // 
            this.GrpTypeParticipant.Controls.Add(this.RadLicencie);
            this.GrpTypeParticipant.Controls.Add(this.RadBenevole);
            this.GrpTypeParticipant.Controls.Add(this.RadIntervenant);
            this.GrpTypeParticipant.Location = new System.Drawing.Point(31, 7);
            this.GrpTypeParticipant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrpTypeParticipant.Name = "GrpTypeParticipant";
            this.GrpTypeParticipant.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrpTypeParticipant.Size = new System.Drawing.Size(604, 71);
            this.GrpTypeParticipant.TabIndex = 21;
            this.GrpTypeParticipant.TabStop = false;
            this.GrpTypeParticipant.Text = "Tupe Participant";
            // 
            // RadLicencie
            // 
            this.RadLicencie.AutoSize = true;
            this.RadLicencie.Location = new System.Drawing.Point(260, 23);
            this.RadLicencie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadLicencie.Name = "RadLicencie";
            this.RadLicencie.Size = new System.Drawing.Size(81, 21);
            this.RadLicencie.TabIndex = 20;
            this.RadLicencie.TabStop = true;
            this.RadLicencie.Text = "Licencié";
            this.RadLicencie.UseVisualStyleBackColor = true;
            this.RadLicencie.CheckedChanged += new System.EventHandler(this.RadTypeParticipant_Changed);
            // 
            // RadBenevole
            // 
            this.RadBenevole.AutoSize = true;
            this.RadBenevole.Location = new System.Drawing.Point(468, 23);
            this.RadBenevole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadBenevole.Name = "RadBenevole";
            this.RadBenevole.Size = new System.Drawing.Size(88, 21);
            this.RadBenevole.TabIndex = 19;
            this.RadBenevole.TabStop = true;
            this.RadBenevole.Text = "Bénévole";
            this.RadBenevole.UseVisualStyleBackColor = true;
            this.RadBenevole.CheckedChanged += new System.EventHandler(this.RadTypeParticipant_Changed);
            // 
            // RadIntervenant
            // 
            this.RadIntervenant.AutoSize = true;
            this.RadIntervenant.Location = new System.Drawing.Point(59, 23);
            this.RadIntervenant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadIntervenant.Name = "RadIntervenant";
            this.RadIntervenant.Size = new System.Drawing.Size(100, 21);
            this.RadIntervenant.TabIndex = 18;
            this.RadIntervenant.TabStop = true;
            this.RadIntervenant.Text = "Intervenant";
            this.RadIntervenant.UseVisualStyleBackColor = true;
            this.RadIntervenant.CheckedChanged += new System.EventHandler(this.RadTypeParticipant_Changed);
            // 
            // GrpIdentite
            // 
            this.GrpIdentite.Controls.Add(this.TxtMail);
            this.GrpIdentite.Controls.Add(this.label7);
            this.GrpIdentite.Controls.Add(this.label6);
            this.GrpIdentite.Controls.Add(this.txtTel);
            this.GrpIdentite.Controls.Add(this.TxtCp);
            this.GrpIdentite.Controls.Add(this.TxtVille);
            this.GrpIdentite.Controls.Add(this.TxtAdr2);
            this.GrpIdentite.Controls.Add(this.TxtAdr1);
            this.GrpIdentite.Controls.Add(this.TxtPrenom);
            this.GrpIdentite.Controls.Add(this.TxtNom);
            this.GrpIdentite.Controls.Add(this.label5);
            this.GrpIdentite.Controls.Add(this.label4);
            this.GrpIdentite.Controls.Add(this.label3);
            this.GrpIdentite.Controls.Add(this.label2);
            this.GrpIdentite.Controls.Add(this.label1);
            this.GrpIdentite.Location = new System.Drawing.Point(31, 86);
            this.GrpIdentite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrpIdentite.Name = "GrpIdentite";
            this.GrpIdentite.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrpIdentite.Size = new System.Drawing.Size(604, 231);
            this.GrpIdentite.TabIndex = 17;
            this.GrpIdentite.TabStop = false;
            this.GrpIdentite.Text = "Identité";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(309, 182);
            this.TxtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(251, 22);
            this.TxtMail.TabIndex = 16;
            this.TxtMail.Text = "patrick.dumoulin@toto.fr";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mail :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tél :";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(103, 182);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTel.Mask = "00 00 00 00 00 00";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(132, 22);
            this.txtTel.TabIndex = 13;
            // 
            // TxtCp
            // 
            this.TxtCp.Location = new System.Drawing.Point(116, 132);
            this.TxtCp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCp.Mask = "00000";
            this.TxtCp.Name = "TxtCp";
            this.TxtCp.Size = new System.Drawing.Size(119, 22);
            this.TxtCp.TabIndex = 12;
            this.TxtCp.Text = "75001";
            // 
            // TxtVille
            // 
            this.TxtVille.Location = new System.Drawing.Point(309, 128);
            this.TxtVille.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtVille.Name = "TxtVille";
            this.TxtVille.Size = new System.Drawing.Size(251, 22);
            this.TxtVille.TabIndex = 11;
            this.TxtVille.Text = "Paris";
            // 
            // TxtAdr2
            // 
            this.TxtAdr2.Location = new System.Drawing.Point(108, 94);
            this.TxtAdr2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtAdr2.Name = "TxtAdr2";
            this.TxtAdr2.Size = new System.Drawing.Size(452, 22);
            this.TxtAdr2.TabIndex = 9;
            // 
            // TxtAdr1
            // 
            this.TxtAdr1.Location = new System.Drawing.Point(108, 62);
            this.TxtAdr1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtAdr1.Name = "TxtAdr1";
            this.TxtAdr1.Size = new System.Drawing.Size(452, 22);
            this.TxtAdr1.TabIndex = 8;
            this.TxtAdr1.Text = "Avenue du PLSQL";
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Location = new System.Drawing.Point(372, 31);
            this.TxtPrenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(188, 22);
            this.TxtPrenom.TabIndex = 7;
            this.TxtPrenom.Text = "Patrick";
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(108, 31);
            this.TxtNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(188, 22);
            this.TxtNom.TabIndex = 6;
            this.TxtNom.Text = "Dumoulin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ville : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "CP : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom : ";
            // 
            // PicAffiche
            // 
            this.PicAffiche.Image = global::MaisonDesLigues.Properties.Resources.affiche;
            this.PicAffiche.Location = new System.Drawing.Point(657, 7);
            this.PicAffiche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PicAffiche.Name = "PicAffiche";
            this.PicAffiche.Size = new System.Drawing.Size(144, 202);
            this.PicAffiche.TabIndex = 5;
            this.PicAffiche.TabStop = false;
            // 
            // GrpIntervenant
            // 
            this.GrpIntervenant.Controls.Add(this.BtnEnregistrerIntervenant);
            this.GrpIntervenant.Controls.Add(this.GrpNuiteIntervenant);
            this.GrpIntervenant.Controls.Add(this.PanFonctionIntervenant);
            this.GrpIntervenant.Controls.Add(this.CmbAtelierIntervenant);
            this.GrpIntervenant.Controls.Add(this.label17);
            this.GrpIntervenant.Location = new System.Drawing.Point(31, 325);
            this.GrpIntervenant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrpIntervenant.Name = "GrpIntervenant";
            this.GrpIntervenant.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrpIntervenant.Size = new System.Drawing.Size(687, 352);
            this.GrpIntervenant.TabIndex = 25;
            this.GrpIntervenant.TabStop = false;
            this.GrpIntervenant.Text = "Complément Inscription Intervenant";
            this.GrpIntervenant.Visible = false;
            // 
            // BtnEnregistrerIntervenant
            // 
            this.BtnEnregistrerIntervenant.Enabled = false;
            this.BtnEnregistrerIntervenant.Location = new System.Drawing.Point(453, 309);
            this.BtnEnregistrerIntervenant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEnregistrerIntervenant.Name = "BtnEnregistrerIntervenant";
            this.BtnEnregistrerIntervenant.Size = new System.Drawing.Size(177, 31);
            this.BtnEnregistrerIntervenant.TabIndex = 30;
            this.BtnEnregistrerIntervenant.Text = "Enregistrer";
            this.BtnEnregistrerIntervenant.UseVisualStyleBackColor = true;
            this.BtnEnregistrerIntervenant.Click += new System.EventHandler(this.BtnEnregistrerIntervenant_Click);
            // 
            // GrpNuiteIntervenant
            // 
            this.GrpNuiteIntervenant.Controls.Add(this.PanNuiteIntervenant);
            this.GrpNuiteIntervenant.Controls.Add(this.RdbNuiteIntervenantNon);
            this.GrpNuiteIntervenant.Controls.Add(this.RdbNuiteIntervenantOui);
            this.GrpNuiteIntervenant.Location = new System.Drawing.Point(28, 128);
            this.GrpNuiteIntervenant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrpNuiteIntervenant.Name = "GrpNuiteIntervenant";
            this.GrpNuiteIntervenant.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrpNuiteIntervenant.Size = new System.Drawing.Size(663, 186);
            this.GrpNuiteIntervenant.TabIndex = 29;
            this.GrpNuiteIntervenant.TabStop = false;
            this.GrpNuiteIntervenant.Text = "Nuités";
            // 
            // PanNuiteIntervenant
            // 
            this.PanNuiteIntervenant.Location = new System.Drawing.Point(4, 53);
            this.PanNuiteIntervenant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanNuiteIntervenant.Name = "PanNuiteIntervenant";
            this.PanNuiteIntervenant.Size = new System.Drawing.Size(659, 126);
            this.PanNuiteIntervenant.TabIndex = 24;
            this.PanNuiteIntervenant.Visible = false;
            // 
            // RdbNuiteIntervenantNon
            // 
            this.RdbNuiteIntervenantNon.AutoSize = true;
            this.RdbNuiteIntervenantNon.Checked = true;
            this.RdbNuiteIntervenantNon.Location = new System.Drawing.Point(123, 18);
            this.RdbNuiteIntervenantNon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RdbNuiteIntervenantNon.Name = "RdbNuiteIntervenantNon";
            this.RdbNuiteIntervenantNon.Size = new System.Drawing.Size(55, 21);
            this.RdbNuiteIntervenantNon.TabIndex = 23;
            this.RdbNuiteIntervenantNon.TabStop = true;
            this.RdbNuiteIntervenantNon.Text = "Non";
            this.RdbNuiteIntervenantNon.UseVisualStyleBackColor = true;
            this.RdbNuiteIntervenantNon.CheckedChanged += new System.EventHandler(this.RdbNuiteIntervenant_CheckedChanged);
            // 
            // RdbNuiteIntervenantOui
            // 
            this.RdbNuiteIntervenantOui.AutoSize = true;
            this.RdbNuiteIntervenantOui.Location = new System.Drawing.Point(31, 20);
            this.RdbNuiteIntervenantOui.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RdbNuiteIntervenantOui.Name = "RdbNuiteIntervenantOui";
            this.RdbNuiteIntervenantOui.Size = new System.Drawing.Size(51, 21);
            this.RdbNuiteIntervenantOui.TabIndex = 22;
            this.RdbNuiteIntervenantOui.Text = "Oui";
            this.RdbNuiteIntervenantOui.UseVisualStyleBackColor = true;
            this.RdbNuiteIntervenantOui.CheckedChanged += new System.EventHandler(this.RdbNuiteIntervenant_CheckedChanged);
            // 
            // PanFonctionIntervenant
            // 
            this.PanFonctionIntervenant.Location = new System.Drawing.Point(423, 18);
            this.PanFonctionIntervenant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanFonctionIntervenant.Name = "PanFonctionIntervenant";
            this.PanFonctionIntervenant.Size = new System.Drawing.Size(224, 50);
            this.PanFonctionIntervenant.TabIndex = 28;
            // 
            // CmbAtelierIntervenant
            // 
            this.CmbAtelierIntervenant.FormattingEnabled = true;
            this.CmbAtelierIntervenant.Location = new System.Drawing.Point(108, 44);
            this.CmbAtelierIntervenant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbAtelierIntervenant.Name = "CmbAtelierIntervenant";
            this.CmbAtelierIntervenant.Size = new System.Drawing.Size(289, 24);
            this.CmbAtelierIntervenant.TabIndex = 26;
            this.CmbAtelierIntervenant.TextChanged += new System.EventHandler(this.CmbAtelierIntervenant_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 39);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 17);
            this.label17.TabIndex = 23;
            this.label17.Text = "Atelier : ";
            // 
            // TabPrincipal
            // 
            this.TabPrincipal.Controls.Add(this.TabInscription);
            this.TabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TabPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabPrincipal.Name = "TabPrincipal";
            this.TabPrincipal.SelectedIndex = 0;
            this.TabPrincipal.Size = new System.Drawing.Size(1285, 745);
            this.TabPrincipal.TabIndex = 0;
            // 
            // FrmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 745);
            this.Controls.Add(this.TabPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPrincipale";
            this.Load += new System.EventHandler(this.FrmPrincipale_Load);
            this.TabInscription.ResumeLayout(false);
            this.GrpBenevole.ResumeLayout(false);
            this.GrpBenevole.PerformLayout();
            this.GrpTypeParticipant.ResumeLayout(false);
            this.GrpTypeParticipant.PerformLayout();
            this.GrpIdentite.ResumeLayout(false);
            this.GrpIdentite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAffiche)).EndInit();
            this.GrpIntervenant.ResumeLayout(false);
            this.GrpIntervenant.PerformLayout();
            this.GrpNuiteIntervenant.ResumeLayout(false);
            this.GrpNuiteIntervenant.PerformLayout();
            this.TabPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage TabInscription;
        private System.Windows.Forms.GroupBox GrpBenevole;
        private System.Windows.Forms.Button BtnEnregistreBenevole;
        private System.Windows.Forms.Panel PanelDispoBenevole;
        private System.Windows.Forms.MaskedTextBox TxtLicenceBenevole;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox TxtDateNaissance;
        private System.Windows.Forms.Button CmdQuitter;
        private System.Windows.Forms.GroupBox GrpTypeParticipant;
        private System.Windows.Forms.RadioButton RadLicencie;
        private System.Windows.Forms.RadioButton RadBenevole;
        private System.Windows.Forms.RadioButton RadIntervenant;
        private System.Windows.Forms.GroupBox GrpIdentite;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.MaskedTextBox TxtCp;
        private System.Windows.Forms.TextBox TxtVille;
        private System.Windows.Forms.TextBox TxtAdr2;
        private System.Windows.Forms.TextBox TxtAdr1;
        private System.Windows.Forms.TextBox TxtPrenom;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicAffiche;
        private System.Windows.Forms.GroupBox GrpIntervenant;
        private System.Windows.Forms.Button BtnEnregistrerIntervenant;
        private System.Windows.Forms.GroupBox GrpNuiteIntervenant;
        private System.Windows.Forms.Panel PanNuiteIntervenant;
        private System.Windows.Forms.RadioButton RdbNuiteIntervenantNon;
        private System.Windows.Forms.RadioButton RdbNuiteIntervenantOui;
        private System.Windows.Forms.Panel PanFonctionIntervenant;
        private System.Windows.Forms.ComboBox CmbAtelierIntervenant;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabControl TabPrincipal;


    }
}