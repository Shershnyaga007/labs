class lab5
{
    public static int k, n, i;
    public static double Sum, Sump, tochn, x, fac;
    public static string? x_s, tochn_s;
    public static void Main(string[] args)
    {
        while (true)
        {
            Sum = 0;
            Sump = 0;
            fac = 1;
            n = 0;
            Console.Write("Введите X: ");
            x_s = Console.ReadLine();
            x = Convert.ToDouble(x_s);
            Console.Write("Введите точность: ");
            tochn_s = Console.ReadLine();
            tochn = Convert.ToDouble(tochn_s);
            
            if (n > 0)
                fac = 2 * n * fac;

            Sum = Sum + Math.Pow(-1, n) * (Math.Pow(x, 2 * n)) / fac;

            n = n + 1;

            while ((Math.Abs(Sum - Sump) > tochn))
            {
                Sump = Sum;

                if (n > 0)
                    fac = 2 * n * fac;

                Sum = Sum + Math.Pow(-1, n) * (Math.Pow(x, 2 * n)) / fac;

                n = n + 1;
            }
            Console.WriteLine($"Sum: {Sum}");
            Console.WriteLine($"n: {n}");
        }
    }
}