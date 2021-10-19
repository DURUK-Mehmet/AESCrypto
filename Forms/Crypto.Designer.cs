
namespace AESCrypto.Forms
{
    partial class Crypto
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
            this.TxtIn = new System.Windows.Forms.TextBox();
            this.BtnSifrele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton128 = new System.Windows.Forms.RadioButton();
            this.radioButton256 = new System.Windows.Forms.RadioButton();
            this.TxtOut = new System.Windows.Forms.TextBox();
            this.BtnFileCreat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtIn
            // 
            this.TxtIn.Location = new System.Drawing.Point(0, 0);
            this.TxtIn.Multiline = true;
            this.TxtIn.Name = "TxtIn";
            this.TxtIn.Size = new System.Drawing.Size(630, 221);
            this.TxtIn.TabIndex = 0;
            // 
            // BtnSifrele
            // 
            this.BtnSifrele.Location = new System.Drawing.Point(660, 215);
            this.BtnSifrele.Name = "BtnSifrele";
            this.BtnSifrele.Size = new System.Drawing.Size(105, 40);
            this.BtnSifrele.TabIndex = 3;
            this.BtnSifrele.Text = "Şifrele";
            this.BtnSifrele.UseVisualStyleBackColor = true;
            this.BtnSifrele.Click += new System.EventHandler(this.BtnSifrele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(640, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Şifreleme Biçimini Seçin";
            // 
            // radioButton128
            // 
            this.radioButton128.AutoSize = true;
            this.radioButton128.Location = new System.Drawing.Point(661, 109);
            this.radioButton128.Name = "radioButton128";
            this.radioButton128.Size = new System.Drawing.Size(104, 17);
            this.radioButton128.TabIndex = 5;
            this.radioButton128.TabStop = true;
            this.radioButton128.Text = "128 Bit Şifreleme";
            this.radioButton128.UseVisualStyleBackColor = true;
            // 
            // radioButton256
            // 
            this.radioButton256.AutoSize = true;
            this.radioButton256.Location = new System.Drawing.Point(661, 151);
            this.radioButton256.Name = "radioButton256";
            this.radioButton256.Size = new System.Drawing.Size(104, 17);
            this.radioButton256.TabIndex = 6;
            this.radioButton256.TabStop = true;
            this.radioButton256.Text = "256 Bit Şifreleme";
            this.radioButton256.UseVisualStyleBackColor = true;
            // 
            // TxtOut
            // 
            this.TxtOut.Location = new System.Drawing.Point(0, 225);
            this.TxtOut.Multiline = true;
            this.TxtOut.Name = "TxtOut";
            this.TxtOut.Size = new System.Drawing.Size(630, 221);
            this.TxtOut.TabIndex = 7;
            // 
            // BtnFileCreat
            // 
            this.BtnFileCreat.Location = new System.Drawing.Point(661, 274);
            this.BtnFileCreat.Name = "BtnFileCreat";
            this.BtnFileCreat.Size = new System.Drawing.Size(105, 40);
            this.BtnFileCreat.TabIndex = 8;
            this.BtnFileCreat.Text = "Şifreyi Çıkart";
            this.BtnFileCreat.UseVisualStyleBackColor = true;
            this.BtnFileCreat.Click += new System.EventHandler(this.BtnFileCreat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lütfen metin belgenizi oluşturduktan sonra bu işlemi uygulayınız";
            // 
            // Crypto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnFileCreat);
            this.Controls.Add(this.TxtOut);
            this.Controls.Add(this.radioButton256);
            this.Controls.Add(this.radioButton128);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSifrele);
            this.Controls.Add(this.TxtIn);
            this.Name = "Crypto";
            this.Text = "Crypto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIn;
        private System.Windows.Forms.Button BtnSifrele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton128;
        private System.Windows.Forms.RadioButton radioButton256;
        private System.Windows.Forms.TextBox TxtOut;
        private System.Windows.Forms.Button BtnFileCreat;
        private System.Windows.Forms.Label label2;
    }
}