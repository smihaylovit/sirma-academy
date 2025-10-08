internal class Program
{
    private static void Main(string[] args)
    {
        int treeSize = int.Parse(Console.ReadLine()!);

        for (int row = 0; row <= treeSize; row++)
        {
            string asterisks = new string('*', row);
            string intervals = new string(' ', treeSize - row);
            string line = intervals + asterisks + " | " + asterisks + intervals;
            Console.WriteLine(line);
        }
    }
}