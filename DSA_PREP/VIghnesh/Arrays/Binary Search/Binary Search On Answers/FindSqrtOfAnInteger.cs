using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search.Binary_Search_On_Answers;

public class FindSqrtOfAnInteger
{
    public static int FindSqrtOfInteger(int n)
    {
        int low = 1;
        int high = n;
        int ans = 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (mid * mid <= n)
            {
                ans = mid;
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }

        }
        return ans;
    }
}
