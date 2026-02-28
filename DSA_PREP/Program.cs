// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using DSA_PREP.VIghnesh.Arrays;
using DSA_PREP.VIghnesh.Arrays.SearchingAlgo;
using DSA_PREP.VIghnesh.Revision.Array;
using DSA_PREP.VIghnesh.SystemDesign.LiskovSubstituion_Principle.LiskovFailing;


public class Program
{

    static void Main(string[] args)
    {
        //int[] arr = { 1, 6, 7, 8, 9, 4, 123, 90, 8 };
       int[] arr = { 1, 1, 2, 3, 4, 5, 5, 6, 7 };
     //int max =   SecondLargestRevision.SecondMax(arr);
     
        Console.Write(RemoveDublicate.RemoveDublicateInArray(arr));
    }
}