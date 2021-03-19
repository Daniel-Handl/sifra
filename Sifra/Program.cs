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
            bool incorrect = true;
            string o;
            bool choice = false;
            Console.WriteLine("pokud chceš zašifrovat tak napiš 1 pokud chceš dešifrovat napiš 2 :");
            do
            {   
                o = Console.ReadLine();
                if (o == "1")
                {
                    choice = false;
                    incorrect = false;
                }
                else if (o == "2")
                {
                    choice = true;
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Zkus to znova: ");
                    incorrect = true;
                }
            } while (incorrect);
            Console.Write("text na zasifrování: ");
            string s = Console.ReadLine();
            string xor;
            string caesar;
            int ckey = 7;
            string xkey = "PRAVDA";

            Console.WriteLine(XORSifra(s, xkey));
            Console.WriteLine(CaesarSifra(s, ckey, choice));
            Console.ReadLine();
        }

        private static string CaesarSifra(string s, int key, bool choice)
        {
            string coded = "";
            if (choice)
            {
                key = -key;
            }
            foreach (char ch in s)
            {
                if (ch == 'z' | ch == 'Z')
                {
                    coded += Convert.ToChar(Convert.ToInt32(ch) + key - 26);
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
                skey += key.Substring(fch, 1);
                if (fch == key.Length - 1)
                {
                    fch = 0;
                }
                else
                {
                    fch++;
                }
            }
            fch = 0;
            foreach (char ch in s)
            {
                coded += Convert.ToChar(Convert.ToInt32(ch)^Convert.ToInt32(Convert.ToChar(skey.Substring(fch,1))));
                fch++;
            }
            return coded;
        }
    }
}
