using System;
namespace Addstring
{
    class Program
    {
        static void Main()
        {
            int[] nums = new int[50];
            int a = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = a;
                a += 2;
            }

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}