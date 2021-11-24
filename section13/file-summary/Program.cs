using System;
using view;
using model;
using System.IO;

namespace file_summary
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "lista-de-produtos.csv";
            //definition of path name to 
            string pathName = @"/home/caiomaia3/projects/dotNetRoadmap/section13/file-summary/data";

            MainInterface.PrintHeader();
            MainInterface.PrintPathQuestion(fileName);
            // //pathName = Console.ReadLine();
            System.Console.WriteLine(pathName);
            try
            {
                if(FileTester.ExistFile(pathName,fileName))
                {   
                    string  msg = FileTester.GetMsg(pathName,fileName);
                    string inputPath = pathName + Path.DirectorySeparatorChar + fileName;
                    System.Console.WriteLine(msg);
                    string outPath = FileManager.CreateOutFolder(pathName);
                    FileManager.CreateSummary(inputPath,outPath);
                    System.Console.WriteLine("\n\n");
                    MainInterface.SuccessMsg(outPath);
                    System.Console.WriteLine();
                }
                else
                {
                    string msg = FileTester.GetMsg(pathName,fileName);
                    System.Console.WriteLine(msg);
                }
           
           }
            catch (IOException e)
            {
                System.Console.WriteLine("An error ocurred!");    
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
