using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Sort;

public class MergeSort_Test
{

    public int MeregeSort(int[] arr,int low,int high)
    {
        if(low>=high) return 0;
        int mid = (high + low) / 2;

       int leftCount  =   MeregeSort(arr, low, mid);
       int rightCount =  MeregeSort(arr, mid + 1, high);
         MergeArray(arr, low, mid, high);                    
       
        return leftCount + rightCount ;
        
    }
    public int CountReversePairs(int[] arr,int low,int mid,int high)
    {
        int count = 0;
        int right = mid + 1;
        for(int i = low; i <= mid; i++)
        {
            while (right <= high && arr[i] > 2 * arr[right]) right++;
            count += (right - (mid + 1));
        }
        return count;
    }

    public int MergeArray(int[] arr, int low,int high,int mid)
    {
        List<int> temp = new List<int>();

        int left = low;
        int right = mid + 1;
        int count = 0;
        while(left<=mid && right <= high)
        {
            if (arr[left] <= arr[right])
            {
                temp.Add(arr[left]);
                left++;
            }
            else
            {
                temp.Add(arr[right]);

                count += mid - left + 1;
                right++;
            }
        }
        while (left <= mid)
        {
            temp.Add(arr[left]);
            left++;
        }
        while (right <= high)
        {
            temp.Add(arr[right]);
            right++;
        }

        for(int i = low; i <= high; i++)
        {
            arr[i] = temp[i - low];
        }

        return count;
    }
}
