using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Revision_Part_Two_Last;

public class Move_Zeros_To_End
{
    // [0, 1, 4, 0, 5, 2]

    //O/P  [1, 4, 5, 2, 0, 0]

    // Brute Force 
    public static void MoveZeroToEnd()
    {
        int[] arr = [0, 1, 4, 0, 5, 2];

        // 1 0 4 0 5 2 
        //1 4  0 0 5 2 
         
        int nz = 0; int z = 0;

        while (nz < arr.Length)
        {
            if (arr[nz] != 0)
            {
                int temp = arr[nz];
                arr[nz] = arr[z];
                arr[z] = temp;
                z++;nz++;
            }
            else
            {
                nz++;
            }
        }

        Console.WriteLine(arr);

    }
}
