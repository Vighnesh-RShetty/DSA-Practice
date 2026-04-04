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
                if (arr[low]<medium && arr[low] < arr[high])
                {
                    low++;medium++;high--;
                }
                if (arr[low] > arr[medium])
                {
                    //arr[medi]
                }
            }
        }
    }
}
