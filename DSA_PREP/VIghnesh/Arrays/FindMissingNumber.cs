using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays;

public class FindMissingNumber
{
    //This logic will work only for the sorted array
    public static int FindMissings(int[] arr)
    {

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != i + 1)
            {
                return i + 1;
            }
        }
        return 0;
    }

    public static int FindMissingNum(int[] arr)
    {
        int total = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            total = total+ arr[i];
        }

        int actualTotal = (arr.Length + 1) * (arr.Length + 2) / 2;
        return actualTotal - total;
    }
    
}
