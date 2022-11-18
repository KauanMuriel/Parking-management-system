using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionamento
{
	class Estacionamento
	{
		public decimal PrecoInicial;
		public decimal PrecoHora;
		public List<Veiculo> VeiculosEstacionados = new List<Veiculo>();

		public Estacionamento (decimal precoInicial, decimal precoHora)
		{
			PrecoInicial = precoInicial;
			PrecoHora = precoHora;
		}

		public string PedeDadosVeiculo()
		{
			Console.Write("Placa do veiculo: ");
			return Console.ReadLine();

		}

		public void CadastrarVeiculo()
		{
			string placa = PedeDadosVeiculo();
			DateTime entrada = DateTime.Now;
			Veiculo vec = new Veiculo(placa, entrada);
			VeiculosEstacionados.Add(vec);
		}

		public void ListarVeiculos()
		{
			int count = 1;
			Console.WriteLine();

			if (VeiculosEstacionados.Count != 0)
			{
				foreach (Veiculo vec in VeiculosEstacionados)
				{
					
					Console.WriteLine($"Veiculo {count}");
					Console.WriteLine(vec.ToString());
					count++;
				}
			}
			else
			{
				Console.WriteLine("Nenhum veiculo cadastrado");
			}

			Console.WriteLine("Aperte ENTER para continuar");
			Console.ReadLine();
		}

		public void RemoverVeiculo()
		{
			string placa = PedeDadosVeiculo();
			Veiculo veiculoSelecionado = SelecionarVeiculo(placa);
			veiculoSelecionado.GeraValorAPagar(PrecoHora, PrecoInicial);

			Console.WriteLine("Aperte ENTER para continuar");
			Console.ReadLine();

			VeiculosEstacionados.Remove(veiculoSelecionado);
		}

		public Veiculo SelecionarVeiculo(string placa)
		{
			return VeiculosEstacionados.Find(x => x.Placa == placa);
		}
	}
}
