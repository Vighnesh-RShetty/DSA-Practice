using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays;

public class NextPermutation
{

    public static int[] NextPermutationArray()
    {
        int[] arr = [1, 2, 5, 4, 0];
        // 0/P = 1 4 5 2 0 
        int idx1 = arr.Length - 2;

        for(int i = idx1; i < arr.Length; i--)
        {
            if (arr[idx1] < arr[idx1+1])
            {
                int temp = arr[idx1];
                arr[idx1] = arr[idx1+1];
                arr[idx1 + 1] = temp;
            }
            else
            {
                break;
            }
        }
        return arr;
    }

}
