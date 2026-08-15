using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search;

public class Find_Minimum_In_Sorted
{
    
    public static int Find_Minimum_In_Rotated(int[] arr)
    {
        int low = 0; 
        
        int high = arr.Length - 1;

        // [ 4 5 6 7 0 1 2 ]
        int min = int.MaxValue;
        
        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] >= arr[low])
            {
                min = Math.Min(min, arr[low]);
                
                low = mid + 1;
            }
            else
            {
                Math.Min(min, arr[mid]);
                high = mid - 1;
            }
        }
         

        return min;
    }
}
