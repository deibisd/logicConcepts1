using System;

class Program
{
    static void Main()
    {
        string repetir;
        do
        {
            Console.Write("Ingrese año: ");
            int anio = int.Parse(Console.ReadLine());

            if ((anio % 4 == 0 && anio % 100!= 0) || (anio % 400 == 0))
                Console.WriteLine("El año: " + anio + ", si es bisiesto");
            else
                Console.WriteLine("El año: " + anio + ", no es bisiesto");

            Console.WriteLine("¿Deseas Continuar? (si/no)");
            repetir = Console.ReadLine()!.ToLower();
        } while (repetir == "si");
    }
}

