using System;
using System.Reflection.Metadata.Ecma335;

namespace Week_5_Challenge_Lab_5._1
{
    internal class Program
    {
        //Given a non-empty array of integers nums, every element appears twice except for one.Find that single one.
        //Example 1:
        //Input: nums = [2, 2, 1]
        //Output: 1
        static int UniqueEle(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int num in nums)
            {
                if (set.Contains(num))
                {
                    set.Remove(num);
                }
                else
                    set.Add(num);
            }

            foreach(int unique in set)
            {
                return unique;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] nums = {2, 2, 1};
            int result = UniqueEle(nums);
            Console.WriteLine(result);

        }
    }
}
