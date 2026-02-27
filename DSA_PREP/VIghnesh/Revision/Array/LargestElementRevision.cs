using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Revision.Array
{
    public class LargestElementRevision
    {
        public static int LargestEle(int[] arr)
        {
            if(arr.Length == 0) return 0;
            if(arr.Length==1) return arr[0];
            int max = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}
