using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Sort;

public class Bubble_Sort
{
    public static void BubbleSort()
    {

        int[] arr = { 13, 46, 24, 20, 9 };
        int n = arr.Length;

        for(int i = n - 1; i >= 1; i--)
        {
            for(int j=0; j < i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

}
