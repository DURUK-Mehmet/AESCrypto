using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AESCrypto.Forms;


namespace AESCrypto
{
    public partial class HomePage : Form
    {
        Crypto aesCrypto = new Crypto();
        DeCrypto aesDeCrypto = new DeCrypto();
        public HomePage()
        {
            InitializeComponent();
        }

        private void BtnCrypto_Click(object sender, EventArgs e)
        {
            aesCrypto.Show();
        }

        private void BtnDeCrypto_Click(object sender, EventArgs e)
        {
            aesDeCrypto.Show();
        }
    }
}
