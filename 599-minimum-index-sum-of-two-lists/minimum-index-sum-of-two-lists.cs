public class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
        Dictionary<string, int> dictOne = new Dictionary<string, int>();
        List<string> result = new List<string>();

        int minIndexSum = int.MaxValue; // We need to find the minimum, so use MaxValue

        // Store values from list1 in dictionary with their index
        for (int i = 0; i < list1.Length; i++)
        {
            dictOne[list1[i]] = i;
        }

        // Iterate through list2 and find common elements with the minimum index sum
        for (int i = 0; i < list2.Length; i++)
        {
            if (dictOne.ContainsKey(list2[i])) // Corrected typo
            {
                int indexSum = dictOne[list2[i]] + i; // Sum of indexes

                if (indexSum < minIndexSum)
                {
                    result.Clear();
                    minIndexSum = indexSum;
                    result.Add(list2[i]);
                }
                else if (indexSum == minIndexSum)
                {
                    result.Add(list2[i]);
                }
            }
        }
        return result.ToArray();
    }
}
