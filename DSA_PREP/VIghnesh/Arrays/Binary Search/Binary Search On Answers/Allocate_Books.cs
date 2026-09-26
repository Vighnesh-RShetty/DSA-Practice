using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search.Binary_Search_On_Answers;

public class Allocate_Books
{
    public static int AllocateBookBrute_Force(int[] arr,int m)
    {

        int low = 0; int high = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > low) low = arr[i];
            high += arr[i];
        }

        for(int pages = low; pages <= high; pages++)
        {
            int countStundets = CountStudents(arr, pages);

            if (countStundets == m)
            {
                return pages;
            }
        }
        return -1;
    }

    public static int AllocateBook_Optimal_Force(int[] arr, int m)
    {

        int low = 0; int high = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > low) low = arr[i];
            high += arr[i];
        }
        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            int noOfStundents = CountStudents(arr, mid);

            if (noOfStundents > m) low = mid + 1;
            else high = mid - 1;
        }
        
        //TC O (log2 (sum-max+1) * O(n) )

        return -1;
    }

    public static int CountStudents(int[] arr,int pages)
    {
        int countStundets = 1;
        int countPages = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            if (countPages+arr[i] <= pages)
            {
                countPages += arr[i];
            }
            else
            {
                countStundets++;
                countPages = arr[i];
            }
        }

        return countStundets;
    }
}
