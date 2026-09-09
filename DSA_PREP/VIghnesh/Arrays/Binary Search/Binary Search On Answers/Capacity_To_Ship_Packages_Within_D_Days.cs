using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search.Binary_Search_On_Answers;

public class Capacity_To_Ship_Packages_Within_D_Days
{

    public static int  MinCapcity_Ship_Packages(int[] weights,int days)
    {
        int low = 0;
        int high = 0;
        for(int i = 0; i < weights.Length; i++)
        {
            if (weights[i]>=low) low = weights[i];
            high += weights[i];
        }

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            int no_of_days = No_Of_Days(weights, mid);

            if (no_of_days <= days) high = mid - 1;
            else low = mid + 1;

        }
        return low;

    }

    public static int No_Of_Days(int[] weights,int mid)
    {
        int days = 1;
        int load = 0;

        for(int i = 0; i < weights.Length; i++)
        {
            if (load + weights[i] > mid)
            {
                days += 1;
                load = weights[i];
            }
            else
            {
                load += weights[i];
            }
        }

        return days;
    }
}
