using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Sort;
public class Merge_with_inversion
{
    public void Merge_Sort(int[] arr,int low,int high)
    {
        if (low >= high) return;
        int mid = (low + high) / 2; // low + (high - low) / 2;

        Merge_Sort(arr, low, mid);
        Merge_Sort(arr, mid + 1,high);

        Merger_Method(arr, low, mid, high);
    }

    public void Merger_Method(int[] arr,int low,int mid,int high)
    {
        int i = low;
        int j = mid+1;
        List<int> temp = new();

        while (i <= mid && j <= high)
        {
            if (arr[i] <= arr[j])
            {
                temp.Add(arr[i]);
                i++;
            }
            else
            {
                temp.Add(arr[j]);
                j++;
            }
        }

        while (i <= mid)
        {
            temp.Add(arr[i]);
            i++;
        }

        while (j <= high)
        {
            temp.Add(arr[j]);
            j++;
        }

        Console.WriteLine(temp);
    }
}