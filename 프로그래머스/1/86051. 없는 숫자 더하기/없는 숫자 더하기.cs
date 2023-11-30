using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int[] temp = new int[10];
        for(int i=0; i< numbers.Length; i++)
        {
            for(int j=0; j<temp.Length; j++)
            {
               if(numbers[i] == j)
               {
                   temp[j] =1;
               }
            }
        }
        for(int i=0; i<temp.Length; i++)
        {
            if(temp[i] !=1)
            {
                answer+=i;
            }
        }
        return answer;
    }
}