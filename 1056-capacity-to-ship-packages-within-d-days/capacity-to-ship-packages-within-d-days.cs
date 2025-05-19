public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int min = 0;
        int max = 0;

        for (int i = 0; i < weights.Length; i++) {
            min = Math.Max(min, weights[i]); // can't be less than the heaviest
            max += weights[i];               // sum is upper bound
        }

        while (min < max) {
            int mid = min + (max - min) / 2;
            if (checkCapacity(weights, days, mid)) {
                max = mid; // try smaller
            } else {
                min = mid + 1; // need more capacity
            }
        }

        return min;
    }

    public bool checkCapacity(int[] weights, int days, int capacity) {
        int daysCount = 1;  // Start with 1 day
        int weightSum = 0;

        foreach (int weight in weights) {
            if (weightSum + weight > capacity) {
                daysCount++;
                weightSum = 0;
            }
            weightSum += weight;

            if (daysCount > days) {
                return false;
            }
        }

        return true;
    }
}
