using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Revision_Part_Two_Last
{
    public class Rearrange_array_elements_by_sign
    {
        /* 
Input : nums = [2, 4, 5, -1, -3, -4]
Output : [2, -1, 4, -3, 5, -4]
Explanation: The positive number 2, 4, 5 maintain their relative positions and -1, -3, -4 maintain their relative positions
         */

        public static int[] Rearrange_By_Sign()
        {
            int[] nums = [2, 4, 5, -1, -3, -4];

            int[] res = new int[nums.Length];
            int positiveIndex = 0;
            int negativeIndex = 1;

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    res[positiveIndex] = nums[i];
                    positiveIndex = positiveIndex + 2;
                }

                else
                {
                    res[negativeIndex] = nums[i];
                    negativeIndex += 2;
                }
                    
            }
            return res;
        }


    }
}
