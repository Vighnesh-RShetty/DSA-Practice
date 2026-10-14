

namespace Revison_First_.Binary_Search.BS_ON_ANSWERS;

public class Find_square_root_of_a_Number
{

    public static int FInd_Sqrt_Of_Number(int number)
    {
        int low = 0;

        int high = number;
        int answer = 0;


        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (mid * mid == number) return mid;

            if (mid * mid > number)
            {

                high = mid - 1;
            }
            else
            {
                answer = mid;
                low = mid + 1;
            }
        }
        return answer;
    }
   
}

