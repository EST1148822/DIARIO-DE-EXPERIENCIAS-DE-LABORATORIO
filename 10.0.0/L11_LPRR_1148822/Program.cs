using System;

class Program
{
    public static double conversionMoneda(double dolares)
    {

        double euros = dolares * 0.75;
        return euros;
    }
    public static double conversionMoneda2(double libra)
    {
        double euros2 = libra * 1.22;
        return euros2;
    }
    public static double conversionMoneda3(double yenes)
    {
        double euros3 = yenes * 0.009;
        return euros3;
    }

    static void Main()
    {
        
        double e = 0, d = 0;

        Console.WriteLine("Ingrese monto en dolares");
        e = Double.Parse(Console.ReadLine());
        d = conversionMoneda(e);
        Console.WriteLine("En euros " + d);

        double a, b;

        Console.WriteLine("Ingrese monto en libras");
        a = Convert.ToDouble(Console.ReadLine());
        b = conversionMoneda2(a);
        Console.WriteLine("En euros " + b);

        double x, y;

        Console.WriteLine("Ingrese monto en yenes");
        x = Double.Parse(Console.ReadLine());
        y = conversionMoneda3(x);
        Console.WriteLine("En euros " + y);

    }
}
