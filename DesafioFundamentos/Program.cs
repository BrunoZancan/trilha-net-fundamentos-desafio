using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Limpa o Console
Console.Clear();

decimal precoInicial = 0.0m;
decimal precoPorHora = 0.0m;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
Console.Write("Digite o preço inicial: ");
precoInicial = Convert.ToDecimal(Console.ReadLine().Trim());

Console.Write("Digite o preço por hora: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine().Trim());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("----------------------------------------------------------");
    Console.WriteLine("Sistema de Estacionamento");
    Console.WriteLine("----------------------------------------------------------");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    Console.WriteLine("----------------------------------------------------------");
    Console.Write("Digite a sua opção: ");

    switch (Console.ReadLine())
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;

        case "2":
            estacionamento.RemoverVeiculo();
            break;

        case "3":
            estacionamento.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    Console.WriteLine();
    Console.WriteLine("Pressione qualquer tecla para continuar");
    Console.ReadKey();
}

Console.Clear();
Console.WriteLine("O programa se encerrou");
