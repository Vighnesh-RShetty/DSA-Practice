using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays;

public class MaximuSubArraySumKadanesAlgo
{
    public static int MaxSubArraySum()
    {
        int[] arr = { -2, -3,-1,-4};

        int maxSum = arr[0];
        int currentSum = 0;

        for(int i = 1; i < arr.Length; i++)
        {

            currentSum += arr[i];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }

            else if (currentSum < 0)
                currentSum = 0;
        }
        return maxSum;
    }

    public static int[] MaxSubArraySumArray(int[] arr)
    {
        int[] temp = [];

        int maxSum = arr[0];
        int currentSum = 0;
        int start = 0;
        int ansStart = -1;
        int ansEnd = -1;
        for (int i = 1; i < arr.Length; i++)
        {
            if (currentSum == 0)
            {
                start = i;
            }

            currentSum += arr[i];

            if (currentSum > maxSum)
            {
                ansStart = start;
                ansEnd = i;
                maxSum = currentSum;
            }

            else if (currentSum < 0)
                currentSum = 0;
        }
        return temp;
    
}
}