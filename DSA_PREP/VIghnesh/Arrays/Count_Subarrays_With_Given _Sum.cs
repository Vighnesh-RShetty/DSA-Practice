using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays;

public class Count_Subarrays_With_Given__Sum
{

    public static int MaxSubArrayCount()
    {

        int[] arr = [10, 2, -2, -20, 10];
        int k = -10;

        Dictionary<int, int> dicArray = new();
        dicArray[0] = 1;

        int prefixSum = 0;
        int count = 0;
    

        for(int i = 0; i < arr.Length; i++)
        {
            prefixSum += arr[i];

            int remaining = prefixSum - k;

            if (dicArray.ContainsKey(remaining)){
                count += dicArray[remaining];
            }
            if (dicArray.ContainsKey(prefixSum))
            {
                dicArray[prefixSum]++;
            }

            else
            {
                dicArray[prefixSum] = 1;
            }
            
        }

        return count;
    }
}
