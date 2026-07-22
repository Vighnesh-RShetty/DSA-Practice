using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Revision_Last_Part;

public class Maximum_SubArray_Sum_Positives
{
    public static int Sliding_Window()
    {
        int[] arr = [1, 2, 3, 1, 1, 1, 1, 4, 2, 3];
        int k = 3;

        int left = 0;
        int right = 0;
        int sum = 0;
        int length = 0;
        int maxLength = 0;

        while (right < arr.Length)
        {
            sum = sum + arr[right];
            right++;

            while (sum > k)
            {
                sum -= arr[left];
                left++;
            }

            if (sum == k)
            {
                length = (right - left);
                if (length > maxLength)
                {
                    maxLength = length;
                }
            }
        }
        return maxLength;
    }
}
