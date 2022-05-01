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
    class AES
    {
        public void EncryptFileAES(string strKey, string bytesToEnc, string strSalt)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(strKey);
            byte[] saltBytes = string.IsNullOrEmpty(strSalt) ? new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 } : Encoding.UTF8.GetBytes(strSalt);
            byte[] txtBytes;

            try
            {
                using (MemoryStream memory = new MemoryStream())
                {
                    using (RijndaelManaged aes = new RijndaelManaged())
                    {
                        aes.Mode = CipherMode.CBC;
                        aes.Padding = PaddingMode.PKCS7;
                        aes.KeySize = 256;
                        aes.BlockSize = 128;

                        Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(keyBytes, saltBytes, 2000);
                        aes.Key = key.GetBytes(aes.KeySize / 8);
                        aes.IV = key.GetBytes(aes.BlockSize / 8);
                        using (CryptoStream ICrypto = new CryptoStream(memory, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            txtBytes = File.ReadAllBytes(bytesToEnc);
                            ICrypto.Write(txtBytes, 0, txtBytes.Length);
                            ICrypto.FlushFinalBlock();
                        }
                    }
                    File.WriteAllBytes(bytesToEnc, memory.ToArray());
                    MessageBox.Show("Файл успішно зашифровано.", "Успіх!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Помилка!");
            }
        }
        public void DecryptFileAES(string strKey, string bytesToDec, string strSalt)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(strKey);
            byte[] saltBytes = string.IsNullOrEmpty(strSalt) ? new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 } : Encoding.UTF8.GetBytes(strSalt);
            byte[] txtBytes;

            try
            {
                using (MemoryStream memory = new MemoryStream())
                {
                    using (RijndaelManaged aes = new RijndaelManaged())
                    {
                        aes.Mode = CipherMode.CBC;
                        aes.Padding = PaddingMode.PKCS7;
                        aes.KeySize = 256;
                        aes.BlockSize = 128;

                        Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(keyBytes, saltBytes, 2000);
                        aes.Key = key.GetBytes(aes.KeySize / 8);
                        aes.IV = key.GetBytes(aes.BlockSize / 8);
                        using (CryptoStream ICrypto = new CryptoStream(memory, aes.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            txtBytes = File.ReadAllBytes(bytesToDec);
                            ICrypto.Write(txtBytes, 0, txtBytes.Length);
                            ICrypto.FlushFinalBlock();
                        }
                    }
                    File.WriteAllBytes(bytesToDec, memory.ToArray());
                    MessageBox.Show("Файл успішно розшифровано.", "Успіх!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!");
            }
        }
        //public byte[] EncryptFileAES(string strKey, byte[] txtBytes, string strSalt)
        //{
        //    byte[] keyBytes = Encoding.UTF8.GetBytes(strKey);
        //    byte[] saltBytes = null;
        //    saltBytes = string.IsNullOrEmpty(strSalt) ? new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 } : Encoding.UTF8.GetBytes(strSalt);
        //    byte[] encryptedFileBites = null;

        //    try
        //    {
        //        using (MemoryStream memory = new MemoryStream())
        //        {
        //            using (RijndaelManaged aes = new RijndaelManaged())
        //            {
        //                aes.Mode = CipherMode.CBC;
        //                aes.Padding = PaddingMode.PKCS7;
        //                aes.KeySize = 256;
        //                aes.BlockSize = 128;

        //                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(keyBytes, saltBytes, 2000);
        //                aes.Key = key.GetBytes(aes.KeySize / 8);
        //                aes.IV = key.GetBytes(aes.BlockSize / 8);
        //                using (var ICrypto = new CryptoStream(memory, aes.CreateEncryptor(), CryptoStreamMode.Write))
        //                {
        //                    ICrypto.Write(txtBytes, 0, txtBytes.Length);
        //                    ICrypto.FlushFinalBlock();
        //                }
        //            }
        //            encryptedFileBites = memory.ToArray();
        //        }
        //        return encryptedFileBites;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

        //public byte[] DecryptFileAES(string strKey, string bytesToDec, string strSalt)
        //{
        //    byte[] keyBytes = Encoding.UTF8.GetBytes(strKey);
        //    byte[] saltBytes = null;
        //    saltBytes = string.IsNullOrEmpty(strSalt) ? new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 } : Encoding.UTF8.GetBytes(strSalt);
        //    byte[] encryptedFileBites = null;

        //    try
        //    {
        //        using (MemoryStream memory = new MemoryStream())
        //        {
        //            using (RijndaelManaged aes = new RijndaelManaged())
        //            {
        //                aes.Mode = CipherMode.CBC;
        //                aes.Padding = PaddingMode.PKCS7;
        //                aes.KeySize = 256;
        //                aes.BlockSize = 128;

        //                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(keyBytes, saltBytes, 2000);
        //                aes.Key = key.GetBytes(aes.KeySize / 8);
        //                aes.IV = key.GetBytes(aes.BlockSize / 8);
        //                using (var ICrypto = new CryptoStream(memory, aes.CreateDecryptor(), CryptoStreamMode.Write))
        //                {
        //                    ICrypto.Write(txtBytes, 0, txtBytes.Length);
        //                    ICrypto.FlushFinalBlock();
        //                }

        //            }
        //            encryptedFileBites = memory.ToArray();
        //        }
        //        return encryptedFileBites;
        //    }
        //    catch
        //    {

        //        return null;
        //    }
        //}






    }
}
