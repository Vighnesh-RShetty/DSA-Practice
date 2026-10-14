

namespace Revison_First_.Binary_Search.BS_ON_ANSWERS;

public class Minimun_Days_ToMake_M_Bouquet
{

    public static int Min_Days_Required_To_Make_Bouq(int[] arr,int m,int k)
    {
        int low = int.MaxValue;
        int high = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            low = Math.Min(low, arr[i]);
            high = Math.Max(high, arr[i]);
        }

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (CanBloom(arr, mid, m, k))
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

    public static bool CanBloom(int[] arr,int mid,int m,int k)
    {
        int count = 0;
        int totaBouq = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] <= mid)
            {
                count++;
            }
            else
            {
                totaBouq += count / k;
                count = 0;
            }
        }
        totaBouq += count / k;
        return totaBouq >= m;
    }
}
