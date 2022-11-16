using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Task1
{
    interface IChiper
    {
        string Encod(string s);
        string Decod(string s);
    }
    class AChuper : IChiper
    {
        public string Decod(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                if (c >= 'B' && c <= 'Z')
                    result += (char)((int)c + 1);

                else if (c == 'A')
                    result += 'Z';
                else
                    result += c;
            }
            return result;
        }

        public string Encod(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                if (c >= 'A' && c <= 'Y')
                    result += (char)((int)c + 1);

                else if (c == 'Z')
                    result += 'A';
                else
                    result += c;
            }
            return result;
        }
    }

    class BChuper : IChiper
    {
        public string Decod(string s)
        {
            return Encod(s); 
        }

        public string Encod(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                int num = (int)c - (int)'A';
                if (c >= 'A' && c <= 'Z')
                    result += (char)((int)'Z' - num);
                else
                    result += c;
            }
            return result;
        }
    }
}
