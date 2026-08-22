using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search.Binary_Search_On_Answers;

public class No_Of_Bouquet
{
    public static int No_Of_Bouq(int[] arr,int m,int k)
    {
        int min = int.MaxValue;
        int max = int.MinValue;

        if (arr.Length < m * k) return -1;

        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] <= min) min = arr[i];
            if (arr[i]>=max) max = arr[i]; 
        }


        int low = min;int high = max;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (isBouquePossible(arr, mid, m, k))
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

    public static bool isBouquePossible(int[] arr, int day,int m ,int k)
    {
        int count = 0;
        int totaLNoOfBouq = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] <= day)
            {
                count++;
            }
            else
            {
                totaLNoOfBouq += (count / k);
                count = 0;
            }
        }
        totaLNoOfBouq += (count / k);
        if (totaLNoOfBouq >= m) return true;
        else return false;
    }
}
