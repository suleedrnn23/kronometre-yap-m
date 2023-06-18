namespace Kronometre
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saat = new System.Windows.Forms.Label();
            this.dakika = new System.Windows.Forms.Label();
            this.saniye = new System.Windows.Forms.Label();
            this.başlat = new System.Windows.Forms.Button();
            this.sıfırla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(70, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(241, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "DAKİKA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(435, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "SANİYE";
            // 
            // saat
            // 
            this.saat.AutoSize = true;
            this.saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saat.ForeColor = System.Drawing.Color.Black;
            this.saat.Location = new System.Drawing.Point(90, 109);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(38, 40);
            this.saat.TabIndex = 3;
            this.saat.Text = "0";
            // 
            // dakika
            // 
            this.dakika.AutoSize = true;
            this.dakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dakika.ForeColor = System.Drawing.Color.Black;
            this.dakika.Location = new System.Drawing.Point(282, 109);
            this.dakika.Name = "dakika";
            this.dakika.Size = new System.Drawing.Size(38, 40);
            this.dakika.TabIndex = 4;
            this.dakika.Text = "0";
            // 
            // saniye
            // 
            this.saniye.AutoSize = true;
            this.saniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saniye.ForeColor = System.Drawing.Color.Black;
            this.saniye.Location = new System.Drawing.Point(475, 109);
            this.saniye.Name = "saniye";
            this.saniye.Size = new System.Drawing.Size(38, 40);
            this.saniye.TabIndex = 5;
            this.saniye.Text = "0";
            // 
            // başlat
            // 
            this.başlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.başlat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.başlat.Location = new System.Drawing.Point(12, 197);
            this.başlat.Name = "başlat";
            this.başlat.Size = new System.Drawing.Size(252, 94);
            this.başlat.TabIndex = 6;
            this.başlat.Text = "Kronometreyi Çalıştır\r\n";
            this.başlat.UseVisualStyleBackColor = true;
            this.başlat.Click += new System.EventHandler(this.başlat_Click);
            // 
            // sıfırla
            // 
            this.sıfırla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sıfırla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sıfırla.Location = new System.Drawing.Point(374, 197);
            this.sıfırla.Name = "sıfırla";
            this.sıfırla.Size = new System.Drawing.Size(265, 94);
            this.sıfırla.TabIndex = 7;
            this.sıfırla.Text = "Kronometreyi Resetle";
            this.sıfırla.UseVisualStyleBackColor = true;
            this.sıfırla.Click += new System.EventHandler(this.sıfırla_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sıfırla);
            this.Controls.Add(this.başlat);
            this.Controls.Add(this.saniye);
            this.Controls.Add(this.dakika);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Label dakika;
        private System.Windows.Forms.Label saniye;
        private System.Windows.Forms.Button başlat;
        private System.Windows.Forms.Button sıfırla;
        private System.Windows.Forms.Timer timer1;
    }
}

