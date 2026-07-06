public class Solution {
    public int MaxProfit(int[] prices) {

        int profit = 0;

        // int l = 0, r = 1 — multi-var declaration requires explicit type (can't use var)
        // r starts at 1 so we always have a buy day (l) before the sell day (r)
        // When nums is empty or single-element, r < nums.Length is immediately false — safe no-op
        for (int l = 0, r = 1; r < prices.Length; r++)
        {
            // Track the best profit seen across all windows
            profit = Math.Max(profit, prices[r] - prices[l]);

            // If today's price is cheaper than our buy day, move the buy day forward —
            // any future sell will pair better with this lower price
            if (prices[r] < prices[l]) l = r;
        }

        return profit;
        
    }
}
