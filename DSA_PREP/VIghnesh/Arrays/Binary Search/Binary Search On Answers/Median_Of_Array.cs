using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search.Binary_Search_On_Answers;

public class Median_Of_Array
{

    public static double MedianOfArray_Binary(int[] arr1, int[] arr2)
    {
        int n1 = arr1.Length;
        int n2 = arr2.Length;

        if (n1 > n2) return MedianOfArray_Binary(arr2, arr1);

        int low = 0;
        int high = n1;

        int left = (n1 + n2 + 1) / 2;

        while (low <= high)
        {
            int mid1 = low + (high - low) / 2;

            int mid2 = left - mid1;

            int l1 = int.MinValue;
            int l2 = int.MinValue;

            int r1 = int.MaxValue;
            int r2 = int.MaxValue;

            if (mid1 < n1) r1 = arr1[mid1];
            if (mid2 < n2) r2 = arr2[mid2];

            if (mid1 - 1 >= 0) l1 = arr1[mid1 - 1];
            if (mid2 - 1 >= 0) l2 = arr2[mid2 - 1];

            if (l1 <= r2 && l2 <= r1)
            {
                if ((n1 + n2) % 2 == 1) return Math.Max(l1, l2);
                else return (Math.Max(l1, l2) + Math.Min(r1, r2)) / 2.0;
            }
            else if (l1 > r2) high = mid1 - 1;
            else low = mid1 + 1;   

        }
        return 0;
    }
}
