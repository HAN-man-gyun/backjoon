using System;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        for(int i=1; i<food.Length; i++)
        {
            for(int j=0; j<food[i]/2;j++)
            {
                answer += i.ToString();
            }
        }
        answer += 0.ToString();
        int temp = answer.Length-2;
        for(int i=temp; i>=0; i--)
        {
            answer += answer[i];
        }
        return answer;
    }
}