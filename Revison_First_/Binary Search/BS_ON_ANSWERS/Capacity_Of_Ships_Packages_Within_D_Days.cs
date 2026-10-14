

namespace Revison_First_.Binary_Search.BS_ON_ANSWERS;

public class Capacity_Of_Ships_Packages_Within_D_Days
{

    public static int Capacity_Of_Ship(int[] arr,int days)
    {
        int low = 1;
        int high = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            high += arr[i];
        }

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (MinCapacity(arr, mid, days))
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


    public static bool MinCapacity(int[] arr, int capacity, int days)
    {
        int totalWeight = 0;
        int totalDays = 1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (totalWeight + arr[i] <= capacity)
            {
                totalWeight += arr[i];
            }
            else
            {
                totalDays++;
                totalWeight = arr[i];
            }
        }

        return totalDays <= days;
    }


}
