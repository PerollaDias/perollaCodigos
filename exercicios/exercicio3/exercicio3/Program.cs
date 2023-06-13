Converter horas = new Converter();
Console.WriteLine("digite a hora desejada para converter: ");
double hora = Convert.ToDouble(Console.ReadLine());

double resulthr = horas.Hora(hora);
Console.WriteLine(resulthr);

Converter minutos = new Converter();
Console.WriteLine("digite o minuto desejado para converter: ");
double minuto = Convert.ToDouble(Console.ReadLine());

double resultmn = minutos.Minutos(minuto);
Console.WriteLine(resultmn);

Converter segundos = new Converter();
Console.WriteLine("digite o segundo desejado para converter: ");
double segundo = Convert.ToDouble(Console.ReadLine());

double resultsg = segundos.Segundos(segundo);
Console.WriteLine(resultsg);

Console.ReadKey();