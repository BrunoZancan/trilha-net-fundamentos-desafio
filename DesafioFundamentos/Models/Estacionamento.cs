using System.Globalization;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal PrecoInicial = 0.0m;
        private decimal PrecoPorHora = 0.0m;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Implementado!

            Console.Write("Digite a placa do veículo para estacionar: ");

            // Lê a placa que a pessoa digita, e deixa tudo formatado
            string placa = Console.ReadLine().Trim().ToUpper();

            // Verifica se o tamanho da placa é diferente de 7 (Tamanho padrão de placas da MERCOSUL)
            while (placa.Replace("-", "").Replace(" ", "").Length != 7)
            {
                Console.WriteLine();
                Console.WriteLine("Placa Incorreta!");
                Console.Write("Digite novamente a placa do veículo para estacionar: ");

                // Lê a placa que a pessoa digita, e deixa tudo formatado
                placa = Console.ReadLine().Trim().ToUpper();
            }

            // Limpa o console
            Console.Clear();

            veiculos.Add(placa);
            Console.WriteLine($"Placa {placa} adicionada com sucesso!");
        }

        public void RemoverVeiculo()
        {
            // Implementado!

            ListarVeiculos();

            Console.WriteLine();

            Console.Write("Digite a placa do veículo para remover: ");
            string placa = Console.ReadLine().Trim().ToUpper();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine();

                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                int horas = Convert.ToInt32(Console.ReadLine());

                // Faz o calculo de quanto a pessoa vai pagar
                decimal valorTotal = PrecoPorHora * horas + PrecoInicial;

                veiculos.Remove(placa);

                Console.WriteLine();

                // Exibe o valor total formatado em moeda (Currency), por exemplo: "R$ 200,00", dependendo do idioma / cultura da máquina
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal.ToString("C", CultureInfo.CurrentCulture)}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Implementado!

            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.Clear();

                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
