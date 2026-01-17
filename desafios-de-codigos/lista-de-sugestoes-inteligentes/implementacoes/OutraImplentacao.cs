using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lista_de_sugestoes_inteligentes.implementacoes
{
    public class OutraImplentacao
    {
        public void Main()
        {
            // Exibe uma mensagem solicitando a quantidade de comandos
            Console.Write("Digite a quantidade de comandos: ");

            // Lê a entrada do usuário e converte para inteiro
            string? input = Console.ReadLine();
            int quantidadeComandos = int.Parse(input!);

            // Cria um conjunto (HashSet) para armazenar sugestões únicas
            // StringComparer.Ordinal garante comparação exata entre textos
            HashSet<string> sugestoes = new HashSet<string>(StringComparer.Ordinal);

            // Laço que executa a quantidade de comandos informada
            for (int i = 0; i < quantidadeComandos; i++)
            {
                // Solicita o comando ao usuário
                Console.Write("Digite o comando (ADD ou REMOVE) seguido da sugestão: ");

                // Lê a linha inteira digitada
                string? entrada = Console.ReadLine();

                // Divide o texto em duas partes usando o espaço como separador
                // Exemplo: "ADD livro" → ["ADD", "livro"]
                string[] partes = entrada!.Split(' ', 2);

                // A primeira parte é o comando (ADD ou REMOVE)
                string comando = partes[0].ToUpper();

                // A segunda parte é a sugestão
                string sugestao = partes[1];

                // Verifica se o comando é ADD
                if (comando == "ADD")
                {
                    // Adiciona a sugestão ao conjunto
                    sugestoes.Add(sugestao);
                }
                // Verifica se o comando é REMOVE
                else if (comando == "REMOVE")
                {
                    // Remove a sugestão do conjunto
                    sugestoes.Remove(sugestao);
                }
                // Caso o comando não seja válido
                else
                {
                    // Exibe mensagem de erro
                    Console.WriteLine("Comando inválido. Use apenas ADD ou REMOVE.");

                    // Encerra a execução do programa
                    return;
                }
            }

            // Verifica se o conjunto está vazio
            if (sugestoes.Count == 0)
            {
                // Caso não existam sugestões, imprime VAZIO
                Console.WriteLine("VAZIO");
            }
            else
            {
                // Converte o HashSet para uma lista
                List<string> listaOrdenada = sugestoes.ToList();

                // Ordena a lista em ordem alfabética
                listaOrdenada.Sort(StringComparer.Ordinal);

                // Exibe as sugestões separadas por espaço
                Console.WriteLine(string.Join(" ", listaOrdenada));
            }
        }
    }
}