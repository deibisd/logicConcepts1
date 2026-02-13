using System;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.Write("Ingrese primer número (o escriba salir): ");
            string entrada = Console.ReadLine().ToLower();

            if (entrada == "salir")
            {
                Console.WriteLine("Programa finalizado.");
                break;
            }

            int num1 = int.Parse(entrada);

            Console.Write("Ingrese segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese tercer número: ");
            int num3 = int.Parse(Console.ReadLine());

            int mayor = num1;

            if (num2 > mayor)
            {
                mayor = num2;
            }

            if (num3 > mayor)
            {
                mayor = num3;
            }

            Console.WriteLine("El número mayor es: " + mayor);
            Console.WriteLine();

        } while (true);
    }
}
