class lab13
{
    public static StreamReader sr = new StreamReader("Inlet.txt");
    public static StreamWriter sw = new StreamWriter("Outlet.txt");

    public static int N, kol1, kol2;
    public static short[,] matrix;

    public static HashSet<short> Set1, Set2, SetD;
    public static void Parse()
    {
        string[] u = sr.ReadLine().Split(' ');
        N = Convert.ToInt16(u[0]);

        matrix = new short[N, N];

        for (int i = 0; i < N; i++)
        {
            string[] ou = sr.ReadLine().Split(' ');
            for (int k = 0; k < N; k++)
                matrix[k, i] = Convert.ToInt16(ou[k]);
        }

        sr.Close();
    }

    public static void Main()
    {
        Parse();

        // Диагональ
        SetD = new HashSet<short>();
        for (int i = 0; i < N; i++)
            SetD.Add(matrix[i, i]);

        // Выше диагонали
        Set1 = new HashSet<short>();
        for (int i = 0; i < N; i++)
            for (int j = i + 1; j < N; j++)
            {
                Set1.Add(matrix[i, j]);
            }


        // Ниже диагонали
        Set2 = new HashSet<short>();
        for (int i = 1; i < N; i++)
            for (int j = 0; j <= i-1; j++)
                Set2.Add(matrix[i, j]);

        kol1 = 0;
        kol2 = 0;
        for (short i = -127; i >= -127 && i <= 127; i++)
            if (Set1.Contains(i))
                kol1++;
        for (short i = -127; i >= -127 && i <= 127; i++)
            if (Set2.Contains(i))
            kol2++;

        if (kol1 > kol2)
            for (short i = -127; i >= -127 && i <= 127; i++)
                if (Set1.Contains(i))
                    sw.Write($"{i} ");
        if (kol1 < kol2)
            for (short i = -127; i >= -127 && i <= 127; i++)
                if (Set2.Contains(i))
                    sw.Write($"{i} ");
        if (kol1 == kol2)
            for (short i = -127; i >= -127 && i <= 127; i++)
                if (SetD.Contains(i))
                    sw.Write($"{i} ");

        sw.Close();
    }
}