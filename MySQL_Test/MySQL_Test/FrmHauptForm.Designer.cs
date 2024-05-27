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
            this.SuspendLayout();
            // 
            // btnSpalteHinzufügen
            // 
            this.btnSpalteHinzufügen.Location = new System.Drawing.Point(38, 49);
            this.btnSpalteHinzufügen.Name = "btnSpalteHinzufügen";
            this.btnSpalteHinzufügen.Size = new System.Drawing.Size(86, 26);
            this.btnSpalteHinzufügen.TabIndex = 0;
            this.btnSpalteHinzufügen.Text = "Sp Hinzfügen";
            this.btnSpalteHinzufügen.UseVisualStyleBackColor = true;
            this.btnSpalteHinzufügen.Click += new System.EventHandler(this.btnSpalteHinzufügen_Click);
            // 
            // btnSpalteLoeschen
            // 
            this.btnSpalteLoeschen.Location = new System.Drawing.Point(38, 92);
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
            this.lblÜberschrieft.Location = new System.Drawing.Point(139, 23);
            this.lblÜberschrieft.Name = "lblÜberschrieft";
            this.lblÜberschrieft.Size = new System.Drawing.Size(176, 23);
            this.lblÜberschrieft.TabIndex = 3;
            this.lblÜberschrieft.Text = "Tablle Anzeigen von:";
            // 
            // btnSpieler
            // 
            this.btnSpieler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSpieler.Location = new System.Drawing.Point(38, 311);
            this.btnSpieler.Name = "btnSpieler";
            this.btnSpieler.Size = new System.Drawing.Size(50, 26);
            this.btnSpieler.TabIndex = 4;
            this.btnSpieler.Text = "Spieler";
            this.btnSpieler.UseVisualStyleBackColor = true;
            this.btnSpieler.Click += new System.EventHandler(this.btnSpieler_Click);
            // 
            // btnAuszeichnung
            // 
            this.btnAuszeichnung.Location = new System.Drawing.Point(94, 311);
            this.btnAuszeichnung.Name = "btnAuszeichnung";
            this.btnAuszeichnung.Size = new System.Drawing.Size(91, 26);
            this.btnAuszeichnung.TabIndex = 5;
            this.btnAuszeichnung.Text = "Auszeichnung";
            this.btnAuszeichnung.UseVisualStyleBackColor = true;
            this.btnAuszeichnung.Click += new System.EventHandler(this.btnAuszeichnung_Click);
            // 
            // btnNation
            // 
            this.btnNation.Location = new System.Drawing.Point(253, 311);
            this.btnNation.Name = "btnNation";
            this.btnNation.Size = new System.Drawing.Size(51, 26);
            this.btnNation.TabIndex = 6;
            this.btnNation.Text = "Nation";
            this.btnNation.UseVisualStyleBackColor = true;
            this.btnNation.Click += new System.EventHandler(this.btnNation_Click);
            // 
            // btnStatistik
            // 
            this.btnStatistik.Location = new System.Drawing.Point(191, 311);
            this.btnStatistik.Name = "btnStatistik";
            this.btnStatistik.Size = new System.Drawing.Size(56, 26);
            this.btnStatistik.TabIndex = 7;
            this.btnStatistik.Text = "Statistik";
            this.btnStatistik.UseVisualStyleBackColor = true;
            this.btnStatistik.Click += new System.EventHandler(this.btnStatistik_Click);
            // 
            // btnTrainer
            // 
            this.btnTrainer.Location = new System.Drawing.Point(365, 311);
            this.btnTrainer.Name = "btnTrainer";
            this.btnTrainer.Size = new System.Drawing.Size(59, 26);
            this.btnTrainer.TabIndex = 8;
            this.btnTrainer.Text = "Trainer";
            this.btnTrainer.UseVisualStyleBackColor = true;
            this.btnTrainer.Click += new System.EventHandler(this.btnTrainer_Click);
            // 
            // btnVerein
            // 
            this.btnVerein.Location = new System.Drawing.Point(310, 311);
            this.btnVerein.Name = "btnVerein";
            this.btnVerein.Size = new System.Drawing.Size(49, 26);
            this.btnVerein.TabIndex = 9;
            this.btnVerein.Text = "Verein";
            this.btnVerein.UseVisualStyleBackColor = true;
            this.btnVerein.Click += new System.EventHandler(this.btnVerein_Click);
            // 
            // btnVertrag
            // 
            this.btnVertrag.Location = new System.Drawing.Point(430, 311);
            this.btnVertrag.Name = "btnVertrag";
            this.btnVertrag.Size = new System.Drawing.Size(56, 26);
            this.btnVertrag.TabIndex = 10;
            this.btnVertrag.Text = "Vertrag";
            this.btnVertrag.UseVisualStyleBackColor = true;
            this.btnVertrag.Click += new System.EventHandler(this.btnVertrag_Click);
            // 
            // btnWerbepartner
            // 
            this.btnWerbepartner.Location = new System.Drawing.Point(492, 311);
            this.btnWerbepartner.Name = "btnWerbepartner";
            this.btnWerbepartner.Size = new System.Drawing.Size(88, 26);
            this.btnWerbepartner.TabIndex = 11;
            this.btnWerbepartner.Text = "Werbepartner";
            this.btnWerbepartner.UseVisualStyleBackColor = true;
            this.btnWerbepartner.Click += new System.EventHandler(this.btnWerbepartner_Click);
            // 
            // btnWettbewerb
            // 
            this.btnWettbewerb.Location = new System.Drawing.Point(586, 311);
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
            this.listView.Location = new System.Drawing.Point(139, 49);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(450, 228);
            this.listView.TabIndex = 13;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // lblTabellen
            // 
            this.lblTabellen.AutoSize = true;
            this.lblTabellen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTabellen.Location = new System.Drawing.Point(38, 291);
            this.lblTabellen.Name = "lblTabellen";
            this.lblTabellen.Size = new System.Drawing.Size(123, 17);
            this.lblTabellen.TabIndex = 14;
            this.lblTabellen.Text = "Wahl der Tabellen:";
            // 
            // btnSpierInfo
            // 
            this.btnSpierInfo.Location = new System.Drawing.Point(613, 67);
            this.btnSpierInfo.Name = "btnSpierInfo";
            this.btnSpierInfo.Size = new System.Drawing.Size(79, 23);
            this.btnSpierInfo.TabIndex = 15;
            this.btnSpierInfo.Text = "Spier Info";
            this.btnSpierInfo.UseVisualStyleBackColor = true;
            this.btnSpierInfo.Click += new System.EventHandler(this.btnSpierInfo_Click);
            // 
            // lblProzedurVerwenden
            // 
            this.lblProzedurVerwenden.AutoSize = true;
            this.lblProzedurVerwenden.Location = new System.Drawing.Point(613, 49);
            this.lblProzedurVerwenden.Name = "lblProzedurVerwenden";
            this.lblProzedurVerwenden.Size = new System.Drawing.Size(118, 15);
            this.lblProzedurVerwenden.TabIndex = 16;
            this.lblProzedurVerwenden.Text = "Prozedur Verwenden:";
            // 
            // FrmHauptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 354);
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
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHauptForm_FormClosing);
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
    }
}