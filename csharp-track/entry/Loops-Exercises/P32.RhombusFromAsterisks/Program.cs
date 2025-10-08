internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine()!);
        int rows = 2 * number - 1;

        for (int row = 1; row <= rows; row++)
        {
            int intervalsCount = Math.Abs(number - row);
            int asterisksCount = row <= number ? row : 2 * number - row;
            string intervals = new string(' ', intervalsCount);
            string line = intervals;

            for (int i = 1; i <= asterisksCount; i++)
            {
                line += "* ";
            }

            line = line.TrimEnd();
            line += intervals;
            Console.WriteLine(line);
        }
    }
}