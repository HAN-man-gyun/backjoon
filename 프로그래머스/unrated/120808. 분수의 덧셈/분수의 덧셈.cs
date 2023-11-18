using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int[] answer = new int[2];
        int first = numer1*denom2 + numer2*denom1;
        int second = denom1*denom2;
        int count = first>second? second : first;
        int max =0;
        for(int i=1; i<=count; i++)
        {
            if((first%i ==0)&& (second%i ==0) &&(i>max))
            {
                max =i;
            }
        }
        answer[0] = first/max;
        answer[1] = second/max;
        
        return answer;
    }
}