namespace MySQL_Test
{
    partial class FrmHauptForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHauptForm));
            this.btnSpalteHinzufügen = new System.Windows.Forms.Button();
            this.btnSpalteLoeschen = new System.Windows.Forms.Button();
            this.lblÜberschrieft = new System.Windows.Forms.Label();
            this.btnSpieler = new System.Windows.Forms.Button();
            this.btnAuszeichnung = new System.Windows.Forms.Button();
            this.btnNation = new System.Windows.Forms.Button();
            this.btnStatistik = new System.Windows.Forms.Button();
            this.btnTrainer = new System.Windows.Forms.Button();
            this.btnVerein = new System.Windows.Forms.Button();
            this.btnVertrag = new System.Windows.Forms.Button();
            this.btnWerbepartner = new System.Windows.Forms.Button();
            this.btnWettbewerb = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.lblTabellen = new System.Windows.Forms.Label();
            this.btnSpierInfo = new System.Windows.Forms.Button();
            this.lblProzedurVerwenden = new System.Windows.Forms.Label();
            this.btnSpNeueAuszeichnung = new System.Windows.Forms.Button();
            this.btnVNeueAuszeichnung = new System.Windows.Forms.Button();
            this.btnSpielerToreErhoehen = new System.Windows.Forms.Button();
            this.btnWerbePartnerHinzufügen = new System.Windows.Forms.Button();
            this.btnwettbewerb_verein = new System.Windows.Forms.Button();
            this.btnAnmelden = new System.Windows.Forms.Button();
            this.lblBenutzer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSpalteHinzufügen
            // 
            this.btnSpalteHinzufügen.Location = new System.Drawing.Point(32, 59);
            this.btnSpalteHinzufügen.Name = "btnSpalteHinzufügen";
            this.btnSpalteHinzufügen.Size = new System.Drawing.Size(86, 26);
            this.btnSpalteHinzufügen.TabIndex = 0;
            this.btnSpalteHinzufügen.Text = "Sp Hinzfügen";
            this.btnSpalteHinzufügen.UseVisualStyleBackColor = true;
            this.btnSpalteHinzufügen.Click += new System.EventHandler(this.btnSpalteHinzufügen_Click);
            // 
            // btnSpalteLoeschen
            // 
            this.btnSpalteLoeschen.Location = new System.Drawing.Point(32, 91);
            this.btnSpalteLoeschen.Name = "btnSpalteLoeschen";
            this.btnSpalteLoeschen.Size = new System.Drawing.Size(86, 26);
            this.btnSpalteLoeschen.TabIndex = 1;
            this.btnSpalteLoeschen.Text = "Sp Löschen";
            this.btnSpalteLoeschen.UseVisualStyleBackColor = true;
            this.btnSpalteLoeschen.Click += new System.EventHandler(this.btnSpalteLoeschen_Click);
            // 
            // lblÜberschrieft
            // 
            this.lblÜberschrieft.AutoSize = true;
            this.lblÜberschrieft.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblÜberschrieft.Location = new System.Drawing.Point(124, 33);
            this.lblÜberschrieft.Name = "lblÜberschrieft";
            this.lblÜberschrieft.Size = new System.Drawing.Size(176, 23);
            this.lblÜberschrieft.TabIndex = 3;
            this.lblÜberschrieft.Text = "Tablle Anzeigen von:";
            // 
            // btnSpieler
            // 
            this.btnSpieler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSpieler.Location = new System.Drawing.Point(23, 321);
            this.btnSpieler.Name = "btnSpieler";
            this.btnSpieler.Size = new System.Drawing.Size(50, 26);
            this.btnSpieler.TabIndex = 4;
            this.btnSpieler.Text = "Spieler";
            this.btnSpieler.UseVisualStyleBackColor = true;
            this.btnSpieler.Click += new System.EventHandler(this.btnSpieler_Click);
            // 
            // btnAuszeichnung
            // 
            this.btnAuszeichnung.Location = new System.Drawing.Point(79, 321);
            this.btnAuszeichnung.Name = "btnAuszeichnung";
            this.btnAuszeichnung.Size = new System.Drawing.Size(91, 26);
            this.btnAuszeichnung.TabIndex = 5;
            this.btnAuszeichnung.Text = "Auszeichnung";
            this.btnAuszeichnung.UseVisualStyleBackColor = true;
            this.btnAuszeichnung.Click += new System.EventHandler(this.btnAuszeichnung_Click);
            // 
            // btnNation
            // 
            this.btnNation.Location = new System.Drawing.Point(238, 321);
            this.btnNation.Name = "btnNation";
            this.btnNation.Size = new System.Drawing.Size(51, 26);
            this.btnNation.TabIndex = 6;
            this.btnNation.Text = "Nation";
            this.btnNation.UseVisualStyleBackColor = true;
            this.btnNation.Click += new System.EventHandler(this.btnNation_Click);
            // 
            // btnStatistik
            // 
            this.btnStatistik.Location = new System.Drawing.Point(176, 321);
            this.btnStatistik.Name = "btnStatistik";
            this.btnStatistik.Size = new System.Drawing.Size(56, 26);
            this.btnStatistik.TabIndex = 7;
            this.btnStatistik.Text = "Statistik";
            this.btnStatistik.UseVisualStyleBackColor = true;
            this.btnStatistik.Click += new System.EventHandler(this.btnStatistik_Click);
            // 
            // btnTrainer
            // 
            this.btnTrainer.Location = new System.Drawing.Point(350, 321);
            this.btnTrainer.Name = "btnTrainer";
            this.btnTrainer.Size = new System.Drawing.Size(59, 26);
            this.btnTrainer.TabIndex = 8;
            this.btnTrainer.Text = "Trainer";
            this.btnTrainer.UseVisualStyleBackColor = true;
            this.btnTrainer.Click += new System.EventHandler(this.btnTrainer_Click);
            // 
            // btnVerein
            // 
            this.btnVerein.Location = new System.Drawing.Point(295, 321);
            this.btnVerein.Name = "btnVerein";
            this.btnVerein.Size = new System.Drawing.Size(49, 26);
            this.btnVerein.TabIndex = 9;
            this.btnVerein.Text = "Verein";
            this.btnVerein.UseVisualStyleBackColor = true;
            this.btnVerein.Click += new System.EventHandler(this.btnVerein_Click);
            // 
            // btnVertrag
            // 
            this.btnVertrag.Location = new System.Drawing.Point(415, 321);
            this.btnVertrag.Name = "btnVertrag";
            this.btnVertrag.Size = new System.Drawing.Size(56, 26);
            this.btnVertrag.TabIndex = 10;
            this.btnVertrag.Text = "Vertrag";
            this.btnVertrag.UseVisualStyleBackColor = true;
            this.btnVertrag.Click += new System.EventHandler(this.btnVertrag_Click);
            // 
            // btnWerbepartner
            // 
            this.btnWerbepartner.Location = new System.Drawing.Point(477, 321);
            this.btnWerbepartner.Name = "btnWerbepartner";
            this.btnWerbepartner.Size = new System.Drawing.Size(88, 26);
            this.btnWerbepartner.TabIndex = 11;
            this.btnWerbepartner.Text = "Werbepartner";
            this.btnWerbepartner.UseVisualStyleBackColor = true;
            this.btnWerbepartner.Click += new System.EventHandler(this.btnWerbepartner_Click);
            // 
            // btnWettbewerb
            // 
            this.btnWettbewerb.Location = new System.Drawing.Point(571, 321);
            this.btnWettbewerb.Name = "btnWettbewerb";
            this.btnWettbewerb.Size = new System.Drawing.Size(79, 26);
            this.btnWettbewerb.TabIndex = 12;
            this.btnWettbewerb.Text = "Wettbewerb";
            this.btnWettbewerb.UseVisualStyleBackColor = true;
            this.btnWettbewerb.Click += new System.EventHandler(this.btnWettbewerb_Click);
            // 
            // listView
            // 
            this.listView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(124, 59);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(450, 228);
            this.listView.TabIndex = 13;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // lblTabellen
            // 
            this.lblTabellen.AutoSize = true;
            this.lblTabellen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTabellen.Location = new System.Drawing.Point(23, 301);
            this.lblTabellen.Name = "lblTabellen";
            this.lblTabellen.Size = new System.Drawing.Size(123, 17);
            this.lblTabellen.TabIndex = 14;
            this.lblTabellen.Text = "Wahl der Tabellen:";
            // 
            // btnSpierInfo
            // 
            this.btnSpierInfo.Location = new System.Drawing.Point(600, 77);
            this.btnSpierInfo.Name = "btnSpierInfo";
            this.btnSpierInfo.Size = new System.Drawing.Size(173, 23);
            this.btnSpierInfo.TabIndex = 15;
            this.btnSpierInfo.Text = "Spier Info";
            this.btnSpierInfo.UseVisualStyleBackColor = true;
            this.btnSpierInfo.Click += new System.EventHandler(this.btnSpierInfo_Click);
            // 
            // lblProzedurVerwenden
            // 
            this.lblProzedurVerwenden.AutoSize = true;
            this.lblProzedurVerwenden.Location = new System.Drawing.Point(598, 59);
            this.lblProzedurVerwenden.Name = "lblProzedurVerwenden";
            this.lblProzedurVerwenden.Size = new System.Drawing.Size(118, 15);
            this.lblProzedurVerwenden.TabIndex = 16;
            this.lblProzedurVerwenden.Text = "Prozedur Verwenden:";
            // 
            // btnSpNeueAuszeichnung
            // 
            this.btnSpNeueAuszeichnung.Location = new System.Drawing.Point(598, 118);
            this.btnSpNeueAuszeichnung.Name = "btnSpNeueAuszeichnung";
            this.btnSpNeueAuszeichnung.Size = new System.Drawing.Size(173, 23);
            this.btnSpNeueAuszeichnung.TabIndex = 17;
            this.btnSpNeueAuszeichnung.Text = "Spieler Neue Auszeichnung";
            this.btnSpNeueAuszeichnung.UseVisualStyleBackColor = true;
            this.btnSpNeueAuszeichnung.Click += new System.EventHandler(this.btnSpNeueAuszeichnung_Click);
            // 
            // btnVNeueAuszeichnung
            // 
            this.btnVNeueAuszeichnung.Location = new System.Drawing.Point(598, 147);
            this.btnVNeueAuszeichnung.Name = "btnVNeueAuszeichnung";
            this.btnVNeueAuszeichnung.Size = new System.Drawing.Size(173, 23);
            this.btnVNeueAuszeichnung.TabIndex = 18;
            this.btnVNeueAuszeichnung.Text = "Verein Neue Auszeichnung";
            this.btnVNeueAuszeichnung.UseVisualStyleBackColor = true;
            this.btnVNeueAuszeichnung.Click += new System.EventHandler(this.btnVNeueAuszeichnung_Click);
            // 
            // btnSpielerToreErhoehen
            // 
            this.btnSpielerToreErhoehen.Location = new System.Drawing.Point(600, 215);
            this.btnSpielerToreErhoehen.Name = "btnSpielerToreErhoehen";
            this.btnSpielerToreErhoehen.Size = new System.Drawing.Size(173, 23);
            this.btnSpielerToreErhoehen.TabIndex = 20;
            this.btnSpielerToreErhoehen.Text = "Spieler Tore Erhöhen";
            this.btnSpielerToreErhoehen.UseVisualStyleBackColor = true;
            this.btnSpielerToreErhoehen.Click += new System.EventHandler(this.btnSpielerToreErhoehen_Click);
            // 
            // btnWerbePartnerHinzufügen
            // 
            this.btnWerbePartnerHinzufügen.Location = new System.Drawing.Point(600, 186);
            this.btnWerbePartnerHinzufügen.Name = "btnWerbePartnerHinzufügen";
            this.btnWerbePartnerHinzufügen.Size = new System.Drawing.Size(173, 23);
            this.btnWerbePartnerHinzufügen.TabIndex = 19;
            this.btnWerbePartnerHinzufügen.Text = "Werbe Partner Hinzufügen";
            this.btnWerbePartnerHinzufügen.UseVisualStyleBackColor = true;
            this.btnWerbePartnerHinzufügen.Click += new System.EventHandler(this.btnWerbePartnerHinzufügen_Click);
            // 
            // btnwettbewerb_verein
            // 
            this.btnwettbewerb_verein.Location = new System.Drawing.Point(656, 321);
            this.btnwettbewerb_verein.Name = "btnwettbewerb_verein";
            this.btnwettbewerb_verein.Size = new System.Drawing.Size(115, 26);
            this.btnwettbewerb_verein.TabIndex = 22;
            this.btnwettbewerb_verein.Text = "wettbewerb/Verein";
            this.btnwettbewerb_verein.UseVisualStyleBackColor = true;
            this.btnwettbewerb_verein.Click += new System.EventHandler(this.btnwettbewerb_verein_Click);
            // 
            // btnAnmelden
            // 
            this.btnAnmelden.Location = new System.Drawing.Point(696, 6);
            this.btnAnmelden.Name = "btnAnmelden";
            this.btnAnmelden.Size = new System.Drawing.Size(75, 23);
            this.btnAnmelden.TabIndex = 23;
            this.btnAnmelden.Text = "Abmelden";
            this.btnAnmelden.UseVisualStyleBackColor = true;
            this.btnAnmelden.Click += new System.EventHandler(this.btnAnmelden_Click);
            // 
            // lblBenutzer
            // 
            this.lblBenutzer.AutoSize = true;
            this.lblBenutzer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBenutzer.Location = new System.Drawing.Point(2, 6);
            this.lblBenutzer.Name = "lblBenutzer";
            this.lblBenutzer.Size = new System.Drawing.Size(150, 17);
            this.lblBenutzer.TabIndex = 24;
            this.lblBenutzer.Text = "Benutzer Zustand: Leer";
            // 
            // FrmHauptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.lblBenutzer);
            this.Controls.Add(this.btnAnmelden);
            this.Controls.Add(this.btnwettbewerb_verein);
            this.Controls.Add(this.btnSpielerToreErhoehen);
            this.Controls.Add(this.btnWerbePartnerHinzufügen);
            this.Controls.Add(this.btnVNeueAuszeichnung);
            this.Controls.Add(this.btnSpNeueAuszeichnung);
            this.Controls.Add(this.lblProzedurVerwenden);
            this.Controls.Add(this.btnSpierInfo);
            this.Controls.Add(this.lblTabellen);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnWettbewerb);
            this.Controls.Add(this.btnWerbepartner);
            this.Controls.Add(this.btnVertrag);
            this.Controls.Add(this.btnVerein);
            this.Controls.Add(this.btnTrainer);
            this.Controls.Add(this.btnStatistik);
            this.Controls.Add(this.btnNation);
            this.Controls.Add(this.btnAuszeichnung);
            this.Controls.Add(this.btnSpieler);
            this.Controls.Add(this.lblÜberschrieft);
            this.Controls.Add(this.btnSpalteLoeschen);
            this.Controls.Add(this.btnSpalteHinzufügen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHauptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfermarkt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHauptForm_FormClosing);
            this.Load += new System.EventHandler(this.FrmHauptForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSpalteHinzufügen;
        private Button btnSpalteLoeschen;
        private Label lblÜberschrieft;
        private Button btnSpieler;
        private Button btnAuszeichnung;
        private Button btnNation;
        private Button btnStatistik;
        private Button btnTrainer;
        private Button btnVerein;
        private Button btnVertrag;
        private Button btnWerbepartner;
        private Button btnWettbewerb;
        private ListView listView;
        private Label lblTabellen;
        private Button btnSpierInfo;
        private Label lblProzedurVerwenden;
        private Button btnSpNeueAuszeichnung;
        private Button btnVNeueAuszeichnung;
        private Button btnSpielerToreErhoehen;
        private Button btnWerbePartnerHinzufügen;
        private Button btnwettbewerb_verein;
        private Button btnAnmelden;
        private Label lblBenutzer;
    }
}