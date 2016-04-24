namespace WifiArduinoLed
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
            this.btnLedON = new System.Windows.Forms.Button();
            this.btnLedOFF = new System.Windows.Forms.Button();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lblRecu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMesures = new System.Windows.Forms.Button();
            this.lblMesures = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLedON
            // 
            this.btnLedON.Enabled = false;
            this.btnLedON.Location = new System.Drawing.Point(57, 41);
            this.btnLedON.Name = "btnLedON";
            this.btnLedON.Size = new System.Drawing.Size(75, 23);
            this.btnLedON.TabIndex = 0;
            this.btnLedON.Text = "Led ON";
            this.btnLedON.UseVisualStyleBackColor = true;
            this.btnLedON.Click += new System.EventHandler(this.btnLedON_Click);
            // 
            // btnLedOFF
            // 
            this.btnLedOFF.Enabled = false;
            this.btnLedOFF.Location = new System.Drawing.Point(174, 41);
            this.btnLedOFF.Name = "btnLedOFF";
            this.btnLedOFF.Size = new System.Drawing.Size(75, 23);
            this.btnLedOFF.TabIndex = 1;
            this.btnLedOFF.Text = "Led OFF";
            this.btnLedOFF.UseVisualStyleBackColor = true;
            this.btnLedOFF.Click += new System.EventHandler(this.btnLedOFF_Click);
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(57, 12);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(192, 23);
            this.btnConnexion.TabIndex = 2;
            this.btnConnexion.Text = "Connection";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lblRecu
            // 
            this.lblRecu.AutoSize = true;
            this.lblRecu.Location = new System.Drawing.Point(64, 70);
            this.lblRecu.Name = "lblRecu";
            this.lblRecu.Size = new System.Drawing.Size(0, 13);
            this.lblRecu.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(98, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnMesures
            // 
            this.btnMesures.Enabled = false;
            this.btnMesures.Location = new System.Drawing.Point(57, 186);
            this.btnMesures.Name = "btnMesures";
            this.btnMesures.Size = new System.Drawing.Size(75, 23);
            this.btnMesures.TabIndex = 5;
            this.btnMesures.Text = "Mesures";
            this.btnMesures.UseVisualStyleBackColor = true;
            this.btnMesures.Click += new System.EventHandler(this.btnMesures_Click);
            // 
            // lblMesures
            // 
            this.lblMesures.AutoSize = true;
            this.lblMesures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesures.Location = new System.Drawing.Point(154, 195);
            this.lblMesures.Name = "lblMesures";
            this.lblMesures.Size = new System.Drawing.Size(23, 16);
            this.lblMesures.TabIndex = 6;
            this.lblMesures.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 224);
            this.Controls.Add(this.lblMesures);
            this.Controls.Add(this.btnMesures);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRecu);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.btnLedOFF);
            this.Controls.Add(this.btnLedON);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLedON;
        private System.Windows.Forms.Button btnLedOFF;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblRecu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMesures;
        private System.Windows.Forms.Label lblMesures;

    }
}

