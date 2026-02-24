using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays
{
    public class RotateAnArrayByKPlace
    {
        
        public static void RotateArray(int[] arr,int k)
        {
            

            if (k == 0 || k == arr.Length || arr.Length==0)
            {
                return;
            }
            int count = 0;

            k = k % arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                if (k != count)
                {
                    int j = 1;
                    int temp = arr[0];
                    while (j < arr.Length)
                    {
                        arr[j - 1] = arr[j];
                        j++;
                    }
                    arr[arr.Length - 1] = temp;
                    count++;
                }
                else
                {
                    return;
                }
            }
        }
    }
}
