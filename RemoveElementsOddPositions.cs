using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveElementsOddPositions
{
    public class RemoveElementsOddPositions
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split()
                .ToList();

            var removed = new List<string>();

            for (int i = 1; i < words.Count; i++)
            {
                removed.Add(words[i]);
                i++;
            }

            Console.WriteLine(string.Join("", removed));

        }
    }
}
