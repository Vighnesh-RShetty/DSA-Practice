using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Binary_Search.Binary_Search_On_Answers;

public class Find_Nth_Root_Of_A_Number
{
    public static int FindNthRootOfNumber(int n,int m)
    {
        int low = 1; int high = m;

        while (low <= high)
        {
           int mid  =  (low + high) / 2;

            if(CheckRoot(mid, n) == m)
            {
                return mid;
            }else if(CheckRoot(mid, n) < m)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }

        }
        return -1;
    }

    public static int CheckRoot(int n, int m)
    {
        int ans = 1;
        for(int i = 1; i < m; i++)
        {
            ans = ans * n;
        }
        return ans;
    }
}
