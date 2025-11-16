internal class Program
{
    private static void Main(string[] args)
    {
        int biomassUnits = int.Parse(Console.ReadLine()!);
        int growthUnits = int.Parse(Console.ReadLine()!);
        int hours = int.Parse(Console.ReadLine()!);
        double totalBiomass = 0;

        for (int hour = 0; hour < hours; hour++)
        {
            double growthBiomass = biomassUnits + hour * (double)growthUnits;
            totalBiomass += growthBiomass;
        }

        Console.WriteLine(totalBiomass);
    }
}