using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search;

public class FloorAndCeil_Value
{
    public static int[] Floor_Ceil_Value(int[] arr,int k)
    {
        int low = 0;
        int high = arr.Length - 1;
        int[] ans = new int[2];

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] >= k)
            {
                ans[1] = arr[mid];
                high = mid - 1;
            }else if (arr[mid]<= k)
            {
                ans[0] = arr[mid];
                low = mid + 1;
            }

        }
        return ans;
    }
}
