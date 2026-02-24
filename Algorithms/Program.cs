namespace Algorithms
{
    class Program
    {
        static void Main()
        {
            var validParentheses = new ValidParentheses();
            Console.WriteLine(validParentheses.IsValid("()[]{}"));

            var twoSum = new TwoSum();
            int[] nums1 = { 3, 2, 4};
            int[] nums2 = { 2,7,11,15 };
            int[] nums3 = { 3,3 };
            int[] nums4 = { 2, 7, 11, 15 };
            int target1 = 6;
            int target2 = 9;
            int target3 = 6;
            int target4 = 4;


            Console.WriteLine(string.Join(", ", twoSum.TwoSum_ResultItem(nums1, target1)));
            Console.WriteLine(string.Join(", ", twoSum.TwoSum_ResultItem(nums2, target2)));
            Console.WriteLine(string.Join(", ", twoSum.TwoSum_ResultItem(nums3, target3)));
            Console.WriteLine(string.Join(", ", twoSum.TwoSum_ResultItem(nums4, target4)));

            Console.WriteLine("--------------------------Two Sum-----------------------------------");
            Console.WriteLine(string.Join(", ", twoSum.TwoSum_ResultItemIndex(nums1, target1)));
            Console.WriteLine(string.Join(", ", twoSum.TwoSum_ResultItemIndex(nums2, target2)));
            Console.WriteLine(string.Join(", ", twoSum.TwoSum_ResultItemIndex(nums3, target3)));
            Console.WriteLine(string.Join(", ", twoSum.TwoSum_ResultItemIndex(nums4, target4)));

            Console.WriteLine("--------------------------Two Sum AI-----------------------------------");
            Console.WriteLine(string.Join(", ", twoSum.TwoSum_chatSolution(nums1, target1)));
            Console.WriteLine(string.Join(", ", twoSum.TwoSum_chatSolution(nums2, 26)));
            Console.WriteLine(string.Join(", ", twoSum.TwoSum_chatSolution(nums3, target3)));
            Console.WriteLine(string.Join(", ", twoSum.TwoSum_chatSolution(nums4, target4)));

            Console.WriteLine("--------------------------Palindrome-----------------------------------");
            var palindrome = new Palindrome();
            Console.WriteLine(palindrome.IsPalindrome(12));
            Console.WriteLine(palindrome.IsPalindrome(1221));



            RemoveDuplicates duplicate = new RemoveDuplicates();
            int[] nums5 = { 1, 1, 2 };
            int[] nums6 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine(duplicate.Execute(nums5));
            Console.WriteLine(duplicate.Execute(nums6));
        }

    }

}
