using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lista_de_sugestoes_inteligentes.implementacoes
{
    public class MinhaImplementacao
    {
        public void Main()
        {
            Console.Write("\nDigite quanto comandos você que inserir: ");
            // Lê o número de comandos a serem processados
            int n = int.Parse(Console.ReadLine() ?? string.Empty);

            // Inicializa a estrutura para armazenar sugestões únicas
            HashSet<string> sugestoes = new HashSet<string>(StringComparer.Ordinal);

            for (int i = 0; i < n; i++)
            {
                Console.Write("Insira o comando seguido da sugestão, separados por espaçao (ex: ADD/REMOVE <sugestão>): ");
                string linha = Console.ReadLine() ?? string.Empty;

                // Divide o comando em ação (ADD/REMOVE) e sugestão
                int spaceIdx = linha.IndexOf(' ');
                string acao = linha.Substring(0, spaceIdx);
                string sugestao = linha.Substring(spaceIdx + 1);

                // TODO: Implemente o tratamento para as ações de adicionar e remover sugestões
                // Dica: utilize os métodos disponíveis na estrutura HashSet para gerenciar as sugestões
                if (acao.ToUpper().Equals("ADD"))
                {
                    sugestoes.Add(sugestao);
                }
                else if (acao.ToUpper().Equals("REMOVE"))
                {
                    sugestoes.Remove(sugestao);
                }
                else
                {
                    Console.WriteLine("Comando inválido! você só poder colocar ADD ou REMOVE antes da sugestão.");
                    return;
                }
            }

            // Ao final, exibe as sugestões em ordem alfabética separadas por espaço,
            // ou "VAZIO" se não houver elementos restantes
            if (sugestoes.Count == 0)
            {
                Console.WriteLine("VAZIO");
            }
            else
            {
                List<string> ordenadas = sugestoes.ToList();
                ordenadas.Sort(StringComparer.Ordinal);
                Console.WriteLine(string.Join(" ", ordenadas));
            }
        }
    }
}