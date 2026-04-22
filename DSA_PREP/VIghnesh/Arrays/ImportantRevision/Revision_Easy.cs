using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.ImportantRevision;

public class Revision_Easy
{
    public static int[] Remove_Dublicates_from_The_Sorted_Array()
    {
        int[] arr = [1, 1, 2, 2, 3, 4, 4];

        int i = 0;
        int j = 1;
        while (j < arr.Length)
        {
            if (arr[i] == arr[j])
            {
                j++;
            }
            else
            {
                arr[i+1]= arr[j];
                i++;j++;
            }
        }

        for(int k = 0; k < arr.Length; k++)
        {
            Console.WriteLine(arr[k]);
        }
        return arr;
}

    public static int[] Left_Rotate_Array_By_One()
    {

        //int[] arr = [1, 2, 3, 4, 5];
        int[] arr = [5];
        if (arr.Length <= 1)
        {
            return arr;
        }

        int temp = arr[0];
        for(int i = 1; i < arr.Length; i++)
        {
            arr[i - 1] = arr[i];
        }

        arr[arr.Length-1] = temp;

        for(int j = 0; j < arr.Length; j++)
        {
            Console.Write(" "+arr[j]);

        }

        return arr;
    }

    //Rotate Arry By K Place Logic Swap
      
    public static void SwapArray(int start,int end,int[] arr)
    {

        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;end--;
        }
    }
    //
    public static int[] Left_Rotate_Array_By_K_Places()
    {
        
        int[] arr = [1, 2, 3, 4, 5];
        int k = 7;

        // [3, 4, 5, 1, 2]

        

        if (arr.Length <= 1)
        {
            return arr;
        }

        k = ((k%arr.Length)+arr.Length) % arr.Length;
        SwapArray(0, k-1, arr);
        SwapArray(k, arr.Length - 1, arr);
        SwapArray(0, arr.Length-1,arr);

        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        return arr;

    }

    public static void MoveZeroToEnd()
    {
        int[] arr = [0, 1, 0, 3, 12];
        //Output: [1, 3, 12, 0, 0]
        int nz = 0;
        int z = 0;

        while(nz < arr.Length){
            if (arr[nz] == 0)
            {
                nz++;
            }
            else
            {
                int temp = arr[nz];
                arr[nz] = arr[z];
                arr[z] = temp;
                z++;nz++;
            }
        }

        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}