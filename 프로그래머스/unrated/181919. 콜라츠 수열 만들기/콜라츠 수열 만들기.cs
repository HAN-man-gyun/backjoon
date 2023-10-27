using System;

public class Solution {
    public int[] solution(int n) {
        int index =0;
        int originN = n;
        while(n !=1)
        {
            if(n%2 ==0)
            {
                n=n/2;
            }
            else 
            {
                n=3*n+1;
            }
            index ++;
        }
        int[] answer = new int[index+1];
        index =0;
        while(originN !=1)
        {
            if(originN%2 ==0)
            {
                answer [index]  = originN;
                originN=originN/2;
                
            }
            else 
            {
                answer [index]  = originN;
                originN=3*originN+1;
            }
            index ++;
        }
        answer [index] =1;
        return answer;
    }
}