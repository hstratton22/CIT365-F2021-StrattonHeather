using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity
{
    public class Utility
    {
        public static string GetLastChars(byte[] token)
        {
            return token[7].ToString();
            // return token.ToString().Substring(
            //token.ToString().Length - 3);// if using SQLiteVersion
        }
    }
}
