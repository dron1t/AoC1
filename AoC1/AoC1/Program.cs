using System;
using System.IO;
using System.Linq;

namespace AoC1
{
    class Program
    {
        private static string _path;


        static void Main(string[] args)
        {
            
            _path = Path.Combine(Directory.GetCurrentDirectory(), "input.txt");
            One();
            Two();
            
        }

        private static void Two()
        {
            var input = File.ReadAllLines(_path);
            var converted = input
                .Select(l => Convert.ToInt32(l)).ToArray();
            var result = 0;
            var n = 3;
            for (int i = n; i < converted.Length; ++i)
            {
                if (converted[i] > converted[i - n])
                {
                    ++result;
                }
            }
            Console.WriteLine(result);
        }

        private static void One()
        {
            
            int previous = 0;
            using (StreamReader reader = new StreamReader(_path))
            {
                previous = int.Parse(reader.ReadLine() ?? "0");
            }

            var howMany = 0;

            foreach (string line in File.ReadLines(_path))
            {
                var current = int.Parse(line);
                if (current > previous) howMany++;
                previous = current;
            }

            Console.WriteLine(howMany);
        }
    }
}