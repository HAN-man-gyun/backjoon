using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        int count = 0;
        int temp = 0;
        for(int i=0; i<s.Length; i++)
        {
            for(int j=i-1; j>=0; j--)
            {
                count++;
                if (s[i] == s[j])
                {
                    temp = count;
                    break;
                }
            }
            if(temp !=0)
            {
                answer[i] = count;
            }
            else
            {
                answer[i] =-1;
            }
            count =0;
            temp =0;
        }
        return answer;
    }
}