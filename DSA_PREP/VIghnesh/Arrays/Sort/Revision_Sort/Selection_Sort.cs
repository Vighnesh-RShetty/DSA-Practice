using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Sort.Revision_Sort;

public class Sorting
{
    public void Selection_Sort()
    {

        int[] arr = { 1, 9, 5, 4, 2 };

        int min = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            min = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }
            int temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
        }
    }

    public void Bubble_Sort()
    {

        int[] arr = { 1, 9, 5, 4, 2 };

        for (int i = arr.Length-1; i >=1; i--)
        {
            for (int j = 0 ; j < i; j++)
            {
                if (arr[j] > arr[j+1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }  
        }
    }

    public void Insertion_Sort()
    {
       int[] arr = { 1, 9, 5, 4, 2 };

        for(int i=1; i <= arr.Length; i++)
        {
            int j = i;

            while(j > 0 && arr[j-1] > arr[j])
            {

                int temp = arr[j - 1];
                arr[j - 1] = arr[j];
                arr[j] = temp;
                j--;
          
            }
        }
    }

    public void Merge_Sort(int[] arr,int low, int high)
    {
        //int[] arr = {1, 9, 5, 4, 2 };

        int mid = ((high + low) / 2);

        if (low <= high) return;

        Merge_Sort(arr, low, mid);
        Merge_Sort(arr, mid + 1, high);

    }

    public void MergeSort(int[] arr,int low,int mid,int high)
    {

        int left = low;
        int right = mid + 1;


    }
}
