using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revison_First_.Arrays;

public class LongestSubArraySumPositive
{
    public  static int LongestSub_Array_Sum_Positive(int[] arr,int k)
    {
        int left = 0; 
        int right = 0;
        int windowSum = 0;
        int maxLength = 0;

       // int[] arr = [10, 5, 2, 7, 1, 9];

        while (right < arr.Length)
        {
            windowSum += arr[right];

            if(windowSum < k)
            {
                right++;
            }else if(windowSum == k)
            {
                if((right-left+1 > maxLength))
                {
                    maxLength = right - left + 1;
                }
                right++;
            }
            else
            {

                while (windowSum > k)
                {
                    windowSum -= arr[left];
                    left++;
                    right++;
                }
            }

        }

        return maxLength;
    }
}
