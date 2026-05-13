using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Revision_Part_Two_Last;

public class Find_Missing_Number
{

    //Brute Force 
    public static int FindMissingNumber()
    {
        int[] arr = [0, 2, 3, 1, 4];
        int sum = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            sum += arr[i];

        }

        return arr.Length-1*(arr.Length-1)+1/2;
     }
}
