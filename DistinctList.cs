using System;
using System.Collections.Generic;
using System.Linq;

namespace DistinctList
{
    public class DistinctList
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            //for (int i = 0; i < nums.Count-1; i++)
            //{
            //    for (int j = i+1; j < nums.Count; j++)
            //    {
            //        if (nums[i] == nums[j])
            //        {
            //            nums.RemoveAt(j);
            //        }
            //    }              

            //}

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
