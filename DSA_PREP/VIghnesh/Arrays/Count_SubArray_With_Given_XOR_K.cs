using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays;

public class Count_SubArray_With_Given_XOR_K
{
    public static int Count_SubArray_With_Given_XOR_k()
    {
        int[] arr = [4, 2, 2, 6, 4];
        int k = 6;

        int length = 0;
        int maxLength = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = i; j < arr.Length; j++)
            {
                if ((arr[i]^arr[j]) == k)
                {
                    length = j - i + 1;
                    if(length>maxLength)
                        maxLength = length;
                }
            }
        }
        return maxLength;
    }

    //Optimal Solution
    public static int Count_SubArray_With_Given_XOR_k_Optimal()
    {
        int[] arr = [4, 2, 2, 6, 4];
        int k = 6;

        int count = 0;
        int prefixXOR = 0;
        Dictionary<int, int> prefixDict = new();
        prefixDict[0] = 1;

        for (int i = 0; i < arr.Length; i++)
        {
            prefixXOR = prefixXOR ^ arr[i];

            if (prefixDict.ContainsKey(prefixXOR ^ k))
            {
                count += prefixDict[prefixXOR^k];
            }
            if (prefixDict.ContainsKey(prefixXOR))
            {
                prefixDict[prefixXOR] ++;
            }
            else
            {
                prefixDict[prefixXOR] = 1;
            }
        }
        return count;
    }
}
