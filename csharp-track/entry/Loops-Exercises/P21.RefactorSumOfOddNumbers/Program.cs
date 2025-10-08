internal class Program
{
    private static void Main(string[] args)
    {
        int oddNumberCount = int.Parse(Console.ReadLine()!);
        int sumOfOddNumbers = 0;

        for (int i = 0; i < oddNumberCount; i++)
        {
            int currentNumber = 2 * i + 1;
            Console.WriteLine(currentNumber);
            sumOfOddNumbers += currentNumber;
        }

        Console.WriteLine($"Sum: {sumOfOddNumbers}");
    }
}