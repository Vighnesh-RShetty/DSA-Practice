using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Revision_Part_Two_Last;

public class Remove_Dublicates_from_the_Sorted_Array
{
    public static void RemoveDublicateFromTheSortedArray()
    {
        int[] arr = [0, 0, 3, 3, 5, 6];

        // O/P [0,3,5,6]
        // [0, 3, 5, 6, _, _]

        int i = 0;
        int j = 1;
        
        while (j < arr.Length)
        {
            if (arr[i] != arr[j])
            {
                arr[i+1] = arr[j];
                i++;
            }
            j++;
        }
       
        Console.WriteLine(i+1);
    }
}
