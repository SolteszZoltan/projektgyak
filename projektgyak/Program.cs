using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektgyak
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //adatszerkezet
            List<string> e_mailok = new List<string>();
            e_mailok.Add("alma@kört.hu");
            e_mailok.Add("alma2.dfdfdf.hu");
            e_mailok.Add("alma3@ssdsds.hu");
            e_mailok.Add("deak.csaba@kkszki.hu");
            e_mailok.Add("alma.korte@alma.hu");
            //menüvezérlés 
            while (true)
            {
                Console.Clear();
                Console.WriteLine("0. Kilépés");
                Console.WriteLine("1. emailek listázása");
                Console.WriteLine("2. új email");
                Console.WriteLine("3. email törlése");
                Console.WriteLine("4. érvényes emailek listázása");

                string valasztas = Console.ReadLine();
                switch (valasztas)
                {
                    case "0" : return;
                    case "1" :  
                        Console.Clear();
                        Console.WriteLine("e-mail címet");
                        int sorszam = 0;
                            foreach(string e_mail in e_mailok)
                        {
                            Console.WriteLine($"{sorszam++}. {e_mail}");
                            
                        }
                        break;
                    case "2": Console.WriteLine("Adja meg az új email címet:");
                        string uj_email = Console.ReadLine();
                        e_mailok.Add(uj_email);
                        break;
                    case "3": Console.WriteLine("email törlése"); break;
                    case "4": Console.WriteLine("érvényes listázása"); break;
                    default: Console.WriteLine("rossz parancs"); break;
                }
                Console.ReadLine();
            }
        }
    }
}
