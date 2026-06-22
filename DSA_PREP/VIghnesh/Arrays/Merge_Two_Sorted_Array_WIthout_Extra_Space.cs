using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays;

public class Merge_Two_Sorted_Array_WIthout_Extra_Space
{

    //Input: nums1 = [-5, -2, 4, 5], nums2 = [-3, 1, 8]

    // Output: [-5, -3, -2, 1, 4, 5, 8]

    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {


        int i = m - 1;
        int j = 0;

        while (i >=0  && j < n)
        {
            if (nums1[i] > nums2[j])
            {
                int temp = nums1[i];
                nums1[i] = nums2[j];
                nums2[j] = temp;

            }
          
            i--;j++;
        }
        //Array.Sort((int[])nums1);
        //Array.Sort((int[])nums2);

        Array.Sort(nums1);
        Array.Sort(nums2);
    }
}