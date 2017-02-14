using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse_
{
    public class RemoveNegativesAndReverse_
    {
        public static void Main()
        {
            var num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var positive = new List<int>(num.Count);

            for (int i = num.Count-1; i >=0; i--)
            {
                if (num[i]>=0)
                {
                    positive.Add(num[i]);

                }
            }
            
            if (positive.Count == 0)
            {
                Console.Write("empty");
            }
            else
            {
                Console.Write(string.Join(" ", positive));
            }            

            Console.WriteLine();
        }
    }
}
