using System;
namespace ejercicio4
//ejercicio 4.10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero para deducir si esta entre 10 y 100");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            if (num <= 10)
            {
                Console.WriteLine("El numero esta dentro de los 10 primeros numeros");
            }
            else
            {
                Console.WriteLine("El numero no esta dentro de los 10 primeros");
            }

            if (num <= 100)
            {
                Console.WriteLine("El numero esta dentro de los 100 primeros numeros");
            }
            else
            {
                Console.WriteLine("El numero no esta dentro de los 100 primeros numeros");
            }



        }
    }
}