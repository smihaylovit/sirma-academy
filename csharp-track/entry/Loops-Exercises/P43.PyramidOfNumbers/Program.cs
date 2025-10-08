internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine()!);
        int currentRow = 1;
        int rowStartNumber = 1;

        while (rowStartNumber <= number)
        {
            int rowEndNumber = Math.Min(number, rowStartNumber + currentRow - 1);

            for (int i = rowStartNumber; i <= rowEndNumber; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            currentRow++;
            rowStartNumber = rowEndNumber + 1;
        }
    }
}