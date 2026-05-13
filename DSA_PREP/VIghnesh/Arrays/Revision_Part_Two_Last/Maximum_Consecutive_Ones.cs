using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Revision_Part_Two_Last;

internal class Maximum_Consecutive_Ones
{

    public static int MaxConsecutiveOnes()
    {
        int[] arr = [1, 1, 0, 0, 1, 1, 1, 0];
        int count = 0;
        int maxCout = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 1)
            {
                count++;
                if (count > maxCout)
                {
                    maxCout = count;
                }
                
            }
            else
            {
                count = 0;
            }

        }

        return maxCout;
        }
    }
   



