namespace ejercicio3_5
{
    public class program
    //ejercicio del capitulo 3
    {
        static void Main(string[] args)
        {

            double precio, unidades;
            double Iva = 0.12, limite = 50000, descuento = 0.05;

            double valorfinal, preciobruto;
            Console.WriteLine("Digite el precio de su compra");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite las unidades de su compra");
            unidades = double.Parse(Console.ReadLine());
            preciobruto = (unidades * precio) + ((unidades * precio) * (Iva));
            if (preciobruto > limite)
            {
                double descuentofinal;
                descuentofinal = (preciobruto) - (preciobruto * descuento);
                Console.WriteLine("el precio final con descuento es: " + descuentofinal);

            }
            if (preciobruto <= limite)
            {
                Console.WriteLine("El precio final es: " + preciobruto);
            }


        }

    }



}
