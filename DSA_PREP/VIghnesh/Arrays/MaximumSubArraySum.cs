using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
                        sum = sum + arr[k];
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

        public static int optimizedMaximunSubArray(int[] arr, int k)
        {
            Dictionary<int, int> prefixMap = new Dictionary<int, int>();

            int prefixSum = 0;
            int count = 0;
            prefixMap[0] = 1;

            for(int i = 0; i < arr.Length; i++)
            {
                prefixSum+=arr[i];

                int remaing = prefixSum - k;
                if (prefixMap.ContainsKey(remaing))
                {
                    count += prefixMap[remaing];
                }
                if (prefixMap.ContainsKey(prefixSum))
                {
                    prefixMap[prefixSum]++;
                }
                else
                {
                    prefixMap[prefixSum] = 1;
                }
            }
            return count;
        }
    }
}

