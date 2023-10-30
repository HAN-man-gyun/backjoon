using System;

public class Solution {
    public int solution(string before, string after) {
        int answer = 0;
        int beforeSum = 0;
        int afterSum = 0;
        for(int i=0; i<before.Length; i++)
        {
            beforeSum += before[i];
        }
        for(int j=0; j<after.Length; j++)
        {
            afterSum += after[j];
        }
        if(beforeSum == afterSum)
        {
            answer =1;
        }
        else
        {
            answer =0;
        }
        return answer;
    }
}