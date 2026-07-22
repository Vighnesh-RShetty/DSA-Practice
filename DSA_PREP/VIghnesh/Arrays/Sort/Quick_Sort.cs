using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Sort;

public class Quick_Sort_Ds
{

    public void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = Partition(arr, low, high);

            QuickSort(arr, low, partitionIndex - 1);

            QuickSort(arr, partitionIndex + 1, high);
        }
    }

    public int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[low];

        int i = low;
        int j = high;

        while (i < j)
        {
            while (i <= high && arr[i] <= pivot)
                i++;

            while (j >= low && arr[j] > pivot)
                j--;

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
