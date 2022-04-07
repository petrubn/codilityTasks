namespace Arrays
{   
    class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine('\n');
            Solution solve = new Solution();
            int[] A = { 3, 8, 9, 7, 6 };
            int K = 4;

            solve.solution(A,K);
        }
        public int[] solution(int[] A, int K)
        {
            Console.WriteLine("Orginal Array:");
            for (int i = 0; i < A.Length; i++) Console.Write(A[i]);

            K = K % A.Length;
            int j = 0;

            while (K > 0) 
            { 
                /*int temp = A.Last();*/
                int temp = A[A.Length - 1];
                for ( j = A.Length - 1; j > 0; j--)
                {
                    A[j] = A[j - 1];
                }
                A[j] = temp;
                K--;
            }

            Console.WriteLine("\n\nNew Array: ");
            for (int i = 0; i < A.Length; i++) Console.Write(A[i]);

            return A;
        }
    }

}