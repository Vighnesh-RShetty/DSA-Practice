using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.SearchingAlgo
{
    public class LinearAlgorithm
    {
        public static int LinearSearch(int target, int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }
            return -1;
        }
    }
}
