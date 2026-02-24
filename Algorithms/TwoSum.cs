using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

/*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
     */
namespace Algorithms
{
    class TwoSum
    {
        public int[] TwoSum_ResultItem(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (dic.ContainsKey(num)) 
                    dic[num]++;
                else 
                    dic.Add(num, 1);
            }

            foreach (var i in nums)
            {
                int diff = target - i;

                if (diff == i)
                {
                    if (dic[diff] > 1)
                        return new[] { i, diff };

                    continue;
                }

                if (dic.ContainsKey(diff))
                    return new[] { i, diff };
            }

            return Array.Empty<int>(); // or throw
        }
        public readonly struct IndexStruct
        {
            public int Index1 { get; }
            public int Index2 { get; }

            public IndexStruct(int index1, int index2)
            {
                Index1 = index1;
                Index2 = index2;
            }
        }

        public int[] TwoSum_ResultItemIndex(int[] nums, int target)
        {
            Dictionary<int, IndexStruct> dic = new();

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];

                if (!dic.ContainsKey(num))
                {
                    dic[num] = new IndexStruct(i, 0);
                }
                else
                {
                    var prev = dic[num];
                    dic[num] = new IndexStruct(prev.Index1, i);
                }
            }


            foreach (var num in nums)
            {
                int diff = target - num;
                var valStruct1 = dic[num];

                if (diff == num)
                {
                    if (valStruct1.Index1 != valStruct1.Index2 )
                        return new[] { valStruct1.Index1, valStruct1.Index2 };

                    continue;
                }

                if (dic.ContainsKey(diff))
                {
                    var valStruct2 = dic[diff];
                    return new[] { valStruct1.Index1, valStruct2.Index1 };
                }
            }

            return Array.Empty<int>(); // or throw
        }

        public int[] TwoSum_chatSolution(int[] nums, int target)
        {
            var seen = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                int diff = target - num;

                if (seen.TryGetValue(diff, out int j))
                    return new[] { j, i };

                seen[num] = i; // overwrite is fine
            }

            return Array.Empty<int>();
        }
    }
}
