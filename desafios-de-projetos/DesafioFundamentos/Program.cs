using DesafioFundamentos.Models;

// Programa principal do sistema de estacionamento.
// Comentários acrescentados para documentar o fluxo e as entradas do usuário.

// Coloca o encoding para UTF8 para exibir acentuação corretamente no console
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Variáveis para armazenar os preços informados pelo usuário
decimal precoInicial = 0;
decimal precoPorHora = 0;

// Solicita ao usuário os valores iniciais (preço inicial e por hora)
Console.Write("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.Write("Agora digite o preço por hora: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe `Estacionamento` com os valores informados
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

// Controle do menu (loop principal)
string opcao = string.Empty;
bool exibirMenu = true;

// Loop que exibe o menu até que o usuário escolha encerrar
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    // Lê a opção do usuário e redireciona para o método correspondente
    Console.Write("\nDigite a sua opção: ");
    string opt = Console.ReadLine();

    switch (opt)
    {
        case "1":
            // Solicita a placa e registra a entrada
            es.AdicionarVeiculo();
            break;

        case "2":
            // Remove o veículo informado e calcula o valor a pagar
            es.RemoverVeiculo();
            break;

        case "3":
            // Lista os veículos atualmente estacionados
            es.ListarVeiculos();
            break;

        case "4":
            // Encerra o loop e finaliza o programa
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("\nPressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
