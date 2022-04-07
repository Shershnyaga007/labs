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
        for (int i = 0; i < N; i++) Console.Write($"{Convert.ToString(A[i])} ");
        Console.WriteLine();

        for (int i = 1; i < N; i++)
        {
            if (!(A[i - 1] > A[i] && A[i] < A[i + 1]))
            {
                B[k] = A[i];
                k = k + 1;
            }
        }
        
        sr.Close();

        for (int i = 1; i < k; i++)
        {
            Console.Write($"{B[i]} ");
            sw.Write($"{B[i]} ");
        }
        
        sw.Close();
    }
}