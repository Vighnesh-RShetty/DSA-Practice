using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Revision.Array
{
    public class SecondLargestRevision
    {
        public static int SecondMax(int[] arr)
        {
            if (arr.Length == 0 || arr.Length == 1) return 0;

            int max1 = arr[0];
            int max2 = arr[2];
            if (max1 < max2)
            {
                int temp = max1;
                max1 = max2;
                max2 = temp;
            }
            for (int i=2;i<arr.Length; i++)
            {
                if (arr[i] > max1)
                {
                    int temp = max1;
                    max1 = arr[i];
                    max2 = temp;
                }else if (arr[i] > max2 && arr[i] != max1)
                {
                    max2 = arr[i];
                }
            }
            return max2;
        }
    }
}
