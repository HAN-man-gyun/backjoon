using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        foreach(int a in array)
        {
            string b = a.ToString();
            foreach(char c in b)
            {
                if(c-55 == 0)
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}