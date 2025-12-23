using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("\x1b[96m🅿️ SISTEMA DE ESTACIONAMENTO 🅿️\x1b[0m");
    Console.WriteLine("\x1b[90m═══════════════════════════════════\x1b[0m");
    Console.WriteLine("\x1b[93m┌─ Selecione uma opção ─┐\x1b[0m");
    Console.WriteLine("\x1b[92m│ 🟢 1 - Cadastrar veículo    │\x1b[0m");
    Console.WriteLine("\x1b[91m│ 🔴 2 - Remover veículo      │\x1b[0m");
    Console.WriteLine("\x1b[94m│ 🔵 3 - Listar veículos      │\x1b[0m");
    Console.WriteLine("\x1b[90m│ ⚫ 4 - Encerrar             │\x1b[0m");
    Console.WriteLine("\x1b[93m└─────────────────────────┘\x1b[0m");
    Console.WriteLine("\x1b[93m└─ Digite sua opção: ──────┘\x1b[0m");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("\x1b[91m❌ Opção inválida! Tente novamente.\x1b[0m");
            break;
    }

    Console.WriteLine("\x1b[90mPressione uma tecla para continuar...\x1b[0m");
    Console.ReadLine();
}

Console.WriteLine("\x1b[96m👋 O programa se encerrou. Até logo!\x1b[0m");
