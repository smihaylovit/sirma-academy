internal class Program
{
    private static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine()!);
        var factorial = 1;

        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);
    }
}