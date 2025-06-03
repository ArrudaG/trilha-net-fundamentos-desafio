using System.Data;

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
            Console.Clear();
            // Pede para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placaAdicionar = Console.ReadLine().ToUpper();
            if (veiculos.Contains(placaAdicionar))
            {
                Console.WriteLine("A placa digitada já consta no sistema.");
                return;
            }
            veiculos.Add(placaAdicionar);
        }

        public void RemoverVeiculo()
        {
            Console.Clear();
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pede para o usuário digitar a placa e armazenar na variável placa
            string placaRemover = Console.ReadLine().ToUpper();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placaRemover.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Pede para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // Realiza o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                int horas = Convert.ToInt16(Console.ReadLine());
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                // Remove a placa digitada da lista de veículos
                veiculos.Remove(placaRemover);

                Console.WriteLine($"O veículo {placaRemover} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            Console.Clear();
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Realiza um laço de repetição, exibindo os veículos estacionados
                foreach (string i in veiculos)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
