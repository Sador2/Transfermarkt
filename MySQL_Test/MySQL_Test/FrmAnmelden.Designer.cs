namespace MySQL_Test
{
    partial class FrmAnmelden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnmelden));
            this.lblPasswort = new System.Windows.Forms.Label();
            this.lblBenutzer = new System.Windows.Forms.Label();
            this.tbxPasswort = new System.Windows.Forms.TextBox();
            this.tbxBenutzer = new System.Windows.Forms.TextBox();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.btnAnmelden = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPasswort
            // 
            this.lblPasswort.AutoSize = true;
            this.lblPasswort.Location = new System.Drawing.Point(124, 61);
            this.lblPasswort.Name = "lblPasswort";
            this.lblPasswort.Size = new System.Drawing.Size(57, 15);
            this.lblPasswort.TabIndex = 13;
            this.lblPasswort.Text = "Passwort:";
            // 
            // lblBenutzer
            // 
            this.lblBenutzer.AutoSize = true;
            this.lblBenutzer.Location = new System.Drawing.Point(124, 29);
            this.lblBenutzer.Name = "lblBenutzer";
            this.lblBenutzer.Size = new System.Drawing.Size(56, 15);
            this.lblBenutzer.TabIndex = 12;
            this.lblBenutzer.Text = "Benutzer:";
            // 
            // tbxPasswort
            // 
            this.tbxPasswort.Location = new System.Drawing.Point(187, 58);
            this.tbxPasswort.Name = "tbxPasswort";
            this.tbxPasswort.Size = new System.Drawing.Size(93, 23);
            this.tbxPasswort.TabIndex = 11;
            // 
            // tbxBenutzer
            // 
            this.tbxBenutzer.Location = new System.Drawing.Point(187, 26);
            this.tbxBenutzer.Name = "tbxBenutzer";
            this.tbxBenutzer.Size = new System.Drawing.Size(93, 23);
            this.tbxBenutzer.TabIndex = 10;
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbbrechen.Location = new System.Drawing.Point(124, 111);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.btnAbbrechen.TabIndex = 9;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            // 
            // btnAnmelden
            // 
            this.btnAnmelden.Location = new System.Drawing.Point(205, 111);
            this.btnAnmelden.Name = "btnAnmelden";
            this.btnAnmelden.Size = new System.Drawing.Size(75, 23);
            this.btnAnmelden.TabIndex = 8;
            this.btnAnmelden.Text = "Anmelden";
            this.btnAnmelden.UseVisualStyleBackColor = true;
            this.btnAnmelden.Click += new System.EventHandler(this.btnAnmelden_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MySQL_Test.Properties.Resources.Anmelden_Schlechte;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAnmelden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 153);
            this.Controls.Add(this.lblPasswort);
            this.Controls.Add(this.lblBenutzer);
            this.Controls.Add(this.tbxPasswort);
            this.Controls.Add(this.tbxBenutzer);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnAnmelden);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAnmelden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAnmelden";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPasswort;
        private Label lblBenutzer;
        private TextBox tbxPasswort;
        private TextBox tbxBenutzer;
        private Button btnAbbrechen;
        private Button btnAnmelden;
        private PictureBox pictureBox1;
    }
}