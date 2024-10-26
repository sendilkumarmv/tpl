internal static class Program
{
    public static void Main(string[] args)
    {
        Task.Factory.StartNew(() => Print('.'));
        var task1 = new Task(() => Print('?'));
        task1.Start();

        Print('-');

        Console.WriteLine("Main method done");
        Console.ReadKey();
    }
    public static void Print(char ch)
    {
        int i = 1000;
        while(i -- > 0)
        {
            Console.Write(ch);
        }
    }
}
