namespace MySQL_Test
{
    partial class FrmProzedurEingabe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProzedurEingabe));
            this.btnBestätigen = new System.Windows.Forms.Button();
            this.btnAbbruch = new System.Windows.Forms.Button();
            this.lblÜberschrieft = new System.Windows.Forms.Label();
            this.tbxSpielerName = new System.Windows.Forms.TextBox();
            this.tbxZwei = new System.Windows.Forms.TextBox();
            this.tbxDrei = new System.Windows.Forms.TextBox();
            this.lblSpielerName = new System.Windows.Forms.Label();
            this.lblZwei = new System.Windows.Forms.Label();
            this.lblDrei = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBestätigen
            // 
            this.btnBestätigen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBestätigen.Location = new System.Drawing.Point(215, 115);
            this.btnBestätigen.Name = "btnBestätigen";
            this.btnBestätigen.Size = new System.Drawing.Size(75, 23);
            this.btnBestätigen.TabIndex = 0;
            this.btnBestätigen.Text = "Bestätigen";
            this.btnBestätigen.UseVisualStyleBackColor = true;
            this.btnBestätigen.Click += new System.EventHandler(this.btnBestätigen_Click);
            // 
            // btnAbbruch
            // 
            this.btnAbbruch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbbruch.Location = new System.Drawing.Point(98, 115);
            this.btnAbbruch.Name = "btnAbbruch";
            this.btnAbbruch.Size = new System.Drawing.Size(75, 23);
            this.btnAbbruch.TabIndex = 1;
            this.btnAbbruch.Text = "Abbruch";
            this.btnAbbruch.UseVisualStyleBackColor = true;
            // 
            // lblÜberschrieft
            // 
            this.lblÜberschrieft.AutoSize = true;
            this.lblÜberschrieft.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblÜberschrieft.Location = new System.Drawing.Point(12, 9);
            this.lblÜberschrieft.Name = "lblÜberschrieft";
            this.lblÜberschrieft.Size = new System.Drawing.Size(435, 26);
            this.lblÜberschrieft.TabIndex = 2;
            this.lblÜberschrieft.Text = "Eingeben von weiteren Spieler Tore:";
            // 
            // tbxSpielerName
            // 
            this.tbxSpielerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxSpielerName.Location = new System.Drawing.Point(215, 47);
            this.tbxSpielerName.Name = "tbxSpielerName";
            this.tbxSpielerName.Size = new System.Drawing.Size(81, 23);
            this.tbxSpielerName.TabIndex = 3;
            // 
            // tbxZwei
            // 
            this.tbxZwei.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxZwei.Location = new System.Drawing.Point(215, 76);
            this.tbxZwei.Name = "tbxZwei";
            this.tbxZwei.Size = new System.Drawing.Size(81, 23);
            this.tbxZwei.TabIndex = 4;
            // 
            // tbxDrei
            // 
            this.tbxDrei.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxDrei.Location = new System.Drawing.Point(468, 104);
            this.tbxDrei.Name = "tbxDrei";
            this.tbxDrei.Size = new System.Drawing.Size(81, 23);
            this.tbxDrei.TabIndex = 5;
            // 
            // lblSpielerName
            // 
            this.lblSpielerName.AutoSize = true;
            this.lblSpielerName.Location = new System.Drawing.Point(93, 47);
            this.lblSpielerName.Name = "lblSpielerName";
            this.lblSpielerName.Size = new System.Drawing.Size(80, 15);
            this.lblSpielerName.TabIndex = 6;
            this.lblSpielerName.Text = "Spieler Name:";
            // 
            // lblZwei
            // 
            this.lblZwei.AutoSize = true;
            this.lblZwei.Location = new System.Drawing.Point(93, 79);
            this.lblZwei.Name = "lblZwei";
            this.lblZwei.Size = new System.Drawing.Size(116, 15);
            this.lblZwei.TabIndex = 7;
            this.lblZwei.Text = "Anzahl weiterer Tore:";
            // 
            // lblDrei
            // 
            this.lblDrei.AutoSize = true;
            this.lblDrei.Location = new System.Drawing.Point(468, 104);
            this.lblDrei.Name = "lblDrei";
            this.lblDrei.Size = new System.Drawing.Size(46, 15);
            this.lblDrei.TabIndex = 8;
            this.lblDrei.Text = "Datum:";
            // 
            // FrmProzedurEingabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(463, 150);
            this.Controls.Add(this.lblDrei);
            this.Controls.Add(this.lblZwei);
            this.Controls.Add(this.lblSpielerName);
            this.Controls.Add(this.tbxDrei);
            this.Controls.Add(this.tbxZwei);
            this.Controls.Add(this.tbxSpielerName);
            this.Controls.Add(this.lblÜberschrieft);
            this.Controls.Add(this.btnAbbruch);
            this.Controls.Add(this.btnBestätigen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProzedurEingabe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prozedur Eingabe";
            this.Load += new System.EventHandler(this.FrmProzedurEingabe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBestätigen;
        private Button btnAbbruch;
        private Label lblÜberschrieft;
        private TextBox tbxSpielerName;
        private TextBox tbxZwei;
        private TextBox tbxDrei;
        private Label lblSpielerName;
        private Label lblZwei;
        private Label lblDrei;
    }
}