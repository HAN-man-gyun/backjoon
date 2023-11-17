using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, int[] query) {
         List<int> temp = new List<int>(arr);
        for (int i = 0; i < query.Length; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = temp.Count-1; j > query[i]; j--)
                {   
                    temp.RemoveAt(j);
                }
            }
            else
            {
                for (int j = query[i] - 1; j >= 0; j--)
                {
                    temp.RemoveAt(j);
                }
            }
        }
        int[] answer = temp.ToArray();
        return answer;
    }
}