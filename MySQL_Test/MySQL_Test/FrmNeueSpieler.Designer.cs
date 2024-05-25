namespace MySQL_Test
{
    partial class FrmNeueSpieler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNeueSpieler));
            this.lblÜberschrift = new System.Windows.Forms.Label();
            this.lblNationalität = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNachname = new System.Windows.Forms.Label();
            this.lblVorname = new System.Windows.Forms.Label();
            this.tbxNationalität = new System.Windows.Forms.TextBox();
            this.tbxGeburtsdatum = new System.Windows.Forms.TextBox();
            this.tbxNachname = new System.Windows.Forms.TextBox();
            this.tbxVorname = new System.Windows.Forms.TextBox();
            this.btnBestätigen = new System.Windows.Forms.Button();
            this.btnAbbruch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblÜberschrift
            // 
            this.lblÜberschrift.AutoSize = true;
            this.lblÜberschrift.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblÜberschrift.Location = new System.Drawing.Point(12, 9);
            this.lblÜberschrift.Name = "lblÜberschrift";
            this.lblÜberschrift.Size = new System.Drawing.Size(232, 20);
            this.lblÜberschrift.TabIndex = 21;
            this.lblÜberschrift.Text = "Neuen Benutzer Erstellen";
            // 
            // lblNationalität
            // 
            this.lblNationalität.AutoSize = true;
            this.lblNationalität.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNationalität.Location = new System.Drawing.Point(39, 136);
            this.lblNationalität.Name = "lblNationalität";
            this.lblNationalität.Size = new System.Drawing.Size(78, 17);
            this.lblNationalität.TabIndex = 20;
            this.lblNationalität.Text = "Nationalität:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Geburtsdatum:";
            // 
            // lblNachname
            // 
            this.lblNachname.AutoSize = true;
            this.lblNachname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNachname.Location = new System.Drawing.Point(39, 78);
            this.lblNachname.Name = "lblNachname";
            this.lblNachname.Size = new System.Drawing.Size(73, 17);
            this.lblNachname.TabIndex = 18;
            this.lblNachname.Text = "Nachname:";
            // 
            // lblVorname
            // 
            this.lblVorname.AutoSize = true;
            this.lblVorname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVorname.Location = new System.Drawing.Point(39, 49);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(63, 17);
            this.lblVorname.TabIndex = 17;
            this.lblVorname.Text = "Vorname:";
            // 
            // tbxNationalität
            // 
            this.tbxNationalität.Location = new System.Drawing.Point(133, 135);
            this.tbxNationalität.Name = "tbxNationalität";
            this.tbxNationalität.Size = new System.Drawing.Size(75, 23);
            this.tbxNationalität.TabIndex = 16;
            // 
            // tbxGeburtsdatum
            // 
            this.tbxGeburtsdatum.Location = new System.Drawing.Point(133, 106);
            this.tbxGeburtsdatum.Name = "tbxGeburtsdatum";
            this.tbxGeburtsdatum.Size = new System.Drawing.Size(75, 23);
            this.tbxGeburtsdatum.TabIndex = 15;
            // 
            // tbxNachname
            // 
            this.tbxNachname.Location = new System.Drawing.Point(133, 77);
            this.tbxNachname.Name = "tbxNachname";
            this.tbxNachname.Size = new System.Drawing.Size(75, 23);
            this.tbxNachname.TabIndex = 14;
            // 
            // tbxVorname
            // 
            this.tbxVorname.Location = new System.Drawing.Point(133, 48);
            this.tbxVorname.Name = "tbxVorname";
            this.tbxVorname.Size = new System.Drawing.Size(75, 23);
            this.tbxVorname.TabIndex = 13;
            // 
            // btnBestätigen
            // 
            this.btnBestätigen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBestätigen.Location = new System.Drawing.Point(133, 164);
            this.btnBestätigen.Name = "btnBestätigen";
            this.btnBestätigen.Size = new System.Drawing.Size(75, 23);
            this.btnBestätigen.TabIndex = 12;
            this.btnBestätigen.Text = "Bestätigen";
            this.btnBestätigen.UseVisualStyleBackColor = true;
            // 
            // btnAbbruch
            // 
            this.btnAbbruch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbbruch.Location = new System.Drawing.Point(39, 164);
            this.btnAbbruch.Name = "btnAbbruch";
            this.btnAbbruch.Size = new System.Drawing.Size(75, 23);
            this.btnAbbruch.TabIndex = 11;
            this.btnAbbruch.Text = "Abbruch";
            this.btnAbbruch.UseVisualStyleBackColor = true;
            // 
            // FrmNeueSpieler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 203);
            this.Controls.Add(this.lblÜberschrift);
            this.Controls.Add(this.lblNationalität);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNachname);
            this.Controls.Add(this.lblVorname);
            this.Controls.Add(this.tbxNationalität);
            this.Controls.Add(this.tbxGeburtsdatum);
            this.Controls.Add(this.tbxNachname);
            this.Controls.Add(this.tbxVorname);
            this.Controls.Add(this.btnBestätigen);
            this.Controls.Add(this.btnAbbruch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNeueSpieler";
            this.Text = "FrmNeueSpieler";
            this.Load += new System.EventHandler(this.FrmNeueSpieler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblÜberschrift;
        private Label lblNationalität;
        private Label label2;
        private Label lblNachname;
        private Label lblVorname;
        private TextBox tbxNationalität;
        private TextBox tbxGeburtsdatum;
        private TextBox tbxNachname;
        private TextBox tbxVorname;
        private Button btnBestätigen;
        private Button btnAbbruch;
    }
}