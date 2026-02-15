using System;

do
{
    Console.Write("\nIngrese un número o escriba 'salir' para terminar: ");
    string input = Console.ReadLine().Trim().ToLower();

    if (input == "salir")
    {
        Console.WriteLine("Programa finalizado.");
        break;
    }

    bool valido = int.TryParse(input, out int numero);
    if (!valido)
    {
        Console.WriteLine("Entrada inválida. Intente nuevamente.");
        continue;
    }

    if (numero % 2 == 0)
    {
        Console.WriteLine($"El número {numero} es PAR.");
    }
    else
    {
        Console.WriteLine($"El número {numero} es IMPAR.");
    }

} while (true);
