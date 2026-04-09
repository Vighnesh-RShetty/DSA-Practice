// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using DSA_PREP.VIghnesh.Arrays;
using DSA_PREP.VIghnesh.Arrays.SearchingAlgo;
using DSA_PREP.VIghnesh.Revision.Array;
using DSA_PREP.VIghnesh.SystemDesign.LiskovSubstituion_Principle.LiskovFailing;
using DSA_PREP.VIghnesh.SystemDesign.ObserverDesignPattern.ImplClasses.ObservableImpl;
using DSA_PREP.VIghnesh.SystemDesign.ObserverDesignPattern.ImplClasses.ObserverImpl;
using DSA_PREP.VIghnesh.SystemDesign.ObserverDesignPattern.Interfaces;
using System.Runtime.CompilerServices;


public class Program
{

    static void Main(string[] args)
    {
        // int[] arr = { 10, 5, 2, 7, 1, 9 };
        //int k = 15;
        // int count = MaximumSubArraySum.optimizedMaximunSubArray(arr, k);
        //int[] arr = { 1, 2, 3, 1, 1, 1, 1 };
        //int k = 3;
        //int maxCount = LongestSubArraySum.LongestSubArraySumLength(arr, k);
        //Console.WriteLine(maxCount);

        //int[] arr1 = { 1, 2, 3, 1, 1, 1, 1,1,4 };
        //int k1 = 4;
        //int maxCount1 = LongestSubArraySum.OptimizedLongestSubArraySumLength(arr1, k1);
        //Console.WriteLine(maxCount1);

        // int[] arr = [2, 7, 11, 15];
        //int k = 9;

        // int[] arr = [10, 1, 7, 3, 9];
        //int k = 10;

        //int[] arr = [3,2,4];
        // int k = 6;

        //int[] targetArray = TwoSum.TwoSumValues(arr, k);
        //Console.WriteLine(targetArray);

        //int[] targetArray = TwoSum.TwoSumValuesOptimized(arr, k);
        //Console.WriteLine(targetArray);

        //Revisions 

        // RemoveDublicate.RemoveDublicateRevision();
        //DSA_PREP.VIghnesh.Revision.Array.MoveZeroToEnd.MoveZeroToEndRevision();

        //int[] arr = { 0, 1, 2, 0, 1, 2 };
        //MoveZeroOneTwoAtEnd.MoveZeroAndOneAtEnd(arr);
        //Console.WriteLine(arr);


        // int[] _arr = {7,0,0,1,7,7,2,7,7};

        // Console.WriteLine(MajorityElement1.MajorityElement(_arr));
        //int maxSum =  MaximuSubArraySumKadanesAlgo.MaxSubArraySum();
        // Console.WriteLine(maxSum);

        //  int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

        //int[] temp = MaximuSubArraySumKadanesAlgo.MaxSubArraySumArray(arr);
        // Console.WriteLine(temp);
       int sum = MaximuSubArraySumKadanesAlgo.MaxSubArraySum();
        Console.WriteLine(sum);
    }
}



//Observer Design Patterngit add

//ProducStock product = new ProducStock();

//IObserver email = new EmailNotification();
//IObserver sms = new SmsNotification();

//product.AddObservers(email);
//product.AddObservers(sms);

//product.SetStock(12);

//Console.ReadLine();

//

////int[] arr = { 1, 6, 7, 8, 9, 4, 123, 90, 8 };
////int[] arr = { 1, 1, 2, 3, 4, 5, 5, 6, 7 };
////int max =   SecondLargestRevision.SecondMax(arr);

////Console.Write(RemoveDublicate.RemoveDublicateInArray(arr));

////RotateAnArrayByOne.RotateByOne(arr);
////for(int i = 0; i < arr.Length; i++)
////{
////    Console.WriteLine(arr[i]);
////}
////int[] arr1 = { 1, 2, 3, 4, 5 };
////int[] arr2 = { 1, 2, 7 };
////int[] arr1 = { 3, 4, 6, 7, 9, 9 };
////int[] arr2 = { 1, 5, 7, 8, 8 };
//// int n = arr1.Length > arr2.Length ?arr1.Length : arr2.Length;
////int n = arr1.Length + arr2.Length;
////int[] resArray = new int[n];
//// int[] resArray = UnionOfElements.UnionOfUsingSet(arr1, arr2);

////int[] resArray = UnionOfElements.UnionOfArrayTwoPointerApproach(arr1, arr2);
////for (int i = 0; i < resArray.Length; i++)
////{
////    Console.WriteLine(resArray[i] + " ");
////}
////int[] arr1 = { 4, 2, 1, 5 };
////int n = FindMissingNumber.FindMissingNum(arr1);
////Console.WriteLine(n);

////int[] arr2 = { 0, 0, 0, 0, 0,0 };
////int maxOnes = MaximumConsecutiveOnes.MaxConsecutiveOnes(arr2);
////Console.WriteLine(maxOnes);

//int[] arr1 = { 2, 2, 1, 1, 2, 1, 2, 1, 2 };
//int k = 3;
////int number = NumberAppearceOnce.NumAppearceOnce(arr1);
////int number = NumberAppearceOnce.NumAppearceOnceXOR(arr1);
////Console.WriteLine(number);
//int length = MaximumSubArraySum.maxSubarrayLength(arr1, k);
//Console.WriteLine(length);