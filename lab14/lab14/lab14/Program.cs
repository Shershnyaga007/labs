class lab14 
{
    public static StreamReader sr = new StreamReader("Inlet.txt");
    public static StreamWriter sw = new StreamWriter("Outlet.txt");
    public static Stack<int> inStack = new Stack<int> ();
    public static Stack<int> outStack = new Stack<int> ();
    public static List<int> inList = new List<int> ();

    public static void FileRead()
    {
        if (sr.EndOfStream)
            return;

        string line = sr.ReadLine();

        string[] Snumbers = line.Split(' ');

        for (int i = 0; i < Snumbers.Length; i++)
            try
            {
                inStack.Push(Convert.ToInt16(Snumbers[i]));
            }
            catch (System.FormatException)
            {
                return;
            }

        FileRead();
    }

    public static void Main()
    {
        int count_ = 0;
        FileRead();
        sr.Close();

        Console.WriteLine("Done!");

        int stackCount = inStack.Count;
        Console.WriteLine(stackCount);
        for (int i = 0; i < stackCount; i++)
        {
            int num = inStack.Pop();

            if (!inList.Contains(num))
            {
                inList.Add(num);
                count_++;
            }
            

            outStack.Push(num);
        }

        string str = "";

        for (int i = inList.Count-1; i >=0; i--)
        {
            str = $"{str}{inList[i]} ";
        }

        sw.WriteLine(count_);
        sw.Write(str);

        sw.Close();
    }
}