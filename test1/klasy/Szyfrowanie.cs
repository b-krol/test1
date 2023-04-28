using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1.klasy
{
    internal static class Szyfrowanie
    {
        private static string[] szyfr = new string[] { "g", "a", "d", "e", "r", "y", "p", "o", "l", "u", "k", "i", "G", "A", "D", "E", "R", "Y", "P", "O", "L", "U", "K", "I" };


        public static string zaszyfrujGADERYPOLUKI(string text)
        {
            bool x = false;
            List<string> list = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                list.Add(text.Substring(i, 1));
            }
            text = String.Empty;
            foreach (string s in list)
            {
                x = false;
                for(int i = 0; i < szyfr.Length; i++)
                {
                    if (szyfr[i] == s)
                    {
                        if (i % 2 == 0) text += szyfr[i + 1];
                        else text += szyfr[i - 1];
                        x = true;
                        break;
                    }
                }
                if (x == true) continue;
                else text += s;
            }
            return text;
        }

        public static string odszyfrujGADERYPOLUKI(string text)
        {
            return zaszyfrujGADERYPOLUKI(text);
        }
    }
}
