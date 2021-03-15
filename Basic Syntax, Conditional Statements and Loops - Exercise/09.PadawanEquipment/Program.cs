using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double freeBeltss = Math.Floor(students / 6);
            double sabersSum = lightsaberPrice * (Math.Ceiling(students * 1.1));
            double robesSum = students * robesPrice;
            double beltsSum = (students - freeBeltss) * beltsPrice;
            double equipmentPrice = sabersSum + robesSum + beltsSum;
            if (money >= equipmentPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {equipmentPrice:f2}lv.");
            }
            else if(equipmentPrice>money)
            {
                Console.WriteLine($"Ivan Cho will need {(equipmentPrice - money):F2}lv more.");
            }
        }
    }
}