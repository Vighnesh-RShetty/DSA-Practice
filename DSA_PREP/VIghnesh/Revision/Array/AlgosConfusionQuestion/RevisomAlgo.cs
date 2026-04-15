using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Revision.Array.AlgosConfusionQuestion;

public class RevisonAlgo
{
    //Sliding Winodw
    //Find the longest subarray with sum = K
    public static int LongestSubarrayWithSum(int[] arr,int k)
    {
        //[2, 3, 1, 2, 4, 3]

        int left = 0;
        int sum = 0;
        int maxLength = 0;

        for (int right = 0; right < arr.Length; right++)
        {
            sum += arr[right];

            while (sum > k)
            {
                sum -= arr[left];
                left++;
            }

            if (sum == k)
            {
                maxLength = right - left + 1;
            }
        }

        return maxLength;
    }

    //  Find the longest subarray with sum = K
    //arr = [1, -1, 5, -2, 3]
    //K = 3
 
    public static int LongestSubarrayWithSum_NegativeValues(int[] arr,int k)
    {
        //arr = arr = [1, 2, 1, 1, 1], K = 3
        int maxLength = 0;
        int sum = 0;
        int[] prefixSumArray = new int[arr.Length];
         Dictionary<int,int> prefixMap = new Dictionary<int,int>();
         
        for(int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            if (sum == k)
                maxLength = i + 1;

            int remaing = sum - k;
            
                if (prefixMap.ContainsKey(remaing))
                {
                int length = i - prefixMap[remaing];
                maxLength=Math.Max(maxLength, length);
                    //if (length > maxLength)
                    //{
                    //    maxLength = length;
                    //}
                }
            if (!prefixMap.ContainsKey(remaing))
            {
                prefixMap[remaing] = i;
            } 
        }
        return maxLength;
    }

    public static int MaximumSumSubraySum()
    {
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

        int maxSum = arr[0];
        int sum = 0;
        for(int i = 0; i < arr.Length; i++)
         {
            sum += arr[i];

            if (sum > maxSum)
             {
                maxSum = sum;
            }

            if (sum < 0)
            {
                sum = 0;
            }
        }
        return maxSum;
    }
}
