using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3 { 

    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a, b;
            Console.WriteLine("Proszę podać boki jednego kwadrata: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Prosze podać boki drugiego kwadrata: ");
            b = int.Parse(Console.ReadLine());
            a = a * a;
            b = b * b;
            Console.WriteLine("suma kwadratów równa się: ");
            Console.WriteLine(a + b);*/


            /*Console.WriteLine("Proszę podać liczbę x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Proszę podać liczbę y");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Proszę podać liczbę z");
            int z = int.Parse(Console.ReadLine());

            if (x >= y && y >= z) Console.WriteLine($"{x}, {y}, {z}");
            else if (y >= x && x >= z) Console.WriteLine($"{y}, {x}, {z}");
            else if (z >= x && x >= y) Console.WriteLine($"{z}, {x}, {y}");
            else if (z >= y && y >= x) Console.WriteLine($"{z}, {y}, {x}");
            else if (y >= z && z >= x) Console.WriteLine($"{y}, {z}, {x}");
            else if (x >= z && z >= y) Console.WriteLine($"{x}, {z}, {y}");*/



            /*int n = int.Parse(Console.ReadLine());
            int wynik = 1;
            for (int i = 1; i <= n; i++)
            {
                wynik = wynik * i;
            }
            Console.WriteLine(wynik);*/



            /*int a = -7;
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine(a);
                a = a + 4;
            }
            */


            /*int a = 2;
            int i = 1;
            while (i <= 6)
            {
                Console.WriteLine(a);
                a = a * 3;
                i++;
            }
            */


            /*int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                n = n / 10;
                Console.WriteLine(n);
            } */


            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("NIE JEST");
                    break;
                }
                else
                {
                    Console.WriteLine("JEST");
                }
            }
            

        }
    }
}
