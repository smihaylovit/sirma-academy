internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()!);
        int M = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= N; i += M)
        {
            Console.WriteLine(i);
        }
    }
}