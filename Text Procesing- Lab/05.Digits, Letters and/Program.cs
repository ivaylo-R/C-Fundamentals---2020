using System;
using System.Text;
using System.Linq;

namespace _05.Digits__Letters_and
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            bool result;
            var letters=new StringBuilder();
            var digits= new StringBuilder();
            var others = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                char currentElement = text[i];

                if ((result = Char.IsLetter(currentElement)) == true)
                {
                    letters.Append(currentElement);     
                }
               
                else if ((result = Char.IsDigit(currentElement))==true)
                {
                    digits.Append(currentElement);
                }
                else 
                {
                    others.Append(currentElement);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
