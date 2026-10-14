

namespace Revison_First_.Binary_Search.BS_ON_ANSWERS;

public class Aggressive_Cows
{

    public static int AggresiveCows(int[] arr, int cows)
    {
        Array.Sort(arr);
        int low = 1;
        int high = arr[arr.Length - 1] - arr[0];

        while(low <= high)
        {
            int mid = low + (high - low) / 2;

            if (CanWePlace(arr, mid, cows))
            {
                low= mid + 1;
            }
            else {
                high = mid - 1;

            }
        }
        return low-1;
    }

    public static bool CanWePlace(int[] arr,int mid,int cows)
    {
        int totalCows = 1;
        int last = arr[0];

        for(int i = 1; i < arr.Length; i++)
        {
            if (arr[i] - last >= mid)
            {
                totalCows++;
                last = arr[i];
            }
        }

        if (totalCows >= cows) return true;
        else return false;
    }
}
