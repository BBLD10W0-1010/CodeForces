using System;
using System.Collections.Generic;
using System.Text;

namespace CodeForces
{
    internal class _479A
    {
        public static void Solution()
        {
            var input = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToList();
            var n = input[0];
            var k = input[1];
            for (int i = 0; i < k; i++)
            {
                if (n % 10 == 0)
                {
                    n = n / 10;
                }
                else
                {
                    n -= 1;
                }
            }
            Console.WriteLine(n);
        }
    }
}
