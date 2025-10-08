internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine()!);
        int rows = 2 * number - 1;

        for (int row = 1; row <= rows; row++)
        {
            int cols;

            if (row <= number)
            {
                cols = row;
            }
            else
            {
                cols = 2 * number - row;
            }

            for (int col = 1; col <= cols; col++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
    }
}