using System;

namespace RotateArray
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Testing nums = 7 and k = 3
            int[] nums = {1, 2, 3, 4, 5, 6, 7};
            int k = 3;
            Rotate(nums, k);
            foreach (int i in nums)
            {
                Console.WriteLine(i + " ");
            }
        }

        public static void Rotate(int[] nums, int k)
        {
            k = k%nums.Length;

            var result = new int[nums.Length];

            for (int i = 0; i < k; i++)
            {
                result[i] = nums[nums.Length - k + i];
            }

            int j = 0;

            for (int i = k; i < nums.Length; i++)
            {
                result[i] = nums[j];
                j++;
            }

            Array.Copy(result, 0, nums, 0, nums.Length);
        }
    }
}