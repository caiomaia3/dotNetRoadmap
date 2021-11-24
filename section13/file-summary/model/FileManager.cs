using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace model
{
    class FileManager
    {
        internal static string CreateOutFolder(string pathName)
        {
            string folderName = "Out";
            if(Directory.Exists(pathName))
            {
                return CreateFolder(pathName,folderName);
            }
            else
            {
                throw  new IOException();
            }
        }
        internal static string CreateFolder(string pathName, string folderName)
        {
            string folderPath = pathName + "/" + folderName;
            if (!Directory.Exists(@folderPath))
            {
                Directory.CreateDirectory(@folderPath);
            }
            return folderPath;
        }

        internal static float CalculateTotal(string line)
        {   const int priceIndex=1, quantityIndex=2;
            string[] columns = line.Split(',');
            return float.Parse(columns[priceIndex])*float.Parse(columns[quantityIndex]);
        }

        internal static string GetNameColumn(string line)
        {   
            const int nameIndex = 0;
            string[] columns = line.Split(',');
            return columns[nameIndex];
        }
        internal static void CreateSummary(string inputPath, string outPath)
        {   
            string outPutFilePath = outPath + Path.DirectorySeparatorChar + "summary.csv";
            using (StreamReader reader = File.OpenText(inputPath))
            {
                using (StreamWriter writer = File.CreateText(@outPutFilePath))
                {
                    while(!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] columns = line.Split(',');
                        writer.WriteLine(GetNameColumn(line) + ',' + CalculateTotal(line).ToString("F2",CultureInfo.InvariantCulture));
                    }    
                }
                
            }
        }
    }

}