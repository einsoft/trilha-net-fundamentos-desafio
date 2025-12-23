namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("\x1b[93m🚗 Digite a placa do veículo para estacionar:\x1b[0m");
            
            // ✅ IMPLEMENTAÇÃO: Adicionar validação de entrada e adição de veículo
            string placa = Console.ReadLine();
            if (!string.IsNullOrEmpty(placa))
            {
                veiculos.Add(placa);
                Console.WriteLine($"\x1b[92m✅ Veículo {placa} estacionado com sucesso!\x1b[0m");
            }
            else
            {
                Console.WriteLine($"\x1b[91m❌ Placa não pode estar vazia. Operação cancelada.\x1b[0m");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("\x1b[93m🔴 Digite a placa do veículo para remover:\x1b[0m");

            // ✅ IMPLEMENTAÇÃO: Obter entrada da placa com validação
            string placa = Console.ReadLine();
            
            if (string.IsNullOrEmpty(placa))
            {
                Console.WriteLine($"\x1b[91m❌ Placa não pode estar vazia. Operação cancelada.\x1b[0m");
                return;
            }

            // Verifica se o veículo existe (case-insensitive)
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("\x1b[93m⏱️ Digite a quantidade de horas que o veículo permaneceu estacionado:\x1b[0m");

                // ✅ IMPLEMENTAÇÃO: Obter entrada de horas com validação
                try
                {
                    int horas = Convert.ToInt32(Console.ReadLine());
                    
                    if (horas <= 0)
                    {
                        Console.WriteLine($"\x1b[91m⚠️ Quantidade de horas deve ser maior que zero. Operação cancelada.\x1b[0m");
                        return;
                    }
                    
                    // ✅ IMPLEMENTAÇÃO: Calcular preço total usando fórmula correta
                    // Fórmula: precoInicial + (precoPorHora * horas)
                    decimal valorTotal = precoInicial + (precoPorHora * horas);
                    
                    // ✅ IMPLEMENTAÇÃO: Remover veículo da lista
                    veiculos.Remove(placa);

                    Console.WriteLine($"\x1b[92m💰 O veículo {placa} foi removido e o preço total foi de: {valorTotal:C}\x1b[0m");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"\x1b[91m❌ Quantidade de horas inválida. Operação cancelada.\x1b[0m");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"\x1b[91m❌ Quantidade de horas muito grande. Operação cancelada.\x1b[0m");
                }
            }
            else
            {
                Console.WriteLine($"\x1b[91m❌ Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.\x1b[0m");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("\x1b[94m📋 Os veículos estacionados são:\x1b[0m");
                
                // ✅ IMPLEMENTAÇÃO: Exibir todos os veículos usando loop foreach
                foreach (string placa in veiculos)
                {
                    Console.WriteLine($"\x1b[96m  🚗 {placa}\x1b[0m");
                }
            }
            else
            {
                Console.WriteLine($"\x1b[93m📭 Não há veículos estacionados.\x1b[0m");
            }
        }
    }
}
