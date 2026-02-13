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

            if (num1 % num2 == 0)
            {
                Console.WriteLine("El número: " + num2 + ", es múltiplo de: " + num1);
            }
            else
            {
                Console.WriteLine("El número: " + num2 + ", NO es múltiplo de: " + num1);
            }

            Console.WriteLine(); // espacio

        } while (true);
    }
}
