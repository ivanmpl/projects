using System;

namespace Exercise2
{
    class Solution
    {
        int arrLength;
        int[] arr;

        public Solution()
        {
            System.Console.Write("Enter array size: ");
            arrLength = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Enter Array values: ");
            int[] A = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                System.Console.Write("Element [{0}]: ", i);
                A[i] = Convert.ToInt32(System.Console.ReadLine());
            }

            arr = A;
        }


        public int GetMaxOccurence()
        {
            int count, element = 0, max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                count = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        count++;
                }

                if (count > max)
                {
                    max = count;
                    element = arr[i];
                }
            }

            return element;
        }
    }

}