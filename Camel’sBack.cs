using System;
using System.Collections.Generic;
using System.Linq;

namespace Camel_sBack
{
    public class Program
    {
        public static void Main()
        {
            var buildings = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var m = int.Parse(Console.ReadLine());

            int rounds = 0;

            if ((buildings.Count) <= m)
            {
                Console.WriteLine($"already stable: {string.Join(" ", buildings)}");
            }

            if (buildings.Count > m)
            {
                while (buildings.Count > m)
                {
                    rounds += 1;
                    buildings.RemoveAt(0);
                    buildings.RemoveAt(buildings.Count - 1);                    
                }

                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", buildings)}");
            }
            
        }
    }
}
