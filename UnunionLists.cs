using System;
using System.Linq;

namespace UnunionLists
{
    public class UnunionLists
    {
        public static void Main()
        {
            var primalList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var current = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

                for (int j = 0; j < current.Count; j++)
                {
                    bool exist = primalList.Contains(current[j]);


                    if (exist)
                    {
                        primalList.Remove(current[j]); 

                        if (exist)
                        {
                            primalList.Remove(current[j]);
                        }                          
                    }
                    else
                    {
                        primalList.Add(current[j]);
                    }
                }
            }

            primalList.Sort();

            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}

