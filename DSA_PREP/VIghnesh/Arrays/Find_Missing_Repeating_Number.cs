using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays
{
    public class Find_Missing_Repeating_Numbers
    {
        public static List<long> Find_Missing_Repeating_Number()
        {
            //Input: nums = [3, 5, 4, 1, 1]

            int[] arr = [3, 5, 4, 1, 1];
            int n = arr.Length;

            List<long> result = new();
            long s = 0;
            long s2 = 0;

            long sn = n * (n + 1) / 2;
            long s2n = n * (n + 1) * (2 * n + 1) / 6;

            for (int i = 0; i < n; i++)
            {
                s += arr[i];
                s2 += arr[i] * arr[i];
            }

            //X-Y

            long val1 = s - sn;

            //X2-Y2
            long val2 = s2 - s2n;

            //X+Y
            long val3 = val2 / val1;

            //Repeating Value 
            long X = (val1 + val3) / 2;

            //Missing Number 
            long Y = X - val1;

            result.Add(X);
            result.Add(Y);

            return result;

        }
    }
}
