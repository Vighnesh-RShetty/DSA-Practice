using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search;

public class Search_In_Rotated_Sorted_I
{
    // [4, 5, 6, 7, 0, 1, 2], //  k = 0

    public static int Search_In_Rotated(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }

            if (arr[mid] >= arr[low])
            {
                if (arr[low] <= target && target <= arr[mid])
                {
                    high = mid - 1;

                }
                else
                {
                    low = mid + 1;
                }
            }
            else
            {
                if (arr[mid]<=target && target <= arr[high])
                {
                    low = mid -1;

                }
                else
                {
                    high = mid - 1;
                }
            }
        }
        return -1;
    }
}
