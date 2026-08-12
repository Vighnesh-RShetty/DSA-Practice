using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search;

public class Search_Insert_Position
{
    public static int SearchInsertPosition(int[] arr,int n,int target)
    {
        int low = 0;
        int high = n - 1;
        int ans = n;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }
            if (arr[mid] > target)
            {
                ans = mid;
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return ans;
    }
}
