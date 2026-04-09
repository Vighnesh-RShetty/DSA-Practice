using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays;

internal class MaximuSubArraySumKadanesAlgo
{
    public static int MaxSubArraySum()
    {
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

        int maxSum = arr[0];
        int currentSum = 0;
        for(int i = 1; i < arr.Length; i++)
        {
            currentSum += arr[i];
            if ( currentSum > maxSum)
            {
                maxSum = currentSum;
            }
            else if(currentSum<0)
            {
                currentSum = 0;
            }
            
          
        }
        return maxSum;
    }
}