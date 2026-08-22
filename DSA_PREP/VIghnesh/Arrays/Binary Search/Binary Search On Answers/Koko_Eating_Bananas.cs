    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace DSA_PREP.VIghnesh.Arrays.Binary_Search.Binary_Search_On_Answers;

    public class Koko_Eating_Bananas
    {

        public static int KokoEatingBanana(int[] piles, int h)
        {
            int low = 1;
            int high = 0;
            int ans = 0;

            foreach(int pile in piles) {
                high = Math.Max(high, pile);
            }

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (CanEat(piles, mid, h)){
                 
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return low;

        }

        public static Boolean CanEat(int[] piles,int mid,int h)
        {
            int hours = 0;
            foreach(int pile in piles)
            {
                hours += (pile + mid - 1) / mid;
            }
            return hours <= h;
        }
    }
