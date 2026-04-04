using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Revision.Array;

public class MoveZeroToEnd
{
    

    public static void MoveZeroToEndRevision()
    {
        int[] arr = { 1, 2, 0, 9, 0, 7, 0, 0, 6, 8, 0 };
        int z = 0;
        int nz = 0;

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

        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine((arr[i])+ " ");
        }
    }
}
