using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search.Binary_Search_On_Answers;

public class Count_Cows_Optimal
{
    public static int CountCows(int[] arr, int cows)
    {

        Array.Sort(arr);
        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }

        int low = 1;
        int high = max-min;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (CanWePlaceCows(arr,cows,mid))
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        
        return high;
    }

    public static bool CanWePlaceCows(int[] arr, int cows, int distance)
    {
        int last = arr[0];
        int countCows = 1;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] - last >= distance)

            {
                countCows++;
                last = arr[i];

            }


        }
        if (countCows >= cows) return true;
        else return false;
    }
}
