internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= N; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}