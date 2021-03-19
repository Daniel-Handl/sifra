using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sifry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("text na zasifrování: ");
            string s = Console.ReadLine();
            string xor;
            string caesar;
            int ckey = 7;
            string xkey = "PRAVDA";

            Console.WriteLine(XORSifra(s, xkey));
            Console.WriteLine(CaesarSifra(s, ckey)); 
        }

        private static string CaesarSifra(string s, int key)
        {
            string coded = "";
            foreach (char ch in s)
            {
                if (ch == 'z' | ch == 'Z')
                {
                    coded += Convert.ToChar(Convert.ToInt32(ch) + key-26);
                }
                else
                {
                coded += Convert.ToChar(Convert.ToInt32(ch) + key);
                }
            }

            return coded;
        }

        private static string XORSifra(string s, string key)
        {
            string coded = "";
            string skey = "";
            int fch = 0;
            foreach (char ch in s)
	        {
                skey  += key.Substring(fch,1);
                if (fch = key.Length-1)
	            {
                    fch = 0;
	            }
                else
	            {
                    fch++;
	            }
	        }

            return coded;
        }
    }
}
