using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Revision_Part_Two_Last;

public class Find_the_Number_That_Appears_Once_and_other_numbers_twice
{
    //Brute Force
    public static int NumberAppearceOnce() {

        int[] arr = [1, 2, 2, 4, 3, 1, 4];
        int count = 0;
         for(int i = 0; i < arr.Length; i++)
        {
             count = 0;
            for(int j = i+1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                }
            }

            if (count == 1)
            {
                return arr[i];
            }

        }
        return 0;

    }

    public static int NumbetThatAppearceOnce()
    {
        int[] arr = [1, 2, 2, 4, 3, 1, 4];
        int xor = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            xor = xor ^ arr[i];
        }
        return xor;
    }
}


