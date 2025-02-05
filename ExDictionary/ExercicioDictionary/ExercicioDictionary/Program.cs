using System;
using System.Collections.Generic;
using System.IO;
using ExercicioDictionary.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, int> dictCandidate = new Dictionary<string, int>();
        string path = @"E:\Repositório\ExDictionary\in.txt";

        try
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] vect = line.Split(',');

                    string name = vect[0];
                    int votes = int.Parse(vect[1]);

                    if (dictCandidate.ContainsKey(name))
                    {
                        dictCandidate[name] += votes; 
                    }
                    else
                    {
                        dictCandidate[name] = votes; 
                    }
                }
            }

            Console.WriteLine("Consolidated Report:");
            foreach (var candidate in dictCandidate)
            {
                Console.WriteLine($"{candidate.Key}: {candidate.Value} votes");
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}
