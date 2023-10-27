using System;

public class Solution {
    public int[] solution(string myString) {
        
        int leng =0;
        foreach(char a in myString)
        {
            if(a =='x')
            {
                leng++;
            }
        }
        int[] answer = new int[leng+1];
        leng =0;
        int index =0;
        foreach(char a in myString)
        {
            if(a == 'x')
            {
                answer[index] = leng;
                leng =0;
                index++;
            }
            else
            {
                leng++;
            }
        }
        answer[index] = leng;
        
        
        
        return answer;
    }
}