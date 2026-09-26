using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revison_First_.Binary_Search.BS_ON_1D_Array;

public class Search_Rotated_Sorted_II
{
    public static bool Search_Rotated__II(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (arr[mid] == target) return true;

            if (arr[low]== arr[mid] && arr[mid] == arr[high])
            {
                low = low + 1;
                high = high - 1;
                continue;
            }

            if (arr[low] <= arr[mid])
            {

                if (arr[mid] >= target && arr[low] <= target)
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
                if (arr[mid] <= target && arr[high] >= target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

        }
        return false;
    
}
}
