using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("\ninsira sua lista de tarefas separadas por espaço: ");

        // Lê uma linha contendo as tarefas separadas por espaço
        string input = Console.ReadLine() ?? string.Empty;

        // Converte a entrada em uma lista de tarefas
        List<string> tarefas = new List<string>(input.Split(' '));

        // TODO: Separe as tarefas realizadas ("feito") das tarefas pendentes,
        // mantendo a ordem relativa de ambas nas listas.
        List<string> tarefasNaoConcluidas = new List<string>();
        List<string> tarefasFeitas = new List<string>();

        // Dica: Percorra todas as tarefas e utilize duas listas diferentes.
        for (int i = 0; i < tarefas.Count; i++)
        {
            if (tarefas[i] == "feito")
            {
                tarefasFeitas.Add(tarefas[i]);
            }
            else
            {
                tarefasNaoConcluidas.Add(tarefas[i]);
            }
        }

        // Após separar, coloque primeiro as pendentes e depois todas as "feito"
        // List<string> resultado = ... // Monte a lista final aqui
        List<string> resultado = new List<string>();
        resultado.AddRange(tarefasNaoConcluidas);
        resultado.AddRange(tarefasFeitas);

        // Imprime as tarefas reordenadas
        Console.WriteLine(string.Join(" ", resultado));
    }
}

/*
// OUTRA MANEIRA DE RESOLVER COM POUCO CODIGO.
  
class Program
{
  static void Main()
  {
    //Console.Write("\ninsira sua lista de tarefas separadas por espaço: ");

    // Lê uma linha contendo as tarefas separadas por espaço
    string input = Console.ReadLine();

    // Converte a entrada em uma lista de tarefas
    var tarefas = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

    // Separe as tarefas realizadas ("feito") das tarefas pendentes,
    // mantendo a ordem relativa de ambas nas listas.
    var resultado = tarefas.Where(t => t != "feito").Concat(tarefas.Where(t => t == "feito")).ToList();

    // Imprime as tarefas reordenadas
    Console.WriteLine(string.Join(" ", resultado));
  }
}
*/