using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revison_First_.Binary_Search.BS_ON_1D_Array;

public class FloorAndCeil
{
    public static int[] FloorAndCeilValue(int[] arr,int target)
    {

        int floor = FindFloor(arr, target);
        int ceil = FindCeil(arr, target);

        return [floor, ceil];
    }

    public static int FindFloor(int[] arr,int target)
    {

        int low = 0;
        int high = arr.Length - 1;
        int ans = -1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] <= target)
            {
                ans = mid;
                low = mid + 1;
            }
            else {
                high = mid - 1;
                    }
        }
        return ans;
    }

    public static int FindCeil(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;
        int ans = -1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] >= target)
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
