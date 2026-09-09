using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revison_First_.Arrays;

public class Majority_Element_1
{
    public static int MajorityElement_1(int[] arr)
    {
        int count = 0; 
        int currentValue = 0;
        for(int i = 1; i < arr.Length; i++)
        {

            if(count == 0)
            {
                currentValue = arr[i];
                count = 1;
            }
            else if(currentValue == arr[i])
            {
                count++;
            }
            else
            {
                count--;
            }
        }
        return currentValue;
    }
}
