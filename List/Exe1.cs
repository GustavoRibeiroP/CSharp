// 3. Crie uma classe Aluno com as propriedades: Nome, Idade e Nota.
// Crie uma List<Aluno> com pelo menos 5 alunos.
// Exiba apenas os alunos com nota maior ou igual a 7.
// Exiba o aluno com a maior nota.

using System;
using System.Collections.Generic;

class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public double Nota { get; set; }
}

class Program
{
    static void Main()
    {
        List<Aluno> alunos = new List<Aluno>
        {
            new Aluno { Nome = "Gustavo", Idade = 20, Nota = 8.5 },
            new Aluno { Nome = "Maria", Idade = 19, Nota = 6.8 },
            new Aluno { Nome = "João", Idade = 21, Nota = 7.0 },
            new Aluno { Nome = "Ana", Idade = 18, Nota = 9.2 },
            new Aluno { Nome = "Pedro", Idade = 22, Nota = 5.9 }
        };

        Console.WriteLine("Alunos com nota >= 7:");
        foreach (var a in alunos)
        {
            if (a.Nota >= 7)
                Console.WriteLine($"{a.Nome} - Nota: {a.Nota}");
        }

        double maiorNota = alunos[0].Nota;
        Aluno melhorAluno = alunos[0];

        foreach (var a in alunos)
        {
            if (a.Nota > maiorNota)
            {
                maiorNota = a.Nota;
                melhorAluno = a;
            }
        }

        Console.WriteLine($"\nAluno com maior nota: {melhorAluno.Nome} - Nota: {melhorAluno.Nota}");
    }
}
