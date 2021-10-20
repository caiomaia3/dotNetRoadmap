using System;

namespace MatrixExample
{
    class Program
    {
        static void Main(string[] args)
        {
            const int matrixDim = 2;
            const int ROWS = 0;
            const int COLS = 1;

            int[] matrixSize = new int[matrixDim];
            int[,] myMatrix;
            string[] strLineVec;

            string inString = Console.ReadLine();
            bool twoItens = inString.Split(" ").Length == matrixDim;

            if (twoItens)
            {
                matrixSize = Array.ConvertAll(inString.Split(" "), s => int.Parse(s));
                myMatrix = new int[matrixSize[ROWS], matrixSize[COLS]];
                strLineVec = new string[matrixSize[COLS]];
                for (int i = 0; i < matrixSize[ROWS]; i++)
                {
                    strLineVec = Console.ReadLine().Split(" ");
                    for (int j = 0; j < matrixSize[COLS]; j++)
                    {
                        myMatrix[i, j] = int.Parse(strLineVec[j]);
                    }
                }
                //Print MAtrix
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                for (int i = 0; i < matrixSize[ROWS]; i++)
                {
                    for (int j = 0; j < matrixSize[COLS]; j++)
                    {
                        if (myMatrix[i,j]==x)
                        {
                            Console.WriteLine("M({0},{1})",i,j);
                            if(j - 1 >= 0)  Console.WriteLine("Left:{0}",myMatrix[i,j-1]);
                            if (j + 1 < matrixSize[COLS]) Console.WriteLine("Right:{0}", myMatrix[i, j+1]);
                            if (i - 1 >= 0) Console.WriteLine("Up:{0}", myMatrix[i-1, j]);
                            if (i + 1 < matrixSize[ROWS]) Console.WriteLine("Down:{0}", myMatrix[i+1, j]);
                        }
                    }
                    Console.WriteLine("");

                }
            }
            else
            {
                Console.WriteLine("You need to put two values, N and M, for the matrix dimenssion.");
            }
        }
    }
}
