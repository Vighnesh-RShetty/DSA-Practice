using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays
{
    public class MoveZeroToEnd
    {
        public static void ZeroToEnd(int[] arr)
        {
            int nz = 0;
            int z = 0;
           
          //  int[] arr = { 1, 0, 0, 4, 5, 0, 0, 8, 9 };
            while (nz < arr.Length)
            {
                if (arr[nz] != 0)
                {
                    int temp = arr[z];
                    arr[z] = arr[nz];
                    arr[nz] = temp;
                    nz++;
                    z++;
                }

                else
                {
                    nz++;
                }
               
            }
        }
    }
}
