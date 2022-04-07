// See https://aka.ms/new-console-template for more information

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Program res = new Program();
            Console.WriteLine(res.solution(1041));

        }

        public int solution(int N) {
       
            int counter = 0;
            int bk = 0;
            
            bool started = false;
            int current = 0;
            int maxGap = 0;
            
            for (int i = 0; i < 32; i++)
            {
                var bit = (N >> i) & 1 ;
               

                if ((bit) == 1)
                {
                    started = true;
                    if (current > maxGap)
                    {
                        maxGap = current;
                    }

                    current = 0;
                }
                else if ( started )
                {
                    current++;
                }

                
            }
            return maxGap;
            
        }
        
        
    }
}