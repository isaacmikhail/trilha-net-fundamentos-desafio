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
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // DONE!
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // DONE
            

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {   
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                Console.ReadLine();
                
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // DONE!!
                int horas = 0;
              //if (int.TryParse(Console.ReadLine(), out horas))
              //{
                decimal valorTotal = 0;
                valorTotal=precoInicial+precoPorHora*horas;
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                veiculos.Remove(placa);
                // TODO: Remover a placa digitada da lista de veículos
                // DONE!!

                
            //}
            // else {
            // Console.WriteLine("Valor inválido para horas. Certifique-se de digitar um número inteiro.");}
            }
            else{
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
            }
            
            

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                           
                Console.WriteLine("Os veículos estacionados são: ");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // DONE!!
                for (int count=0; count<veiculos.Count; count++);
                foreach(var veiculo in veiculos){     
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
