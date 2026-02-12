using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays
{
    public class LargestElement
    {

        public static int LargeEelement(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        //public static void Main(string[] args)
        //{
        //    int[] arr = { 3, 4, 9, 8, 10 };
        //    LargestElement largset = new LargestElement();
        //   largset.LargeEelement(arr);
        //}

    }
}
