using System;
namespace Listwithrandomnumbers
{
    class Program
    {
        static void Main()
        {
            
            int[] nums = new int [100];
            for (int i = 0; i < 100; i++)
            {
                if (i == 0)
                {
                    nums[i] = 100;
                }
                else
                {
                    nums[i] = nums [i - 1] - 3;
                }
            }

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}