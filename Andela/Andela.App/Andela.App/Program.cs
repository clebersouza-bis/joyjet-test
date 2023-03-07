using System;

namespace Andela.App
{
    /*Given an unsorted array A of size N that contains only non-negative integers, find a continuous sub-array which adds to a given number S.

In case of multiple subarrays, return the subarray which comes first on moving from left to right.

 

Example 1:

Input:
N = 5, S = 12
A[] = {1,2,3,7,5}
Output: 2 4
Explanation: The sum of elements 
from 2nd position to 4th position 
is 12.
 

Example 2:

Input:
N = 10, S = 15
A[] = {1,2,3,4,5,6,7,8,9,10}
Output: 1 5
Explanation: The sum of elements 
from 1st position to 5th position
is 15.
 

Your Task:
You don't need to read input or print anything. The task is to complete the function subarraySum() which takes arr, N and S as input parameters and returns an arraylist containing the starting and ending positions of the first such occurring subarray from the left where sum equals to S. The two indexes in the array should be according to 1-based indexing. If no such subarray is found, return an array consisting only one element that is -1.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = TwoSum(new int[] { 1, 2, 3, 7, 5 }, 5, 12);
            Console.WriteLine($"result is: {res[0]}, {res[1]}");

            res = TwoSum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10, 15);
            Console.WriteLine($"result is: {res[0]}, {res[1]}");

        }

        public static int[] TwoSum(int[] input, int n, int s)
        {
            //ss start to end position 
            int flow = 0;
            int total = 0;
            int[] arrPosition = new int[2];

            for (int i = 0; i < input.Length; i++)
            {
                arrPosition[0] = i; 
                var firsElementresult = input[i];
                total += firsElementresult;
                for (int x = i; x < input.Length; x++)
                {
                    total += input[x + 1];
                    if (total > s)
                    {
                        total = 0;
                        break;
                    }
                    arrPosition[1] = x+2;

                    if (total == s)
                    {
                        arrPosition[0] = i+1;
                        return arrPosition;
                    }
                    arrPosition[1] = x + 2;

                }
            }
            return arrPosition;
        }
    }
}
