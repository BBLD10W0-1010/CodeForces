using System;
using System.Collections.Generic;
using System.Text;

namespace CodeForces._800RATE
{
    internal class _734A
    {
        public static void Solution()
        {
            int games = Convert.ToInt32(Console.ReadLine());
            string wins = Console.ReadLine();
            int count = 0;
            foreach (char win in wins)
            {
                count += Convert.ToInt16(win == 'A');
            }
            if (games - count == count)
            {
                Console.WriteLine("Friendship");
                return;
            }
            else if (games - count < count)
            {
                Console.WriteLine("Anton");
                return;
            }
            else
            {
                Console.WriteLine("Danik");
                return;
            }
        }
    }
}
