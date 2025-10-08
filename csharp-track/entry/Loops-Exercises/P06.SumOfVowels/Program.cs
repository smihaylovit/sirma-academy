internal class Program
{
    private static void Main(string[] args)
    {
        var text = Console.ReadLine()!;
        var sumOfVowels = 0;

        for (int i = 0; i < text.Length; i++)
        {
            var currentLetter = text[i];

            switch (currentLetter)
            {
                case 'a':
                    sumOfVowels += 1;
                    break;
                case 'e':
                    sumOfVowels += 2;
                    break;
                case 'i':
                    sumOfVowels += 3;
                    break;
                case 'o':
                    sumOfVowels += 4;
                    break;
                case 'u':
                    sumOfVowels += 5;
                    break;
            }
        }

        Console.WriteLine(sumOfVowels);
    }
}