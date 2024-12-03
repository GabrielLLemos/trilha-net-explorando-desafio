using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;


Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);
Reserva reserva = new Reserva();

Console.WriteLine("Dados para reserva:\n");

Console.WriteLine("Entre com a quantidade de hóspedes");
int quantidadeDeHospedes = Convert.ToInt32(Console.ReadLine());

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(quantidadeDeHospedes);

Console.WriteLine("Quantidade de dias reservados:");
int dias = Convert.ToInt32(Console.ReadLine());
reserva.DiasReservados = dias;

Console.WriteLine("Informações da reserva:\n");

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Total: {reserva.CalcularValorDiaria()}");