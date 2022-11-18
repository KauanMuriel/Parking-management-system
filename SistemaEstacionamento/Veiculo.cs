using System;
using System.Globalization;

namespace SistemaEstacionamento
{
	class Veiculo
	{
		public string Placa { get; private set; }
		public DateTime Entrada { get; private set; }
		public DateTime Saida { get; private set; }
		public decimal ValorAPagar { get; private set; }

		public Veiculo (string placa, DateTime entrada)
		{
			Placa = placa;
			Entrada = entrada;
		}

		public void GeraValorAPagar(decimal precoHora, decimal precoInicial)
		{
			Saida = DateTime.Now;
			TimeSpan tempoGasto = Saida - Entrada;
			ValorAPagar = (Convert.ToDecimal(tempoGasto.TotalHours) * precoHora) + precoInicial;
			Console.WriteLine($"Valor a pagar: {ValorAPagar.ToString("F2", CultureInfo.InvariantCulture)}");
		}

		public override string ToString()
		{
			return $"Placa do veiculo: {Placa}, Entrada: {Entrada}";
		}
	}
}
