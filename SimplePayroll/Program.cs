using System;

class Program
{
    static void Main()
    {
        string continuar;
        do
        {
            Console.Clear();
            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese número de horas trabajadas: ");
            double horas = double.Parse(Console.ReadLine());

            Console.Write("Ingrese valor hora: ");
            double valor = double.Parse(Console.ReadLine());

            Console.Write("Ingrese valor salario mínimo mensual: ");
            double minimo = double.Parse(Console.ReadLine());

            double total = horas * valor;

            Console.WriteLine("Nombre: " + nombre);
            if (total > minimo)
            {
                Console.WriteLine("Salario mensual: " + total);
            }

            Console.WriteLine("¿Desea ingresar otro empleado? (si/no)");
            continuar = Console.ReadLine().ToLower();

        } while (continuar == "si");
    }
}