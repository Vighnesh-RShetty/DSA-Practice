using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Sort.Revision_Sort;

public class QuickSortClass
{
    public void Quick_Sort(int[] arr, int low,int high)
    {
        if (low >= high) return;
        int partion = Partition(arr, low, high);
        Quick_Sort(arr, low, partion-1);
        Quick_Sort(arr, partion + 1, high);
    }

    public int Partition(int[] arr, int low , int high)
    {
        int pivot = arr[low];

        int i = low;
        int j = high;

        while (i < j)
        {
            while (i <= high && arr[i] <= pivot) i++;
            while (j >= low && arr[j] > pivot) j--;

            if (i < j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

        }

        int temp2 = arr[low];
        arr[low] = arr[j];
        arr[j] = temp2;

        return j;
    }

}
