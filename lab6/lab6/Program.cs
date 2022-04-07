using Microsoft.VisualBasic.CompilerServices;

class lab6
{
    public static double e, S;
    
    public static  StreamReader sr = new StreamReader("Inlet.txt");
    public static StreamWriter sw = new StreamWriter("Outlet.txt");
    
    public static double Sum(int n, double fac, double e, double slag)
    {
        if (Math.Abs(slag) >= e)
            return slag + Sum(n + 1, fac * (n + 1), e, Math.Pow(-1, n) * (n + 1) / fac);
        else
            return 0;
    }
    
    public static void Main(string[] args)
    {

        // e Считывается из файла Inlet
        e = Convert.ToDouble(sr.ReadLine());
        S = Sum(0, 1, e, 1);
        
        // вывести S в Outlet
        Console.WriteLine(e);
        sw.WriteLine(S);
        sr.Close();
        sw.Close();
    }
}