using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AOC_2023.Day1
{
    public class Day1 : BaseDay
    {
        public Day1() : base(1)
        {
        }

        public void Run1()
        {
            Console.WriteLine("Day 1, part 1");

            int total = 0;

            foreach (var line in _input)
            {
                string numbers = "";

                foreach (char c in line)
                {
                    int num;
                    if (int.TryParse(c.ToString(), out num))
                    {
                        numbers += c;
                    }
                }

                if (numbers.Length == 1)
                {
                    total += int.Parse(numbers) * 11;
                }
                else
                {
                    string finalNumber = numbers[0].ToString() + numbers[numbers.Length - 1];

                    total += int.Parse(finalNumber);
                }
            }

            Console.WriteLine(total);
        }

        public void Run2()
        {
            Console.WriteLine("Day 1, part 2");

            int total = 0;

            foreach (var _line in _input)
            {
                string numbers = "";

                string line = _line;

                List<int> firstInts = new List<int>()
                {
                    line.IndexOf("one"),
                    line.IndexOf("two"),
                    line.IndexOf("three"),
                    line.IndexOf("four"),
                    line.IndexOf("five"),
                    line.IndexOf("six"),
                    line.IndexOf("seven"),
                    line.IndexOf("eight"),
                    line.IndexOf("nine"),
                    line.IndexOf("1"),
                    line.IndexOf("2"),
                    line.IndexOf("3"),
                    line.IndexOf("4"),
                    line.IndexOf("5"),
                    line.IndexOf("6"),
                    line.IndexOf("7"),
                    line.IndexOf("8"),
                    line.IndexOf("9"),
                };

                List<int> lastInts = new List<int>()
                {
                    line.LastIndexOf("one"),
                    line.LastIndexOf("two"),
                    line.LastIndexOf("three"),
                    line.LastIndexOf("four"),
                    line.LastIndexOf("five"),
                    line.LastIndexOf("six"),
                    line.LastIndexOf("seven"),
                    line.LastIndexOf("eight"),
                    line.LastIndexOf("nine"),
                    line.LastIndexOf("1"),
                    line.LastIndexOf("2"),
                    line.LastIndexOf("3"),
                    line.LastIndexOf("4"),
                    line.LastIndexOf("5"),
                    line.LastIndexOf("6"),
                    line.LastIndexOf("7"),
                    line.LastIndexOf("8"),
                    line.LastIndexOf("9"),
                };

                var filteredFirst = firstInts.Where(i => i > -1).ToList<int>();

                int firstMin = filteredFirst.Min();
                int firstMinIndex = firstInts.IndexOf(firstMin);
                string number = ((firstMinIndex % 9) + 1).ToString();
                numbers += number;

                var filteredLast = lastInts.Where(i => i > -1).ToList<int>();
                int lastMin = filteredLast.Max();
                int lastMinIndex = lastInts.IndexOf(lastMin);

                if (firstMinIndex != lastMinIndex)
                {
                    string lastNumber = ((lastMinIndex % 9) + 1).ToString();
                    numbers += lastNumber;
                }

                if (numbers.Length == 1)
                {
                    total += int.Parse(numbers) * 11;
                }
                else
                {
                    string finalNumber = numbers[0].ToString() + numbers[numbers.Length - 1];

                    total += int.Parse(finalNumber);
                }
            }

            Console.WriteLine(total);
        }
    }
}
