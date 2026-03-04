using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays;

public class FindMissingNumber
{

    public static int FindMissings(int[] arr)
    {

        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != i + 1)
            {
                return i + 1;
            }
        }
        return 0;
    }
}
