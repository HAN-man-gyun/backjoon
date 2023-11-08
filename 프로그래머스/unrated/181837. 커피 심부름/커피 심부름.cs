using System;

public class Solution {
    public int solution(string[] order) {
        int answer = 0;
        foreach(string a in order)
        {
            
            if(a.Contains("cafelatte"))
            {
                answer +=5000;
            }
            else
            {
                answer +=4500;
            }
        }
        return answer;
    }
}