using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Sort;

public class Insertion_Sort
{
    public static void InsertionSort()
    {
        int[] arr = { 6,5,4,3,2,1 };

        for (int i = 0; i < arr.Length; i++)
        {

            int j = i;

            while(j>0 && arr[j-1] > arr[j])
            {
                int temp = arr[j];
                arr[j] = arr[j-1];
                arr[j - 1] = temp;
                j--;
            }
        }
    }
}
