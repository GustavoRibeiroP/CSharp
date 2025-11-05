using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // 1. Crie um ArrayList e adicione os seguintes elementos:
        // "Maria", "João", "Ana", "Carlos". Em seguida, exiba todos os elementos no console.
        ArrayList nomes = new ArrayList();
        nomes.Add("Maria");
        nomes.Add("João");
        nomes.Add("Ana");
        nomes.Add("Carlos");

        Console.WriteLine("Elementos do ArrayList:");
        foreach (var nome in nomes)
        {
            Console.WriteLine(nome);
        }
        Console.WriteLine();

        // 2. A partir do ArrayList criado no exercício anterior,
        // remova o elemento "Ana" e mostre a lista atualizada.
        nomes.Remove("Ana");

        Console.WriteLine("ArrayList após remover 'Ana':");
        foreach (var nome in nomes)
        {
            Console.WriteLine(nome);
        }
        Console.WriteLine();

        // 3. Verifique se o elemento "Carlos" existe no ArrayList.
        // Caso exista, exiba a posição (índice) em que ele está.
        if (nomes.Contains("Carlos"))
        {
            int indice = nomes.IndexOf("Carlos");
            Console.WriteLine($"'Carlos' encontrado no índice: {indice}");
        }
        else
        {
            Console.WriteLine("'Carlos' não foi encontrado.");
        }
        Console.WriteLine();

        // 4. Crie um ArrayList que contenha números e strings ao mesmo tempo.
        // Em seguida, percorra e exiba todos os elementos.
        ArrayList listaMista = new ArrayList();
        listaMista.Add(10);
        listaMista.Add("Texto");
        listaMista.Add(25);
        listaMista.Add("C#");

        Console.WriteLine("ArrayList com elementos mistos:");
        foreach (var item in listaMista)
        {
            Console.WriteLine(item);
        }
    }
}
