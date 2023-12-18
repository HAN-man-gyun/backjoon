using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] answers) {
        int[] temp1 = new int[] { 1, 2, 3, 4, 5 };
        int[] temp2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] temp3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

        int[] temp4 = new int[3];
        List<int> temp5 = new List<int>();
        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == temp1[i % temp1.Length])
            {
                temp4[0]++;
            }
        }
        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == temp2[i % temp2.Length])
            {
                temp4[1]++;
            }
        }
        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == temp3[i % temp3.Length])
            {
                temp4[2]++;
            }
        }
        int max = 0;
        for (int i = 0; i < temp4.Length; i++)
        {
            if (max < temp4[i])
            {
                max = temp4[i];
            }
        }
        for (int i = 0; i < temp4.Length; i++)
        {
            if (max == temp4[i])
            {
                temp5.Add(i+1);
            }
        }
        int[] answer = temp5.ToArray();

        return answer;
    }
}