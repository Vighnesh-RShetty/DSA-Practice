using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search;

public class Lower_Bound
{
    public static int LowerBound(int[] arr,int k)
    {

        int low = 0;
        int high = arr.Length - 1;

        int ans = arr.Length;

        while (low<= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] >= k)
            {
                ans = mid;
                high = mid - 1;
            } else  {
                low = mid+1;
                //return mid;
            }
          
        }
        return ans;
    }
}
