using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.ImportantRevision;

public class Revision_Easy
{
    public static int[] Remove_Dublicates_from_The_Sorted_Array()
    {
        int[] arr = [1, 1, 2, 2, 3, 4, 4];

        int i = 0;
        int j = 1;
        while (j < arr.Length)
        {
            if (arr[i] == arr[j])
            {
                j++;
            }
            else
            {
                arr[i+1]= arr[j];
                i++;j++;
            }
        }

        for(int k = 0; k < arr.Length; k++)
        {
            Console.WriteLine(arr[k]);
        }
        return arr;
}
}