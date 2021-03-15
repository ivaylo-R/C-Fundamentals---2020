using System;

namespace Nehstosi
{
    class Program
    {
        static void Main()
        {
            
            Console.Write("inches=");
            var inches = double.Parse(Console.ReadLine());
            var centimeters = inches * 2.54;
            Console.Write("centimeters=");
            Console.Write(centimeters);
        }

    }
}
