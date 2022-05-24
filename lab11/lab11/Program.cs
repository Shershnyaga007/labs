class lab11
{
    private static StreamReader sr = new StreamReader("Inlet.txt");
    private static StreamWriter sw = new StreamWriter("Outlet.txt");
    private static char fn;

    private static void ReadFile()
    {
        List<String> text = new List<string>();
        text.Add(sr.ReadLine());
        string[] str = text[0].Split(' ');

        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i][0];

            if (ch.Equals(fn))
            {
                Console.WriteLine(str[i]);
                sw.WriteLine(str[i]);
                return;
            }
        }
        
        if (sr.EndOfStream)
        {
            Console.WriteLine("0");
            sw.WriteLine("0");
            return;
        }
        ReadFile();
    }
    
    public static void Main(string[] args)
    {
        fn = Convert.ToChar(sr.ReadLine());
        ReadFile();
        sr.Close();
        sw.Close();
        Console.ReadLine();
    }
}
