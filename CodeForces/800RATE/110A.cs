using System;
using System.Collections.Generic;
using System.Text;

namespace CodeForces._800RATE
{
    internal class _110A
    {
        public static void Solution()
        {
            string input = Console.ReadLine();
            int count = 0;
            foreach (int num in input)
            {
                if (num == '4' || num == '7')
                {
                    count++;
                }
            }
            if (count == 4 || count == 7)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
