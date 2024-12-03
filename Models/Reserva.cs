namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(int quantidadeDeHospedes)
        {
            if (Suite.Capacidade >= quantidadeDeHospedes && quantidadeDeHospedes > 0)
            {
                List<Pessoa> hospedes = new List<Pessoa>();

                for(var i=0; i<quantidadeDeHospedes; i++){
                    Console.WriteLine($"Nome do {i+1}º hóspede:");
                    var nomeDoHospede = Console.ReadLine();
                    hospedes.Add(new Pessoa(nome: $"{nomeDoHospede}"));
                }   
                Hospedes = hospedes;
            }
            if(quantidadeDeHospedes <= 0){
                throw new Exception("Quantidade de hóspedes deve ser maior que zero!");
            }
            else
            {
                throw new Exception("Capacidade do quarto excedida!");
            }
        }
      
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor = valor * 0.90M;
            }

            return valor;
        }
    }
}