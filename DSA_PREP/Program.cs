// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using DSA_PREP.VIghnesh.Arrays;


public class Program
{
    
    static void Main(string[] args)
    {
        int[] arr = { 3, 4, 9, 8, 10 };
        //int max = LargestElement.LargeEelement(arr);
        //int secondMax = LargestElement.SecondLargest(arr);
        //Boolean isSorted = ArraySorted.SortedArray(arr);
        Boolean isSorted = ArraySorted.SortedArrayOptimal(arr);
        Console.WriteLine(isSorted ? "Sorted Array" :"Not Sorted Array");
    }
}