using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace File_encryption_decryption
{
    class DataEncS
    {
        DESCryptoServiceProvider dES = new DESCryptoServiceProvider();
        public DataEncS(string key)
        {
            try
            {
                dES.Key = Encoding.UTF8.GetBytes(key);
                dES.Mode = CipherMode.ECB;
                dES.Padding = PaddingMode.PKCS7;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!");
            }
        }
        //public void EncryptFileDES(string source, string destination, string key)
        //{
        //    try
        //    {
        //        using (FileStream fileStream = new FileStream(source, FileMode.Open, FileAccess.Read))
        //        {
        //            using (FileStream fsEncrypted = new FileStream(destination, FileMode.Create, FileAccess.Write))
        //            {
        //                dES.Key = Encoding.ASCII.GetBytes(key);
        //                dES.IV = Encoding.ASCII.GetBytes(key);
        //                ICryptoTransform cryptoTransform = dES.CreateEncryptor();
        //                using (CryptoStream cryptoStream = new CryptoStream(fsEncrypted, cryptoTransform, CryptoStreamMode.Write))
        //                {
        //                    byte[] byteArrayInp = new byte[fileStream.Length - 0];
        //                    fileStream.Read(byteArrayInp, 0, byteArrayInp.Length);
        //                    cryptoStream.Write(byteArrayInp, 0, byteArrayInp.Length);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Помилка!");
        //        return;
        //    }

        //}



        //public void DecryptFileDES(string source, string destination, string key)
        //{
        //    try
        //    {
        //        using (FileStream fileStream = new FileStream(source, FileMode.Open, FileAccess.Read))
        //        {
        //            using (FileStream fsEncrypted = new FileStream(destination, FileMode.Create, FileAccess.Write))
        //            {
        //                dES.Key = Encoding.ASCII.GetBytes(key);
        //                dES.IV = Encoding.ASCII.GetBytes(key);
        //                ICryptoTransform cryptoTransform = dES.CreateDecryptor();
        //                using (CryptoStream cryptoStream = new CryptoStream(fsEncrypted, cryptoTransform, CryptoStreamMode.Write))
        //                {
        //                    byte[] byteArrayInp = new byte[fileStream.Length - 0];
        //                    fileStream.Read(byteArrayInp, 0, byteArrayInp.Length);
        //                    cryptoStream.Write(byteArrayInp, 0, byteArrayInp.Length);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Помилка!");
        //        return;
        //    }
        //}


        public void EncryptFileDES(string filePath)
        {
            try
            {
                byte[] fileBytes = File.ReadAllBytes(filePath);
                byte[] encBytes = dES.CreateEncryptor().TransformFinalBlock(fileBytes, 0, fileBytes.Length);
                File.WriteAllBytes(filePath, encBytes);
                MessageBox.Show("Файл успішно зашифровано.", "Успіх!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!");
                return;
            }
        }

        public void DecryptFileDES(string filePath)
        {
            try
            {
                byte[] fileBytes = File.ReadAllBytes(filePath);
                byte[] encBytes = dES.CreateDecryptor().TransformFinalBlock(fileBytes, 0, fileBytes.Length);
                File.WriteAllBytes(filePath, encBytes);
                MessageBox.Show("Файл успішно розшифровано.", "Успіх!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!");
                return;
            }
        }




    }
}

