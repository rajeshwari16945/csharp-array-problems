using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class KangarooJumps
    {
        public static void kangaroo()
        {
            int[] pos = {0, 3};
            int[] jump = {4, 2};
            int x1 = pos[0];
            int x2 = pos[1];
            int v1 = jump[0];
            int v2 = jump[1];

            if ((x1 < x2 && v1 <= v2) || (x2 < x1 && v2 <= v1))
                Console.WriteLine( "NO");

            if ((x2 - x1) % (v1 - v2) == 0)
                Console.WriteLine("YES");

            Console.WriteLine("NO");
        }

    }
}
