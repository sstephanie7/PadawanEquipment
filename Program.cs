using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine()); 

            double sabersTotal = Math.Ceiling(students * 1.10);
            double totalForLightsabers = priceOfLightsabers * sabersTotal;
            double totalForRobes = priceOfRobes * students;

            double freeBelts = Math.Floor(students / 6.0);
            double totalForBelts = (students - freeBelts) * priceOfBelts;

            double totalForEquipment = totalForLightsabers + totalForRobes + totalForBelts;

            if (totalForEquipment <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalForEquipment:f2}lv."); 
            }
            else
            {
                double neededMoney = totalForEquipment - amountOfMoney;
                Console.WriteLine($"John will need {neededMoney:f2}lv more.");
            }


        }   
    }
}
