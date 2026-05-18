using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Revision_Part_Two_Last;

public class TwoSum
{
     //Brute Force Solution
    public static int[] TwoSumBruteForce()
    {
        int[] arr = [-1, -2, -3, -4, -5];
        int k = -8;
        int i = 0;
        int j = arr.Length-1;

        while (i<=j)
        {
            int sum = arr[i] + arr[j];
            if (sum == k)
            {
                return [i, j];
            }else if (sum > k)
            {
                i++;
            }
            else if (sum > k)
            {
                j--;
            }
            
        }

        return [];
    }

}
