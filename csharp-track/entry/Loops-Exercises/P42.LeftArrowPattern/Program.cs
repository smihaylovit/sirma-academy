internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine()!);
        int rowsCount = 2 * number - 3;

        for (int row = 1; row <= rowsCount; row++)
        {
            int intervalsCount = number - row - 1;

            if (row > rowsCount / 2 + 1)
            {
                intervalsCount = row - number + 1;
            }

            int asterisksCount = number - 1 - intervalsCount;
            string intervals = new string(' ', intervalsCount);
            string asterisks = new string('*', asterisksCount);
            string line = intervals + asterisks;
            Console.WriteLine(line);
        }
    }
}