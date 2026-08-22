using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search.Binary_Search_On_Answers;

public class smallest_divisor
{

    public static int FindSmallestDivisor(int[] arr,int limit)
    {
        int low = 1;int high = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > high) high = arr[i];
        }

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (CheckDivisor(arr, mid) <= limit)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
       
        return low;
    }

    public static int CheckDivisor(int[] arr, int divsior)
    {
        int totalNum = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            totalNum += (arr[i] + divsior - 1) / divsior;
        }

        return totalNum;
    }
}
