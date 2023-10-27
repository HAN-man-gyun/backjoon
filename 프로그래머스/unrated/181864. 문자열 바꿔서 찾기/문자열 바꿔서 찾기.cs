using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        string answerString = "";
        foreach (char a in myString)
        {
            if (a == 'A')
            {
                answerString += 'B';
            }
            else if (a == 'B')
            {
                answerString += 'A';
            }
        }
        if(answerString.Contains(pat))
        {
            answer = 1;
        }
        else
        {
            answer =0;
        }
        
        
        return answer;
    }
}