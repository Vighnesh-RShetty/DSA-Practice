using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search;

public class Find_Out_How_Many_Times_The_Array_Is_Rotated
{
    public static int Find_No_Of_Times_Array_Rotated(int[] arr)
    {
        int low = 0;

        int high = arr.Length - 1;

        // [ 4 5 6 7 0 1 2 ]
        int min = int.MaxValue;
        int minIndex = -1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] >= arr[low])
            {
               // min = Math.Min(min, arr[low]);
                if (arr[low] < min)
                {
                    min = arr[low];
                    minIndex = low;
                }

                low = mid + 1;
            }
            else
            {
                if (arr[mid] < min)
                {
                    min = arr[mid];
                    minIndex = mid;
                }
                high = mid - 1;
            }
        }
        return min;
    }
}
