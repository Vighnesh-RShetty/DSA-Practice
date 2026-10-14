
namespace Revison_First_.Binary_Search.BS_ON_ANSWERS;

public class Find_Nth_Root_of_a_number
{
    public static int Nth_Root_Of_Number(int n,int m)
    {

        int low = 0;
        int high = m;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            int result = isNthRoot(n, mid);

            if (result == m) return mid;

            if (result > m)
            {

                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return -1;
    }

    public static int isNthRoot(int n,int mid)
    {
        int res = 1;
        for(int i=1; i <= n; i++)
        {
            res = res * mid;
        }

        return res;
    }
}
