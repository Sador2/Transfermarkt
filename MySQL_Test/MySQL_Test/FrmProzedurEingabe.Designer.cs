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
            this.btnBestätigen = new System.Windows.Forms.Button();
            this.btnAbbruch = new System.Windows.Forms.Button();
            this.lblÜberschrieft = new System.Windows.Forms.Label();
            this.tbxSpielerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBestätigen
            // 
            this.btnBestätigen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBestätigen.Location = new System.Drawing.Point(125, 67);
            this.btnBestätigen.Name = "btnBestätigen";
            this.btnBestätigen.Size = new System.Drawing.Size(75, 23);
            this.btnBestätigen.TabIndex = 0;
            this.btnBestätigen.Text = "Bestätigen";
            this.btnBestätigen.UseVisualStyleBackColor = true;
            // 
            // btnAbbruch
            // 
            this.btnAbbruch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbbruch.Location = new System.Drawing.Point(44, 67);
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
            this.lblÜberschrieft.Location = new System.Drawing.Point(26, 9);
            this.lblÜberschrieft.Name = "lblÜberschrieft";
            this.lblÜberschrieft.Size = new System.Drawing.Size(210, 26);
            this.lblÜberschrieft.TabIndex = 2;
            this.lblÜberschrieft.Text = "Spieler Eingeben:";
            // 
            // tbxSpielerName
            // 
            this.tbxSpielerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxSpielerName.Location = new System.Drawing.Point(63, 38);
            this.tbxSpielerName.Name = "tbxSpielerName";
            this.tbxSpielerName.Size = new System.Drawing.Size(122, 23);
            this.tbxSpielerName.TabIndex = 3;
            // 
            // FrmProzedurEingabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(277, 113);
            this.Controls.Add(this.tbxSpielerName);
            this.Controls.Add(this.lblÜberschrieft);
            this.Controls.Add(this.btnAbbruch);
            this.Controls.Add(this.btnBestätigen);
            this.Name = "FrmProzedurEingabe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prozedur Eingabe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBestätigen;
        private Button btnAbbruch;
        private Label lblÜberschrieft;
        private TextBox tbxSpielerName;
    }
}