const double taxaIOFAoMes = 0.0038;
const double taxaIOFAoDia = 0.000082;

decimal valorTotalFatura, 
        percentualPagamentoMinimo,
        percentualMultaAtraso, 
        taxaJurosMensais,
        valorPagamentoMinimo,
        valorNaoPago,
        jurosSobreRotativo,
        valorIOFMensal,
        valorIOFDiario,
        valorMultaAtraso,
        valorProximaFatura,
        custoCreditoRotativo;

Console.Clear();
Console.WriteLine("--- Crédito Rotativo de Cartão de Crédito ---");

Console.Write($"Valor total da fatura (R$)...: ");
valorTotalFatura = Convert.ToDecimal(Console.ReadLine());
Console.Write($"Pagamento mínimo (%).........: ");
percentualPagamentoMinimo = Convert.ToDecimal(Console.ReadLine()) / 100;
Console.Write($"Taxa de juros mensais (%)....: ");
taxaJurosMensais = Convert.ToDecimal(Console.ReadLine()) / 100;

Console.Write($"Multa de atraso (%)....: ");
percentualMultaAtraso = Convert.ToDecimal(Console.ReadLine()) / 100;

Console.WriteLine();
valorPagamentoMinimo = valorTotalFatura * percentualPagamentoMinimo; 
Console.WriteLine($"Pagamento mínimo..................: {valorPagamentoMinimo:C2}");

Console.WriteLine("\nCaso seja pago o valor mínimo:\n");

valorNaoPago = valorTotalFatura - valorPagamentoMinimo;
Console.WriteLine($"Valor não pago....................: {valorNaoPago:C2}");

jurosSobreRotativo = valorNaoPago * taxaJurosMensais;
Console.WriteLine($"Juros.............................: {jurosSobreRotativo:C2}");

valorIOFMensal = valorNaoPago * Convert.ToDecimal(taxaIOFAoMes);
Console.WriteLine($"IOF mensal........................: {valorIOFMensal:C2}");

valorIOFDiario = valorNaoPago * Convert.ToDecimal(taxaIOFAoDia * 30);
Console.WriteLine($"IOF diário........................: {valorIOFDiario:C2}");

valorMultaAtraso = valorNaoPago * percentualMultaAtraso;
Console.WriteLine($"Multa por atraso..................: {valorMultaAtraso:C2}");

Console.WriteLine();

valorProximaFatura = valorNaoPago + jurosSobreRotativo + valorIOFDiario + valorIOFMensal + valorMultaAtraso;
Console.WriteLine($"Valor a pagar na próxima fatura...: {valorProximaFatura:C2}");

custoCreditoRotativo = valorProximaFatura - valorNaoPago;
Console.WriteLine($"Custo do crédito rotativo.........: {custoCreditoRotativo:C2}");