using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search.Binary_Search_On_Answers;

public class Count_Cows_Brute_Force
{
    public static int CountCows(int[] arr, int cows)
    {
        int max = int.MinValue;

        int min = int.MaxValue;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }

        for (int i = 0; i < max - min; i++)
        {
            if (CanWePlaceCows(arr, cows, i) == true)
            {
                continue;
            }
            else
            {
                return i - 1;
            }
        }
        return -1;
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
