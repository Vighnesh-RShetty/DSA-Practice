
using System.Numerics;

namespace Revison_First_.Binary_Search.BS_ON_1D_Array;

public class FInd_Minimum_In_Rotatd_Sorted
{
    public static int FindMinInRotedSorted(int[] arr)
    {
        int low = 0;
        int high = arr.Length - 1;
        int minValue = int.MaxValue;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[low] <= arr[mid])
            {
                
                    minValue = Math.Min(arr[low], minValue);
                    low = mid + 1;
                }
                else
                {
                minValue = Math.Min(arr[mid], minValue);
                    high = mid - 1;
                }
        }
        return minValue;
    }
}
