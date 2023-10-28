using System;

public class Solution {
    public int solution(string number) {
        int answer = 0;
        int sum =0;
        foreach(char a in number)
        {
            sum += a -'0';
        }
        answer = sum%9; 
        return answer;
    }
}