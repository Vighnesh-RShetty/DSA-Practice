using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Revision_Part_Two_Last;

internal class Longest_Subarray_With_Given_Sum_K_Positives
{

    //Brute Force
    public static int Longest_SubArray_Length_Positives()
    {

        int[] arr = [10, 5, 2, 7, 1, 9];
        int sum = 0;
        int count = 0; 
        int maxCount = 0;
        int n = 15;
        //Output: 4

        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = i;j < arr.Length; j++)
            {
                sum = 0;
            
                for (int k = i; k <= j; k++) {
                    sum += arr[k];
                    
                        }

                if(sum == n)
                {
                    int length = j - i + 1;

                    if (maxCount < length) {
                        maxCount = length;
                            }
                }

            }
        }
        return maxCount;

    }
}
