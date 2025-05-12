namespace Week_5_Challenge_5._1._2
{
    internal class Program
    {
        static int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            int expected = n * (n + 1) / 2;
            int actualSum = 0;
            foreach (int x in nums)
                actualSum += x;
            return expected - actualSum;
        }

        static void Main(string[] args)
        {
            // Example 1:
            int[] nums = { 3, 0, 1 };

            // Call the helper and print the missing number:
            Console.WriteLine(MissingNumber(nums));  // Output: 2

        }
    }
}
