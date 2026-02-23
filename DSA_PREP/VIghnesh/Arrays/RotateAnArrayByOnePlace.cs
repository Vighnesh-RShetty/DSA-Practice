using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays
{
    public class RotateAnArrayByOnePlace
    {
        public static void RotateAnArray(int[] arr)
        {
            int temp = arr[0];
            int i = 1;
            while (i < arr.Length)
            {
                arr[i - 1] = arr[i];
                i++;
            }
            arr[arr.Length - 1] = temp;
        }
    }
}
