using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Revision.Array;

public class UnionOfTwoSorted_Array
{

    public static int[] UnionArrayRevision()
    {
        int[] arr1 = { 1, 2, 2, 3, 4, 5 };
        int[] arr2 = { 1, 1, 2, 3, 4, 4, 5, 6 };
        int[] res = new int [arr1.Length+arr2.Length];

        int i = 0;int j = 0;int k = 0;

        while(i<arr1.Length && j < arr2.Length)
        {
            if (arr1[i] < arr2[j])
            {
                if (res[k] != arr1[i])
                {
                    res[k] = arr1[i];
                }
                    k++; i++;
            }
            else if (arr1[i] > arr2[j])
            {
                if (res[k] != arr1[j])
                {
                    res[k] = arr2[j];
                }
               
                    j++;k++;
            }
            else if (arr1[i] == arr2[j])
            {
                if (res[k] != arr1[i])
                {
                    res[k] = arr1[i];
                }
              
                i++;j++;k++;
            }
        }
        return res;
    }
}
