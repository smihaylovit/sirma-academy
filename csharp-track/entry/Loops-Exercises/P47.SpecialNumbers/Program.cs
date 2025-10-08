internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine()!);

        for (int i = 1111; i <= 9999; i++)
        {
            if (!i.ToString().Contains('0'))
            {
                int currentNumber = i;
                bool isSpecial = true;

                while (currentNumber > 0)
                {
                    int digit = currentNumber % 10;

                    if (number % digit != 0)
                    {
                        isSpecial = false;
                        break;
                    }

                    currentNumber /= 10;
                }

                if (isSpecial)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}