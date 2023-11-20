using System;

public class Solution {
    public int[] solution(int[,] score) {
                    int[] answer = new int[score.GetLength(0)];
            int[] temp = new int[score.GetLength(0)];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = score[i, 0] + score[i, 1];
            }
            Array.Sort(temp);
            Array.Reverse(temp);
            for (int i = 0; i < score.GetLength(0); i++)
            {
                int sum = score[i, 0] + score[i, 1];
                for (int j = 0; j < temp.Length; j++)
                {
                    if (sum == temp[j])
                    {
                        answer[i] = j+1;
                        break;
                    }
                }
            }
            return answer;
    }
}