using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesESpeciales.Helper
{
   public class GeneraMd5
    {
       public static GeneraMd5 instancia = new GeneraMd5();

        public string md5(string password)
        {
            System.Security.Cryptography.MD5 md5;
            md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            Byte[] encodedBytes = md5.ComputeHash(ASCIIEncoding.Default.GetBytes(password));
            return System.Text.RegularExpressions.Regex.Replace(BitConverter.ToString(encodedBytes).ToLower(), @"-", "");
        }

    }
}
