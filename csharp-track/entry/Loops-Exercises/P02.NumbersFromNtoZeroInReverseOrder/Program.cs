internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()!);

        for (int i = N; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
    }
}