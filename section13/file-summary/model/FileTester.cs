using System;
using System.IO;

namespace model
{
    public static class FileTester
    {
        internal static bool ExistFile(string pathName,string fileName)
        {
            bool existFile = false;
            var existentFile = Directory.EnumerateFiles(pathName,fileName,SearchOption.AllDirectories);
            foreach (var s in existentFile) existFile = true;

            return existFile;
        }

        internal static string GetMsg(string pathName, string fileName)
        {
            string msg;
            if(ExistFile(pathName,fileName))
            {
                msg = "\nArquivo encontrado: " + fileName;
            }
            else
            {
                msg = $"\nArquivo {fileName} não encontrado:";
            }
            return msg;
        }
    }

}