internal class Program
{
    private static void Main(string[] args)
    {
        int rowsCount = int.Parse(Console.ReadLine()!);
        int symbolsPerLine = 2 * rowsCount - 3;

        for (int row = 1; row <= rowsCount - 1; row++)
        {
            string intervals = new string(' ', rowsCount - row - 1);
            string asterisks = string.Empty;

            for (int i = 1; i <= row; i++)
            {
                asterisks += "* ";
            }

            asterisks.TrimEnd();
            string line = intervals + asterisks + intervals;
            Console.WriteLine(line);
        }

        int bottomLineAsterisksCount = symbolsPerLine / 2 + (rowsCount + 1) % 2;
        int bottomLineIntervalsCount = (symbolsPerLine - bottomLineAsterisksCount) / 2;
        string bottomLine =
            new string(' ', bottomLineIntervalsCount) +
            new string('*', bottomLineAsterisksCount) +
            new string(' ', bottomLineIntervalsCount);

        for (int row = 1; row <= rowsCount - 1; row++)
        {
            Console.WriteLine(bottomLine);
        }
    }
}