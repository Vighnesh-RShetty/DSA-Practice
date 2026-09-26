using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revison_First_.Binary_Search.BS_ON_1D_Array;

public class SearhInRotatedSorted_1
{

    public static int SearchInRotated(int[] arr,int target)
    {

        int low = 0;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (arr[mid] == target) return mid;

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
                if (arr[mid]<=target && arr[high] >= target)
                {
                    low = mid + 1;
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
