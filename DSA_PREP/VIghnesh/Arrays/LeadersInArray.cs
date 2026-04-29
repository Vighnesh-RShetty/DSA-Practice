using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays;

public class LeadersInArray
{
    public static int[] LeadersArray()
    {
        // int[] arr = [5, 4, 3, 2, 1];
        //O/P

        int[] arr = [10, 22, 12, 3, 0, 6];
        //Output: [22, 12, 6]

        int[] LeadersArray = new int[arr.Length];
        int maxLeader = arr[arr.Length-1];
        LeadersArray[arr.Length-1] = arr[arr.Length-1] ;
        for(int i = arr.Length - 2; i >= 0; i--)
        {
            if (arr[i] > maxLeader)
            {
                LeadersArray[i] = arr[i];
                if (maxLeader < arr[i])
                {
                    maxLeader = arr[i];
                }
            }
        }


        return LeadersArray;
    }
}
