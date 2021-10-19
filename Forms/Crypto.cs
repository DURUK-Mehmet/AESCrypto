using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AESCrypto.Clas;

namespace AESCrypto.Forms
{
    public partial class Crypto : Form
    {
        Crypto_DeCrypto crypto_deCrypto = new Crypto_DeCrypto();
        OpenFileDialog file = new OpenFileDialog();
        public Crypto()
        {
            InitializeComponent();
        }
        
        private void BtnSifrele_Click(object sender, EventArgs e)
        {
            int tip;
            if (radioButton128.Checked==true)
            {
                tip = 128;
            }
            else if (radioButton256.Checked==true)
            {
                tip = 256;
            }
            else { tip = 128; }
            TxtOut.Text=crypto_deCrypto.AESSifrele(TxtIn.Text,tip);
        }

        private void BtnFileCreat_Click(object sender, EventArgs e)
        {
            file.ShowDialog();
            string dosya_yolu = file.FileName;
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(TxtOut.Text);
            sw.Close();
        }
    }
}
