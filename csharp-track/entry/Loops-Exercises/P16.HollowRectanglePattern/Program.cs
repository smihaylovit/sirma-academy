internal class Program
{
    private static void Main(string[] args)
    {
        int numberOfRows = int.Parse(Console.ReadLine()!);
        int numberOfColumns = int.Parse(Console.ReadLine()!);

        for (int row = 1; row <= numberOfRows; row++)
        {
            for (int col = 1; col <= numberOfColumns; col++)
            {
                if (row == 1 || col == 1 || 
                    row == numberOfRows || col == numberOfColumns)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}