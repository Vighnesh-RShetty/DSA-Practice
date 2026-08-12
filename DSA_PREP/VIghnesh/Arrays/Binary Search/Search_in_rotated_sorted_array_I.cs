using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search;

public class Search_in_rotated_sorted_array_I
{

    public static int SearchInRotatedSorted(int[] arr,int target)
    {
        int low = 0;int high = arr.Length - 1;

        while (low <= high)
        {
            int mid =   (low+ high )/ 2;

            if (arr[mid]  == target)
            {
                return mid;
            }

            //left
            if (arr[low] <= arr[mid])
            {

                if (arr[mid] >=target && arr[low] <= target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }


            //right
            else
            {
                if (arr[mid] <=target && arr[high] >= target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid  - 1;
                }
            }
        }



        return -1;
    }
}
