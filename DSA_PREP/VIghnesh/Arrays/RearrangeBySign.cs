using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays;

public class RearrangeBySign
{
    //Space is 0(1) and TC 0(n)
    public static int[] RearrangeBySignValue()
    {
        //int[] arr = { -4, 4, -4, 4, -4, 4 };
        int[] arr = { 1, 2, -3, -4 };
        int positivePointer = 0;
        int negativePointer = 1;

        while(negativePointer < arr.Length && arr[positivePointer]<arr.Length)
        {

            while (positivePointer < arr.Length && arr[positivePointer] > 0)
            {
                positivePointer += 2;
            }
            while (negativePointer < arr.Length && arr[negativePointer] < 0)
            {
                negativePointer += 2;
            }

            if (positivePointer < arr.Length && negativePointer < arr.Length)
            {
                int temp = arr[positivePointer];
                arr[positivePointer] = arr[negativePointer];
                arr[negativePointer] = temp;
            }

        }

        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        return arr;
    }

    public static int[] ArrangeBySign()
    {
        int[] arr = { -4, 4, -4, 4, -4, 4 };
        int positiveIndex = 0;
        int negativeIndex = 1;
        int[] res = new int[arr.Length];

        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {

                res[positiveIndex] = arr[i];
                positiveIndex += 2;
            }
            else
            {
                res[negativeIndex] = arr[i];
                negativeIndex += 2;
            }
        }
        return res;
    }
}
