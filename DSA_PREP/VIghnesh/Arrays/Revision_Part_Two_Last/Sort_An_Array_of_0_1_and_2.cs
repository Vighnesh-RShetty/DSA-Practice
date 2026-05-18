using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Revision_Part_Two_Last
{
    public class Sort_An_Array_of_0_1_and_2
    {

        public static void SortArrayByZeoOnesandTwo()
        {
            int[] arr = [2,0,2,1,1,0];
            int low = 0;
            int mid = 0;
            int high = arr.Length-1;
            int temp;
            while (mid < high)
            {
                if (arr[mid] == 0)
                {
                    temp = arr[low];
                    arr[low] = arr[mid];
                    arr[mid] = temp;
                    mid++;
                    low++;
                } else if (arr[mid] == 2)
                {
                    temp = arr[high];
                    arr[high]= arr[mid];
                    arr[mid] = temp;
                    high--;
                }
                else
                {
                    mid++;
                }

            }
            Console.WriteLine(arr);
        }
    }
}
