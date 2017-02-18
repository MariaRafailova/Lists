using System;
using System.Collections.Generic;
using System.Linq;

namespace FlipListSides
{
    class FlipListSides
    {
        static void Main()
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var temp = 0;
            
            for (int i = 1; i < nums.Count/2; i++)
            {
                temp = nums[i];
                nums[i] = nums[nums.Count - 1 - i];
                nums[nums.Count - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
