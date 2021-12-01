using System;
using System.Collections.Generic;
using System.IO;
using dictionaryExample.Utils;

namespace dictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                 //read a file
                System.Console.WriteLine("Enter file full path:");
                string filePath = @"./data/in.txt";
                System.Console.WriteLine(filePath);
                // readMyFile.printFile(filePath);

                List<string[]> myList = new List<string[]>();
                myList = readMyFile.getLineList(filePath);
                var candidates = new Dictionary<string,int>();
                foreach (var v in myList)
                {
                    if(!candidates.ContainsKey(v[0]))
                    {
                        candidates[v[0]] = 0;
                    }
                    candidates[v[0]] += int.Parse(v[1]);
                }
                foreach (var d in candidates)
                {
                    System.Console.WriteLine($"{d.Key} - {d.Value}");
                }
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);    
            }
        }
    }
}
