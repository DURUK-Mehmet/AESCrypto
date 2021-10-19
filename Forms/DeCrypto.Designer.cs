
namespace AESCrypto.Forms
{
    partial class DeCrypto
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
            this.BtnSifreCoz = new System.Windows.Forms.Button();
            this.TxtCozIn = new System.Windows.Forms.TextBox();
            this.TxtCozOut = new System.Windows.Forms.TextBox();
            this.radioButton128 = new System.Windows.Forms.RadioButton();
            this.radioButton256 = new System.Windows.Forms.RadioButton();
            this.BtnFileOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSifreCoz
            // 
            this.BtnSifreCoz.Location = new System.Drawing.Point(548, 12);
            this.BtnSifreCoz.Name = "BtnSifreCoz";
            this.BtnSifreCoz.Size = new System.Drawing.Size(117, 23);
            this.BtnSifreCoz.TabIndex = 0;
            this.BtnSifreCoz.Text = "Şifreli Metni Dönüştür";
            this.BtnSifreCoz.UseVisualStyleBackColor = true;
            this.BtnSifreCoz.Click += new System.EventHandler(this.BtnSifreCoz_Click);
            // 
            // TxtCozIn
            // 
            this.TxtCozIn.Location = new System.Drawing.Point(0, 104);
            this.TxtCozIn.Multiline = true;
            this.TxtCozIn.Name = "TxtCozIn";
            this.TxtCozIn.Size = new System.Drawing.Size(398, 346);
            this.TxtCozIn.TabIndex = 1;
            // 
            // TxtCozOut
            // 
            this.TxtCozOut.Location = new System.Drawing.Point(421, 104);
            this.TxtCozOut.Multiline = true;
            this.TxtCozOut.Name = "TxtCozOut";
            this.TxtCozOut.Size = new System.Drawing.Size(380, 346);
            this.TxtCozOut.TabIndex = 2;
            // 
            // radioButton128
            // 
            this.radioButton128.AutoSize = true;
            this.radioButton128.Location = new System.Drawing.Point(362, 18);
            this.radioButton128.Name = "radioButton128";
            this.radioButton128.Size = new System.Drawing.Size(98, 17);
            this.radioButton128.TabIndex = 3;
            this.radioButton128.TabStop = true;
            this.radioButton128.Text = "128 Bit Şifrleme";
            this.radioButton128.UseVisualStyleBackColor = true;
            // 
            // radioButton256
            // 
            this.radioButton256.AutoSize = true;
            this.radioButton256.Location = new System.Drawing.Point(362, 58);
            this.radioButton256.Name = "radioButton256";
            this.radioButton256.Size = new System.Drawing.Size(98, 17);
            this.radioButton256.TabIndex = 4;
            this.radioButton256.TabStop = true;
            this.radioButton256.Text = "256 Bit Şifrleme";
            this.radioButton256.UseVisualStyleBackColor = true;
            // 
            // BtnFileOpen
            // 
            this.BtnFileOpen.Location = new System.Drawing.Point(158, 18);
            this.BtnFileOpen.Name = "BtnFileOpen";
            this.BtnFileOpen.Size = new System.Drawing.Size(98, 23);
            this.BtnFileOpen.TabIndex = 5;
            this.BtnFileOpen.Text = "Dosya Seç";
            this.BtnFileOpen.UseVisualStyleBackColor = true;
            this.BtnFileOpen.Click += new System.EventHandler(this.BtnFileOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(167, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Metin Girişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(571, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Metin Çıkışı";
            // 
            // DeCrypto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFileOpen);
            this.Controls.Add(this.radioButton256);
            this.Controls.Add(this.radioButton128);
            this.Controls.Add(this.TxtCozOut);
            this.Controls.Add(this.TxtCozIn);
            this.Controls.Add(this.BtnSifreCoz);
            this.Name = "DeCrypto";
            this.Text = "DeCrypto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSifreCoz;
        private System.Windows.Forms.TextBox TxtCozIn;
        private System.Windows.Forms.TextBox TxtCozOut;
        private System.Windows.Forms.RadioButton radioButton128;
        private System.Windows.Forms.RadioButton radioButton256;
        private System.Windows.Forms.Button BtnFileOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}