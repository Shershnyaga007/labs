class lab8
{
    public static StreamReader sr = new StreamReader("Inlet.txt");
    public static StreamWriter sw = new StreamWriter("Outlet.txt");
    public static int[,] matrix;
    public static int N, M;

    public static void GetMatrix()
    {
        string[] nm = sr.ReadLine().Split(' ');
        N = int.Parse(nm[0]) - 1;
        M = int.Parse(nm[1]) - 1;

        matrix = new int[N+2, M+2];

        for (int i = 0; i <= M; i++)
        {

            nm = sr.ReadLine().Split(' ');

            for (int k = 0; k <= N; k++)
                matrix[k, i] = Convert.ToInt16(nm[k]);

        }
        sr.Close();
    }
    public static void Main()
    {
        GetMatrix();

        for (int i = 0; i <= M; i++)
        {
            for (int k = 0; k <= N; k++)
                Console.Write(matrix[k, i] + " ");
            Console.WriteLine();
        } 
        
        Console.WriteLine("-----------------");

        int sum = 0;
        int str = 0;
        while (str <= M)
        {
            sum = 0;
            for (int column = 0; column <= N; column++)
                if (matrix[column, str] >= 0)
                    sum = sum + matrix[column, str];
                else 
                    sum = sum - matrix[column, str];

            if (sum == 0)
            {
                for (int row = str; row <= M; row++)
                    for (int column = 0; column <= N; column++)
                        matrix[column, row] = matrix[column, row + 1];
                M--;
            }
            else
                str++;
        }

        int stb = 0;

        while (stb <= N)
        {
            sum = 0;
            for (int row = 0; row <= M; row++)
                if (matrix[stb, row] >= 0)
                    sum = sum + matrix[stb, row];
                else
                    sum = sum = matrix[stb, row];

            if (sum == 0)
            {
                for (int column = stb; column <= N; column++)
                    for (int row = 0; row <= M; row++)
                        matrix[column, row] = matrix[column + 1, row];
                N--;
            }
            else 
                stb++;
        }

        for (int i = 0; i <= M; i++)
        {
            for (int k = 0; k <= N; k++)
                Console.Write(matrix[k, i] + " ");
            Console.WriteLine();
        }

        for (int i = 0; i <= M; i++)
        {
            for (int k = 0; k <= N; k++)
                sw.Write(matrix[k, i] + " ");
            sw.WriteLine();
        }

        sw.Close();
    }
}