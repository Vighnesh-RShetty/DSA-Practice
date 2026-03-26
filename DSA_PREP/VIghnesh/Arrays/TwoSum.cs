using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays
{
    public class TwoSum
    {
        public static int[] TwoSumValues(int[] arr, int k)
        {
            int i = 0;
            int j = arr.Length - 1;

            while (i <= j)
            {
                if (arr[i] + arr[j] == k)
                {
                    return [i,j];
                }else if(arr[i] > arr[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }

            }
            return [0,0];
        }

        public static int[] TwoSumValuesOptimized(int[] arr,int k)
        {
            Dictionary<int, int> twoSumDict = new();

            for (int i = 0; i < arr.Length; i++)
            {
                if (twoSumDict.ContainsKey(k - arr[i]))
                {
                    return [twoSumDict[k - arr[i]],i];
                }
                else
                {
                    twoSumDict[arr[i]] = i;
                }
            }
            return [-1, -1];
        }
    }
}
