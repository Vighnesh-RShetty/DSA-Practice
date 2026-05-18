using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays.Revision_Part_Two_Last
{
    internal class Stock_Buy_And_Sell_Revision
    {

        public static int Stock_Buy_Sell()
        {
            /*
             * The stock should be purchased before selling it, and both actions cannot occur on the same day.
              
               Example 1
               int[] arr = [10, 7, 5, 8, 11, 9];
               Output: 6
               Explanation: Buy on day 3 (price = 5) and sell on day 5 (price = 11), profit = 11 - 5 = 6.
            
             */

            int[] arr = [10, 7, 5, 8, 11, 9];
            int sellValue = arr[1];
            int profit = 0;
            int maxProfit = 0;

            for (int i = 0; i <arr.Length; i++)
            {
                if (arr[i] > sellValue)
                {
                    profit = sellValue - arr[i];
                    if(profit > maxProfit)
                        maxProfit = profit;
                }
                if (arr[i] > sellValue && i != 0)
                    sellValue = arr[i];

            }
            return maxProfit;
        }
    }
}
