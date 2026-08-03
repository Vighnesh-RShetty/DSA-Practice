using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search;
public class Find_Minimum_Rotated_Sorted
{
    public static int FindMinimunInRotatedSorted(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;
        int minValue = -1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }

            //left
            if (arr[mid] >= arr[low])
            {
                if (arr[low] <= target && target <= arr[mid])
                {
                    high = mid - 1;

                }
                else
                {

                    low = mid + 1;
                    if (arr[low] < minValue)
                    {
                        minValue = arr[low];
                    }
                }
            }
            //right
            else
            {
                if (arr[mid] <= target && target <= arr[high])
                {
                    low = mid - 1;
                    if (arr[low] < minValue)
                    {
                        minValue = arr[low];
                    }

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
