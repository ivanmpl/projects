using System;

namespace Exercise4
{
    class Program
    {
        public static void PrintSpiralOrder(int[,] arr2D)
        {

            int col = arr2D.GetLength(0);
            int row = arr2D.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                System.Console.WriteLine(arr2D[0,i]);
            }

            for (int j = 0; j < col-2; j++)
            {
                System.Console.WriteLine(arr2D[j+1,row-1]);
            }

            for (int k = row-1; k > 0; k--)
            {
                System.Console.WriteLine(arr2D[col-1,k]);
            }

            for (int n = col-1; n > 0; n--)
            {
                System.Console.WriteLine(arr2D[n,0]);
            }

            
            for (int n = col-1; n > 0; n--)
            {
                System.Console.WriteLine(arr2D[n,0]);
            }
            
        }

        static void Main(string[] args)
        {

            int[,] A = {{1,2,3},
                        {4,5,6},
                        {7,8,9}};

            PrintSpiralOrder(A);



        }
    }
}
