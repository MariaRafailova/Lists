using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitByWordCasing
{
    public class SplitByWordCasing
    {
        public static void Main()
        {
            var separators = new char[]
              {
                ',', ';', ':', '.', '!', '(', ')', '&', '\\', '/', '[', ']', '"', '\'', ' '
              };

            var words = Console.ReadLine()
                .Split(separators,
StringSplitOptions.RemoveEmptyEntries)
.ToList();
            
            var lower = new List<string>();
            var upper = new List<string>();
            var mix = new List<string>();

            foreach (var word in words)
            {
                List<char> letters = word.ToList();

                var countLower = 0;
                var countUpper = 0;

              foreach (var letter in letters)              
                {
                    if (letter >= 'a' && letter <= 'z')
                    {
                        countLower++;
                    }
                    else if (letter >= 'A' && letter <= 'Z')
                    {
                        countUpper++;
                    }                    
                }

                if (countLower == letters.Count)
                {
                    lower.Add(word);
                }
                else if (countUpper == letters.Count)
                {
                    upper.Add(word);
                }
                else
                {
                    mix.Add(word);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lower));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mix));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upper));
        }
    }
}
