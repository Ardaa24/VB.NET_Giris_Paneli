using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris_Panel
{
    internal class Cryptology
    {
       public  static string Encryption(string text, int key)
        {
            char[] cry = text.ToCharArray();
            string encryptedText = "";
            foreach (char item in cry)
            {
                encryptedText+= Convert.ToChar(item + key).ToString();
            }
            return encryptedText;
        }

        public static string Decryption(string text, int key)
        {
            char[] cry = text.ToCharArray();
            string decryptedText = "";
            foreach (char item in cry)
            {
                decryptedText += Convert.ToChar(item - key).ToString();
            }
            return decryptedText;
        }

    }
}
