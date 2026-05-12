using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Revision_Part_Two_Last
{
    //Brute Force Approach
    public class Check_if_the_array_is_sorted_II
    {
        public static bool CheckArraySorted()
        {
            //int[] arr = [1, 2, 1, 4, 5];
            int[] arr = [1, 2, 3, 4, 5];

            if (arr.Length <= 1)
            {
                return true;
            }

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i]> arr[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //Optimal Solution
        public static bool CheckArraySorted_V2()
        {
            //  int[] arr = [1, 2, 1, 4, 5];
            int[] arr = [1, 2, 3, 4, 5];
            for (int i= 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        
    }
}
