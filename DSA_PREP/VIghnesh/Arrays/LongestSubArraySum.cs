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
    }
}
