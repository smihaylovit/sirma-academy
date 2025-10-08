internal class Program
{
    private static void Main(string[] args)
    {
        int treeHeight = int.Parse(Console.ReadLine()!);

        for (int row = 1; row <= treeHeight; row++)
        {
            int intervalsCount = treeHeight - row;
            int asterisksCount = 2 * row - 1;
            string intervals = new string(' ', intervalsCount);
            string asterisks = new string('*', asterisksCount);
            string line = intervals + asterisks + intervals;
            Console.WriteLine(line);
        }

        string lastLineIntervals = new string(' ', treeHeight - 1);
        string lastLine = lastLineIntervals + "*" + lastLineIntervals;
        Console.WriteLine(lastLine);
    }
}