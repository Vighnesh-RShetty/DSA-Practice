using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search;

public class FindFirstAndLastOcuurance
{

    public static int[] Find_First_Last_Occurance(int[] arr,int k)
    {
        int low = 0;
        int high = arr.Length - 1;
        int[] ans = new int[2];
        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] < k)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
            int i = 0;
            if (arr[low] == k)
            {
                ans[i] = low;
                i++;
            }
            if (arr[high] == k)
                ans[i] = high;
            i++;
        }
        return ans;
    }
}
    
