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

    //Better Force
    public static int Longest_SubArray_Length_Positives_Better( )
    {

        int[] arr = [10, 5, 2, 7, 1, 9];
        int sum = 0;
        int count = 0;
        int maxCount = 0;
        int target = 15;
        //Output: 4

        for (int i = 0; i < arr.Length; i++)
        {
            sum = 0;
            for (int j = i; j < arr.Length; j++)
            {
                sum +=  arr[j];

                if (sum == target)
                {
                    int length = j - i + 1;

                    if (maxCount < length)
                    {
                        maxCount = length;
                    }
                }
            }
        }
        return maxCount;
    }

    //Optimal Solution
    public static int Longest_SubArray_Length_Positives_Optimal()
    {

        // int[] arr = [10, 5, 2, 7, 1, 9]; //Output: 4
        // int target = 15;
        // 
        int[] arr = [2, -1, 2, 3];
         int target = 4;

        int windowSize = 0;
        int maxLength = 0;

        int right = 0;
        int left = 0;
        int sum = 0;

        while (right < arr.Length)
        {
            sum += arr[right];


            if (sum == target)
            {
                windowSize = right - left + 1;
                if (windowSize > maxLength)
                {
                    maxLength = windowSize;

                }
            }
                while (sum > target)
                {
                    sum -= arr[left];
                    left++;
                }
            right++;
            }
        return maxLength;
        }

        
    }


