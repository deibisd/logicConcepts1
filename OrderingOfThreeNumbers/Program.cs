using System;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.Write("Ingrese primer número (o escriba salir): ");
            string entrada1 = Console.ReadLine().ToLower();

            if (entrada1 == "salir")
            {
                Console.WriteLine("Programa finalizado.");
                break;
            }

            int num1 = int.Parse(entrada1);

            Console.Write("Ingrese segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese tercer número: ");
            int num3 = int.Parse(Console.ReadLine());

            int mayor, medio, menor;

            // Buscar mayor
            if (num1 > num2)
            {
                if (num1 > num3)
                    mayor = num1;
                else
                    mayor = num3;
            }
            else
            {
                if (num2 > num3)
                    mayor = num2;
                else
                    mayor = num3;
            }

            // Buscar menor
            if (num1 < num2)
            {
                if (num1 < num3)
                    menor = num1;
                else
                    menor = num3;
            }
            else
            {
                if (num2 < num3)
                    menor = num2;
                else
                    menor = num3;
            }

            medio = num1 + num2 + num3 - mayor - menor;

            Console.WriteLine("El número mayor es: " + mayor);
            Console.WriteLine("El número del medio es: " + medio);
            Console.WriteLine("El número menor es: " + menor);

            Console.WriteLine(); // Espacio visual

        } while (true);
    }
}




