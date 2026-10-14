

namespace Revison_First_.Binary_Search.BS_ON_ANSWERS;

public class Find_Smallest_Divisor
{
    public static int FinadSmallestDivisor(int[] arr,int threshold)
    {
        int low = 1;
        int high = 8;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (CanDivide(arr, threshold, mid))
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return low;


    }

    public static bool CanDivide(int[] arr,int threshold,int value)
    {
        int sum = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            sum += (arr[i] + value - 1) / value;
        }

        return sum <= threshold;
    }

}
