using System;
using System.Globalization;

namespace SistemaEstacionamento
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("------------------------------");
			Console.WriteLine("   *KAUAN'S ESTACIONAMENTO*");
			Console.WriteLine("------------------------------");
			Console.Write("Valor inicial: R$ ");
			decimal precoInicial = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.Write("Valor por hora: R$ ");
			decimal precoHora = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);

			Estacionamento estacionamento = new Estacionamento(precoInicial, precoHora);

			bool optionsController = true;

			while (optionsController)
			{
				Console.Clear();

				Console.WriteLine($"Preco inicial: R${estacionamento.PrecoInicial.ToString("F2", CultureInfo.InvariantCulture)}  Preco p/hora: R${estacionamento.PrecoHora.ToString("F2", CultureInfo.InvariantCulture)}");
				Console.WriteLine();
				Console.WriteLine("1.Cadastrar veiculo");
				Console.WriteLine("2.Remover veiculo");
				Console.WriteLine("3.Listar veiculos");
				Console.WriteLine("4.Encerrar");

				int parkOptions = Convert.ToInt32(Console.ReadLine());

				switch (parkOptions)
				{
					case 1:
						estacionamento.CadastrarVeiculo();
						break;
					case 2:
						estacionamento.RemoverVeiculo();
						break;
					case 3:
						estacionamento.ListarVeiculos();
						break;
					case 4:
						optionsController = false;
						break;
				}

				Console.Clear();
			}

			Console.WriteLine("Obrigado por utilizar o Kauan's Estacionamento");
		}
	}
}
