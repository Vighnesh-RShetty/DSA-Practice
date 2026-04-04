using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Revision.Array
{
    public class RemoveDublicate
    {
        public static int RemoveDublicateInArray(int[] arr)
        {
            int i = 0;
            for(int j = 1; j < arr.Length; j++)
            {
                if (arr[i] != arr[j])
                {
                    arr[i + 1] = arr[j];
                    i++;
                }
            }
            return i + 1;
        }

        public static void RemoveDublicateRevision()
        {
            int[] arr = { 1, 1, 2, 2, 3, 4, 5, 6 };

            int i = 0;
            for(int j = 1; j < arr.Length; j++)
            {
                if (arr[i] != arr[j])
                {
                    arr[i + 1] = arr[j];
                    i++;
                }
            }
            Console.WriteLine(i + 1);
        }

    }
}
