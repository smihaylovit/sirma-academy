internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine()!);
        int rowsCount = number - (number + 1) % 2;
        int middleRowIndex = rowsCount / 2 + 1;

        string topAndBottomLine = new string('#', number + 2);
        Console.WriteLine(topAndBottomLine);

        for (int row = 1; row <= rowsCount; row++)
        {
            int sideIntervalsCount = row;

            if (row > middleRowIndex)
            {
                sideIntervalsCount = rowsCount - row + 1;
            }

            bool isSingleSymbolCenter = number % 2 == 1 && row == middleRowIndex;
            int middleIntervalsCount = 
                number - 2 * sideIntervalsCount + (isSingleSymbolCenter ? 1 : 0);
            string line =
                new string(' ', sideIntervalsCount) + "#" +
                new string(' ', middleIntervalsCount) + 
                (!isSingleSymbolCenter ? "#" : string.Empty) +
                new string(' ', sideIntervalsCount);
            Console.WriteLine(line);
        }

        Console.WriteLine(topAndBottomLine);
    }
}