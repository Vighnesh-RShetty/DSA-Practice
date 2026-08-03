using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search;

public class Lower_Bound_And_Upper_Bound__
{
    public static int LowerBound(int[] arr,int k)
    {
        int low = 0;
        int high = arr.Length - 1;
        int ans = arr.Length;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] >= k)
            {
                ans = mid;
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return ans;
    }

    public static int UpperBound(int[] arr, int k)
    {

        int low = 0;
        int high = arr.Length - 1;
        int ans = arr.Length;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] > k)
            {
                ans = mid;
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return ans;
    }

    public static List<int> Find_First_Last_Occurance(int[] arr ,int k)
    {
        int first = LowerBound(arr, k);
        if(first == arr.Length || arr[first] !=k)
        {
            return new List<int>{ -1, -1 };
        }
        return new List<int> { first, UpperBound(arr, k) - 1 };
    }

    public static List<int> Count_The_Occurance(int[] arr, int k)
    {
        int first = LowerBound(arr, k);
        if (first == arr.Length || arr[first] != k)
        {
            return new List<int> { -1, -1 };
        }
        return new List<int> { first, UpperBound(arr, k) - 1 };
    }
}
