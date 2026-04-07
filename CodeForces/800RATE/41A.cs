using System;
using System.Collections.Generic;
using System.Text;

namespace CodeForces._800RATE
{
    internal class _41A
    {
        public static void Solution()
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string tempCompare = "";
            for  (int i = input1.Length-1; i >= 0; i--)
            {
                tempCompare += input1[i];
            }

            if (input2 == tempCompare)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            return;
        }
    }
}
