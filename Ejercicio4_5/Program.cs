using System;
namespace ejercicio1
//ejercicio 4.5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite una fecha(DIA, MES Y AÑO)");
            int dia, mes, año;
            Console.WriteLine("Digite el dia");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el mes");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el año");
            año = int.Parse(Console.ReadLine());
            if (dia > 32) // si el dia pasa de 32 sera regresado a 31, lo mismo con el mes si supera 13
                          //lo regresara a 12 
            {
                dia = 1;
                mes = mes + 1;
                Console.WriteLine("su fecha es: " + dia + ":" + mes + ":" + año);
                if (mes > 13)
                {
                    mes = 1;
                    año = año + 1;
                    Console.WriteLine("su fecha es: " + dia + ":" + mes + ":" + año);
                }
            }
            else
            {
                dia = dia + 1;
                Console.WriteLine("su fecha es: " + dia + ":" + mes + ":" + año);
            }


            if (mes > 13)
            {
                mes = 1;
                año = año + 1;
                Console.WriteLine("su fecha es: " + dia + ":" + mes + ":" + año);
            }




        }
    }
}
