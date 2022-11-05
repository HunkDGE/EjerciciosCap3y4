using System;
//elaborado por DAE.
namespace ejercicio5
//ejercicio 4.17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bases, exp, resultado, contador;
            Console.Write("Digite la base del numero: ");
            bases = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el exponente : ");
            contador = exp = Convert.ToInt32(Console.ReadLine());

            resultado = 1;
            while (contador != 0)
            {
                resultado = resultado * bases;
                contador = contador - 1;
            }

            Console.WriteLine("Exponer {0} veces el numero {1} da un resultado de {2}", exp, bases, resultado);

        }


    }
}
