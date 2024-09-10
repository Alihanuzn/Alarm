namespace Alarm
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
            this.btnAlarmKur = new System.Windows.Forms.Button();
            this.btnAlarmErteleme = new System.Windows.Forms.Button();
            this.btnAlarmDurdur = new System.Windows.Forms.Button();
            this.lblGuncelZaman = new System.Windows.Forms.Label();
            this.txtAlarmZamani = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnAlarmKur
            // 
            this.btnAlarmKur.BackColor = System.Drawing.Color.Red;
            this.btnAlarmKur.FlatAppearance.BorderSize = 0;
            this.btnAlarmKur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarmKur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlarmKur.ForeColor = System.Drawing.Color.White;
            this.btnAlarmKur.Location = new System.Drawing.Point(165, 245);
            this.btnAlarmKur.Name = "btnAlarmKur";
            this.btnAlarmKur.Size = new System.Drawing.Size(143, 56);
            this.btnAlarmKur.TabIndex = 0;
            this.btnAlarmKur.Text = "Kur";
            this.btnAlarmKur.UseVisualStyleBackColor = false;
            this.btnAlarmKur.Click += new System.EventHandler(this.btnAlarmKur_Click);
            // 
            // btnAlarmErteleme
            // 
            this.btnAlarmErteleme.BackColor = System.Drawing.Color.Red;
            this.btnAlarmErteleme.FlatAppearance.BorderSize = 0;
            this.btnAlarmErteleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarmErteleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlarmErteleme.ForeColor = System.Drawing.Color.White;
            this.btnAlarmErteleme.Location = new System.Drawing.Point(314, 245);
            this.btnAlarmErteleme.Name = "btnAlarmErteleme";
            this.btnAlarmErteleme.Size = new System.Drawing.Size(143, 56);
            this.btnAlarmErteleme.TabIndex = 1;
            this.btnAlarmErteleme.Text = "Ertele";
            this.btnAlarmErteleme.UseVisualStyleBackColor = false;
            this.btnAlarmErteleme.Click += new System.EventHandler(this.btnAlarmErteleme_Click);
            // 
            // btnAlarmDurdur
            // 
            this.btnAlarmDurdur.BackColor = System.Drawing.Color.Red;
            this.btnAlarmDurdur.FlatAppearance.BorderSize = 0;
            this.btnAlarmDurdur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarmDurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlarmDurdur.ForeColor = System.Drawing.Color.White;
            this.btnAlarmDurdur.Location = new System.Drawing.Point(463, 245);
            this.btnAlarmDurdur.Name = "btnAlarmDurdur";
            this.btnAlarmDurdur.Size = new System.Drawing.Size(143, 56);
            this.btnAlarmDurdur.TabIndex = 2;
            this.btnAlarmDurdur.Text = "Durdur";
            this.btnAlarmDurdur.UseVisualStyleBackColor = false;
            this.btnAlarmDurdur.Click += new System.EventHandler(this.btnAlarmDurdur_Click);
            // 
            // lblGuncelZaman
            // 
            this.lblGuncelZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuncelZaman.Location = new System.Drawing.Point(170, 71);
            this.lblGuncelZaman.Name = "lblGuncelZaman";
            this.lblGuncelZaman.Size = new System.Drawing.Size(426, 70);
            this.lblGuncelZaman.TabIndex = 3;
            this.lblGuncelZaman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAlarmZamani
            // 
            this.txtAlarmZamani.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlarmZamani.Location = new System.Drawing.Point(241, 165);
            this.txtAlarmZamani.Name = "txtAlarmZamani";
            this.txtAlarmZamani.Size = new System.Drawing.Size(281, 38);
            this.txtAlarmZamani.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(173, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 80);
            this.label2.TabIndex = 5;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAlarmZamani);
            this.Controls.Add(this.lblGuncelZaman);
            this.Controls.Add(this.btnAlarmDurdur);
            this.Controls.Add(this.btnAlarmErteleme);
            this.Controls.Add(this.btnAlarmKur);
            this.Name = "Form1";
            this.Text = "Alarm Projesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlarmKur;
        private System.Windows.Forms.Button btnAlarmErteleme;
        private System.Windows.Forms.Button btnAlarmDurdur;
        private System.Windows.Forms.Label lblGuncelZaman;
        private System.Windows.Forms.TextBox txtAlarmZamani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

