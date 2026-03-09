using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays
{
    public class MaximumConsecutiveOnes
    {
        public static int MaxConsecutiveOnes(int[] arr)
        {
            int count = 0;
            int maxCount = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    count++;
                    if (maxCount < count)
                    {
                        maxCount = count;
                    }

                }
                else
                {
                    count = 0;
                }
            }
            return maxCount;
        }
    }
}
