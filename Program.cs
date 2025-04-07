double  tempoDeUso, consumoPorMes, custoluz;
Console.WriteLine("Calculo de Consumo");
Console.Write("Consumo do aparelho (em kWh/mês)...: ");
consumoPorMes = Convert.ToDouble(Console.ReadLine());
Console.Write("\nHoras de uso por dia...............: ");
tempoDeUso = Convert.ToDouble(Console.ReadLine());
Console.Write("\nCusto da energia (em R$/kWh).......: ");
custoluz = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Custo estimado: R${tempoDeUso * consumoPorMes * custoluz}");


