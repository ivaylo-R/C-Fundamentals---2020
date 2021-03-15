using System;

namespace _07Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            
            int totalTickets = 0;
            int standartTickets = 0;
            int kidTickets = 0;
            int studentTickets = 0;
            while (movie!="Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());
                string tickets = Console.ReadLine();
                int currentTickets = 0; 


                while (tickets!="End")
                {
                    switch (tickets)
                    {
                        case "standard":
                            standartTickets++;
                            break;
                        case "kid":
                            kidTickets++;
                            break;
                        case "student":
                            studentTickets++;     
                            break;
                    }
                    currentTickets++;
                    if (currentTickets == availableSeats)
                    {
                        break;
                    }
                    tickets = Console.ReadLine();

                }
                totalTickets += currentTickets;

                double seatsTaken = currentTickets *1.0/ availableSeats * 100;
                Console.WriteLine($"{movie} - {seatsTaken:f2}% full.");

                movie = Console.ReadLine();
            }

            double standartTicketsInPercent = standartTickets * 1.0 / totalTickets * 100;
            double kidTicketsInPercent = kidTickets * 1.0 / totalTickets * 100;
            double studentTicketsInPercent = studentTickets * 1.0 / totalTickets * 100;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTicketsInPercent:f2}% student tickets.");
            Console.WriteLine($"{standartTicketsInPercent:f2}% standard tickets.");
            Console.WriteLine($"{kidTicketsInPercent:f2}% kids tickets.");
        }
    }
}
