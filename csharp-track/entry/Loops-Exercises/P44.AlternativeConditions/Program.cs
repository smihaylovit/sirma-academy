internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine()!);
        int currentRow = 1;
        int rowStartNumber = 1;
        var lines = new List<string>();

        while (rowStartNumber <= number)
        {
            int rowEndNumber = Math.Min(number, rowStartNumber + currentRow - 1);
            string line = string.Empty;

            for (int i = rowStartNumber; i <= rowEndNumber; i++)
            {
                line += $" {i}";
            }

            line = line.TrimStart();
            lines.Add(line);
            currentRow++;
            rowStartNumber = rowEndNumber + 1;
        }

        var lastNumbers = lines.
            Select(l => " " + string.Join("", l.Split(' ').TakeLast(1)));
        var linesWithoutLastNumber = lines
            .Select(l => string.Join(' ', l.Split(' ').SkipLast(1)));
        int startingIndentation = linesWithoutLastNumber
            .Max(l => l.Length);
        linesWithoutLastNumber = linesWithoutLastNumber
            .Select(l => new string(' ', startingIndentation - l.Length) + l);
        var rightIndentedLines = linesWithoutLastNumber
            .Select((l, index) => l + lastNumbers.ElementAt(index))
            .ToList();

        // Should it be completely centered from both sides?
        // If yes not every row will contain exactly row numbers or
        // not all numbers will be separated with a single interval
        var centerIndentedLines = lines
            .Select((l, index) =>
                new string(' ', currentRow - index - 2) +
                l +
                new string(' ', currentRow - index - 2)
            );

        foreach (var line in rightIndentedLines)
        {
            Console.WriteLine(line);
        }

        Console.WriteLine();

        foreach (var line in centerIndentedLines)
        {
            Console.WriteLine(line);
        }
    }
}