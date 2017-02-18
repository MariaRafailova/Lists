using System;
using System.Collections.Generic;
using System.Linq;


namespace TrackDownloader
{
    public class TrackDownloader
    {
        public static void Main()
        {
            var blacklisted = Console.ReadLine()
                .Split()
                .ToList();

            var result = new List<string>();

            var list = Console.ReadLine();
            while (list != "end")
            {
                var inList = false;

                foreach (var word in blacklisted)
                {
                    if (list.Contains(word))
                    {
                        inList = true;
                        break;
                    }                    
                }

                if (!inList)
                {
                    result.Add(list);
                }

                list = Console.ReadLine();
            }

            result.Sort();

            Console.WriteLine(string.Join(Environment.NewLine, result));                      
        }
    }
}
