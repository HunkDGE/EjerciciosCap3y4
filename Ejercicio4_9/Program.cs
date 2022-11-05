using System;
//eleaborado por DAE.
namespace ejercicio3
//ejercicio 4.9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SUMA O RESTA");
            Console.WriteLine("Digite el primer numero");
            double nu1, nu2;
            nu1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            nu2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite S(suma) o R(resta) para observar el resultado");
            string opcion;

            opcion = Console.ReadLine();
            if (opcion == "S" || opcion == "s")
            {
                double suma;
                suma = nu1 + nu2;
                Console.WriteLine("el resultado de la suma es: " + suma);
                Console.WriteLine("gracias por usar este algoritmo");
            }

            if (opcion == "R" || opcion == "r")
            {
                double resta;
                resta = nu1 - nu2;
                Console.WriteLine("el resultado de la resta es: " + resta);
                Console.WriteLine("gracias por usar este algoritmo");
            }
            if (opcion != "R" && opcion != "r" && opcion != "S" && opcion != "s")
            {
                Console.WriteLine("Digite una de las opciones disponibles: ´S´ o ´R´ ");
            }
        }
    }
}

