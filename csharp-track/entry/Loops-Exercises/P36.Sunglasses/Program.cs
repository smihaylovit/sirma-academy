internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine()!);

        if (number >= 3)
        {
            string topAndBottomLine = 
                new string('*', 2 * number) +
                new string(' ', number) +
                new string('*', 2 * number);
            Console.WriteLine(topAndBottomLine);

            for (int row = 2; row < number; row++)
            {
                string middleLine =
                    "*" + new string('/', 2 * number - 2) + "*" +
                    (row == number / 2 + number % 2 ?
                    new string('|', number) :
                    new string(' ', number)) +
                    "*" + new string('/', 2 * number - 2) + "*";
                Console.WriteLine(middleLine);
            }

            Console.WriteLine(topAndBottomLine);
        }
    }
}