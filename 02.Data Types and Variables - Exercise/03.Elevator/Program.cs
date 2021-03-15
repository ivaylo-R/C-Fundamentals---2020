using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = people / capacity;
            
            if (people % capacity == 0)
            {
                Console.WriteLine(courses);
            }
            else if (people<capacity)
            {
                Console.WriteLine("1");
            }
            else
            {
                if ((people%capacity)<capacity)
                {
                    Console.WriteLine(courses+1);
                }
                else
                {
                    Console.WriteLine(courses+((people%capacity)/capacity));
                }
            }
        }
    }
}
