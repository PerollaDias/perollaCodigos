Juros juros = new Juros();

Console.WriteLine("digite o juros desejado para calcular: ");
double juro = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("digite o valor desejado para calcular: ");
double valor = Convert.ToDouble(Console.ReadLine());


double resultadoj = juros.Calcularjuros(valor,juro );
Console.WriteLine(resultadoj);

Juros valord = new Juros();
valord.Calcularjuros(valor,juro);
double resultadov = valord.Calcularjuros(valor, juro)+valor;
Console.WriteLine(resultadov);

Console.ReadKey();