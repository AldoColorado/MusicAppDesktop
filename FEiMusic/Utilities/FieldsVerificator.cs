using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Threading.Tasks;
using FEiMusic.View;

namespace FEiMusic.Utilities
{
    internal class FieldsVerificator
    {
        public static bool VerificateEmail(string email)
        {
            string emailFormat = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, emailFormat))
                return true;
            else
            {
                return false;
            }
        }

        public static bool VerificateEmpty(string cadena)
        {
            if(cadena != "")
            {
                return true;
            }
            else
            {   
                return false;
            }
        }

        public static bool VerificateName(string name)
        {
            Regex rgx = new Regex(@"^[a-zA-ZÀ-ÿ\u00f1\u00d1\s]+$");
            if (rgx.IsMatch(name))
                return true;
            else
            {
                return false;
            }
        }

    }
}
