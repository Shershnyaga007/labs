class lab9
{
    public static StreamReader sr;
    public static StreamWriter sw = new StreamWriter("Outlet.txt");
    public static char ch;
    public static int count = 0;

    public static void find()
    {
        List<string> str = new List<string>();
        str.Add(sr.ReadLine());
        string[] n = str[0].Split(' ');
        
        for (int i = 0; i < n.Length; i++)

        {
            string word = n[i];
            if (word.EndsWith(ch)) count++;
        }

        if (sr.EndOfStream)
        {
            if (count == 1)
            {
                sw.WriteLine("-1");
                Console.WriteLine("-1");
            }
            else
            {
                sw.WriteLine(count-1);
                Console.WriteLine(count-1);
            }
            return;
        }
        find();
    }
    
    public static void Main(string[] args)
    {
        List<string> l = new List<string>();
        StreamReader r = new StreamReader("Inlet.txt");
        while (!r.EndOfStream)
        {
            l.Add(r.ReadLine());
        }

        ch = Convert.ToChar(l[l.Count-1][0]);
        r.Close();
        sr = new StreamReader("Inlet.txt");
        find();
        sw.Close();
        sr.Close();
        Console.ReadLine();
    }
}