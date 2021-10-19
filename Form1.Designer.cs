
namespace AESCrypto
{
    partial class HomePage
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
            this.BtnCrypto = new System.Windows.Forms.Button();
            this.BtnDeCrypto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCrypto
            // 
            this.BtnCrypto.Location = new System.Drawing.Point(26, 29);
            this.BtnCrypto.Name = "BtnCrypto";
            this.BtnCrypto.Size = new System.Drawing.Size(200, 150);
            this.BtnCrypto.TabIndex = 0;
            this.BtnCrypto.Text = "Şifrele";
            this.BtnCrypto.UseVisualStyleBackColor = true;
            this.BtnCrypto.Click += new System.EventHandler(this.BtnCrypto_Click);
            // 
            // BtnDeCrypto
            // 
            this.BtnDeCrypto.Location = new System.Drawing.Point(272, 29);
            this.BtnDeCrypto.Name = "BtnDeCrypto";
            this.BtnDeCrypto.Size = new System.Drawing.Size(200, 150);
            this.BtnDeCrypto.TabIndex = 1;
            this.BtnDeCrypto.Text = "Şifre Çöz";
            this.BtnDeCrypto.UseVisualStyleBackColor = true;
            this.BtnDeCrypto.Click += new System.EventHandler(this.BtnDeCrypto_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.BtnDeCrypto);
            this.Controls.Add(this.BtnCrypto);
            this.Name = "HomePage";
            this.Text = "AESCrypto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCrypto;
        private System.Windows.Forms.Button BtnDeCrypto;
    }
}

