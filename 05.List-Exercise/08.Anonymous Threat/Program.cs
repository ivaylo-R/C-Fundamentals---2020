using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Anonymous_Threat
{
    class Program
    {
        static void Main()
        {
            List<string> data = Console.ReadLine().Split().ToList();
            string line = string.Empty;
            while ((line = Console.ReadLine()) != "3:1")
            {
                string[] lineSplitt = line.Split().ToArray();
                string command = lineSplitt[0];
                if (command == "merge")
                {
                    MergeString(data, lineSplitt, command);
                }
                else if (command == "divide")
                {

                    int index = int.Parse(lineSplitt[1]);
                    int partitions = int.Parse(lineSplitt[2]);
                    if (index >= 0 && index <= data.Count - 1)
                    {


                        string word = data[index];
                        int stringLengthToAdd = word.Length / partitions;
                        List<string> divideWord = new List<string>();

                        int startIndex = 0;
                        for (int i = 0; i < partitions; i++)
                        {
                            if (i == partitions - 1)
                            {
                                divideWord.Add(word.Substring(startIndex, word.Length - startIndex));
                            }
                            else
                            {
                                divideWord.Add(word.Substring(startIndex, stringLengthToAdd));
                                startIndex += stringLengthToAdd;
                            }

                        }
                        data.RemoveAt(index);
                        data.InsertRange(index, divideWord);

                    }
                }
            }
            Console.WriteLine(String.Join(" ",data));
        }

        private static void MergeString(List<string> data, string[] lineSplitt, string command)
        {
            int startIndex = int.Parse(lineSplitt[1]);
            int endIndex = int.Parse(lineSplitt[2]);
            string concat = string.Empty;
            if (startIndex < 0)
            {
                if (endIndex >= 0 && endIndex <= data.Count - 1)
                {
                    startIndex = 0;
                }

            }
            if (endIndex > data.Count - 1)
            {
                if (startIndex <= data.Count - 1 && startIndex >= 0)
                {
                    endIndex = data.Count - 1;
                }

            }
            if ((startIndex >= 0 && startIndex <= data.Count) && (endIndex >= 0 && endIndex <= data.Count))
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    concat += data[i];
                }
                data.RemoveRange(startIndex, endIndex - startIndex + 1);
                data.Insert(startIndex, concat);
            }
        }
    }
}
