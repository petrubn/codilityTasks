// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

using System;
using System.Linq;
using System.Security.Cryptography;

namespace HelloWorld
{
    class Solution
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine(sol.solution(10, 85, 30));
        }

        public int solution(int X, int Y, int D )
        {
            double res = (Y - X) / (double) D;
            return (int) Math.Ceiling(res);
        }
}

}