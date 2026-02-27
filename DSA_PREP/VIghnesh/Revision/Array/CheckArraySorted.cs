using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Revision.Array
{
    public class CheckArraySorted
    {
        public static bool CheckSorted(int[] arr)
        {
            if(arr.Length == 0) return true;
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i-1] > arr[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
