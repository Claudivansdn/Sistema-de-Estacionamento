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
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string adicionaVeiculo = Console.ReadLine();

            // verifica se o campo tem valor nulo. só adiciona se tiver valor.
            if (!string.IsNullOrWhiteSpace(adicionaVeiculo)) {
                 veiculos.Add(adicionaVeiculo);
            }
            else {
                Console.WriteLine("CAMPO VAZIO!");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            //verificar se tem o veículo, transforma a placa e veículo em maíusculo para nao ter erro
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                string horasVeiculo = Console.ReadLine();
                // remove o veículo da lista
                veiculos.Remove(veiculos.First(x => x.ToUpper() == placa.ToUpper()));             
                //Realizar o cálculo do valor a ser pago
                int horas = Convert.ToInt32(horasVeiculo);
                decimal valorTotal = precoInicial + precoPorHora * horas; 

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Realiza um laço de repetição, exibindo os veículos estacionados
                foreach (string veiculo in veiculos){
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
