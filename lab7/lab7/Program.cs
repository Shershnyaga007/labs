class lab7
{

    public static int N, k;
    public static int[] A = new int[20], B = new int[20];

    public static  StreamReader sr = new StreamReader("Inlet.txt");
    public static StreamWriter sw = new StreamWriter("Outlet.txt");

    public static void Main(string[] args)
    {
        k = 0;
        N = Convert.ToInt16(sr.ReadLine());

        for (int i = 0; i < N; i++) A[i] = Convert.ToInt16(sr.ReadLine());
        for (int i = 0; i < N; i++) Console.Write($"{A[i]} ");
        Console.WriteLine();

        for (int i = 1; i < N+2; i++)
        {
            if ((A[i - 1] > A[i]) && (A[i] < A[i + 1]))
            {
            }
            else
            {
                B[k] = i;
                k++;
            }
        }
        
        sr.Close();

        for (int i = 0; i <= k; i++)
        {
            if (B.Contains(i))
            {
                Console.Write($"{i+1} ");
                sw.Write($"{i+1} ");
            }
        }
        
        sw.Close();
    }
}