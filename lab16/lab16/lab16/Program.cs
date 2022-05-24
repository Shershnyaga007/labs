class lab16
{
    public static StreamReader sr = new StreamReader("Inlet.txt");
    public static double b, q;
    public static double N, i, P;
    public static List<double> Vector = new List<double>();
    public static void NiP()
    {
        string[] s = sr.ReadLine().Split(' ');
        N = Convert.ToDouble(s[0]);
        i = Convert.ToDouble(s[1]) - 1;
        P = Convert.ToDouble(s[2]);
    }

    public static void Progress(double b, double q)
    {
        Console.Write($"Первые 10 членов прогрессии: {b} ");

        for (int i = 1; i <= 10; i++)
        {
            b *= q;

            Console.Write($"{b} ");
        }

        Console.WriteLine();
    }
    public static void vec()
    {
        if (sr.EndOfStream)
            return;

        Vector.Add(Convert.ToDouble(sr.ReadLine()));

        vec();
    }

    public static void Preobrazowanie(List<double> Vector, double i)
    {
        Console.Write("Преобразование: ");


        int index = 0;

        for (int j = 1; j < Vector.Count; j++)
            if (Vector[j] < Vector[j - 1])
                index = j - 1;
            else
                index = j;

        double el1 = Vector[index];
        double el2 = Vector[Convert.ToInt16(i)];

        List<double> vec = Vector;
        vec[index] = el2;
        vec[Convert.ToInt16(i)] = el1;

        for (int j = 0; j < vec.Count; j++)
            Console.Write($"{vec[j]} ");

        Console.WriteLine();
    }

    public static void Widilenie(List<double> Vector)
    {
        Console.Write($"Выделение/Построение: ");

        for (int j = 0; j < Vector.Count; j++)
            if ((Vector[j] - Math.Floor(Vector[j])) <= 0.5)
                Console.Write($"{Vector[j]} ");

        Console.WriteLine();


    }

    public static void Raschet(List<double> Vector, double P)
    {
        Console.Write("Расчет: ");
        double sum = 0;
        for (int j = 0; j < Vector.Count(); j++)
        {
            double num = Math.Floor(Vector[j]);
            double num1 = P / num;

            if (num1 - Math.Floor(num1) == 0)
                sum += Vector[j];
        }

        Console.WriteLine($"{sum}");

    }

    public static void Poisk(List<double> Vector)
    {
        Console.Write($"Поиск: ");

        List<double> Vector1 = Vector;

        double max = Vector1[0];
        double min = Vector1[0];

        for (int j = 1; j < Vector1.Count; j++)
        {
            if (Vector[j] < min)
                min = Vector1[j];

            if (Vector[j] > max)
                max = Vector1[j];    
        }

        Console.WriteLine(max - min);
    }

    public static void Main1()
    {
        NiP();
        vec();
        Console.WriteLine("-------\nДанные:");
        Console.WriteLine($"N: {N}");
        Console.WriteLine($"i: {i}");
        Console.WriteLine($"P: {P}");
        Console.Write("Вектор: ");
        for (int i = 0; i < Vector.Count; i++)
            Console.Write($"{Vector[i]} ");
        Console.WriteLine();
        Console.WriteLine("-------\nРешение:");

        Progress(b, q);
        List<double> b11 = Vector;
        Preobrazowanie(Vector, i);
        Widilenie(Vector);
        Raschet(Vector, P);
        Poisk(Vector);

        sr.Close();
        Console.ReadKey();
    }

}

class Choose {
    public static  void Main()
    {
        Console.Write("Введите b и q: \n> ");

        string[] bq = Console.ReadLine().Split(' ');

        lab16.b = Convert.ToInt16(bq[0]);
        lab16.q = Convert.ToInt16(bq[1]);

        lab16.Main1();
    }
}