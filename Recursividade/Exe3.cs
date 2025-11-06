using System;

// 3. Implemente uma função recursiva que receba como entrada um vetor e seu tamanho
// e retorne a soma dos elementos desse vetor.

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = { 2, 4, 6, 8, 10 };
        Console.WriteLine($"Soma: {SomaVetor(vetor, vetor.Length)}");
    }

    static int SomaVetor(int[] vetor, int tamanho)
    {
        if (tamanho == 0)
            return 0;
        return vetor[tamanho - 1] + SomaVetor(vetor, tamanho - 1);
    }
}
