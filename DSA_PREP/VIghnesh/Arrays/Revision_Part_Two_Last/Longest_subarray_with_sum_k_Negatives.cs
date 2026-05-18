using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Revision_Part_Two_Last;


//Optimal Prefix Sum Algo
public class Longest_subarray_with_sum_k_Negatives
{

    public static void Longest_SubArray_With_Sum_K_Negatives()
    {
        int[] arr = [10, 5, 2, 7, 1, 9];

        int k = 15;
        int length = 0;
        int maxLength = 0;
        int prefixSum = 0;
        //[-3, 2, 1], k=6 

        Dictionary<int, int> prefixDictionary = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            prefixSum += arr[i];

            if (prefixSum == k)
                maxLength = i + 1;

            int remaining = prefixSum - k;
            if (prefixDictionary.ContainsKey(remaining))
            {
                length = i - prefixDictionary[remaining];
                if (length > maxLength)
                {
                    maxLength = length;
                }
            }

            if (!prefixDictionary.ContainsKey(prefixSum))
            {
                prefixDictionary.Add(prefixSum, i);
            }

        }
        Console.WriteLine(maxLength);
    }
}
