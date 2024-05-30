namespace MySQL_Test
{
    partial class FrmNeueSpalte
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
            this.lblUeberschrieft = new System.Windows.Forms.Label();
            this.btnAbbruch = new System.Windows.Forms.Button();
            this.btnBestätigen = new System.Windows.Forms.Button();
            this.tbxEins = new System.Windows.Forms.TextBox();
            this.tbxZwei = new System.Windows.Forms.TextBox();
            this.tbxDrei = new System.Windows.Forms.TextBox();
            this.lblEins = new System.Windows.Forms.Label();
            this.lblZwei = new System.Windows.Forms.Label();
            this.lblDrei = new System.Windows.Forms.Label();
            this.tbxVier = new System.Windows.Forms.TextBox();
            this.lblVier = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUeberschrieft
            // 
            this.lblUeberschrieft.AutoSize = true;
            this.lblUeberschrieft.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUeberschrieft.Location = new System.Drawing.Point(76, 21);
            this.lblUeberschrieft.Name = "lblUeberschrieft";
            this.lblUeberschrieft.Size = new System.Drawing.Size(158, 26);
            this.lblUeberschrieft.TabIndex = 0;
            this.lblUeberschrieft.Text = "Überschrieft";
            // 
            // btnAbbruch
            // 
            this.btnAbbruch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbbruch.Location = new System.Drawing.Point(91, 115);
            this.btnAbbruch.Name = "btnAbbruch";
            this.btnAbbruch.Size = new System.Drawing.Size(75, 23);
            this.btnAbbruch.TabIndex = 3;
            this.btnAbbruch.Text = "Abbruch";
            this.btnAbbruch.UseVisualStyleBackColor = true;
            // 
            // btnBestätigen
            // 
            this.btnBestätigen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBestätigen.Location = new System.Drawing.Point(172, 115);
            this.btnBestätigen.Name = "btnBestätigen";
            this.btnBestätigen.Size = new System.Drawing.Size(75, 23);
            this.btnBestätigen.TabIndex = 2;
            this.btnBestätigen.Text = "Bestätigen";
            this.btnBestätigen.UseVisualStyleBackColor = true;
            // 
            // tbxEins
            // 
            this.tbxEins.Location = new System.Drawing.Point(12, 75);
            this.tbxEins.Name = "tbxEins";
            this.tbxEins.Size = new System.Drawing.Size(100, 23);
            this.tbxEins.TabIndex = 4;
            // 
            // tbxZwei
            // 
            this.tbxZwei.Location = new System.Drawing.Point(118, 75);
            this.tbxZwei.Name = "tbxZwei";
            this.tbxZwei.Size = new System.Drawing.Size(100, 23);
            this.tbxZwei.TabIndex = 5;
            // 
            // tbxDrei
            // 
            this.tbxDrei.Location = new System.Drawing.Point(224, 75);
            this.tbxDrei.Name = "tbxDrei";
            this.tbxDrei.Size = new System.Drawing.Size(100, 23);
            this.tbxDrei.TabIndex = 6;
            // 
            // lblEins
            // 
            this.lblEins.AutoSize = true;
            this.lblEins.Location = new System.Drawing.Point(12, 57);
            this.lblEins.Name = "lblEins";
            this.lblEins.Size = new System.Drawing.Size(38, 15);
            this.lblEins.TabIndex = 7;
            this.lblEins.Text = "label1";
            // 
            // lblZwei
            // 
            this.lblZwei.AutoSize = true;
            this.lblZwei.Location = new System.Drawing.Point(118, 57);
            this.lblZwei.Name = "lblZwei";
            this.lblZwei.Size = new System.Drawing.Size(38, 15);
            this.lblZwei.TabIndex = 8;
            this.lblZwei.Text = "label2";
            // 
            // lblDrei
            // 
            this.lblDrei.AutoSize = true;
            this.lblDrei.Location = new System.Drawing.Point(224, 57);
            this.lblDrei.Name = "lblDrei";
            this.lblDrei.Size = new System.Drawing.Size(38, 15);
            this.lblDrei.TabIndex = 9;
            this.lblDrei.Text = "label3";
            // 
            // tbxVier
            // 
            this.tbxVier.Location = new System.Drawing.Point(330, 75);
            this.tbxVier.Name = "tbxVier";
            this.tbxVier.Size = new System.Drawing.Size(100, 23);
            this.tbxVier.TabIndex = 10;
            // 
            // lblVier
            // 
            this.lblVier.AutoSize = true;
            this.lblVier.Location = new System.Drawing.Point(330, 57);
            this.lblVier.Name = "lblVier";
            this.lblVier.Size = new System.Drawing.Size(38, 15);
            this.lblVier.TabIndex = 11;
            this.lblVier.Text = "label1";
            // 
            // FrmNeueSpalte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 161);
            this.Controls.Add(this.lblVier);
            this.Controls.Add(this.tbxVier);
            this.Controls.Add(this.lblDrei);
            this.Controls.Add(this.lblZwei);
            this.Controls.Add(this.lblEins);
            this.Controls.Add(this.tbxDrei);
            this.Controls.Add(this.tbxZwei);
            this.Controls.Add(this.tbxEins);
            this.Controls.Add(this.btnAbbruch);
            this.Controls.Add(this.btnBestätigen);
            this.Controls.Add(this.lblUeberschrieft);
            this.Name = "FrmNeueSpalte";
            this.Text = "Neue Spalte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUeberschrieft;
        private Button btnAbbruch;
        private Button btnBestätigen;
        private TextBox tbxEins;
        private TextBox tbxZwei;
        private TextBox tbxDrei;
        private Label lblEins;
        private Label lblZwei;
        private Label lblDrei;
        private TextBox tbxVier;
        private Label lblVier;
    }
}