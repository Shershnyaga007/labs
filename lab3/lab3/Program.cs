using System.Globalization;
using System.Runtime.CompilerServices;

public class lab3
{

    public static int n, k;
    public static string? a_, b_, tochnost_;
    public static double x, x_o,a, b, tochnost, koren;
    public static double f(double x)
    {
        return x + Math.Cos(Math.Pow(x, 0.52) + 2);
    }
    
    public static double f1(double x)
    {
        return 1 - ((0.52*Math.Sin(Math.Pow(x, 0.52) + 2))/ Math.Pow(x, 0.48));
    }
    
    public static double f2(double x)
    {
        return - ((0.0208 * (13 * Math.Pow(x, 0.52)* Math.Cos(Math.Pow(x, 0.52)+2)- 12 * Math.Sin(Math.Pow(x, 0.52)+2)))/ Math.Pow(x, 1.48));
    }

    public static double np(double a, double b)
    {
        if (f1(a) * f2(a) > 0)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    public static double znach(double a, double b, double tochnost)
    {
        x = np(a, b);
        double test;
        while (Math.Abs(x - x_o) > tochnost)
        {
            x_o = x;
            Console.WriteLine(x);
            test = x;
            x = test - f(x) / f1(x);
        }
        
        return x;
    }
    
    public static void Main(String[] args)
    {
        x_o = 0;
        while (true)
        {
            Console.WriteLine("Введите a, b, tochnost: ");
            a_ = Console.ReadLine();
            b_ = Console.ReadLine();
            tochnost_ = Console.ReadLine();
            a = Convert.ToDouble(a_);
            b = Convert.ToDouble(b_);
            tochnost = Convert.ToDouble(tochnost_);

            //----------------------------
            koren = znach(a, b, tochnost);
            //----------------------------
            
            Console.WriteLine($"Ответ: {Convert.ToString(tochnost, CultureInfo.InvariantCulture)}");
            Console.WriteLine("----------------------------");
        } 
    }
}