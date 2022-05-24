class lab15
{
    public static Queue<int> queue = new Queue<int>();
    public static Queue<int> queue2 = new Queue<int>();

    public static String num = "";
    public static int numCount = 0;

    public static int A, B;

    public static StreamReader sr = new StreamReader("Inlet.txt");
    public static StreamWriter sw = new StreamWriter("Outlet.txt");

    public static void i()
    {
        String[] str = sr.ReadLine().Split(' ');
        A = Convert.ToInt16(str[0]);
        B = Convert.ToInt16(str[1]);
    }


    public static void Parse()
    {
        if (sr.EndOfStream)
            return;

        String[] str = sr.ReadLine().Split(' ');

        for (int i = 0; i < str.Length; i++)
            queue.Enqueue(int.Parse(str[i]));

        Parse();
    }

    public static void out_()
    {
        while (true)
        {
            try
            {
                if (queue.Peek() >= A && queue.Peek() <= B)
                {
                    numCount++;
                    queue2.Enqueue(queue.Dequeue());
                }
                else
                    queue.Dequeue();
            } 
            catch(System.InvalidOperationException)
            {
                return;
            }
        }
    }

    public static void ou()
    {
        try
        {
            num = $"{num}{queue2.Dequeue()} ";
        }
        catch (System.InvalidOperationException)
        {
            return;
        }
        ou();
    }

    public static void Main()
    {
        i();
        Parse();
        sr.Close();

        out_();

        ou();

        if (numCount > 0)
        {
            sw.WriteLine(numCount);
            sw.WriteLine(num);
        }
        else
            sw.WriteLine("-1");

        sw.Close();
    }
}