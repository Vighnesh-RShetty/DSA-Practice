using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Revision_Part_Two_Last;

public class Print_subarray_with_maximum_subarray_sum
{

    /* 
     * Test Case 1
    Input:
      [2, 3, 5, -2, 7, -4]
   Output:
     Maximum Sum = 15
     Subarray = [2, 3, 5, -2, 7]

     * Test Case 2
     Input:
      [-2, -3, -7, -2, -10, -4]
     Output:
   Maximum Sum = -2
   Subarray = [-2]


     */
    //Brute Force
    public static void Print_SubArray_MaxSum()
    {
        /* 
          Input:
      [2, 3, 5, -2, 7, -4]
        Output:
      Maximum Sum = 15
         Subarray = [2, 3, 5, -2, 7]
         */
        int[] arr = [2, 3, 5, -2, 7, -4];
        
        int maxSum = 0;
        int startIndex = 0;
        int endIndex = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            int sum = 0;
            for(int j = i; j < arr.Length; j++)
            {
                sum += arr[j];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    startIndex = i;
                    endIndex = j;
                }

            }
        }
        for(int k = startIndex; k <= endIndex; k++)
        {
            Console.Write(arr[k] + " ");
        }
    }

    public static void Print_SubArray_MaxSum_Optimized()
    {
        /* 
         Input:
     [2, 3, 5, -2, 7, -4]
       Output:
     Maximum Sum = 15
        Subarray = [2, 3, 5, -2, 7]
        */

        int currentSum = 0;
        int maxSum = 0;
        int startIndex = 0;
        int endIndex = 0;
        int tempStart = 0;

        int[] arr = [2, 3, 5, -2, 7, -4];

        for(int i = 0; i < arr.Length; i++)
        {
            currentSum += arr[i];
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                endIndex = i;
                startIndex = tempStart;
            }
            if (currentSum < 0)
            {
                currentSum = 0;
                tempStart = i + 1;
            }
        }
    }
}
