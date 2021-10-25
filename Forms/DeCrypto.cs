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
    public partial class DeCrypto : Form
    {
        Crypto_DeCrypto crypto_deCrypto = new Crypto_DeCrypto();
        OpenFileDialog file = new OpenFileDialog();

        public DeCrypto()
        {
            InitializeComponent();
        }
        public string DosyadanOku(string dosya_yolu)
        {
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            
            StreamReader sw = new StreamReader(fs);
            
            string yazi = sw.ReadLine();
            
            sw.Close();
            fs.Close();
            
            return yazi;
        }
        private void BtnSifreCoz_Click(object sender, EventArgs e)
        {
            int tip;
            if (radioButton128.Checked == true)
            {
                tip = 128;
            }
            else if (radioButton256.Checked == true)
            {
                tip = 256;
            }
            else { tip = 128; }
            TxtCozOut.Text = crypto_deCrypto.AESSifre_Coz(TxtCozIn.Text, tip);
        }

        private void BtnFileOpen_Click(object sender, EventArgs e)
        {
            file.ShowDialog();
            string dosya_yolu = file.FileName;
            TxtCozIn.Text=DosyadanOku(dosya_yolu);
        }
    }
}
