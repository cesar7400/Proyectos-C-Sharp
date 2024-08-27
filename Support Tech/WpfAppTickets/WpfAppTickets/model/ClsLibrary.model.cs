using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfAppTickets.model
{
    public class ClsLibraryModel
    {
        private string strEncrypt = "";
        private string strDecrypt = "";
        private string passUnique = "WpfAppTickets";
        private TripleDESCryptoServiceProvider descp = new TripleDESCryptoServiceProvider();
        private MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

        public string Encrypt(string text)
        {
            if (text == "")
            {
                strEncrypt = "";
            }
            else
            {
                descp.Key = md5.ComputeHash((new UnicodeEncoding()).GetBytes(passUnique));
                descp.Mode = CipherMode.ECB;
                ICryptoTransform cryptoTransform = descp.CreateEncryptor();
                byte[] buff = UnicodeEncoding.ASCII.GetBytes(text);
                strEncrypt = Convert.ToBase64String(cryptoTransform.TransformFinalBlock(buff, 0, buff.Length));
            }
            return strEncrypt;
        }
        public string Decrypt(string text)
        {
            if (text == "")
            {
                strDecrypt = "";
            }
            else
            {
                descp.Key = md5.ComputeHash((new UnicodeEncoding()).GetBytes(passUnique));
                descp.Mode = CipherMode.ECB;
                ICryptoTransform decryptoTransform = descp.CreateDecryptor();
                byte[] buff = Convert.FromBase64String(text);
                strDecrypt = UnicodeEncoding.ASCII.GetString(decryptoTransform.TransformFinalBlock(buff, 0, buff.Length));
            }
            return strDecrypt;
        }
        //expresión regular para validar correo
        public bool isValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }
            string pattern = @"^[\w!#$%&'*+/=?^_`{|}~-]+(?:\.[\w!#$%&'*+/=?^_`{|}~-]+)*@(?:[\w](?:[\w-]*[\w])?\.)+[\w](?:[\w-]*[\w])?$";
            Match match = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            if (!match.Success)
            {
                return false;
            }
            return true;
        }

        public void FormatMask(TextBox text,string mask, string val = "")
        {
            //Elimina cualquier carácter que no sea un dígito de la entrada
            string input = Regex.Replace(text.Text, @"\D", "");
            //Formatee la entrada según la máscara
            string formattedInput = "";
            int index = 0;
            if (val == "")
            {
                input = input.Remove(0, 2);
            }
            foreach (char maskChar in mask)
            {
                if (maskChar == '0' && index < input.Length)
                {
                    formattedInput += input[index];
                    index++;
                }
                else
                {
                    formattedInput += maskChar;
                }
            }
            //Establecer la entrada formateada en TextBox
            text.Text = val != "" ? $"({val})"+" "+formattedInput : formattedInput;
        }
    }
}
