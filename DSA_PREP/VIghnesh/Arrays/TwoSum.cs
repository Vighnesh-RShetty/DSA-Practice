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
                }else if(i > j)
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
    }
}
