using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_PREP.VIghnesh.Arrays
{
    public class StockBuy_And_Sell
    {
        public static int BuyAndSell()
        {

            int[] arr = [7, 1, 5, 3, 6, 4];
            //Output: 5

            int minPrice = arr[0];
            int price = 0;
            int maxPrice = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]< minPrice)
                {
                    minPrice = arr[i];
                }

                price = arr[i] - minPrice;
                if (price > maxPrice )
                    maxPrice = price;
               
                
            }
            return maxPrice;
        }
    }
}
