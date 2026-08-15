using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search;

public class Single_Element_In_A_Sorted_Array
{

   // [1, 1, 2, 2, 3, 3, 4, 5, 5, 6, 6]
   // O/P : 4 

    public int SingleElementInArray(int[] arr)
    {
        int n = arr.Length;
        if (n ==1) return arr[0];
        if (arr[0] != arr[1]) return arr[0];
        if (arr[n - 1] != arr[n - 2]) return arr[n - 1];

        int low = 0;int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] != arr[mid - 1] && arr[mid] != arr[mid + 1]) return arr[mid];

            if (mid % 2 == 1 && arr[mid] == arr[mid - 1] || mid % 2 == 0 && arr[mid] == arr[mid + 1])
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }

        }
        return -1;
    }
}
