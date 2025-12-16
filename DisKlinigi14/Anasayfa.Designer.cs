namespace DisKlinigi14
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.btnHasta = new System.Windows.Forms.Button();
            this.btnRandevu = new System.Windows.Forms.Button();
            this.btnTedavi = new System.Windows.Forms.Button();
            this.btnRecete = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHasta
            // 
            this.btnHasta.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHasta.Location = new System.Drawing.Point(76, 68);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(205, 50);
            this.btnHasta.TabIndex = 0;
            this.btnHasta.Text = "HASTA İŞLEMLERİ";
            this.btnHasta.UseVisualStyleBackColor = true;
            this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click_1);
            // 
            // btnRandevu
            // 
            this.btnRandevu.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandevu.Location = new System.Drawing.Point(383, 68);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Size = new System.Drawing.Size(205, 50);
            this.btnRandevu.TabIndex = 1;
            this.btnRandevu.Text = "RANDEVU AL";
            this.btnRandevu.UseVisualStyleBackColor = true;
            this.btnRandevu.Click += new System.EventHandler(this.btnRandevu_Click);
            // 
            // btnTedavi
            // 
            this.btnTedavi.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTedavi.Location = new System.Drawing.Point(709, 68);
            this.btnTedavi.Name = "btnTedavi";
            this.btnTedavi.Size = new System.Drawing.Size(205, 50);
            this.btnTedavi.TabIndex = 2;
            this.btnTedavi.Text = "TEDAVİLER";
            this.btnTedavi.UseVisualStyleBackColor = true;
            this.btnTedavi.Click += new System.EventHandler(this.btnTedavi_Click);
            // 
            // btnRecete
            // 
            this.btnRecete.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecete.Location = new System.Drawing.Point(1021, 68);
            this.btnRecete.Name = "btnRecete";
            this.btnRecete.Size = new System.Drawing.Size(205, 50);
            this.btnRecete.TabIndex = 3;
            this.btnRecete.Text = "REÇETELER";
            this.btnRecete.UseVisualStyleBackColor = true;
            this.btnRecete.Click += new System.EventHandler(this.btnRecete_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Location = new System.Drawing.Point(532, 577);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(205, 50);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(558, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "KONTROL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnRecete);
            this.panel1.Controls.Add(this.btnTedavi);
            this.panel1.Controls.Add(this.btnRandevu);
            this.panel1.Controls.Add(this.btnHasta);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 133);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(540, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 35);
            this.label3.TabIndex = 14;
            this.label3.Text = "DİŞ KLİNİĞİ 14";
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1270, 639);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCikis);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHasta;
        private System.Windows.Forms.Button btnRandevu;
        private System.Windows.Forms.Button btnTedavi;
        private System.Windows.Forms.Button btnRecete;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}