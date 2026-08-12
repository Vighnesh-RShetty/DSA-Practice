using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search;

public class Floor_And_Ceil_In_Sorted_Array
{

    public static int[] Floor_Ceil_Sorted_Array()
    {
        int[] nums = [3, 4, 4, 7, 8, 10];
        int x = 5;
        // 4 7

        int floor = FindFloor(nums, x);
        int ceil = FindCeil(nums, x);

        return [floor,ceil];
    }

    public static int FindFloor(int[] arr,int target)
    {
        int low = 0;
        int high = arr.Length - 1;
        int ans = -1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] <= target)
            {
                ans = arr[mid];
                low = mid + 1;
            }
            else
            {
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
            int mid = (low + high) / 2;

            if (arr[mid] >= target)
            {
                ans = arr[mid];
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
