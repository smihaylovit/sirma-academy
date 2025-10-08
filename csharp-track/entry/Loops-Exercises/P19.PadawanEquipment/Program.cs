internal class Program
{
    private static void Main(string[] args)
    {
        var budget = double.Parse(Console.ReadLine()!);
        var studentsCount = int.Parse(Console.ReadLine()!);
        var lightsaberPrice = double.Parse(Console.ReadLine()!);
        var robePrice = double.Parse(Console.ReadLine()!);
        var beltPrice = double.Parse(Console.ReadLine()!);
        var paidLightsabersCount = Math.Ceiling(studentsCount * 1.1);
        var paidRobesCount = studentsCount;
        var paidBeltsCount = studentsCount - studentsCount / 6;
        var totalPrice = 
            paidLightsabersCount * lightsaberPrice + 
            paidRobesCount * robePrice + 
            paidBeltsCount * beltPrice;

        if (totalPrice <= budget)
        {
            Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
        }
        else
        {
            Console.WriteLine($"George Lucas will need {(totalPrice - budget):f2}lv more.");
        }
    }
}