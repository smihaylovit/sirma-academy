internal class Program
{
    private static void Main(string[] args)
    {
        var totalWeeklyConsumption = double.Parse(Console.ReadLine()!);
        var numberOfPeople = int.Parse(Console.ReadLine()!);
        var dailyConsumptionPerPerson = totalWeeklyConsumption / (numberOfPeople * 7);

        Console.WriteLine($"{dailyConsumptionPerPerson:f2}");
    }
}