using System;
using System.Linq;

namespace homework16
{
    internal static class Program
    {
        private static void Main()
        {
            var array1 = new[] {3, 4, 8, 5, 9, 7};

            Console.WriteLine("# 1");
            Console.Write("normal: ");
            array1.ToList().ForEach(item => Console.Write($"{item} "));
            Console.WriteLine();

            var reverse = array1.Reverse();
            Console.Write("reverse: ");
            reverse.ToList().ForEach(item => Console.Write($"{item} "));

            Console.WriteLine();
            Console.WriteLine("# 2");
            var array2 = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15};
            var a = new[] {array2.Count(i => i >= 0), array2.Where(i => i < 0).Sum()};
            a.ToList().ForEach(i => Console.Write($"{i} "));

            Console.WriteLine();
            Console.WriteLine("# 3");
            var array3 = new[] {"Telescopes", "Glasses", "Eyes", "Monocles"};
            var orderedArray3 = array3.OrderBy(s => s.Length).ToList();
            orderedArray3.ForEach(i => { Console.Write($"{i} "); });

            Console.WriteLine();
            Console.WriteLine($"# 4");
            var array4 = new[] {1, 1, 1, 2, 1, 1};
            var u1 = array4.GroupBy(i => i).Select(item => item.Count() == 1 ? item.Key : 0).Max();
            Console.WriteLine(u1);
            var array5 = new[] {0, 0, 0.55, 0, 0};
            var u2 = array5.GroupBy(i => i).Select(item => item.Count() == 1 ? item.Key : 0).Max();
            Console.WriteLine(u2);
        }
    }
}