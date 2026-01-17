using System.Globalization;

namespace DesafioFundamentos.Models
{
    // Classe responsável por manter o registro dos veículos e calcular valores.
    // Comentários em português foram adicionados para explicar cada campo e método.
    public class Estacionamento
    {
        // Preço fixo cobrado na entrada (valor inicial)
        private decimal precoInicial = 0;

        // Preço cobrado por hora — usado para derivar o preço por minuto
        private decimal precoPorHora = 0;

        // Lista de placas dos veículos estacionados (mantém ordem de chegada)
        private List<string> veiculos = new List<string>();

        // Lista de timestamps de entrada correspondentes ao índice em `veiculos`
        // A posição em `entrada` deve estar sempre sincronizada com `veiculos`.
        private List<DateTime> entrada = new List<DateTime>();

        // Construtor: recebe os valores de preço inicial e por hora
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        // Adiciona um veículo na lista e registra a data/hora de entrada automaticamente
        public void AdicionarVeiculo()
        {
            Console.Write("\nDigite a placa do veículo para estacionar: ");
            // Armazena a placa informada pelo usuário
            veiculos.Add(Console.ReadLine());
            // Registra o momento exato da entrada (DateTime.Now)
            entrada.Add(DateTime.Now);
        }

        // Remove veículo: procura a placa, calcula tempo decorrido e valor a pagar
        public void RemoverVeiculo()
        {
            Console.WriteLine("\nDigite a placa do veículo para remover:");

            Console.Write("Insira a placa do carro: ");
            string placa = Console.ReadLine();

            // Encontra o índice do veículo na lista (comparação case-insensitive)
            int indice = veiculos.FindIndex(x => x.Equals(placa, StringComparison.OrdinalIgnoreCase));

            if (indice != -1)
            {
                // Recupera os timestamps correspondentes ao veículo
                DateTime horaEntrada = entrada[indice];
                DateTime horaSaida = DateTime.Now;
                TimeSpan duracao = horaSaida - horaEntrada;

                // Calcula o total de minutos estacionados. Aqui usamos Round
                // para arredondar ao minuto mais próximo; ajustar para Floor/Ceiling conforme política.
                int minutos = Convert.ToInt32(Math.Round(duracao.TotalMinutes));

                // Converte o preço por hora para preço por minuto e calcula total
                decimal valorPorMinuto = precoPorHora / 60;
                decimal valorTotal = precoInicial + valorPorMinuto * minutos;

                // Remove entradas nas duas listas pelo índice para manter consistência
                veiculos.RemoveAt(indice);
                entrada.RemoveAt(indice);

                // Exibe informações detalhadas ao usuário
                Console.WriteLine($"\nO veículo {placa} foi removido.");
                Console.WriteLine($"Entrada: {horaEntrada.ToString("g", CultureInfo.GetCultureInfo("pt-BR"))}");
                Console.WriteLine($"Saída:   {horaSaida.ToString("g", CultureInfo.GetCultureInfo("pt-BR"))}");
                Console.WriteLine($"Tempo estacionado: {minutos} minuto(s)");
                Console.WriteLine($"Preço total: {valorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}");
            }
            else
            {
                // Mensagem amigável em caso de placa não encontrada
                Console.WriteLine("\nDesculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        // Lista veículos estacionados com o índice (posição) e a data de entrada
        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("\nOs veículos estacionados são:");

                // Use um loop com índice para obter a posição (i) e acessar ambas as listas
                for (int i = 0; i < veiculos.Count; i++)
                {
                    // i é 0-based; i+1 é a posição 1-based exibida para o usuário
                    Console.WriteLine($"{i + 1} - {veiculos[i]} - data: {entrada[i]}");
                }
            }
            else
            {
                Console.WriteLine("\nNão há veículos estacionados.");
            }
        }
    }
}
