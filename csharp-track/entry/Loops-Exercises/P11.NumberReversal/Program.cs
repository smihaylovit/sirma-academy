internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine()!;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write(input[i]);
        }

        Console.WriteLine();
    }
}