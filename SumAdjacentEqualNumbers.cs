using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToList();

            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] == nums[i-1])
                {
                    nums[i] *= 2;
                    nums.RemoveAt(i-1);
                    i = 0;
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
