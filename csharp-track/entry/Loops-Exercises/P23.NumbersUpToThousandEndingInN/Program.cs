internal class Program
{
    private static void Main(string[] args)
    {
        int endDigit = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= 1000; i++)
        {
            if (i % 10 == endDigit)
            {
                Console.WriteLine(i);
            }
        }
    }
}