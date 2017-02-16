using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendLists
{
    public class AppendLists
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .ToList();

            input.Reverse();

            var result = new List<string>();

            foreach (var token in input)
            {
                List<string> nums = token.Split(' ').ToList();

                foreach (var num in nums)
                {
                    if (num != "")
                    {
                        result.Add(num);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
