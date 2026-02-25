using System;
using System.Collections.Generic;
using System.Text;

/* Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.

 

Example 1:

Input: nums = [1,3,5,6], target = 5
Output: 2
Example 2:

Input: nums = [1,3,5,6], target = 2
Output: 1
Example 3:

Input: nums = [1,3,5,6], target = 7
Output: 4
*/
namespace Algorithms
{
    public class SearchInsert
    {
        //1,3,5,6,8 target 7.
        public int Execute(int[] nums, int target)
        {
            if (nums.Length == 0)
                return 0;

            int low = 0;
            int high = nums.Length - 1;
            

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (nums[mid] == target)
                    return mid;

                if (nums[mid] > target)
                {
                    high = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    low = mid + 1;
                }
            }
            return low;
        }
    }
}
