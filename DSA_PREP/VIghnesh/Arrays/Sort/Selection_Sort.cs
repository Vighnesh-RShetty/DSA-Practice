using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Sort;

public class Selection_Sort
{
    public static void SelectionSort()
    {
        int[] arr = { 13, 46, 24, 20, 9 };

        for(int i = 0; i < arr.Length-1; i++)
        {
            int minimun = i;

            for(int j = i; j < arr.Length; j++)
            {
                if (arr[j]< arr[minimun])
                {
                    minimun = j;
                }
            }

            int temp = arr[minimun];
            arr[minimun] = arr[i];
            arr[i] = temp;
        }
    }
}
