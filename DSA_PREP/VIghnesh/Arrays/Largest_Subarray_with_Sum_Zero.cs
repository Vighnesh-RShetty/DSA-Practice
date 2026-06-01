using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays;

public class Largest_Subarray_with_Sum_Zero
{
    public static int Largest_SubArray_With_Sum_Zero()
    {
        int[] arr = [15, -2, 2, -8, 1, 7, 10, 23];
        Dictionary<int, int> map = new();
        map[0] = -1;

        int prefixSum = 0;
        int maxLength = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            prefixSum += arr[i];

            if (map.ContainsKey(prefixSum))
            {
                int length = i - map[prefixSum];
                if(length > maxLength)
                maxLength = length;
            }
            else
            {
                map.Add(prefixSum, i);
            }
        }
        return maxLength;
    }
}
