using System.Globalization;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        private List<DateTime> entrada = new List<DateTime>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.Write("\nDigite a placa do veículo para estacionar: ");
            veiculos.Add(Console.ReadLine());
            entrada.Add(DateTime.Now);
        }

        // public void AdicionarVeiculo()
        // {
        //     Console.Write("\nDigite a placa do veículo para estacionar: ");
        //     veiculos.Add(Console.ReadLine());
        // }

        public void RemoverVeiculo()
        {
            Console.WriteLine("\nDigite a placa do veículo para remover:");

            Console.Write("Insira a placa do carro: ");
            string placa = Console.ReadLine();

            int indice = veiculos.FindIndex(x => x.Equals(placa, StringComparison.OrdinalIgnoreCase));

            if (indice != -1)
            {
                DateTime horaEntrada = entrada[indice];
                DateTime horaSaida = DateTime.Now;
                TimeSpan duracao = horaSaida - horaEntrada;

                int minutos = Convert.ToInt32(Math.Ceiling(duracao.TotalMinutes));

                decimal valorPorMinuto = precoPorHora / 60;
                decimal valorTotal = precoInicial + valorPorMinuto * minutos;

                veiculos.RemoveAt(indice);
                entrada.RemoveAt(indice);

                // Console.WriteLine($"\nO veículo {placa} foi removido e o preço total foi de: {valorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}");
                Console.WriteLine($"\nO veículo {placa} foi removido.");
                Console.WriteLine($"Entrada: {horaEntrada.ToString("g", CultureInfo.GetCultureInfo("pt-BR"))}");
                Console.WriteLine($"Saída:   {horaSaida.ToString("g", CultureInfo.GetCultureInfo("pt-BR"))}");
                Console.WriteLine($"Tempo estacionado: {minutos} minuto(s)");
                Console.WriteLine($"Preço total: {valorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}");
            }
            else
            {
                Console.WriteLine("\nDesculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }

            // Console.WriteLine($"Indice na lista veiculos: {indice}");
            // Console.WriteLine($"Veiculo cadastrado em: {entrada[indice]}");

            // Verifica se o veículo existe
            // if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            // {
            //     Console.Write("\nDigite a quantidade de horas que o veículo permaneceu estacionado: ");

            //     int horas = Convert.ToInt32(Console.ReadLine());
            //     decimal valorTotal = precoInicial + precoPorHora * horas;

            //     veiculos.Remove(placa);

            //     Console.WriteLine($"\nO veículo {placa} foi removido e o preço total foi de: {valorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}");
            // }
            // else
            // {
            //     Console.WriteLine("\nDesculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            // }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("\nOs veículos estacionados são:");

                // foreach (string value in veiculos)
                // {
                //     Console.WriteLine(value);
                // }

                for (int i = 0; i < veiculos.Count; i++)
                {
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
