using System;
using System.Collections.Generic;
using System.Text;

namespace CodeForces._800RATE
{
    internal class _677A
    {
        public static void Solution()
        {
            var nh = Console.ReadLine().Split(" ").Select(x => Convert.ToInt32(x)).ToList();
            int n = nh[0];
            int h = nh[1];
            var heights = Console.ReadLine().Split(" ").Select(x => Convert.ToInt32(x)).ToList();
            int width = 0;
            foreach (var height  in heights)
            {
                if (height > h)
                {
                    width += 2;
                }
                else
                {
                    width++;
                }
            }
            Console.WriteLine(width);
        }
    }
}
