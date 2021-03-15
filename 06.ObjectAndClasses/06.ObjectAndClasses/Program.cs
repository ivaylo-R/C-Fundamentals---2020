using System;

namespace _06.ObjectAndClasses
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine(AdvertisementMessage.Randomizer());
            }

        }
        class AdvertisementMessage
        {
            static string[] Phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            static string[] Events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            static string[] Authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            static string[] Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            public static string Randomizer()
            {
                Random rand = new Random();
                int currentPhrases = rand.Next(0, Phrases.Length);
                int currentEvents = rand.Next(0, Events.Length);
                int currentAuthors = rand.Next(0, Authors.Length);
                int currentCities = rand.Next(0, Phrases.Length);
                return $"{Phrases[currentPhrases]} {Events[currentEvents]} {Authors[currentAuthors]} – {Cities[currentCities]}";

            }
        }
    }
}
