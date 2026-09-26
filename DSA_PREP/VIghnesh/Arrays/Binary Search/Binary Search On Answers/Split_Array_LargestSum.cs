using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search.Binary_Search_On_Answers;

public class Split_Array_LargestSum
{
    public static int SplitLargest(int[] arr, int k)
    {
        int low = 0;
        int high = 0 ;

        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > low) low = arr[i];
            high += arr[i];
        }

        for(int i = low; i < high; i++)
        {
            int count = CheckLargest(arr, i);

            if (count == k) return i;
        }
        return -1;
    }

    public static int CheckLargest(int[] arr,int value)
    {
        int countSplit = 1;int sum = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            if (sum + arr[i] <= value)
            {
                sum += arr[i];
            }
            else
            {
                countSplit++;
                sum = arr[i];
            }
        }
        return countSplit; 
    }
}
