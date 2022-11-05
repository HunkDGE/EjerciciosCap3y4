using System;
namespace ejercicio2
//ejercicio 4.7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("ingresa numero");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingresa numero");
            b = Convert.ToInt32(Console.ReadLine());
            if (a % b == 0)
            {
                Console.WriteLine(b + " es divisor de " + a);
            }
            else
            {
                if (b % a == 0)
                {
                    Console.WriteLine(a + " es divisor de " + b);
                }
                else
                {
                    Console.WriteLine("ninguno es divisor del otro");
                }




            }
        }
    }
}