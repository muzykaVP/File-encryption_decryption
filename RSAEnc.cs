using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace File_encryption_decryption
{
    class RSAEnc
    {
        //private static RSAEnc instance;
        //public static RSAEnc GetInstance()
        //{
        //    if (instance == null)
        //    {
        //        instance = new RSAEnc();
        //    }
        //    return instance;
        //}



        /// <summary>
        /// ////////////////////////////////////////////////////////
        /// </summary>
       
        public void EncryptFileRSA(string filePath, string publicKeyPath)
        {
            try
            {
                RSACryptoServiceProvider rSA = new RSACryptoServiceProvider();
                rSA.FromXmlString(File.ReadAllText(publicKeyPath));
                byte[] fileBytes = File.ReadAllBytes(filePath);
                byte[] encBytes = rSA.Encrypt(fileBytes, false);
                File.WriteAllBytes(filePath, encBytes);
                MessageBox.Show("Файл успішно зашифровано.", "Успіх!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!");
            }
        }
        public void DecryptFileRSA(string filePath, string privateKeyPath)
        {
            try
            {
                RSACryptoServiceProvider rSA = new RSACryptoServiceProvider();
                rSA.FromXmlString(File.ReadAllText(privateKeyPath));
                byte[] fileBytes = File.ReadAllBytes(filePath);
                byte[] decBytes = rSA.Decrypt(fileBytes, false);
                File.WriteAllBytes(filePath, decBytes);
                MessageBox.Show("Файл успішно розшифровано.", "Успіх!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!");
            }
        }




        //RSACryptoServiceProvider rSA = new RSACryptoServiceProvider();
        //RSAParameters privateKey;
        //RSAParameters publicKey;
        //public RSAEnc()
        //{
        //    try
        //    {
        //        privateKey = rSA.ExportParameters(true);
        //        publicKey = rSA.ExportParameters(false);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Помилка!");
        //    }
        //}


        //public void EncryptFileRSA(string filePath)
        //{
        //    try
        //    {
        //        using (rSA = new RSACryptoServiceProvider())
        //        {
        //            rSA.ImportParameters(publicKey);
        //            byte[] fileBytes = File.ReadAllBytes(filePath);
        //            byte[] encBytes = rSA.Encrypt(fileBytes, false);
        //            File.WriteAllBytes(filePath, encBytes);
        //            MessageBox.Show("Файл успішно зашифровано.", "Успіх!");
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Помилка!");
        //    }

        //}
        //public void DecryptFileRSA(string filePath)
        //{
        //    try
        //    {
        //        byte[] fileBytes = File.ReadAllBytes(filePath);
        //        rSA.ImportParameters(privateKey);
        //        byte[] encBytes = rSA.Decrypt(fileBytes, false);
        //        File.WriteAllBytes(filePath, encBytes);
        //        MessageBox.Show("Файл успішно розшифровано.", "Успіх!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Помилка!");
        //    }
        //}







    }
}
