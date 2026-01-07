# Explorando Estruturas de Dados em .NET
## Desafio - 1/2 - Lista de Sugestoes Inteligentes

### Desafio

Em uma empresa que lidera projetos de Transformação Digital utilizando **.NET** e Inteligência Artificial, você faz parte da equipe de desenvolvedores responsável pelo motor de sugestões inteligentes do sistema. Esse motor recebe comandos dos usuários para registrar e remover sugestões tecnológicas, e ao final de cada interação, precisa apresentar as sugestões da lista, em ordem alfabética, para futura análise do algoritmo de IA.

Implemente um programa que processe uma sequência de comandos sobre uma lista de sugestões. Cada comando será **“ADD”** para adicionar uma sugestão à lista, ou **“REMOVE”** para remover. Após processar todos os comandos recebidos, seu programa deve exibir, em uma única linha, as sugestões restantes, separadas por espaços, ordenadas alfabeticamente. Se a lista estiver vazia, exiba apenas a palavra **“VAZIO”**.

### Entrada
A primeira linha contém um número inteiro N, representando a quantidade de comandos.
As próximas N linhas contêm comandos no formato:
“ADD sugestao” ou “REMOVE sugestao”, onde “sugestao” é um texto sem espaços.

### Saída
Exiba as sugestões restantes da lista em ordem alfabética e separadas por espaço, em uma única linha. Caso não haja sugestões, imprima "VAZIO".

### Exemplos
A tabela abaixo apresenta exemplos de entrada e saída:

| **Entrada** | **Saída** |
|:-----|:-----|
| 3 <br> ADD chatbot <br> ADD cloud <br> REMOVE chatbot | cloud
| 2 <br> ADD mlapi <br> REMOVE mlapi <br> |	VAZIO |
| 4 <br> ADD iot <br> ADD azure <br> ADD bot <br> REMOVE iot <br> | azure bot |
---

<br>
<br>
<br>

- RESULTADOS.

```c#

    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            // Lê o número de comandos a serem processados
            int n = int.Parse(Console.ReadLine());

            // Inicializa a estrutura para armazenar sugestões únicas
            HashSet<string> sugestoes = new HashSet<string>(StringComparer.Ordinal);

            for (int i = 0; i < n; i++)
            {
                string linha = Console.ReadLine();

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

```

```c#



```