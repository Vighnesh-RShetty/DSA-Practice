using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays
{
    public class MaximumSubArraySum
    {
        public static int maxSubarrayLength(int[] arr, int n)
        {
            int count = 0;
           // int length = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    int sum = 0;
                    for (int k = i; k <= j; k++)
                    {
                        sum = sum+arr[k];
                    }
                    if (sum == n)
                    {
                        count++;
                    }
                    //sum = 0;

                }


            }
            return count;
        }
    }
}

