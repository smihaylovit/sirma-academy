internal class Program
{
    private static void Main(string[] args)
    {
        int houseHeight = int.Parse(Console.ReadLine()!);

        if (houseHeight >= 3)
        {
            int rows = houseHeight / 2 + houseHeight % 2;
            int asterisksCount = (houseHeight + 1) % 2 + 1;
            int intervalsCount = houseHeight - asterisksCount;

            for (int row = 1; row <= rows; row++)
            {
                string intervals = new string(' ', intervalsCount);
                string asterisks = string.Empty;

                for (int count = 1; count <= asterisksCount; count++)
                {
                    asterisks += "* ";
                }

                asterisks.TrimEnd();
                string line = intervals + asterisks + intervals;
                Console.WriteLine(line);
                asterisksCount += 2;
                intervalsCount -= 2;
            }

            string bottomLine = "*" + new string(' ', 2 * houseHeight - 3) + "*";
            Console.WriteLine(bottomLine);
            Console.WriteLine(bottomLine);
        }
    }
}