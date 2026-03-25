using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays
{
    public class LongestSubArraySum
    {
        public static int LongestSubArraySumLength(int[] arr,int k)
        {

            int count = 0;
            int maxCount = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                
                int sum = 0;
                for(int j = i; j < arr.Length; j++)
                {
                    count++;
                    sum += arr[j];
                    if(sum == k)
                    {
                        if(count > maxCount)
                        {
                            maxCount = count;
                        }
                    }
                }
                count = 0;
            }
            return maxCount;
        }

        public static int OptimizedLongestSubArraySumLength(int[] arr, int k)
        {
            //int[] arr = { 9, 4, 8, 4, 5, 5, 4 };
            //int k = 9;

            Dictionary<int,int> dict = new Dictionary<int,int>();

            int maxLength = 0;
            int prefixSum = 0;
            int currentLength = 0;
           for(int i = 0; i < arr.Length; i++)
            {
                prefixSum += arr[i];
                if(prefixSum == k)
                {
                    maxLength = i + 1;
                }
               

                int remaining = prefixSum - k;


                if (dict.ContainsKey(remaining))
                {
                    currentLength = i - dict[remaining];
                    if(currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                }
                if (!dict.ContainsKey(prefixSum))
                {
                    dict[prefixSum] = i;
                }
               // return maxLength; 
            }
            return maxLength;

        }
    }
}
