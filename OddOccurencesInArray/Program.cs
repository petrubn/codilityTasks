// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

using System;
using System.Linq;
using System.Security.Cryptography;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Program res = new Program();
            
            int[] arr =
            {
                9, 3, 9,
                3, 9, 7, 
                9, 11, 11,13
            };
            
            Console.WriteLine("First solution - " + res.solution(arr) + "\n");
            Console.WriteLine("Second solution - " + res.secondSolution(arr));
            
        }

        public int solution(int[] arr)
        {
            // int occurence = arr.Aggregate((a, b) => a ^ b);  2 + doar 1 
            // int[] group = Array.FindAll(arr, arr => arr.Equals(arr+1));  3, aproape, tot ca 2
            
            var occurs = new List<int> { };

            for (int i = 0; i < arr.Length; i++) 
            {
                int j;
                for (j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j]) 
                        break;
                }
                if (j == arr.Length)
                {
                    occurs.Append(j);
                    return arr[i];
                }
            }
            foreach ( var o in occurs ) Console.WriteLine("oo " + o);
            
            Console.WriteLine('\n');
            return 0;
        }

        public int secondSolution(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                result ^= arr[i];
            }
            return result;
        }
        
    }
}