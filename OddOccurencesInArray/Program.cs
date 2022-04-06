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
            Console.WriteLine(res.solution(0));
        }

        public int solution(int N)
        {
            int[] arr =
            {
                9, 3, 9,
                3, 9, 7, 
                9, 11, 11,13
            };


            // var res = arr.Distinct();  1 --
            
            // int occurence = arr.Aggregate((a, b) => a ^ b);  2 + doar 1 
            // int[] group = Array.FindAll(arr, arr => arr.Equals(arr+1));  3, aproape, tot ca 2


            /* same */

            Queue<int> occurs = new Queue<int>();

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
                    occurs.Enqueue(j);
                    return arr[i];
                }
            }

            foreach ( var o in occurs ) Console.WriteLine("oo " + o);


            Console.WriteLine('\n');
            return 0;
        }


    }
}