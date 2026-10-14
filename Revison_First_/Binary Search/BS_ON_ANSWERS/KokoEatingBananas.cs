

namespace Revison_First_.Binary_Search.BS_ON_ANSWERS;

public class KokoEatingBananas
{

    public static int KokoBanana(int[] piles,int h)
    {
        int low = 1;
        int high = 0;

        for(int i = 0; i < piles.Length;i++)
        {
            high = Math.Max(high, piles[i]);
        }

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (CanEat(piles, mid, h))
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return low;
    }

    public static bool CanEat(int[] piles,int mid,int h)
    {
        int hours = 0;

        for(int i = 0; i < piles.Length; i++)
        {
            hours += (piles[i] + mid - 1)/mid;
        }
        return hours <= h;
    }
}
