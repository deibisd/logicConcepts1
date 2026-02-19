using System;

class Program
{
    static void Main()
    {
        string continuar;
        do
        {
            Console.Clear();
            Console.WriteLine("--- SISTEMA DE MATRÍCULAS ---");

            Console.Write("Número de créditos: ");
            int creditos = int.Parse(Console.ReadLine());

            Console.Write("Valor crédito: ");
            double valorCredito = double.Parse(Console.ReadLine());

            Console.Write("Estrato del estudiante: ");
            int estrato = int.Parse(Console.ReadLine());

            // Llamada a funciones
            double costoMatricula = CalcularMatricula(creditos, valorCredito, estrato);
            double valorSubsidio = CalcularSubsidio(estrato);

            // Resultados
            Console.WriteLine("\nCosto de la matricula: " + costoMatricula);
            Console.WriteLine("Valor del subsidio: " + valorSubsidio);

            Console.WriteLine("\n¿Desea ingresar otro estudiante? (si/no)");
            continuar = Console.ReadLine().ToLower();

        } while (continuar == "si" || continuar == "s");
    }

    // Subprograma para el costo de matrícula
    static double CalcularMatricula(int cr, double val, int est)
    {
        double subtotal;
        if (cr <= 20)
        {
            subtotal = cr * val;
        }
        else
        {
            int extras = cr - 20;
            subtotal = (20 * val) + (extras * val * 2);
        }

        double descuento = 0;
        if (est == 1) descuento = 0.80;
        else if (est == 2) descuento = 0.50;
        else if (est == 3) descuento = 0.30;

        return subtotal - (subtotal * descuento);
    }

    // Subprograma para el subsidio
    static double CalcularSubsidio(int est)
    {
        if (est == 1) return 200000;
        else if (est == 2) return 100000;
        else return 0;
    }
}