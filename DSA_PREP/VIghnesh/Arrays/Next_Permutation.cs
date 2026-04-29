using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays
{
    public class Next_Permutation
    {

        public static int[] Next_Permutation_Problem()
        {
            //int[] arr = [1, 3, 2];
            // O/P [2, 1, 3]

            //Input:
            // [2, 1, 5, 4, 3, 0, 0]

            //O/p [2, 3, 0, 0, 1, 4, 5]
            int[] arr = [2, 2, 0, 4, 3, 1];

            int i = arr.Length - 2;
            int pivot = 0;
            while (i >=0)
           
            {
                if (arr[i] > arr[i + 1])
                {
                    i--;
                }
                else
                {
                    pivot = i;
                    int smallest = arr[i+1];
                    for (int j = i + 2; j < arr.Length; j++)
                    {
                        if (arr[j] < arr[smallest] && arr[j] > arr[pivot])
                        {
                            smallest = j;
                        }

                    }
                    int temp = arr[i];
                    arr[i] = arr[smallest];
                    arr[smallest] = temp;

                    int k = i + 1; int l = arr.Length - 1;
                    while (k <= l)
                    {
                        int tempData = arr[k];
                        arr[k] = arr[l];
                        arr[l] = tempData;
                        k++; l--;
                    }
                    i--;
                }
            }
         return arr;

        }


        public static int[] Next_Permutation_Problem_Two()
        {
            int[] arr = [1, 3, 2];
            // O/P [2, 1, 3]

            //Input:
            // [2, 1, 5, 4, 3, 0, 0]

            //O/p [2, 3, 0, 0, 1, 4, 5]
            //int[] arr = [2, 2, 0, 4, 3, 1];

            int i = arr.Length - 2;

            while (i >= 0 && arr[i] >= arr[i + 1])
            {
                i--;
            }
            if (i >= 0)
            {
                int smallest = i + 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] <= arr[smallest] && arr[smallest] > arr[i])
                    {
                        smallest = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[smallest];
                arr[smallest] = temp;
            }
                int left = i + 1;int right = arr.Length - 1;

                while (left < right)
                {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                right--;
                left++;
                }
            
            return arr;

        }
    }
}
