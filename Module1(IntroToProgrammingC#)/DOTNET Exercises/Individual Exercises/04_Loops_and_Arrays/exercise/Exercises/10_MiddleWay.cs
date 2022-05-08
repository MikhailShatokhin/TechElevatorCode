﻿namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 2 int arrays, a and b, each length 3, return a new array length 2 containing their middle
         elements.
         MiddleWay([1, 2, 3], [4, 5, 6]) → [2, 5]
         MiddleWay([7, 7, 7], [3, 8, 0]) → [7, 8]
         MiddleWay([5, 2, 9], [1, 4, 5]) → [2, 4]
         */
        public int[] MiddleWay(int[] a, int[] b)
        {
            int[] result = new int[2];
            result[0] = a[1];
            result[1] = b[1];

            return result;
        }
    }
}
