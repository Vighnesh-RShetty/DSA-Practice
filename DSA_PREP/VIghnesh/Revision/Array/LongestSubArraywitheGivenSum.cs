using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Revision.Array
{
    public class LongestSubArraywitheGivenSum
    {
        public static int LongestSubArraySum_K_Positives(int[] arr, int k)
        {

            int left = 0; 
            int right = 0;
            int sum = 0;
            int maxLength = 0;

            while (right < arr.Length)
            {
                sum+=arr[right];
                if(sum==k && right > maxLength)
                {
                    maxLength = right+1;
                }
                if (sum < k)
                {
                    //sum += arr[right];
                    right++;
                    
                }else if(sum > k)
                {
                    sum -= arr[left];
                    left++;
                    right++;
                    if (maxLength > right)
                    {
                        maxLength = right;
                    }
                }
               
            }
            return maxLength;

        }
    }
}
