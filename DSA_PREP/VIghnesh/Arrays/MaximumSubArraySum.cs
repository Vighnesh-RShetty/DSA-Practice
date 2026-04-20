using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays;
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

    public static int optimizedMaximunSubArray()
    {
        int[] arr = { 1, 2, 3, 4 }; 
        int k = 3;
        Dictionary<int, int> map = new Dictionary<int, int>();

        int prefixSum = 0;
        int count = 0;
        map[0] = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            prefixSum += arr[i];
            int remaining = prefixSum - k;

            if (map.ContainsKey(remaining)){
                count += map[remaining];
            }
            if (map.ContainsKey(prefixSum))
            {
                map[prefixSum]++;
            }
            else{
                map[prefixSum] = 1;
            }
            
        }
        return count;
    }
}
        //return count;
    

    //public static int 


