using System;

// 2. Escreva uma função recursiva que imprima uma contagem regressiva
// de um número até zero.

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int n = int.Parse(Console.ReadLine());
        ContagemRegressiva(n);
    }

    static void ContagemRegressiva(int n)
    {
        if (n < 0)
            return;
        Console.WriteLine(n);
        ContagemRegressiva(n - 1);
    }
}
