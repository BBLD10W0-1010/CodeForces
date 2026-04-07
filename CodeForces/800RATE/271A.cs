using System;
using System.Collections.Generic;
using System.Text;

namespace CodeForces._800RATE
{
    internal class _271A
    {

        public static void Solution()
        {
            var dict = BuildDateKey();
            
        }

        public static Dictionary<int, int> BuildDateKey()
        {
            int cnt = 0;
            var Dict = new Dictionary<int, int>();
            for (int i = 1; i<9; i++)
            {
                for(int j = 0; j<=9; j++)
                {
                    
                    if (i == j)
                    {
                        continue;
                    }

                    for(int k = 0; k<=9; k++)
                    {
                        
                        if (k == j || k == i)
                        {
                            continue;
                        }

                        for(int l = 0; l<=9; l++)
                        {
                            if (l == i || l == j || l == k)
                            {
                                continue;
                            }
                            Dict.Add(cnt, Convert.ToInt32($"{i}{j}{k}{l}"));
                            cnt++;
                        }
                    }
                }
            }
            return Dict;
        }
    }
}
