using System;

public class Solution {
    public int[] solution(string my_string) {
        int[] answer = new int[52];
        foreach(char a in my_string)
        {
            if(a >=65 && a<=90)
            {
                answer[a-65]++;
            }
            else if(a >=97 && a<=122)
            {
                answer[a-97+26]++;
            }
        }
        return answer;
    }
}