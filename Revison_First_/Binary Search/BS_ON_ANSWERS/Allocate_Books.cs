using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Revison_First_.Binary_Search.BS_ON_ANSWERS;

public class Allocate_Books
{ 
public static int AllocateBooks(int[] arr,int m)
    {
        int low = 0;
        int high = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            low = Math.Max(arr[i], low);
            high += arr[i];
        }

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            int stundet = StudentCount(arr, mid);
            if (stundet == m) return mid;

            if (stundet < m)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
            
        }
        return -1;
    }

    public static int StudentCount(int[] arr, int pages)
    {
        int students = 1;
        int totalPages = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            
            if ((totalPages+arr[i]) <= pages)
            {
                totalPages += arr[i];
            }
            else
            {
                students++;
                totalPages = arr[i];
            }
        }
        return students;
    }
}
