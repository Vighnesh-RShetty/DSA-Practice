using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Revision.Array
{
    public class LeftRotateAnArrayByKPlace
    {

        public void ReverAnArray(int[] arr,int start,int end)
        {
             start = 0;
             end = arr.Length - 1;
            while (start <= end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
        public static void LeftRotateByKPlace(int[] arr, int k)
        {

            k = ((k % arr.Length) + arr.Length) % arr.Length;
            
            
            
        }
    }
}
