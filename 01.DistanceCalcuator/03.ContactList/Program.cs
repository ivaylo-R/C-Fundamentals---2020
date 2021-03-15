using System;
using System.Linq;

namespace _03.ContactList
{
    class Program
    {
        static void Main()
        {
            var contacts = Console.ReadLine().Split().ToList();

            while (true)
            {
                var line = Console.ReadLine().Split();
                string cmd = line[0];
                if (cmd == "Add")
                {
                    string contact = line[1];
                    int index = int.Parse(line[2]);
                    if (!contacts.Contains(contact))
                    {
                        contacts.Add(contact);
                        continue;
                    }
                    else
                    {
                        if (index >= 0 && index <= contacts.Count - 1)
                        {
                            contacts.Insert(index, contact);
                        }
                    }
                }
                else if (cmd == "Remove")
                {
                    int index = int.Parse(line[1]);
                    if (index >= 0 && index <= contacts.Count - 1)
                    {
                        contacts.RemoveAt(index);
                    }
                }
                else if (cmd == "Export")
                {
                    int startIndex = int.Parse(line[1]);
                    int count = int.Parse(line[2]);
                    if ((count + startIndex) > contacts.Count - 1)
                    {
                        for (int i = startIndex; i < contacts.Count; i++)
                        {
                            Console.Write(contacts[i] + " ");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int i = startIndex; i <= count; i++)
                        {
                            Console.Write(contacts[i] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else if (cmd == "Print" && line[1] == "Normal")
                {
                    Console.Write("Contacts: ");
                    Console.Write(string.Join(" ", contacts));
                    return;
                }
                else if (cmd == "Print" && line[1] == "Reversed")
                {
                    contacts.Reverse();
                    Console.Write("Contacts: ");
                    Console.Write(string.Join(" ", contacts));
                    return;
                }
            }
        }
    }
}
