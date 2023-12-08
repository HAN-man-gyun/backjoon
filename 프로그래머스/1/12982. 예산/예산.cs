using System;

public class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        Array.Sort(d);
        foreach(int a in d)
        {
            if(budget -a <0)
            {
                break;
            }
            budget -= a;
            answer++;
        }
        
        return answer;
    }
}