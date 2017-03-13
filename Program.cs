using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] A = { 3, 1, 2, 4, 3 };
            Console.WriteLine(s.solution(A));
            Console.ReadLine();
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            //find total
            int total = 0;
            foreach (int a in A) { total += a; }

            //find min abs dif
            int firstSum = 0;
            int secondSum = 0;
            int minDiff = Int32.MaxValue;
            for (int i = 0; i < A.Length; i++)
            {
                firstSum += A[i];
                secondSum = total - firstSum;
                int diff = Math.Abs(secondSum - firstSum);
                if (diff < minDiff) minDiff = diff;
            }
            return minDiff;
        }
    }
}
