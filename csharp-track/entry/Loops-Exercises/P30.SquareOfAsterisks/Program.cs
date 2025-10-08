internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine()!);

        for (int row = 0; row < number; row++)
        {
            string line = string.Empty;

            for (int col = 0; col < number; col++)
            {
                line += "* ";
            }

            line = line.Trim();
            Console.WriteLine(line);
        }
    }
}