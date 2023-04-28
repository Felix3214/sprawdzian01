using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzian01.folderek
{
    public static class Szyfrowanie
    {
        private static Dictionary<char, char> alfabet = new Dictionary<char, char>
        {
       {'A', 'G'},
        {'B', 'A'},
        {'C', 'D'},
        {'D', 'E'},
        {'E', 'R'},
        {'F', 'Y'},
        {'G', 'P'},
        {'H', 'O'},
        {'I', 'L'},
        {'J', 'U'},
        {'K', 'K'},
        {'L', 'I'},
        {'M', '3'},
        {'N', 'J'},
        {'O', 'Z'},
        {'P', 'S'},
        {'R', 'C'},
        {'S', 'B'},
        {'T', 'T'},
        {'U', 'F'},
        {'V', '7'},
        {'W', 'N'},
        {'Y', 'M'},
        {'Z', '6'},

        };
        public static string ZaszyfrujGADERYPOLUKI(string tekst)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in tekst)
            {
                if (alfabet.ContainsKey(c))
                {
                    sb.Append(alfabet[c]);
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }

        public static string OdszyfrujGADERYPOLUKI(string szyfr)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in szyfr)
            {
                bool znaleziono = false;

                foreach (KeyValuePair<char, char> para in alfabet)
                {
                    if (c == para.Value)
                    {
                        sb.Append(para.Key);
                        znaleziono = true;
                        break;
                    }
                }

                if (!znaleziono)
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}

    




