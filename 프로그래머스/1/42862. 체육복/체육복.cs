using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
    int answer = 0;
        int temp = n - lost.Length;
        List<int> temp1 = new List<int>(lost);
        List<int> temp2 = new List<int>(reserve);
        temp1.Sort();
        temp2.Sort();
        for (int i = 0; i < temp1.Count; i++)
        {
            for (int j = 0; j < temp2.Count; j++)
            {
                if (temp1[i] == temp2[j])
                {
                    temp++;
                    temp1.RemoveAt(i);
                    temp2.RemoveAt(j);
                }
            }
        }
         for (int i = 0; i < temp1.Count; i++)
        {
            for (int j = 0; j < temp2.Count; j++)
            {
                if (temp1[i] >= temp2[j] - 1 && temp1[i] <= temp2[j] + 1)
                {
                    temp++;
                    temp2.RemoveAt(j);
                    break;
                }
            }
        }
        answer = temp;
        return answer;
    }
}