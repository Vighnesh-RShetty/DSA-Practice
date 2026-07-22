public class MergeSort
{
    // This function ONLY divides the array.
    // It never compares elements.
    // It never sorts elements.
    // It simply keeps dividing until only one element remains.

    public void MergeSortArray(int[] arr, int low, int high)
    {
        // Base Case
        // If there is only one element,
        // it is already sorted.
        if (low >= high)
            return;

        // Find the middle element.
        // This divides the current array into two halves.
        int mid = (low + high) / 2;

        // Sort the LEFT half.
        MergeSortArray(arr, low, mid);

        // Sort the RIGHT half.
        MergeSortArray(arr, mid + 1, high);

        // Now BOTH halves are sorted.
        // Merge them into one sorted array.
        Merge(arr, low, mid, high);
    }

    // This function NEVER divides.
    // It ONLY merges two already sorted halves.

    public void Merge(int[] arr, int low, int mid, int high)
    {
        // Temporary list to store the merged result.
        List<int> temp = new List<int>();

        // Left pointer starts from beginning of left half.
        int left = low;

        // Right pointer starts from beginning of right half.
        int right = mid + 1;

        //--------------------------------------------------
        // Compare both halves.
        //--------------------------------------------------

        while (left <= mid && right <= high)
        {
            // Smaller element should go first.
            if (arr[left] <= arr[right])
            {
                temp.Add(arr[left]);

                // Move left pointer.
                left++;
            }
            else
            {
                temp.Add(arr[right]);

                // Move right pointer.
                right++;
            }
        }

        //--------------------------------------------------
        // Left half still has elements?
        //--------------------------------------------------

        while (left <= mid)
        {
            temp.Add(arr[left]);
            left++;
        }

        //--------------------------------------------------
        // Right half still has elements?
        //--------------------------------------------------

        while (right <= high)
        {
            temp.Add(arr[right]);
            right++;
        }

        //--------------------------------------------------
        // Copy the sorted elements back into the array.
        //--------------------------------------------------

        for (int i = low; i <= high; i++)
        {
            arr[i] = temp[i - low];
        }
    }
}