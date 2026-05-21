using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Revision_Part_Two_Last;

public class NextPermutation_Revision_Part
{
    int[] arr = [1,2,7,4,3,1];
    //O P   [1,3,1,2,4,4,7]
    
    public static void Next_Permu()
    {
        int[] arr = [1, 2, 7, 4, 3, 1];
        int pivot = 0;
       
        for(int i = arr.Length - 2; i >= 0; i--)
        {
            if (arr[i] > arr[i - 1])
            {
                pivot = i;
                break;
            }
        }
        
        for(int i = arr.Length - 1; i > pivot; i--)
        {
            if (arr[i] > arr[pivot])
            {
                int temp = arr[i];
                arr[i] = arr[pivot];
                arr[pivot] = temp;
                break;
            }
        }

        int left = pivot+1;
        int right = arr.Length - 1;
        while (left < right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            left++;right--;

        }
        Console.WriteLine(arr);
    }
}
