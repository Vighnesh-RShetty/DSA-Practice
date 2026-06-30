// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using DSA_PREP.VIghnesh.Arrays;
using DSA_PREP.VIghnesh.Arrays.ImportantRevision;
using DSA_PREP.VIghnesh.Arrays.Revision_Part_Two_Last;
using DSA_PREP.VIghnesh.Arrays.Revision_Part_Two_Last.Matrix;
using DSA_PREP.VIghnesh.Arrays.SearchingAlgo;
using DSA_PREP.VIghnesh.Arrays.Sort;
using DSA_PREP.VIghnesh.Arrays.TwoDimension_Array;
using DSA_PREP.VIghnesh.Recursion;
using DSA_PREP.VIghnesh.Revision.Array;
using DSA_PREP.VIghnesh.Revision.Array.AlgosConfusionQuestion;
using DSA_PREP.VIghnesh.SystemDesign.LiskovSubstituion_Principle.LiskovFailing;
using DSA_PREP.VIghnesh.SystemDesign.ObserverDesignPattern.ImplClasses.ObservableImpl;
using DSA_PREP.VIghnesh.SystemDesign.ObserverDesignPattern.ImplClasses.ObserverImpl;
using DSA_PREP.VIghnesh.SystemDesign.ObserverDesignPattern.Interfaces;
using System.Runtime.CompilerServices;


public class Program
{

    static void Main(string[] args)
    {
        // Console.WriteLine( Check_if_the_array_is_sorted_II.CheckArraySorted() );
        // Console.WriteLine(Check_if_the_array_is_sorted_II.CheckArraySorted_V2());
        // Remove_Dublicates_from_the_Sorted_Array.RemoveDublicateFromTheSortedArray();

        //Move_Zeros_To_End.MoveZeroToEnd();

        //Find_Missing_Number.FindMissingNumber();
        //Maximum_Consecutive_Ones.MaxConsecutiveOnes();

        //int values =   Find_the_Number_That_Appears_Once_and_other_numbers_twice.NumberAppearceOnce();
        // int values = Find_the_Number_That_Appears_Once_and_other_numbers_twice.NumbetThatAppearceOnce();

        #region Max SubArray
        //Longest_Subarray_With_Given_Sum_K_Positives.Longest_SubArray_Length_Positives();
        // Longest_Subarray_With_Given_Sum_K_Positives.Longest_SubArray_Length_Positives_Better();
        //Longest_Subarray_With_Given_Sum_K_Positives.Longest_SubArray_Length_Positives_Optimal();

        // Longest_subarray_with_sum_k_Negatives.Longest_SubArray_With_Sum_K_Negatives();

        //DSA_PREP.VIghnesh.Arrays.Revision_Part_Two_Last.TwoSum.TwoSumBruteForce();
        //Sort_An_Array_of_0_1_and_2.SortArrayByZeoOnesandTwo();
        //  Maximum_Subarray_sum.BruteForceMaxSum();
        // Maximum_Subarray_sum.MaxSumOptimal_Kadanes_Algo();
        // Print_subarray_with_maximum_subarray_sum.Print_SubArray_MaxSum();

        //Stock_Buy_And_Sell_Revision.Stock_Buy_Sell();
        //NextPermutation_Revision_Part.Next_Permu();

        //Set_Matrix_Zero.SetMatZero();
        //Rotate_Matrix_By_90.RotateMatrix();

        // Count_Subarrays_With_Given__Sum.MaxSubArrayCount();
        //Pascal_Triangle.PascalTriangle();
        //Majority_Element_II.MajorityEle();
        //Three_Sum.Three_Sum_Array();


        //Three_Sum.Three_Sum_Array_Brute();
        //Three_Sum.Three_Sum_Array_Better();
        //Three_Sum.Three_Sum_Array_Optimal_Solution();
        //_4_Sum_.Four_Sum_Problem();

        //Largest_Subarray_with_Sum_Zero.Largest_SubArray_With_Sum_Zero();
        //Count_SubArray_With_Given_XOR_K.Count_SubArray_With_Given_XOR_k();

        // Count_SubArray_With_Given_XOR_K.Count_SubArray_With_Given_XOR_k_Optimal();
        //Merge_Intervals.Merge_Interval_Brute();
        //Print_Matrix_In_Spiral_Manner.PrintMatrixInSpiralManner();
        #endregion

        //int[] nums1 =  { 1, 3, 5};
        // int[] nums2 =  { 2, 4, 6 };

        // int m = 3;
        // int n = 3;

        // Merge_Two_Sorted_Array_WIthout_Extra_Space.Merge(nums1, m, nums2, n);
        // Find_Missing_Repeating_Numbers.Find_Missing_Repeating_Number();

        //Sorting Technique

        //Selection_Sort.SelectionSort();
        //Bubble_Sort.BubbleSort();

        //Insertion_Sort.InsertionSort();
        //BaseCondition baseCondition = new BaseCondition();

        //baseCondition.functionBaseCondition();

        //
        //  PrintName_FIve_Times printNames = new();
        //printNames.PrintNames();

        //Print N Values
        //Print_Linearly_1_N printNValue = new();
        //printNValue.Print_1_N(5);

        //Print_From_N_1 printNValue = new();
        //printNValue.Prinrt_N_To_1(5);

        //Print_Linearly_BackTracking printLinearly = new();


        //printLinearly.Print_Linearly_BackTracking_1_N(n, n);
        int n = 5;

        //Sum_Of_Natural_Number sumNatural = new();
        //sumNatural.Print_Sum_Value(n,0);

        //Factorial_Of_Number factNum = new();
        //factNum.Print_Factorial_Number(5, 1);

        int[] arr = { 2, 6, 7, 1, 0 };

        ReverseArray_Through_Recursion reverseArray = new();
        //reverseArray.Reverse_Array(arr, 0, arr.Length - 1);
        string str = "MADAM";

        //bool res = reverseArray.CheckPalindrome_Recursion(str, 0);

        reverseArray.PrintAllSubSequence(arr, new List<int>(), 0);
    }
}