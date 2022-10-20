
namespace Caldaia_Domotica
{
    partial class Termostato
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.powerButton = new System.Windows.Forms.Button();
            this.produttoreBox = new System.Windows.Forms.TextBox();
            this.modelloBox = new System.Windows.Forms.TextBox();
            this.nrdiserieBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tempupButton = new System.Windows.Forms.Button();
            this.tempdownButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.riscaldamentoButton = new System.Windows.Forms.Button();
            this.acquaButton = new System.Windows.Forms.Button();
            this.powerLed = new System.Windows.Forms.PictureBox();
            this.riscaldamentoLed = new System.Windows.Forms.PictureBox();
            this.acquaLed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerLed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riscaldamentoLed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acquaLed)).BeginInit();
            this.SuspendLayout();
            // 
            // powerButton
            // 
            this.powerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.powerButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerButton.ForeColor = System.Drawing.Color.Black;
            this.powerButton.Location = new System.Drawing.Point(50, 12);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(100, 30);
            this.powerButton.TabIndex = 3;
            this.powerButton.Text = "Power";
            this.powerButton.UseVisualStyleBackColor = false;
            // 
            // produttoreBox
            // 
            this.produttoreBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.produttoreBox.Location = new System.Drawing.Point(11, 255);
            this.produttoreBox.Name = "produttoreBox";
            this.produttoreBox.Size = new System.Drawing.Size(181, 20);
            this.produttoreBox.TabIndex = 4;
            // 
            // modelloBox
            // 
            this.modelloBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.modelloBox.Location = new System.Drawing.Point(11, 292);
            this.modelloBox.Name = "modelloBox";
            this.modelloBox.Size = new System.Drawing.Size(181, 20);
            this.modelloBox.TabIndex = 5;
            // 
            // nrdiserieBox
            // 
            this.nrdiserieBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nrdiserieBox.Location = new System.Drawing.Point(11, 329);
            this.nrdiserieBox.Name = "nrdiserieBox";
            this.nrdiserieBox.Size = new System.Drawing.Size(181, 20);
            this.nrdiserieBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Produttore";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 11);
            this.label2.TabIndex = 8;
            this.label2.Text = "Modello";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numero di Serie";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempupButton
            // 
            this.tempupButton.AutoSize = true;
            this.tempupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tempupButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempupButton.ForeColor = System.Drawing.Color.Black;
            this.tempupButton.Location = new System.Drawing.Point(11, 162);
            this.tempupButton.Name = "tempupButton";
            this.tempupButton.Size = new System.Drawing.Size(85, 40);
            this.tempupButton.TabIndex = 14;
            this.tempupButton.Text = "+";
            this.tempupButton.UseVisualStyleBackColor = false;
            // 
            // tempdownButton
            // 
            this.tempdownButton.AutoSize = true;
            this.tempdownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tempdownButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempdownButton.ForeColor = System.Drawing.Color.Black;
            this.tempdownButton.Location = new System.Drawing.Point(107, 162);
            this.tempdownButton.Name = "tempdownButton";
            this.tempdownButton.Size = new System.Drawing.Size(85, 40);
            this.tempdownButton.TabIndex = 15;
            this.tempdownButton.Text = "-";
            this.tempdownButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Temperatura";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(202, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 337);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // riscaldamentoButton
            // 
            this.riscaldamentoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.riscaldamentoButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riscaldamentoButton.ForeColor = System.Drawing.Color.Black;
            this.riscaldamentoButton.Location = new System.Drawing.Point(11, 48);
            this.riscaldamentoButton.Name = "riscaldamentoButton";
            this.riscaldamentoButton.Size = new System.Drawing.Size(170, 30);
            this.riscaldamentoButton.TabIndex = 18;
            this.riscaldamentoButton.Text = "Riscaldamento";
            this.riscaldamentoButton.UseVisualStyleBackColor = false;
            // 
            // acquaButton
            // 
            this.acquaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.acquaButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acquaButton.ForeColor = System.Drawing.Color.Black;
            this.acquaButton.Location = new System.Drawing.Point(11, 84);
            this.acquaButton.Name = "acquaButton";
            this.acquaButton.Size = new System.Drawing.Size(170, 30);
            this.acquaButton.TabIndex = 19;
            this.acquaButton.Text = "Acqua";
            this.acquaButton.UseVisualStyleBackColor = false;
            // 
            // powerLed
            // 
            this.powerLed.Location = new System.Drawing.Point(50, 0);
            this.powerLed.Name = "powerLed";
            this.powerLed.Size = new System.Drawing.Size(100, 10);
            this.powerLed.TabIndex = 20;
            this.powerLed.TabStop = false;
            // 
            // riscaldamentoLed
            // 
            this.riscaldamentoLed.Location = new System.Drawing.Point(184, 48);
            this.riscaldamentoLed.Name = "riscaldamentoLed";
            this.riscaldamentoLed.Size = new System.Drawing.Size(8, 30);
            this.riscaldamentoLed.TabIndex = 21;
            this.riscaldamentoLed.TabStop = false;
            // 
            // acquaLed
            // 
            this.acquaLed.Location = new System.Drawing.Point(184, 84);
            this.acquaLed.Name = "acquaLed";
            this.acquaLed.Size = new System.Drawing.Size(8, 30);
            this.acquaLed.TabIndex = 22;
            this.acquaLed.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.acquaLed);
            this.Controls.Add(this.riscaldamentoLed);
            this.Controls.Add(this.powerLed);
            this.Controls.Add(this.acquaButton);
            this.Controls.Add(this.riscaldamentoButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tempdownButton);
            this.Controls.Add(this.tempupButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nrdiserieBox);
            this.Controls.Add(this.modelloBox);
            this.Controls.Add(this.produttoreBox);
            this.Controls.Add(this.powerButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerLed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riscaldamentoLed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acquaLed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.TextBox produttoreBox;
        private System.Windows.Forms.TextBox modelloBox;
        private System.Windows.Forms.TextBox nrdiserieBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tempupButton;
        private System.Windows.Forms.Button tempdownButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button riscaldamentoButton;
        private System.Windows.Forms.Button acquaButton;
        private System.Windows.Forms.PictureBox powerLed;
        private System.Windows.Forms.PictureBox riscaldamentoLed;
        private System.Windows.Forms.PictureBox acquaLed;
    }
}

