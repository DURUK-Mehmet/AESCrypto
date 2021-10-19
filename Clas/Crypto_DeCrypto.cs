using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace AESCrypto.Clas
{
    class Crypto_DeCrypto
    {
        private const string Aes_IV = @"EE5m29u7P8bqzvZ1";
        private string Aes_Key = @"nzky1YqrgSGCUeer544zdeSWxq1Cf3UV";
        AesCryptoServiceProvider AesSaglayici = new AesCryptoServiceProvider();
        public string AESSifrele(string metin,int Tip)
        {
            AesSaglayici.BlockSize = 128;
            AesSaglayici.KeySize = 128;

            AesSaglayici.IV = Encoding.UTF8.GetBytes(Aes_IV);
            AesSaglayici.Key = Encoding.UTF8.GetBytes(Aes_Key);
            AesSaglayici.Mode = CipherMode.CFB;

            byte[] kaynak = Encoding.Unicode.GetBytes(metin);
            using (ICryptoTransform cryptoTransform = AesSaglayici.CreateEncryptor())
            {
                byte[] hedef = cryptoTransform.TransformFinalBlock(kaynak, 0, kaynak.Length);
                return Convert.ToBase64String(hedef);
            }

        }
        public string AESSifre_Coz(string metin, int Tip) 
        {
            AesSaglayici.BlockSize = 128;
            AesSaglayici.KeySize = 128;

            AesSaglayici.IV = Encoding.UTF8.GetBytes(Aes_IV);
            AesSaglayici.Key = Encoding.UTF8.GetBytes(Aes_Key);
            AesSaglayici.Mode = CipherMode.CFB;
            AesSaglayici.Padding = PaddingMode.PKCS7;

            byte[] kaynak = System.Convert.FromBase64String(metin);
            using (ICryptoTransform cryptoTransform = AesSaglayici.CreateDecryptor())
            {
                byte[] hedef = cryptoTransform.TransformFinalBlock(kaynak, 0, kaynak.Length);
                return Encoding.Unicode.GetString(hedef);
            }
        }
    }
}
