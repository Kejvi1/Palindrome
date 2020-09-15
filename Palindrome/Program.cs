using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            bool istrue = false;
            Console.WriteLine("Vendosni fjalen:");
            string fjala = Console.ReadLine().ToString();
            if (fjala != null)
            {
                foreach (var chr1 in fjala.Reverse())
                {
                    foreach (var chr in fjala)
                    {
                        if (chr.Equals(chr1))
                        {
                            istrue = true;
                        }
                        else istrue = false;
                    }
                }
                if (istrue)
                {
                    Console.WriteLine("Fjala e vendosur eshte palindrome!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Fjala e vendosur nuk eshte palindrome!");
                    Console.ReadKey();
                }

            }
        }
    }
}
