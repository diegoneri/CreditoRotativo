const double TaxaIOFMes = 0.0038;
const double TaxaIOFDia = 0.000082;

decimal valorTotalFatura;
double percentualPagamentoMinimo, taxaJurosMensais;

decimal valorPagamentoMinimo, valorNaoPago, valorJuros,
        valorIOFMes, valorIOFDiario, valorProximaFatura, custoCreditoRotativo;

Console.WriteLine("--- Crédito Rotativo de Cartão de Crédito ---\n");

Console.Write("Valor total da fatura (R$)...: ");
valorTotalFatura = Convert.ToDecimal(Console.ReadLine());
Console.Write("Pagamento mínimo (%).........: ");
percentualPagamentoMinimo = Convert.ToDouble(Console.ReadLine()) / 100;
Console.Write("Taxa de juros mensais (%)....: ");
taxaJurosMensais = Convert.ToDouble(Console.ReadLine()) / 100;

valorPagamentoMinimo = valorTotalFatura * Convert.ToDecimal(percentualPagamentoMinimo);
valorNaoPago = valorTotalFatura - valorPagamentoMinimo;
valorJuros = valorNaoPago * Convert.ToDecimal(taxaJurosMensais);
valorIOFMes = valorNaoPago * Convert.ToDecimal(TaxaIOFMes);
valorIOFDiario = valorNaoPago * Convert.ToDecimal(TaxaIOFDia * 30);

valorProximaFatura = valorNaoPago + valorJuros + valorIOFMes + valorIOFDiario;
custoCreditoRotativo = valorProximaFatura - valorNaoPago;

Console.WriteLine($"\nPagamento mínimo..................: {valorPagamentoMinimo:C2}");

Console.WriteLine("\nCaso seja pago o valor mínimo:");

Console.WriteLine($"Valor não pago....................: {valorNaoPago:C}");
Console.WriteLine($"Juros.............................: {valorJuros:C}");
Console.WriteLine($"IOF mensal........................: {valorIOFMes:C}");
Console.WriteLine($"IOF diário........................: {valorIOFDiario:C}");
Console.WriteLine($"");
Console.WriteLine($"Valor a pagar na próxima fatura...: {valorProximaFatura:C}");
Console.WriteLine($"Custo do crédito rotativo.........: {custoCreditoRotativo:C}");