using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays
{
    public class Rearrange_Array_Elements_By_Sign
    {

        public static int[] RearrangeBySign()
        {
            int[] arr = [3, 1, -2, -5, 2, -4];
            //Output:
            //[3, -2, 1, -5, 2, -4]
            int positiveIndex = 0;
            int negativeIndex = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (positiveIndex < arr.Length  && arr[positiveIndex] > 0 )
                {
                    positiveIndex += 2;
                }else if (negativeIndex < arr.Length && arr[negativeIndex] > 0)
                {
                    int temp = arr[positiveIndex];
                    arr[positiveIndex] = arr[negativeIndex];
                    arr[negativeIndex] = temp;
                    positiveIndex += 2;
                    negativeIndex += 2;
                }
                if (negativeIndex < arr.Length && arr[negativeIndex] < 0)
                {
                    negativeIndex += 2;
                }
                else if (negativeIndex < arr.Length && arr[positiveIndex] < 0 )
                {
                    int temp = arr[positiveIndex];
                    arr[positiveIndex] = arr[negativeIndex];
                    arr[negativeIndex] = temp;
                    positiveIndex += 2;
                    negativeIndex += 2;
                }
                
            }
            return arr;
        }
    }
}
