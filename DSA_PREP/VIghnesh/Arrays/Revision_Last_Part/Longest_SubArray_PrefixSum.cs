using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Revision_Last_Part;

public class Longest_SubArray_PrefixSum
{
    public  static int LongestSubArrayPrefixSum(int[] arr, int k)
    {
        Dictionary<int, int> subArrayMap = new();
        int length = 0;
        int maxLength = 0;
        int sum = 0;

        subArrayMap.Add(0, -1);
        for (int i = 0; i < arr.Length; i++)
        {
            sum = sum + arr[i];

            int remaining = sum - k;

            if (subArrayMap.ContainsKey(remaining))
            {
                length =i - subArrayMap[remaining];
               maxLength = Math.Max(length, maxLength);
            }

            if (!subArrayMap.ContainsKey(sum))
            {
                subArrayMap.Add(sum, i);
            }

        }
        return maxLength;
    }
}

