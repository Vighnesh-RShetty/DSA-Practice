using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays
{
    public class MoveZeroOneTwoAtEnd
    {

        public static void MoveZeroOneToLast(int[] arr)
        {
            int low = 0;
            int medium = 1;
            int high = arr.Length - 1;
            while (low < arr.Length)
            {
                if (arr[low] < medium && arr[low] < arr[high])
                {
                    low++; medium++; high--;
                }
                if (arr[low] > arr[medium])
                {
                    //arr[medi]
                }
            }
        }

        //Dutch National Flag Algorithm
        public static void MoveZeroAndOneAtEnd(int[] arr)
        {
            int low = 0, high = arr.Length - 1, mid = 0;
            int temp = 0;
            while (mid <= high)
            { 
                if (arr[mid] == 0)
                {
                    temp = arr[low];
                    arr[low] = arr[mid];
                    arr[mid] = temp;
                    mid++;
                    low++;
                }
            else if (arr[mid] == 1)
            {
                mid++;
            }
                else 
            {
                temp = arr[high];
                arr[high] = arr[mid];
                arr[mid] = temp;
                high--;
            }

        }
    }
    }
}

