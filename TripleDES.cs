using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace File_encryption_decryption
{
    class TripleDES
    {
        private TripleDESCryptoServiceProvider tDESp = new TripleDESCryptoServiceProvider();
        public TripleDES(string key)
        {
            try
            {
                tDESp.Key = Encoding.UTF8.GetBytes(key);
                tDESp.Mode = CipherMode.ECB;
                tDESp.Padding = PaddingMode.PKCS7;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!");
            }
        }
        public void EncryptFileTDES(string filePath)
        {
            try
            {
                byte[] fileBytes = File.ReadAllBytes(filePath);
                byte[] encBytes = tDESp.CreateEncryptor().TransformFinalBlock(fileBytes, 0, fileBytes.Length);
                File.WriteAllBytes(filePath, encBytes);
                MessageBox.Show("Файл успішно зашифровано.", "Успіх!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!");
            }
            
        }
        public void DecryptFileTDES(string filePath)
        {
            try
            {
                byte[] fileBytes = File.ReadAllBytes(filePath);
                byte[] decBytes = tDESp.CreateDecryptor().TransformFinalBlock(fileBytes, 0, fileBytes.Length);
                File.WriteAllBytes(filePath, decBytes);
                MessageBox.Show("Файл успішно розшифровано.", "Успіх!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!");
            }
        }


    }
}
