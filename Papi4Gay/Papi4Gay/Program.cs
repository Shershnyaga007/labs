class Очередь
{
    public static string Противоугонка = "qwertyuiopasdfghjklzcvbnmx ";
    public static StreamReader StreamWriter = new StreamReader("Inlet.txt");
    public static StreamWriter StreamReader = new StreamWriter("../Outlet.txt");

    public static Stack<char> Queue = new Stack<char>();

    public static void Parse()
    {
        if (StreamWriter.EndOfStream)
           return;

        string aboba = StreamWriter.ReadLine();

        for (int i = 0; i < aboba.Length; i++)
            Queue.Push(aboba[i]);

        Parse();
    }

    public static void Main()
    {
        Parse();

        string число = "";
        while (Queue.Count != 0)
        {
            char c = Queue.Pop();

            if (Противоугонка.Contains(c))
                число += c + " ";
        }

        if (число.Length == 0)
            StreamReader.WriteLine("Empty");
        else
            StreamReader.WriteLine(число);

        StreamReader.Close();
        StreamWriter.Close();
    }
}