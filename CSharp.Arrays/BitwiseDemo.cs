using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class BitwiseDemo
    {
        private int a;
        private int b;

        public BitwiseDemo(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void AND()
        {
            int result = a & b;
            Console.WriteLine($"a & b  = {result}  (AND)");
        }

        public void OR()
        {
            int result = a | b;
            Console.WriteLine($"a | b  = {result}  (OR)");
        }

        public void XOR()
        {
            int result = a ^ b;
            Console.WriteLine($"a ^ b  = {result}  (XOR)");
        }

        public void NOT()
        {
            int result = ~a;
            Console.WriteLine($"~a     = {result}  (NOT a)");
        }

        public void LeftShift()
        {
            int result = a << 1;
            Console.WriteLine($"a << 1 = {result}  (Left Shift)");
        }

        public void RightShift()
        {
            int result = a >> 1;
            Console.WriteLine($"a >> 1 = {result}  (Right Shift)");
        }

        public void CheckEven()
        {
            bool isEven = (a & 1) == 0;
            Console.WriteLine($"Is a even? {isEven}");
        }

        public void SwapXOR(ref int x, ref int y)
        {
            Console.WriteLine($"Before swap: x={x}, y={y}");
            x ^= y;
            y ^= x;
            x ^= y;
            Console.WriteLine($"After swap: x={x}, y={y}");
        }
    }
}
