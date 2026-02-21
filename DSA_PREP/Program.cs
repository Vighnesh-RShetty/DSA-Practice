// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using DSA_PREP.VIghnesh.Arrays;


public class Program
{

    static void Main(string[] args)
    {
        // int[] arr = { 1,2,2,3,4,4,5,6,7, 8, 10 };
        //int max = LargestElement.LargeEelement(arr);
        //int secondMax = LargestElement.SecondLargest(arr);
        //Boolean isSorted = ArraySorted.SortedArray(arr);
        //  Boolean isSorted = ArraySorted.SortedArrayOptimal(arr);
        //Console.WriteLine(isSorted ? "Sorted Array" : "Not Sorted Array");
        int[] arr = { 1, 1, 2,2,3,4,5,6,6,7,8,8,9,9,10,11,11 };

        ArraySorted.RemoveDublicateEle(arr);
        Console.WriteLine("Array After Removing The Ele");
        for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(" " + arr[i]);
        }
    }
}