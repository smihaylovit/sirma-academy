internal class Program
{
    private static void Main(string[] args)
    {
        int rowsCount = int.Parse(Console.ReadLine()!);

        for (int row = 1; row <= rowsCount; row++)
        {
            string intervals = new string(' ', rowsCount - row);
            string line = intervals;

            for (int i = row; i <= 2 * row - 1; i++)
            {
                line += i;
            }

            for (int i = 2 * row - 2; i >= row; i--)
            {
                line += i;
            }

            line += intervals;
            Console.WriteLine(line);
        }
    }
}