using System;

class Program
{
    static void Main()
    {
        string continuar;
        do
        {
            Console.Clear();
            double precioEscritorio = 650000;
            double descuento = 0;

            Console.Write("Número de escritorios: ");
            int cantidad = int.Parse(Console.ReadLine());

            if (cantidad < 5)
            {
                descuento = 0.10;
            }
            else if (cantidad >= 5 && cantidad < 10)
            {
                descuento = 0.20;
            }
            else if (cantidad >= 10)
            {
                descuento = 0.40;
            }

            double subtotal = cantidad * precioEscritorio;
            double valorDescuento = subtotal * descuento;
            double totalAPagar = subtotal - valorDescuento;

            Console.WriteLine("El valor a pagar es: " + totalAPagar);

            Console.WriteLine("¿Desea realizar otro cálculo? (si/no)");
            continuar = Console.ReadLine().ToLower();

        } while (continuar == "si" || continuar == "s");
    }
}