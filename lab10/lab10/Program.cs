using System.Formats.Asn1;
using System.Linq.Expressions;

class lab10
{

    public static int[,] mass = new int[100, 100];

    public static int N1, M1, i1, k1;
    public static int SZ1, SW1, YW1, YZ1;
    
    public static  StreamReader sr = new StreamReader("Inlet.txt");
    public static StreamWriter sw = new StreamWriter("Outlet.txt");

    public static void 
    
    public static void PasrseSides()
    {
        string text = sr.ReadToEnd();
        int[] side = new int[5];
        
        text.Split(' ');
        
    }
    
    public static void find(int N, int M, int SW, int SZ, int YW, int YZ, int i, int k)
    {
        int res;
        if (k == M)
        {
            i++;
            k = 0;
            Console.WriteLine();
            sw.WriteLine();
        }

        if (i == 0 && k == 0) res = SW;
        else if (i == 0 && k == M - 1) res = SZ;
        else if (i == N - 1 && k == M - 1) res = YZ;
        else if (i == N - 1 && k == 0) res = YW;
        else if (i < (N - 1) / 2 && k < (N - 1) / 2) res = SW;
        else if (i < (N - 1) / 2 && k > (N - 1) / 2) res = SZ;
        else if (i > (N - 1) / 2 && k > (N - 1) / 2) res = YZ;
        else if (i > (N - 1) / 2 && k < (M - 1) / 2) res = YW;
        else if (i == ((N - 1) / 2) && k < (N - 1) / 2) res = SW + YW;
        else if (i == ((N - 1) / 2) && k > (N - 1) / 2) res = SZ + YZ;
        else if (i < ((N - 1) / 2) && k == (N - 1) / 2) res = SW + SZ;
        else if (i > ((N - 1) / 2) && k == (N - 1) / 2) res = YW + YZ;
        else if (i == ((N - 1) / 2) && k == (N - 1) / 2) res = YW + YZ + SZ + SW;
        else res = 0;

        k++;
        
        sw.Write($"{res} ");
        Console.WriteLine($"{res} ");
        if (i == N && k == M) return;
        find(N, M, SW, SZ, YW, YZ, i, k);
    }
    
    public static void Main(string[] args)
    {
        
    }
}
