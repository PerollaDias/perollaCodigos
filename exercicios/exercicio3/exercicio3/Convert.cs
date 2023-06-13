public class Converter
{
    public double Hora(double hora)
    {
        return hora * 60;
    }

    public double Minutos(double minutos)
    {
        return minutos * 60;
    }

    public double Segundos(double segundos)
    {
        return (segundos * 60) * 60;
    }
}