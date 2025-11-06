// Crie um ArrayList que contenha valores de tipos diferentes (int, string, double).
// Percorra o ArrayList e exiba apenas os números inteiros. Depois, exiba apenas as strings.

using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList lista = new ArrayList();

        lista.Add(10);
        lista.Add("Gustavo");
        lista.Add(25.7);
        lista.Add(42);
        lista.Add("Pena");

        Console.WriteLine("Números inteiros:");
        foreach (var item in lista)
        {
            if (item is int)
            {
                Console.WriteLine(item);
            }
        }

        Console.WriteLine("\nStrings:");
        foreach (var item in lista)
        {
            if (item is string)
            {
                Console.WriteLine(item);
            }
        }
    }
}
