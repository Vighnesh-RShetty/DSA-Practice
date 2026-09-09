namespace Revison_First_.Arrays;

public class Stock_Buy_and_sell
{
    public static int StockBuyAndSell(int[] arr)
    {
        //arr = [10, 7, 5, 8, 11, 9]

        int minValue = arr[0];
        int profit = 0;
        int maxProfit = 0;

        for(int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > minValue)
            {
                profit =  arr[i] - minValue;
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }

            if (arr[i] < minValue)
            {
                minValue = arr[i];
            }
        }
        return maxProfit;
    }
}
