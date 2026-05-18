using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Revision_Part_Two_Last
{
    public class Maximum_Subarray_sum
    {
        //Brute Force 
        public static int BruteForceMaxSum()
        {
            //Input: nums = [2, 3, 5, -2, 7, -4] Output: 15
            int[] arr = [-2, -3, -7, -2, -10, -4];
            
            int maxSum = arr[0];

            for(int i = 0; i < arr.Length; i++)
            {
                int sum = 0;

                for (int j = i; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if(sum>maxSum)

                        maxSum= sum;
                }
            }
            Console.WriteLine(maxSum);
            return maxSum;
        }

        //Optimal Solution 
        public static int MaxSumOptimal_Kadanes_Algo()
        {
            //Input: nums = [2, 3, 5, -2, 7, -4] Output: 15
            int[] arr = [-2, -3, -7, -2, -10, -4];
            int maxSum = arr[0];
            int current = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                current += arr[i];

                if (current > maxSum)
                {
                    maxSum = current;
                }else if (current < 0)
                {
                    current = 0;
                }
            }
            
            Console.WriteLine(maxSum);
            return maxSum;
        }

    }
}
