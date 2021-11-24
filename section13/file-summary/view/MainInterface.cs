using System;

namespace view
{
    class MainInterface
    {
       public static void PrintMainView()
       {
           System.Console.WriteLine(); 
           PrintHeader();
           System.Console.WriteLine("Requisição de entrada");
           System.Console.WriteLine("Confirmação do trabalho.");
       } 

       public static void PrintHeader()
       {
           System.Console.WriteLine();
           System.Console.WriteLine("Header");
           Console.WriteLine("Este programa realiza um resumo do arquivo lista-de-produtos e o salva no arquivo summary.");
           System.Console.WriteLine();
       }

        internal static void PrintPathQuestion(string fileName)
        {
            System.Console.WriteLine($"Por favor entre com o folder que contém o arquivo {fileName}:");
        }

        internal static void SuccessMsg(string path)
        {
            System.Console.WriteLine("Operação realizada com sucesso.");
            System.Console.WriteLine("Arquivo summary criado em:");
            System.Console.WriteLine(path);
        }
    } 
}