public class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
        Dictionary<string, int> dict = new Dictionary<string,int>();
        for(int i=0;i < list1.Length;i++)
        {
            dict[list1[i]]=i;
        }
        List<string> res = new List<string>();
        int minindexsum = int.MaxValue;
        for(int j=0; j<list2.Length;j++)
        {
            if(dict.ContainsKey(list2[j]))
            {
                int indexsum= dict[list2[j]] +j;
                if(indexsum < minindexsum)
                {
                    minindexsum = indexsum;
                    res.Clear();
                    res.Add(list2[j]);
                }
                else
                 if(indexsum == minindexsum)
                 {
                    res.Add(list2[j]);
                 }
            }
        }
        return res.ToArray();
    }
}