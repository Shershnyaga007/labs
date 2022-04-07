using System.Formats.Asn1;
using System.Linq.Expressions;

class lab10
{
    public static int N1, M1, i1, k1;
    public static int SZ1, SW1, YW1, YZ1;

    public static string text;

    public static int i2 = 0;
    
    public static  StreamReader sr = new StreamReader("Inlet.txt");
    public static StreamWriter sw = new StreamWriter("Outlet.txt");

    public static void parse()
    {
        List<String> words = new List<string>();
        
        words.Add(sr.ReadLine());
        string[] num = words[0].Split(' ');
        
        N1 = Convert.ToInt16(num[0]);
        M1 = Convert.ToInt16(num[1]);

        SW1 = Convert.ToInt16(num[2]);
        SZ1 = Convert.ToInt16(num[3]);
        YW1 = Convert.ToInt16(num[4]);
        YZ1 = Convert.ToInt16(num[5]);
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
        Console.Write($"{res} ");
        if (i == N && k == M) return;
        find(N, M, SW, SZ, YW, YZ, i, k);
    }
    
    public static void Main(string[] args)
    {
        parse();

        i1 = 0;
        k1 = 0;

        N1 = M1;
        find(N1, M1, SW1, SZ1, YW1, YZ1, 0, 0);
        
        sr.Close();
        sw.Close();
    }
}
