using System.Collections.Generic;
using System.IO;

namespace dictionaryExample.Utils
{
    public static class readMyFile
    {
        public static void printFile(string filePath)
        {
            if (!File.Exists(@filePath))
            {
                throw new FileNotFoundException();
            }
            else
            {
                using(FileStream fs = File.OpenRead(@filePath))
                {
                    using(StreamReader sr = new StreamReader(fs)) 
                    {
                        while (!sr.EndOfStream)
                        {
                            System.Console.WriteLine(sr.ReadLine());
                        }

                    }

                }
            }
        }

        public static List<string[]> getLineList(string filePath)
        {
            var myList = new List<string[]>();
            if (!File.Exists(@filePath))
            {
                throw new FileNotFoundException();
            }
            else
            {
                using(FileStream fs = File.OpenRead(@filePath))
                {
                    using(StreamReader sr = new StreamReader(fs)) 
                    {
                        while (!sr.EndOfStream)
                        {
                            myList.Add(sr.ReadLine().Split(','));
                        }
                    }

                }
                return myList;
            }
        }

        // public static Dictionary<string,float> lineListToDict(this string[] thisObj)
        // {
        //     return new Dictionary<string, float>
        // }


    }
    
}