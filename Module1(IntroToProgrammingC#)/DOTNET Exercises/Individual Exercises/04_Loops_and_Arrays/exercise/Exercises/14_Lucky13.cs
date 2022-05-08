﻿namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints, return true if the array contains no 1's and no 3's.
         Lucky13([0, 2, 4]) → true
         Lucky13([1, 2, 3]) → false
         Lucky13([1, 2, 4]) → false
         */
        public bool Lucky13(int[] nums)
        {
            for (int i=0; i<nums.Length; i++)
            {
                if(nums[i]==1 || nums[i]==3)
                {
                    return false;
                
                }
            }
            return true;
        }
    }
}
