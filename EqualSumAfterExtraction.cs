using System;
using System.Collections.Generic;
using System.Linq;


namespace EqualSumAfterExtraction
{
    public class EqualSumAfterExtraction
    {
        public static void Main()
        {
            var first = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();           

            var second = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var sum1 = 0;
            for (int i = 0; i < first.Count; i++)
            {
                sum1 += first[i];
            }

            for (int i = 0; i < second.Count; i++)
            {
                for (int j = 0; j < first.Count; j++)
                {
                    if (second[i] == first[j])
                    {
                        second.Remove(second[i]);
                    }
                }
            }

            var sum2 = 0;
            for (int i = 0; i < second.Count; i++)
            {
                sum2 += second[i];               
            }

            var diff = Math.Abs(sum1 - sum2);

            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes. Sum: {sum2}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {diff}");
            }
        }
    }
}
