using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace ConsoleApp9
{
    internal class Program
    {
        public static int Zad2(int n)
        {
            int suma_cyfr = 0;
            int cyfra;
            while (n > 0)
            {
                cyfra = n % 10;
                suma_cyfr += cyfra;
                n = n / 10;
            }
            return suma_cyfr;
        }
        public static int Silnia(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Silnia(n);
        }
        public static int SilniaIteracyjnie(int n)
        {
            int silnia = 1;
            for (int i = 1; i <= n; i++)
            {
                silnia=silnia*i;
            }
            return silnia;
        }
        public static int Fibo(int n)
        {
            if (n < 2)
            {
                return 1;
            }
            return Fibo(n - 1) + Fibo(n - 2);
        }
        static void Main(string[] args)
        {
            /*int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Zad2(n));*/
            /*int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Silnia(n));*/
            /*int n = int.Parse(Console.ReadLine());
            Console.WriteLine(SilniaIteracyjnie(n));*/
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibo(n));
        }
    }
}
