using System;

// 1. Implemente uma função recursiva que receba como entrada um número inteiro
// positivo N e retorne o seguinte cálculo: 1 + 2 + 3 + ... + N

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Resultado: {CalculoRecursivo(n)}");
    }

    static int CalculoRecursivo(int n)
    {
        if (n <= 1)
            return 1;
        return n + CalculoRecursivo(n - 1);
    }
}
