using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            for (; ; )
            {
                Console.WriteLine("Adınızı Giriniz:");
                a = Console.ReadLine();
                foreach (char b in a)
                    Console.Write((char)(b + 10));
                Console.WriteLine();
                Console.WriteLine("Sıfırlamak için herhangi bir tuşa basın.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
