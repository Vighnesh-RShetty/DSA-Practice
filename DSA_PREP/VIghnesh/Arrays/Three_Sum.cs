using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays;

public class Three_Sum
{

    public static List<List<int>> Three_Sum_Array()
    {
        // Input: nums = [2, -2, 0, 3, -3, 5]
        // Output: [[-2, 0, 2], [-3, -2, 5], [-3, 0, 3]]
        int[] arr = [2, -2, 0, 3, -3, 5];
        List<List<int>> listArray = new();

        int i = 0;
        int j = i + 1;
        int k = j + 1;

        while (k < arr.Length)
        {
            if (arr[i] + arr[j] + arr[k] == 0)
            {
                listArray.Add([arr[i], arr[j], arr[k]]);
            
            }
            i = j;
            j = k;
            k++;
        }
        return listArray;      
    }
}
